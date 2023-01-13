using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Predstava
    {
        int id;
        string naziv;
        DateTime vreme;
        int sala;
        double cenaKarte;

        public Predstava(int id, string naziv, DateTime vreme, int sala, double cenaKarte)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Vreme = vreme;
            this.Sala = sala;
            this.CenaKarte = cenaKarte;
        }

        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public string Naziv { get => naziv; set => naziv = value; }
        [DataMember]
        public DateTime Vreme { get => vreme; set => vreme = value; }
        [DataMember]
        public int Sala { get => sala; set => sala = value; }
        [DataMember]
        public double CenaKarte { get => cenaKarte; set => cenaKarte = value; }
    }
}
