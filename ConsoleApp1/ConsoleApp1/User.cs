using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Utente
    {
        public static void Menu()
        {
            Console.WriteLine("==============BENVENUTO IN BANCA MARIOS===============");
            Console.WriteLine("Cosa vuoi fare oggi?");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica ora e data di login");
            Console.WriteLine("4. ESCI");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                Login();
                Menu();
            }
            else if (scelta == 2)
            {
                Logout();
                Menu();
            }
            else if (scelta == 3)
            {
                StampaDataEOraLogin();
                Menu();
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Esci");
            }
            else
            {
                Console.WriteLine("Comando non valido");
                Menu();
            }

        }

        public static string username;
        public static string password;
        public static bool IsLogged;
        public static DateTime DataOraLog;
        
        public static void Login()
        {
            Console.WriteLine("Inserisci username:");
            Utente.username = Console.ReadLine();

            Console.WriteLine("Inserisci password:");
            Utente.password = Console.ReadLine();

            Console.WriteLine("Conferma password:");
            string password2 = Console.ReadLine();

            if ((Utente.password == password2) && (Utente.username != ""))
            {
                IsLogged = true;
                DataOraLog = DateTime.Now;
                Console.WriteLine($"Utente correttamente loggato alle ore {DataOraLog}");
            }
            else
            {
                Console.WriteLine("Le due password non corrispondono");
            }
        }

        public static void Logout()
        {
            username = "";
            password = "";
            IsLogged = false;
            Console.WriteLine("Nessun utente loggato al sistema");
        }

        public static void StampaDataEOraLogin()
        {
            if (Utente.IsLogged == true)
            {
                Console.WriteLine($"L'ultimo utente che ha effettuato l'accesso è {Utente.username} il {Utente.DataOraLog}");
            }
            else
            {
                Console.WriteLine("Non ci sono utenti loggati");
            }
        }
    }

}
