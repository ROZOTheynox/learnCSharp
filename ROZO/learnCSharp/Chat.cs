using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    class Chat : Animal
    {
        public Chat(string unNom) : base(unNom)
        {

        }

        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }

        public override void Manger()
        {
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
