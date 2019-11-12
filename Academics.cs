using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Academics: IWriter
    {
        public int marks;
       
        public virtual void Scores(string name, int marks )
        {
            Console.WriteLine(name+"=>"+marks);
        }

        public void Write(string message)
        {
            Console.WriteLine("Academics");
        }
    }
}
