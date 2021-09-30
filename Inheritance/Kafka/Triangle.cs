using System;

namespace Inheritance.Kafka
{
    public class Triangle : Shape
    {
        private string _name;

        public Triangle(string name)
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
