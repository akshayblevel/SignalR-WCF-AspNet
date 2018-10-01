var app = angular.module('angularServiceDashboard',[]);
app.value('backendServerUrl', 'http://localhost:5502/~/');


app.controller('PerformanceDataController', ['$scope', 'backendHubProxy',
    function ($scope, backendHubProxy) {
        console.log('trying to connect to service')
        var performanceDataHub = backendHubProxy(backendHubProxy.defaultServer, 'orderHub');
        console.log('connected to service')
        
        performanceDataHub.on('broadcastPerformance', function (data) {
            $scope.student= data[0].ProductName;
        });

        $scope.student = "demo";
    }

    
]);

app.factory('backendHubProxy', ['$rootScope', 'backendServerUrl',
    function ($rootScope, backendServerUrl) {
        
        function backendFactory(serverUrl, hubName) {
            var connection = $.hubConnection(backendServerUrl);
            var proxy = connection.createHubProxy(hubName);

            connection.start().done(function () { });

            return {
                on: function (eventName, callback) {
                    proxy.on(eventName, function (result) {
                        $rootScope.$apply(function () {
                            if (callback) {
                                callback(result);
                            }
                        });
                    });
                },
                invoke: function (methodName, callback) {
                    proxy.invoke(methodName)
                        .done(function (result) {
                            $rootScope.$apply(function () {
                                if (callback) {
                                    callback(result);
                                }
                            });
                        });
                }
            };
        };

        return backendFactory;
    }]);
//app.controller('PerformanceDataController', function ($scope) {
//    $scope.student = "demo";
//});