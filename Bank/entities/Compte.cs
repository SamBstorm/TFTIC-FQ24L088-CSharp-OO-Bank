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

        public static double operator +(Compte left, Compte right)
        {
            return Math.Max(left.Solde, 0) + Math.Max(right.Solde, 0);
            //return ((left._solde > 0)? left._solde : 0) + ((right._solde > 0) ? right._solde : 0);
        }

        public static double operator +(double left, Compte right)
        {
            return left + Math.Max(right.Solde, 0);
        }
    }
}
