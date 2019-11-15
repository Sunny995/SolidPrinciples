using System;

namespace SRP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Srp and OCP
            ObjectCreator obj = new ObjectCreator();
            obj.StudentCreator("Shekhar",2).Info();
            var o = obj.PhysicallyChallengedCreator("rohit",400);
            o.Scores(o.Name,o.marks);
            Console.WriteLine("Hello World!");
            //Lsp 
            new Configure().ConfigurePhone(new SamsungJ());

            //DIP AND somwhat ISP
            Academics a = new Academics();
            Writer wr = new Writer();
            Reports r = new Reports(a);
            r.printer("DI");
           
           
        }
    }
}
