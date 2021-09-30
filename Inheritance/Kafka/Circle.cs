using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Kafka
{
    public class Circle : Shape
    {
        private string _name;

        public Circle(string name)
        {
            _name = name;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Drawing a {_name}");
        }
    }
}
