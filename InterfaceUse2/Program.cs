using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse2
{

    interface IMemeli
    {
        void Konus();
    }

    class Kedi : IMemeli
    {
        void IMemeli.Konus()
        {
            Console.WriteLine("miyav");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. Kullanım
            IMemeli k = new Kedi();
            k.Konus();
            Console.ReadLine();

            //2. kullanım
            Kedi kedi2 = new Kedi();
            ((IMemeli)kedi2).Konus();
            
        }
    }
}
