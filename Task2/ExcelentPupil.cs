using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil: Учится - прекрасно");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil:  Читает - прекрасно");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil:  Пишет - прекрасно");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil:  Отдыхает - плохо");
        }
    }
}
