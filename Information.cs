using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Student
    {
        public string Name;
        public int Id;
        public Writer _writer;
        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this._writer = new Writer();
        }

        public void Info()
        {
            this._writer.Write(this.Name);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Id);
        }
    }
}
