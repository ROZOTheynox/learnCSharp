using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    public abstract class Animal
    {
        //Création de variables
        private string nom;
        protected bool aFaim;

        //Création d'une procédure pour définir les variables
        public Animal(string unNom)
        {
            nom = unNom;
            aFaim = false;

        }

        //Creation d'une procedure pour manger qui prend le nom de l'animal et qui rajoute le mot mange
        public virtual void Manger()
        {
            Console.Write(nom + " mange ");
        }

        //Fonction qui reourne le nom
        public string GetName()
        {
            return nom;
        }

        //Procédure pour définir le nom
        public void SetName(string value)
        {
            nom = value;
        }

        //Procédure pour définir si l'animal a faim ou pas
        public void SetFaim(bool value)
        {
            aFaim = value;
        }
        
    }
}
