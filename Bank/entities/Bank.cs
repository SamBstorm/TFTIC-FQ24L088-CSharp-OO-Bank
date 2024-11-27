using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.entities
{
    public class Banque
    {
        public string Nom { get; set; }

        private List<Compte> _comptes = new List<Compte>();
        public Compte this[string numero]
        {
            get
            {
                foreach (var compte in _comptes)
                {
                    if (compte.Numero == numero) return compte;
                }
                return null;
            }
        }

        public void Ajouter(Compte compte)
        {
            _comptes.Add(compte);
            Console.WriteLine($"Le compte {compte.Numero} a été ajouté à la banque.");
        }

        public void Supprimer(string numero)
        {
            Compte compte = this[numero];
            if (compte != null)
            {
                _comptes.Remove(compte);
                Console.WriteLine($"Le compte {numero} a été supprimé de la banque.");
            }
            else
            {
                Console.WriteLine($"Aucun compte trouvé avec le numéro {numero}.");
            }
        }
    
        public double AvoirDesComptes (Personne titulaire)
        {
            double somme = 0;
            foreach (Compte compte in _comptes)
            {
                if(compte.Titulaire == titulaire)
                {
                    somme += compte;
                }
            }
            return somme;
        }
    }
}
