using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    //Implement IHelloWorld interface and override GetMessage() method displlay a message.
    public class HelloWorld : IHelloWorld
    {
        public string GetMessage()
        {
            return string.Format("Wow! You have successfully created first WCF application.");
        }
    }
}
