using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319Win_Interface
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int Hp { get; set; }
        public Silah Silahi { get; set; }

        public string NisanAl()
        {
            if (Silahi is IYakinlastirabilable)
            {   //????????????????????????????????????????
                IYakinlastirabilable iy = (IYakinlastirabilable)Silahi;
                return iy.Yakinlastir();
            }
            else
                return "";

        }
        public void Saldir()
        {

        }
    }
}
