using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiFilmowe.Modele
{
    public partial class Adres
    {
        public Adres()
        {
            Klient = new HashSet<Klient>();
        }

        public long Id { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string KodPocztowy { get; set; }
        public long NumerDomu { get; set; }


        [JsonIgnore]
        public virtual ICollection<Klient> Klient { get; set; }
    }
}
