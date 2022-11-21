using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
    {
        private string _name;
        private string _ruolo;
        private string _stipendio;
        
        public Dipendente(string nome, string stipendio, string ruolo)
        {
            Ruolo = ruolo;
        }

        public string Name { get => _name; set => _name = value; }
        public string Ruolo { get => _ruolo; set => _ruolo = value; }
        public string Stipendio { get => _stipendio; set => _stipendio = value; }
    }
}
