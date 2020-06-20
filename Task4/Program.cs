using System;

namespace Task4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите ключ продукта: ");
            
            string regKey = Console.ReadLine();
            if (regKey == "Pro")
            {
                DocumentWorker document1 = new ProDocumentWorker();
                document1.OpenDocument();
                document1.EditDocument();
                document1.SaveDocument();
            }
            else if (regKey == "Expert")
            {
                DocumentWorker document2 = new ExpertDocumentWorker();
                document2.OpenDocument();
                document2.EditDocument();
                document2.SaveDocument();
            }
            else
            {
                DocumentWorker document3 = new DocumentWorker();
                document3.OpenDocument();
                document3.EditDocument();
                document3.SaveDocument();
            }
        }
    }
}
