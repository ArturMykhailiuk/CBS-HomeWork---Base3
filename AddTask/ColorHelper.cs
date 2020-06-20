using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask
{
	public static class ColorHelper
	{
			public static ConsoleColor GetRandomColor(int value)
			{
				switch (value)
				{
					case 1:
						return ConsoleColor.Red;
					case 2:
						return ConsoleColor.Green;
					case 3:
						return ConsoleColor.Yellow;
					case 4:
						return ConsoleColor.Cyan;
					case 5:
						return ConsoleColor.Magenta;
					default:
						return ConsoleColor.White;
				}
			}
	}
}
