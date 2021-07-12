using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_test_de_Csharp
{

    class Episode13
    {

        enum Range : long { Max = 2147483648L, Min = 255L}


        public enum ConnectionResult
        {
            ConnectionOK,
            WrongLogin,
            WrongPassword
        }


        enum FrenchDay
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Samedi,
            Dimanche
        }

        public static void Ep13()
        {
            ConnectionResult connectionResult = UserCanConnect("login", "pass");
            if (connectionResult == ConnectionResult.ConnectionOK)
            {
                Console.WriteLine("Connexion réussie !");
            }
            else if (connectionResult == ConnectionResult.WrongLogin)
            {
                Console.WriteLine("Connexion refusée : login inconnu");
            }
            else if (connectionResult == ConnectionResult.WrongPassword)
            {
                Console.WriteLine("Connexion refusée : mot de passe erroné");
            }



            FrenchDay unJour = FrenchDay.Lundi;
            Console.WriteLine(unJour);

            long nb = 456L;
            if(nb > (long)Range.Max)
            {
                Console.WriteLine("Erreur");
            }
            else
            {
                Console.WriteLine("OK");
            }

            
            }
        private static ConnectionResult UserCanConnect(string login, string password)
        {
            if (login != "0")
            {
                if (login == "login" && password == "pass")
                    return ConnectionResult.ConnectionOK;
                else
                    return ConnectionResult.WrongPassword;
            }

            return ConnectionResult.WrongLogin;

        }
    }
}
