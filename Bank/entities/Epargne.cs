namespace Bank.entities
{
    public class Epargne : Compte
    {
        public DateTime DateDernierRetrait { get; set; }

        public override void Retrait(double montant) {
            double ancienSolde = Solde;
            base.Retrait(montant);
            if (Solde < ancienSolde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }
    }
}
