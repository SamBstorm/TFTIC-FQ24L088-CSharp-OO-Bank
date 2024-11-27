using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.entities
{
    public class Compte
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

        protected void Retrait(double montant, double limite)
        {
            if (montant <= 0) return;                   //Exception serait plus appropiée
            if (limite < 0) return;                     //Exception serait plus appropiée
            if (Solde - montant < -limite) return;      //Exception serait plus appropiée
            Solde -= montant;
        }
        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }
        public void Depot(double montant)
        {
            if (montant <= 0) return;                   //Exception serait plus appropiée
            Solde += montant;
        }
    }
}
