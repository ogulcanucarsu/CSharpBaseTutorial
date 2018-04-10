using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVSInterface
{


    abstract class Araba
    {
        public int LastikGenisligi { get; set; }
        public int VitesSayisi { get; set; }
        
        public abstract void Hiz();
    }

    interface ITavanTipi
    {
        void TavanTipi();
        
    }

    class Ford : Araba, ITavanTipi
    {
        //Abstarct class dan kalıtım olarak aldığın fonk override etmek zorundasın
        public override void Hiz()
        {
            Console.WriteLine("Hız çoook");
        }
        //Interfaceden aldığın fonksiyonuda almak zorundasın 
        public void TavanTipi()
        {
            Console.WriteLine("Tavanı Açık");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Ford mondeo = new Ford();

            mondeo.Hiz();
            mondeo.TavanTipi();
            mondeo.LastikGenisligi = 180;
            mondeo.VitesSayisi = 6;

            Console.WriteLine("Lastik boyutu -> "+ mondeo.LastikGenisligi + " " + "Vites sayisi -> " + mondeo.VitesSayisi);
            Console.ReadLine();


        }
    }
}
