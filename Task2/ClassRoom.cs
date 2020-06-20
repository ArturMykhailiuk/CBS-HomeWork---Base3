using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] arrClassRoom;

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            arrClassRoom = new Pupil[] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            arrClassRoom = new Pupil[] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            arrClassRoom = new Pupil[] { p1, p2 };
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("Учится: ");
            foreach (Pupil item in arrClassRoom)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.WriteLine("Читает: ");
            foreach (Pupil item in arrClassRoom)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.WriteLine("Пишет: ");
            foreach (Pupil item in arrClassRoom)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.WriteLine("Отдыхает: ");
            foreach (Pupil item in arrClassRoom)
                item.Relax();
        }
    }
}
