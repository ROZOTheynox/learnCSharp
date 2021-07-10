using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string username = "ROZO";
            string password = "Jemangelecode1";

            if(password == "Jemangelecode1" && username == "ROZO")
            {
                Console.WriteLine("Identifiants corrects");
            }
            else
            {
                Console.WriteLine("Identifiants non corrects");
            }

        }
    }
}
 