using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {

        public enum EkmekTurleri
        {
            BeyazEkmek,
            Kepekli,
            Cavdarli
        }

        public enum SusamCesitleri
        {
            AnkaraSusami,
            MuglaSusami,
            IzmirSusami
        }
        
        static void Main(string[] args)
        {
            Ekmek ekmek = new Ekmek(); // adet 1 tür beyaz
            Ekmek ekmek2 = new Ekmek(2); // adet biz 2 verdik, tür beyaz
            Ekmek ekmek3 = new Ekmek(3, EkmekTurleri.Kepekli); // adet 3 türü kepekli verdik
            Ekmek ekmek4 = new Ekmek(4, EkmekTurleri.Cavdarli, SusamCesitleri.AnkaraSusami); //Adet 4, türü cavdarli, susamı ankara verdik
            Console.ReadLine();
        }

        public class Ekmek
        {
            public int Adet { get; set; }
            public EkmekTurleri Tur { get; set; }
            public SusamCesitleri SusamTuru { get; set; }

            public Ekmek() : this(1, EkmekTurleri.BeyazEkmek)
            {
                Console.WriteLine("Adet: " + Adet + "Ekmek türü  " + Tur);
                //Adet 1 tür beyaz --> default bu değerler setli
            }

            public Ekmek (int adet) : this (adet, EkmekTurleri.BeyazEkmek)
            {
                Console.WriteLine("Adet: " + adet + "Ekmek türü " + Tur);
                //Adet sen kaç verirsen tür beyaz
                // Adeti biz setledik, ekmek türü default olarak beyaz ekmek
            }

           
            public Ekmek(int adet, EkmekTurleri tur)
            {
                Adet = adet;
                Tur = tur;
                //adet ve türü sen ne verirsen 
                //değerleri biz setliyoruz
            }

            public Ekmek(int adet, EkmekTurleri tur, SusamCesitleri susamCesidi)
            {
                Adet = adet;
                Tur = tur;
                SusamTuru = susamCesidi;
                //adet tür ve susamı sen ne verirsen o 
                //değerleri biz setliyoruz
            }


        }
    }
}
