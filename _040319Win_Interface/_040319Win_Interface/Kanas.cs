using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Win_Interface
{
    class Kanas : AtesliSilahlar, IYakinlastirabilable
    {
        public string Yakinlastir()
        {
            return "Dürbün Acildi";
        }
    }
}
