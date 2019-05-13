using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Greet
    {
        public static string sayHello(string name)
        {
            
            string param = String.IsNullOrWhiteSpace(name) ? "World" : name;
            return (String.Format("Hello, {0}", param));
        }
    }
}
