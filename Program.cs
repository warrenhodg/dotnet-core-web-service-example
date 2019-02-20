using System;
using System.ServiceModel;
using System.Threading.Tasks;
/*
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Security;
*/

namespace dotnet_core_wsdl
{
    class Program
    {
        static async void GetDicts()
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://services.aonaware.com/DictService/DictService.asmx");

            DictServiceSoapClient c = new DictServiceSoapClient(binding, endpoint);
            var v = c.ChannelFactory.CreateChannel();
            Console.WriteLine("About to call");

            var dicts = await v.DictionaryListAsync();
            foreach (Dictionary d in x)
            {
                Console.WriteLine(d.Id + ":" + d.Name);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                GetDicts();
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Really done");
        }
    }
}
