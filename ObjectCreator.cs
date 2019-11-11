using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class ObjectCreator 
    {
        IWriter w;
        public Academics AcademicsCreator()
        {
            return new Academics();
        }

        public Student StudentCreator(string name, int marks)
        {
            var stud = new Student(name, marks);
            return stud;
        }
    }
}
