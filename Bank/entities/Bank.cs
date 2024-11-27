using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.entities
{
    public class Banque
    {
        public string _nom { get; set; }

        private List<Courant> _comptes = new List<Courant>();
        public Courant this[string numero]
        {
            get
            {
                foreach (var compte in _comptes)
                {
                    if (compte._numero == numero) return compte;
                }
                return null;
            }
        }

        public void Ajouter(Courant compte)
        {
            _comptes.Add(compte);
            Console.WriteLine($"Le compte {compte._numero} a été ajouté à la banque.");
        }

        public void Supprimer(string numero)
        {
            var compte = this[numero];
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
    }
}
