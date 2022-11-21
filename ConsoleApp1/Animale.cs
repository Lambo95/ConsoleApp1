using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animale
    {
        private string _zampe;
        private string _genere;
        private string _verso;

        public Animale(string genere, string zampe, string verso)
        {
            Genere = genere;
            Zampe = zampe;
            Verso = verso;
        }

        public string Zampe { 
            get => _zampe;
            set => _zampe = value;
        }
        public string Genere { 
            get => _genere;
            set => _genere = value; 
        }
        public string Verso { 
            get => _verso;
            set => _verso = value;
        }
    }
}
