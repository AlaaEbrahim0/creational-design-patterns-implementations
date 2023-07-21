using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.CrossPlatformUI.Product.ConcreteProducts;
using FactoryMethod.CrossPlatformUI.Product;

namespace FactoryMethod.CrossPlatformUI.Creator.ConcreteCreators
{
	internal class WindowsDialog : Dialog
	{
		protected override IButton CreateButton()
		{
			return new WindowsButton();
		}
	}
}
