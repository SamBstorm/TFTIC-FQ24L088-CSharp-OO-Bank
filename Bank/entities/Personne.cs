using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.entities
{
    public class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaiss { get; set; }

        public Personne(string nom, string prenom, DateTime date)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = date;
        }
    }
}
