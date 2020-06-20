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
                GetFunctionalityBeVersion(document1);
            }
            else if (regKey == "Expert")
            {
                DocumentWorker document2 = new ExpertDocumentWorker();
                GetFunctionalityBeVersion(document2);
            }
            else
            {
                DocumentWorker document3 = new DocumentWorker();
                GetFunctionalityBeVersion(document3);
            }
        }

        public static void GetFunctionalityBeVersion(DocumentWorker document)
        {
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }
}
