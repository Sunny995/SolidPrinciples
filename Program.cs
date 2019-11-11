using System;

namespace SRP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Srp and OCP
            Student student = new Student("Shubham", 2);
            student.Info();

            new Academics().Scores(student.Name, 450);
            new AcademicsLevarage().Scores(student.Name, 450);
            Console.WriteLine("Hello World!");
            //DIP AND somwhat ISP
            Writer wr = new Writer();
            Reports r = new Reports(wr);
            r.printer("DI");
        }
    }
}
