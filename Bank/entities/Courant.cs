using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.entities
{
    public class Courant
    {
        #region déclaration
        public Personne _titulaire { get; set; }
        public string _numero { get; set; }
        public double _solde { get; private set; }
        public double _ligneDeCredit { get; set; }
        #endregion

        public Courant(Personne titulaire, string numero, double solde, double ligneDeCredit)
        {
            this._numero = numero;
            this._solde = solde;
            this._ligneDeCredit = ligneDeCredit;
            this._titulaire = titulaire;
        }

        public void Retrait(double montant)
        {
            _solde -= montant;
        }

        public void Depot(double montant)
        {
            _solde += montant;
        }

        public static double operator +(Courant left, Courant right)
        {
            return Math.Max(left._solde, 0) + Math.Max(right._solde,0);
            //return ((left._solde > 0)? left._solde : 0) + ((right._solde > 0) ? right._solde : 0);
        }
    }
}
