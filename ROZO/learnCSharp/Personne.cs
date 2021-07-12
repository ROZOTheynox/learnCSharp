using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private string sexe;
        public int age{ get; set; }

        public Personne(string unNom, string unPrenom, string unSexe, int unAge)
        {
            nom = unNom;
            prenom = unPrenom;
            sexe = unSexe;
            age = unAge;
        }

        public string infosPersonne ()
        {
            return nom + " " + prenom + " " + sexe + " " + age;
        }
    }
}
