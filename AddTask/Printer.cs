using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask
{
    class Printer
    {
        
        virtual public void Print(string value)
        {
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
            Console.WriteLine(value);
            Console.ResetColor();
        }
	}
}
