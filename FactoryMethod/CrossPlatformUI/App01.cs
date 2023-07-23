using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.CrossPlatformUI.Creator;
using FactoryMethod.CrossPlatformUI.Creator.ConcreteCreators;

namespace FactoryMethod.CrossPlatformUI
{
	public class App01
	{
		public Dialog dialog;

        public App01()
        {
            var os = Environment.OSVersion.Platform;
            if (os == PlatformID.Win32NT)
                dialog = new WindowsDialog();

            else if (os == PlatformID.Unix)
                dialog = new LinuxDialog();

            else
                throw new Exception();
        }
    }
}
