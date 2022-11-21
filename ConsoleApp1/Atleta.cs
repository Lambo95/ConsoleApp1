using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {
        private string _nome;
        private string _sport;
        private string _ruolo;

        public Atleta(string nome, string sport, string ruolo)
        {
            Nome = nome;
            Sport = sport;
            Ruolo = ruolo;
        }

        public string Ruolo { get => _ruolo; set => _ruolo = value; }
        public string Sport { get => _sport; set => _sport = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
