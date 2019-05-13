using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    class Greet
    {
        public static string sayHello(string name)
        {
            return (String.Format("Hello, {0}", name));
        }
    }
}
