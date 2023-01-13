using CertificationManager;
using Common;
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
    public class User : ChannelFactory<IService>, IService, IDisposable
    {
		IService factory;

		public User(NetTcpBinding binding, EndpointAddress address)
			: base(binding, address)
		{
			/// cltCertCN.SubjectName should be set to the client's username. .NET WindowsIdentity class provides information about Windows user running the given process
			string cltCertCN = Formater.ParseName(WindowsIdentity.GetCurrent().Name);

			this.Credentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.Custom;
			this.Credentials.ServiceCertificate.Authentication.CustomCertificateValidator = new ClientCertValidator();
			this.Credentials.ServiceCertificate.Authentication.RevocationMode = X509RevocationMode.NoCheck;

			/// Set appropriate client's certificate on the channel. Use CertManager class to obtain the certificate based on the "cltCertCN"
			this.Credentials.ClientCertificate.Certificate = CertManager.GetCertificateFromStorage(StoreName.My, StoreLocation.LocalMachine, cltCertCN);

			factory = this.CreateChannel();
		}

		

		public void Dispose()
		{
			if (factory != null)
			{
				factory = null;
			}

			this.Close();
		}

        public void dodajPredstavu(Predstava predstava)
        {
            throw new NotImplementedException();
        }

        public void izmeniPopust()
        {
            throw new NotImplementedException();
        }

        public void izmeniPredstavu(Predstava predstava)
        {
            throw new NotImplementedException();
        }

        public void napraviRezervaciju(Rezervacija rezervacija)
        {
            throw new NotImplementedException();
        }

        public void platiRezervaciju(Rezervacija rezervacija)
        {
            throw new NotImplementedException();
        }

        public void testMessage()
        {
            throw new NotImplementedException();
        }
    }
}
