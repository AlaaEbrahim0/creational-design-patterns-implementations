using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.CrossPlatformUI
{
	public interface IGUIFactory
	{
		public Button CreateButton();
		public Checkbox CreateCheckbox();
	}

	public class WindowsGUIFactory : IGUIFactory
	{
		public Button CreateButton()
		{
			return new WindowsButton("Click Here!");
		}

		public Checkbox CreateCheckbox()
		{
			return new WindowsCheckbox(true);
		}
	}
	public class MacGUIFactory : IGUIFactory
	{
		public Button CreateButton()
		{
			return new MacButton("Click!");
		}

		public Checkbox CreateCheckbox()
		{
			return new MacCheckbox(true);
		}
	}
}
