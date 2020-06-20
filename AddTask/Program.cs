using System;

namespace AddTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Printer printer = new Printer();
            printer.Print("Пример печати строки на стендовом принтере");

            TestPrinter testPrinter = new TestPrinter();

            if (testPrinter is Printer)
            {
                testPrinter.Print("Пример печати строки на тестовом принтере");
            }
            else
            {
                testPrinter = null;
            }
        }
    }
}
