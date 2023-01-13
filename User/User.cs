using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User : ChannelFactory<IService>, IService
    {
        IService proxy;

        public User(NetTcpBinding binding, EndpointAddress address) : base(binding, address)
        {
            proxy = this.CreateChannel();
        }

        public void testMessage()
        {
            try
            {
                proxy.testMessage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}
