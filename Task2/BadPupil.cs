using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BadPupil : Pupil
    {

        public override void Study()
        {
            Console.WriteLine("BadPupil:  Учится - плохо");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil:  Читает - плохо");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil:  Пишет - плохо");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil:  Отдыхает - прекрасно");
        }
    }
}
