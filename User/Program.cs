using CertificationManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class Program
    {
		static void Main(string[] args)
		{
		/// Define the expected service certificate. It is required to establish cmmunication using certificates.
			string srvCertCN = "WCFService";

			NetTcpBinding binding = new NetTcpBinding();
			binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Certificate;

			/// Use CertManager class to obtain the certificate based on the "srvCertCN" representing the expected service identity.
			X509Certificate2 srvCert = CertManager.GetCertificateFromStorage(StoreName.TrustedPeople, StoreLocation.LocalMachine, srvCertCN);
			EndpointAddress address = new EndpointAddress(new Uri("net.tcp://localhost:9999/Receiver"),
									  new X509CertificateEndpointIdentity(srvCert));

			using (User proxy = new User(binding, address))
			{
				/// 1. Communication test
				//proxy.TestCommunication();
				Console.WriteLine("TestCommunication() finished. Press <enter> to continue ...");
				Console.ReadLine();
			}
		}
	}
}
