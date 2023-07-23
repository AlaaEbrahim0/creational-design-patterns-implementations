using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.CrossPlatformUI
{
	public abstract class Button
	{
		protected Button(string title)
		{
			Title = title.ToUpper();
			SetColors();
		}

		public string Title { get; protected set; }

		protected abstract void SetColors();

		public override string ToString()
		{
			return $"[{Title}]";
		}
	}

	public class WindowsButton : Button
	{
		public WindowsButton(string title) : base(title)
		{
		}

		protected override void SetColors()
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
	public class MacButton : Button
	{
		public MacButton(string title) : base(title)
		{
		}

		protected override void SetColors()
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
		}
	}

}
