using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderService
{
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        void Create(long OrderID);
    }
}
