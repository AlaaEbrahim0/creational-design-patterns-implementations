using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.CrossPlatformUI
{
	public class GUIApp
	{
		public static void Render()
		{
			//Simulating real world scenairo where we get the os type from a config file or env metadata
			var os = Environment.OSVersion.Platform;
			IGUIFactory? factory = null;

			if (os == PlatformID.Win32NT)
			{
				factory = new WindowsGUIFactory();
			}
			else if (os == PlatformID.Unix)
			{
				factory = new MacGUIFactory();
			}
			else
			{
				throw new Exception("Unsupported Platform!!");
			}

			var button = factory.CreateButton();
            Console.WriteLine(button);

			var checkbox = factory.CreateCheckbox();
            Console.WriteLine(checkbox);
        }

	}
}
