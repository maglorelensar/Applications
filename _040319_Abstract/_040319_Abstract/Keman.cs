using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040319_Abstract
{
    class Keman : MuzikAletleri
    {
        public override CalmaTipi CalmaTipi
        {
            get
            {
                return CalmaTipi.Telli;            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Cal()
        {
            return "Keman Çalınıor";
        }
    }
}
