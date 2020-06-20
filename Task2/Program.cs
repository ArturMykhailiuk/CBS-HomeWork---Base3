using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil() , new BadPupil());

            classRoom.PrintInfoStudy();
            classRoom.PrintInfoRead();           
            classRoom.PrintInfoWrite();
            classRoom.PrintInfoRelax();

            Console.ReadKey();
        }
    }
}
