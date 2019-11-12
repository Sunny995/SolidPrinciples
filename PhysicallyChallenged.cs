using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class PhysicallyChallenged : Academics
    {
        public string Name;
        public int Id;
        public PhysicallyChallenged(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public override void Scores(string name, int marks)
        {
            marks += 50;
            Console.WriteLine(name + "=>" + marks);
        }
    }
}
