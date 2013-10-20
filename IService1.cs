using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]          //This attribute is used to create a ServiceContract.
    public interface IService1         //Create a interface which defines contract
    {
        [OperationContract]   //Use [OperationContract] attribute to declare a method which will be accessiable via client.
        string GetMessage();
    }

}