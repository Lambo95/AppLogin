using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogin
{
    internal class Program
    {
        public static List<Utente> listaUtenti = new List<Utente>();
        static void Main(string[] args)
        {
            Esegui();
        }

        public static void Esegui()
        {
            bool schermo = true;

            while(schermo)
            {
                schermo = SchermoMenu();
            }
        }

        public static Utente Registrati()
        {
            Console.WriteLine("Inserisci nome :");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci password :");
            string password = Console.ReadLine();
            Utente utente = new Utente(nome, password);
            listaUtenti.Add(utente);
            return utente;
        }

        public static void Login(Utente utente)
        {
            
            Console.WriteLine("Inserisci nome :");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci password :");
            string password = Console.ReadLine();
            utente.Nome = nome;
            utente.Password = password;
            foreach(Utente user in listaUtenti)
            {
                if (utente != user)
                {
                    Console.WriteLine("Non sei registrato! Registrati!");
                    Registrati();
                } else {
                    utente.Login = true;
                    utente.Logout = false;
                    utente.dataEntrata = DateTime.Now;
                    SchermoMenuLogged();
                }
            }
        }

        public static void Logout(Utente utente)
        {
            utente.Logout = true;
            utente.Login = false;
            utente.dataUscita = DateTime.Now;
        }

        public static void ListaAccessi(Utente utente)
        {
            utente.StampaListaAccessi();    
        }

        public static bool SchermoMenu()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("************** App LOGIN  *****************");
            Console.WriteLine("----------------------- V.1 ---------------------------");
            Console.WriteLine("\n \t \t ************** MENU ****************");
            Console.WriteLine("0 - per uscire");
            Console.WriteLine("1.: Registrati");
            Console.WriteLine("2.: Login");


            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    Registrati();
                    return false;
                case "2":
                    Login();
                    return false;
                default:
                    return true;
            }
        }
        public static bool SchermoMenuLogged()
        {
            try
            {
                Console.WriteLine("\t\t===============OPERAZIONI==============");
                Console.WriteLine("\n\t\t Scegli l’operazione da effettuare:");
                
                Console.WriteLine("1.: Logout");
                Console.WriteLine("2.: Verifica ora e data di login");
                Console.WriteLine("3.: Lista degli accessi");
                Console.WriteLine("4.: Esci");
                Console.WriteLine("========================================");

                switch (Console.ReadLine())
                {
                    case "1":
                        return true;
                    case "2":
                        return true;
                    case "3":
                        return true;
                    case "4":
                        return false;
                    default:
                        return true;
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}" );
                return false;
            }
        }
    }
}
