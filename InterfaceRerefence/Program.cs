using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRerefence
{
    interface ICSharp
    {
        void metot1();
    }

    class sinif1 : ICSharp
    {
        public void metot1()
        {
            Console.WriteLine("sinif1 metot1");
        }
    }

    class sinif2 : ICSharp
    {
        public void metot1()
        {
            Console.WriteLine("sinif2 metot1");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ICSharp obj;

            sinif1 sinif1obj = new sinif1();
            sinif2 sinif2obj = new sinif2();

            obj = sinif1obj;
            obj.metot1();

            obj = sinif2obj;
            obj.metot1();

            Console.ReadLine();

        }
    }
}
