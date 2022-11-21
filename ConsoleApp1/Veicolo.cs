using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Veicolo
    {

        private string _tipo;
        private string _carburante;
        private string _prezzo;

        public Veicolo(string nome, string sport, string ruolo)
        {
        }

        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Carburante { get => _carburante; set => _carburante = value; }
        public string Prezzo { get => _prezzo; set => _prezzo = value; }
    }
}
