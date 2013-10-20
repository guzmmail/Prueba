using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    [ServiceContract]          //This attribute is used to create a ServiceContract.
    public interface IHelloWorld            //Create a interface which defines contract
    {
        [OperationContract]   //Use [OperationContract] attribute to declare a method which will be accessiable via client.
        string GetMessage();
    }

}