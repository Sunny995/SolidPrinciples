using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Writer: IWriter
    {
        
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
