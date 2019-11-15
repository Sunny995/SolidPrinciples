using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Configure
    {
        //Lsp Violations
        // derived class does not truly fulfill is-a relationship with Base class.
        //derived class object is not a replaceable for a base class object.
        public void ConfigurePhone(SamsungPhone phone)
        {
            if (phone.Name == "SamsungJ")
            {
                Console.WriteLine(phone.Name+"is Configured");
            }
            // normal configurations
        }
    }
}
