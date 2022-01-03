using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Light
    {
        public string Color { get; set; }
        public void redLight(int t)
        {
            Console.WriteLine("light is red");
        }
        public void yellowLight(int t)
        {
            Console.WriteLine("light is yellow");
        }
    }
}
