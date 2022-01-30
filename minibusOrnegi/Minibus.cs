using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minibusOrnegi
{
    class Minibus
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        string hatKodu;
        double bakiye;

        const double TAMBILET = 1.90;
        const double OGRENCIBILET = 1.40;

        public Minibus(string hatKodu, int toplamKoltukSayisi)
        {
            this.toplamKoltukSayisi = toplamKoltukSayisi;
            this.bosKoltukSayisi = toplamKoltukSayisi;
            this.hatKodu = hatKodu;
            bakiye = 0;
        }

        public void yolcuAl(bool tammi)
        {
            bosKoltukSayisi--;
            if (tammi == true)
            {
                bakiye += TAMBILET;
            }
            else
            {
                bakiye += OGRENCIBILET;
            }
        }

        public void yolcuIndir()
        {
            bosKoltukSayisi++;
        }

        public int bosKoltukOgren()
        {
            return bosKoltukSayisi;
        }

        public double bakiyeOgren()
        {
            return bakiye;
        }

    }
}
