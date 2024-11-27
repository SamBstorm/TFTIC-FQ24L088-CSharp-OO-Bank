namespace Bank.entities
{
    public class Courant : Compte
    {
        public double LigneDeCredit { get; set; }

        public Courant(Personne titulaire, string numero, double solde, double ligneDeCredit)
        {
            this.Numero = numero;
            Depot(solde);
            this.LigneDeCredit = ligneDeCredit;
            this.Titulaire = titulaire;
        }

        public void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }
    }
}
