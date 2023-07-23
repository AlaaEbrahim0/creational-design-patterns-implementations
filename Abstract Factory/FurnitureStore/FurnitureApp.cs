using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.FurnitureStore
{
	public class FurnitureApp
	{
		public static void Start()
		{
			Console.WriteLine("1) Modern");
			Console.WriteLine("2) Victorian");
			Console.WriteLine("3) ArtDeco\n\n");

			Console.Write("Choice: ");
			int input;
			IFamilyFactory factory = null;
			if (int.TryParse(Console.ReadLine(), out input))
			{
				switch (input)
				{
					case 1:
						factory = new ModernFamilyFactory();
						break;
					case 2:
						factory = new VictorianFamilyFactory();
						break;
					case 3:
						factory = new ArtDecoFamilyFactory();
						break;
					default:
						throw new NullReferenceException();
				}
			}
			var chair = factory.CreateChair();
			var coffeeTable = factory.CreateCoffeeTable();

			chair.SitOn();
			Console.WriteLine(chair);
			coffeeTable.DrinkOn();
		}
	}
}
