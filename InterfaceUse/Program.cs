using InterfaceUse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{

    interface IArayuz1
    {
        void metot1();
    }
    interface IArayuz2 : IArayuz1
    {
        new void metot1();
    }

    class Program : IArayuz2
    {
        static void Main(string[] args)
        {
            
        }

        void IArayuz1.metot1()
        {
            
        }

        void IArayuz2.metot1()
        {

        }

    }
}
