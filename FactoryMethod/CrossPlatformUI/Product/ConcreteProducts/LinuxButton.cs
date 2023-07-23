using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CrossPlatformUI.Product.ConcreteProducts
{
	public class LinuxButton : IButton
	{
		public void Render()
		{
			Console.WriteLine($"Rendering {nameof(LinuxButton)} ");
		}
	}
}
