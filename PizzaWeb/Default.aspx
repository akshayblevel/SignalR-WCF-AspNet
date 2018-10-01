<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaWeb.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.6.4.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.4/angular.min.js"></script>
    <script src="Scripts/jquery.signalR-2.2.1.js"></script>
    <script src="~/signalr/js"></script>

    <script src="Scripts/app.js"></script>
    <%--<script src="Scripts/controller.js"></script>--%>
    <%--<script src="Scripts/services.js"></script>--%>
</head>
<body ng-app="angularServiceDashboard">
    <div ng-controller="PerformanceDataController">
       <%-- <form id="form1" runat="server">
            <div>
            </div>
        </form>--%>
        {{student}}
    </div>
    

    <%-- <script>
        $(function () {
            // Enable logging for development purpose
            $.connection.hub.logging = true;
            // Declare a proxy to reference the hub.
            var orderHub = $.connection.orderHub;
            //// Create a function that the hub can call to broadcast messages.
            orderHub.client.DisplayOrder = function (OrderID) {
                // Wrap the sender and the message in HTML
                
                var messageDiv = $('<div />').text(OrderID).html();
                // Add the message to the page.
                $('#messagelist').append('<li>&nbsp;&nbsp;' + messageDiv + '</li>');
            };

            $.connection.hub.start().done(function () {
            $.connection.hub.start("~/signalr").done(function () {
                });
            });
        });
    </script>--%>



    <ul id="messagelist">
    </ul>

</body>
</html>
