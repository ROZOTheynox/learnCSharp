using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    //La classe est une descendante de la classe animal
    class Chat : Animal
    {
        //Procédure pour importer les fonctions de Animal
        public Chat(string unNom) : base(unNom)
        {

        }

        //Procédure pour Miauler
        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }

        //Procédure pour manger qui prends la base de manger dans la classe Animal
        public override void Manger()
        {
            //Condition qui permet de voir si le chat a faim
            if (aFaim)
            {
                base.Manger();
                Console.Write(" du poisson.");
                Console.Write(GetName() + " se régale.");
            }

            else
            {
                Console.WriteLine(GetName() + " n'a pas faim.");
            }
        }
    }
}
