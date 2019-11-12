﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Reports : IWriter
    {

        public IWriter _w;

        public Reports(IWriter w)
        {
            _w = w;
        }

        public void printer(string num)
        {

            _w.Write(num);
        }

        public void Write(string message)
        {
            Console.WriteLine("into"); 
        }
    }

}