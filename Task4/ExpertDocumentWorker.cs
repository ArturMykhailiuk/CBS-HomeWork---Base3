using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ExpertDocumentWorker : DocumentWorker
    {
        override public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        override public void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
