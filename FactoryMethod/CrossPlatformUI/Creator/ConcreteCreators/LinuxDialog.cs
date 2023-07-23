using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.CrossPlatformUI.Product;
using FactoryMethod.CrossPlatformUI.Product.ConcreteProducts;

namespace FactoryMethod.CrossPlatformUI.Creator.ConcreteCreators
{
	public class LinuxDialog : Dialog
	{
		protected override IButton CreateButton()
		{
			return new LinuxButton();
		}
	}
}
