using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyAğacı
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TC No giriniz");
            string tcNo = Console.ReadLine();
            soyAgacı(tcNo);
        }
        private static void soyAgacı(string tcNo)
        {
            string YedinciRakam = tcNo.Substring(6, 1);
            string UcuncuRakam = tcNo.Substring(2, 1);
            int BesRakam = Convert.ToInt32(tcNo.Substring(0, 5));
            int DortRakam = Convert.ToInt32(tcNo.Substring(5, 4));
            int OnuncuRakam = Convert.ToInt32(tcNo.Substring(9, 1));
            int SonRakam = Convert.ToInt32(tcNo.Substring(10, 1));

            BesRakam += 3;
            DortRakam -= 1;

            if (SonRakam < 4)
            {
                SonRakam += 10;
                SonRakam -= 4;
            }
            else
            {
                SonRakam -= 4;
            }
            if (UcuncuRakam != BesRakam.ToString().Substring(2, 1))
            {
                if (SonRakam < 6)
                {
                    SonRakam += 10;
                    SonRakam -= 6;

                }
                else if (YedinciRakam != DortRakam.ToString().Substring(1, 1))
                {
                    if (SonRakam < 2)
                    {
                        SonRakam += 10;
                        SonRakam -= 2;
                    }
                    else
                    {
                        if (SonRakam < 4)
                        {
                            SonRakam += 10;
                            SonRakam -= 4;
                        }
                    }
                }
            }
            int Bir = BesRakam / 10000;
            BesRakam = BesRakam - (Bir * 10000);

            int İki = BesRakam / 1000;
            BesRakam = BesRakam - (İki * 1000);

            int Uc = BesRakam / 100;
            BesRakam = BesRakam - (Uc * 100);

            int Dort = BesRakam / 10;
            BesRakam = BesRakam - (Dort * 10);

            int Bes = BesRakam;


            int Altı = DortRakam / 1000;
            DortRakam = DortRakam - (Altı * 1000);

            int Yedi = DortRakam / 100;
            DortRakam = DortRakam - (Yedi * 100);

            int Sekiz = DortRakam / 10;
            DortRakam = DortRakam - (Sekiz * 10);

            int Dokuz = DortRakam;

            int Toplam = Bir + İki + Uc + Dort + Bes + Altı + Yedi + Sekiz + Dokuz;
            int x;
            if (SonRakam < Toplam % 10)
            {
                x = (SonRakam + 10) - (Toplam % 10);

            }
            else
            {
                x = SonRakam - (Toplam % 10);
            }
            string YeniTc = "" + Bir + İki + Uc + Dort + Bes + Altı + Yedi + Sekiz + Dokuz + x + SonRakam;
            Console.WriteLine("YeniTc");
            Console.WriteLine("" + YeniTc);
            Console.ReadLine();


        }
       
    }
}
