namespace Bank.entities
{
    public class Courant : Compte
    {
        public double LigneDeCredit { get; set; }

        public Courant(Personne titulaire, string numero, double solde, double ligneDeCredit)
        {
            this._numero = numero;
            this._solde = solde;
            this.LigneDeCredit = ligneDeCredit;
            this._titulaire = titulaire;
        }

        public void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }

        public static double operator +(Courant left, Courant right)
        {
            return Math.Max(left.Solde, 0) + Math.Max(right.Solde,0);
            //return ((left._solde > 0)? left._solde : 0) + ((right._solde > 0) ? right._solde : 0);
        }

        public static double operator + (double left, Courant right)
        {
            return left + Math.Max(right.Solde, 0);
        }

    }
}
