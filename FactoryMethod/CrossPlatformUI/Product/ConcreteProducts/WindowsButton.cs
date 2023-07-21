using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CrossPlatformUI.Product.ConcreteProducts
{
	internal class WindowsButton : IButton
	{
		public void Render()
		{
			Console.WriteLine($"Rendering {nameof(WindowsButton)} ");
		}
	}
}
