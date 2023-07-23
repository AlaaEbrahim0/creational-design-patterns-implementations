using System.Globalization;
using Abstract_Factory.CrossPlatformUI;
using Abstract_Factory.FurnitureStore;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
				Abstract Factory is a creational design pattern that lets you
				produce families of related objects without specifying their
				concrete classes.
			 */

            //FurnitureExample
            FurnitureApp.Start();

            //GuiExample
            GUIApp.Render();

        }
    }
}