using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMicroServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.TestServiceSoapClient test = new ServiceReference.TestServiceSoapClient();
            Console.WriteLine(test.HelloWorld());


            WCFServiceTest.TestServiceClient testWCF = new WCFServiceTest.TestServiceClient();
            Console.WriteLine(testWCF.GetData(1));

            Console.ReadKey();

        }
    }
}
