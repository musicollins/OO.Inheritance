using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PetStore
    {
        public string _name;
        public PetStore(string name)
        {
            _name = name;
        }

        public void BuyAnimal(IAnimal animal)
        {
            Console.WriteLine($"Petstore: {_name}");
            animal.BuyMe();
        }

    }
}
