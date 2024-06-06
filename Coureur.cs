using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON
{
    class Coureur
    {
        private string nom;
        private string prenom;
        private string ville;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Ville { get => ville; set => ville = value; }
    }
}
