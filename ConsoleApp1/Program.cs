using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        public void esegui() { 



        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("\t\t Primo progetto C#");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("Che oggetto vuoi creare?");

            while(true)
            {
                switch (schermoMenu())
                {
                    case 0:
                        {
                            Console.WriteLine("Arrivederci");
                            Environment.Exit(0);
                            break;
                        };
                    case 1:
                        {
                            creaAtleta();
                            break;
                        }
                    case 2:
                        {
                            creaAnimale();
                            break;
                        }
                    case 3:
                        {
                            creaVeicolo();
                            break;
                        }
                    case 4:
                        {
                            creaDipendente();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Digita un numero tra 0 e 4");
                            break;
                        }
                }
            }
           


        }

        public Animale creaAnimale()
        {
            Console.WriteLine("Genere :");
            string genere = Console.ReadLine();
            Console.WriteLine("Zampe :");
            string zampe = Console.ReadLine();
            Console.WriteLine("Verso :");
            string verso = Console.ReadLine();
            Animale animale = new Animale(genere, zampe, verso);
            Console.WriteLine(animale.ToString());
            return animale;
        }

        public Veicolo creaVeicolo()
        {
            Console.WriteLine("Tipo :");
            string tipo = Console.ReadLine();
            Console.WriteLine("Carburante :");
            string carburante = Console.ReadLine();
            Console.WriteLine("Prezzo :");
            string prezzo = Console.ReadLine();
            Veicolo veicolo = new Veicolo(tipo, carburante, prezzo);
            Console.WriteLine(veicolo.ToString());
            return veicolo;
        }

        public Atleta creaAtleta()
        {
            Console.WriteLine("Nome :");
            string nome = Console.ReadLine();
            Console.WriteLine("Sport :");
            string sport = Console.ReadLine();
            Console.WriteLine("Ruolo :");
            string ruolo = Console.ReadLine();
            Atleta atleta = new Atleta(nome, sport, ruolo);
            Console.WriteLine(atleta.ToString());
            return atleta;
        }

        public Dipendente creaDipendente()
        {
            Console.WriteLine("Nome :");
            string nome = Console.ReadLine();
            Console.WriteLine("Ruolo :");
            string ruolo = Console.ReadLine();
            Console.WriteLine("Stipendio :");
            string stipendio = Console.ReadLine();
            Dipendente dipendente = new Dipendente(nome, stipendio, ruolo);
            Console.WriteLine(dipendente.ToString());
            return dipendente;
        }

        public int schermoMenu()
        {
            int scelta;

            do
            {
                Console.WriteLine("0 - per uscire");
                Console.WriteLine("1 - Atleta");
                Console.WriteLine("2 - Animale");
                Console.WriteLine("3 - Veicolo");
                Console.WriteLine("4 - Dipendnte");
                scelta = Console.Read();
            } while (scelta < 0 || scelta > 4);
            return scelta;

        }
    }
}
