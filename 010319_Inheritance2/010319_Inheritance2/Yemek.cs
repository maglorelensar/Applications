using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010319_Inheritance2
{
    class Yemek
    {
        public string PismeSuresi { get; set; }
        public string Icerik { get; set; }
        public string AciTipi { get; set; }
        public string PismeSekli { get; set; }
        public virtual string Sunumsekli()
        {
            return "Yanında az pilav ve salata ile ..";
        }
    }
}
