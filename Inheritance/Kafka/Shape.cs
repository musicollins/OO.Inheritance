using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Kafka
{
    public class Shape // Parent Class
    {
        //Field Memebers
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        //Virtual Method
        public virtual void Draw()
        {
            Console.WriteLine("Base class drawing task");
        }
    }


}
