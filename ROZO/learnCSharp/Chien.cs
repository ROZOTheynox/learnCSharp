using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    class Chien : Animal
    {
        public  Chien(string unNom) : base(unNom)
        {

        }

        public void Aboyer ()
        {
            Console.WriteLine("Ouaf ouaf");
        }

        public override void Manger()
        {
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
