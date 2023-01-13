using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void testMessage();
        
        [OperationContract]
        void dodajPredstavu(Predstava predstava);

        [OperationContract]
        void izmeniPredstavu(Predstava predstava);

        [OperationContract]
        void izmeniPopust();

        [OperationContract]
        void napraviRezervaciju(Rezervacija rezervacija);

        [OperationContract]
        void platiRezervaciju(Rezervacija rezervacija);

    }
}
