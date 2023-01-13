using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum stanjeRezervacije { NEPLACENA, PLACENA };
    [DataContract]
    public class Rezervacija
    {
        int id;
        int idPredstave;
        DateTime vremeRezervacije;
        int kolicinaKarata;
       

        public Rezervacija(int id, int idPredstave, DateTime vremeRezervacije, int kolicinaKarata, stanjeRezervacije stanje)
        {
            stanje = stanjeRezervacije.NEPLACENA;
           
            this.id = id;
            this.idPredstave = idPredstave;
            this.vremeRezervacije = vremeRezervacije;
            this.kolicinaKarata = kolicinaKarata;
        }


        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public int IdPredstave { get => idPredstave; set => idPredstave = value; }
        [DataMember]
        public DateTime VremeRezervacije { get => vremeRezervacije; set => vremeRezervacije = value; }
        [DataMember]
        public int KolicinaKarata { get => kolicinaKarata; set => kolicinaKarata = value; }

        
    }
}
