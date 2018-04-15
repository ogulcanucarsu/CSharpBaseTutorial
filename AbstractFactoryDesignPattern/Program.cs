using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AbstractFactoryDesignPattern
{

    interface GUIFactory
    {
        Button createButton();
    }

    class WinFactory : GUIFactory
    {
        public Button createButton()
        {
            return new WinButton();
        }
    }

    class OSXFactory : GUIFactory
    {
        public Button createButton()
        {
            return new OSXButton();
        }
    }

    interface Button
    {
        void paint();
    }

    class WinButton : Button
    {
        public void paint()
        {
            Console.WriteLine("Winbutton");
        }
    }

    class OSXButton : Button
    {
        public void paint()
        {
            Console.WriteLine("OSXbutton");
        }
    }

    class Application
    {
        public Application(GUIFactory factory)
        {
            Button button = factory.createButton();
            button.paint();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Program(createOsSpesificFactory());
        }
        public GUIFactory createOsSpesificFactory()
        {
            return new WinFactory();
        }
    }
}
