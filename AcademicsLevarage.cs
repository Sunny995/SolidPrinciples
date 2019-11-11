using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class AcademicsLevarage : Academics
    {
        public int marks;
        public override void Scores(string name, int marks)
        {
            marks += 50;
            Console.WriteLine(name + "=>" + marks);
        }
    }
}
