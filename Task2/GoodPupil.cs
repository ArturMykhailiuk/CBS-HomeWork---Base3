using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil:  Учится - хорошо");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil:  Читает - хорошо");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil:  Пишет - хорошо");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil:  Отдыхает - хорошо");
        }
    }
}
