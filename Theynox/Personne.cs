using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_test_de_Csharp
{
    public class Personne
    {
        private string nom;
        private string prenom;
        public int age { get; set; }

        public Personne(string Nom, string Prenom, int Age)
        {
            this.nom = Nom;
            this.prenom = Prenom;
            this.age = Age;
        }


        public string Info()
        {
            return nom + " " + prenom + " " + age;
        }
    }
}
