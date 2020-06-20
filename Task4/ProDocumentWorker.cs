using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ProDocumentWorker : DocumentWorker
    {
        override public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        override public void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        override  public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
