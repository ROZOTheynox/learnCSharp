using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    public abstract class Animal
    {
        private string nom;
        protected bool aFaim;

        public Animal(string unNom)
        {
            nom = unNom;
            aFaim = false;

        }

        public virtual void Manger()
        {
            Console.Write(GetType().Name);
            Console.Write(nom + " mange ");
        }

        public string GetName()
        {
            return nom;
        }

        public void SetName(string value)
        {
            nom = value;
        }

        public void SetFaim(bool value)
        {
            aFaim = value;
        }
        
    }
}
