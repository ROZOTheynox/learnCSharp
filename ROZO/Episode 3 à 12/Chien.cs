using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    //La classe est une descendante de la classe animal
    class Chien : Animal
    {
        //Procédure pour importer les fonctions de Animal
        public Chien(string unNom) : base(unNom)
        {

        }

        //Procédure pour aboyer
        public void Aboyer ()
        {
            Console.WriteLine("Ouaf ouaf");
        }

        //Procédure pour manger qui prends la base de manger dans la classe Animal
        public override void Manger()
        {
            //Condition qui permet de voir si le chien a faim
            if (aFaim)
            {
            base.Manger();
            Console.Write(" des croquettes.");
            Console.Write(GetName() + " se régale.");
            }

            else
            {
                Console.WriteLine(GetName() + " n'a pas faim.");
            }
        }
    }
}
