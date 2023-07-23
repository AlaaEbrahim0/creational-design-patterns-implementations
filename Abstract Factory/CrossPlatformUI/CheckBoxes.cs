using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.CrossPlatformUI
{
	public abstract class Checkbox
	{
		protected Checkbox(bool @checked)
		{
			Checked = @checked;
			SetColors();
		}

		public bool Checked { get; set; }

        protected abstract void SetColors();

		public override string ToString()
		{
			var output = (Checked ? "✓" : " ");
			return $"({output})";
		}
	}

	public class WindowsCheckbox : Checkbox
	{
		public WindowsCheckbox(bool @checked) : base(@checked)
		{
		}

		protected override void SetColors()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Green;
		}
	}

	public class MacCheckbox : Checkbox
	{
		public MacCheckbox(bool @checked) : base(@checked)
		{
		}

		protected override void SetColors()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Blue;
		}
	}
}
