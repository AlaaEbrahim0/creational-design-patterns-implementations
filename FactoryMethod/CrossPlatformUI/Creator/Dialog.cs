using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.CrossPlatformUI.Product;

namespace FactoryMethod.CrossPlatformUI.Creator
{
	public abstract class Dialog
	{
		public void Render()
		{
			IButton button = CreateButton();
			button.Render();
        }
		protected abstract IButton CreateButton();
	}
}
