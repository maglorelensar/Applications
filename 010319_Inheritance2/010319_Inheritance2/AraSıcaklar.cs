using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010319_Inheritance2
{
    class AraSıcaklar:Yemek
    {
        public override string Sunumsekli()
        {   //burdaki override metodu ezmeye yarar ..
            return "Yanında patateskızartması ve içecek ile ..";
        }
    }
}
