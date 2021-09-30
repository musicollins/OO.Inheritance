using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Runner
    {
        public readonly IParentInterface _load;
        public Runner(IParentInterface load)
        {
            _load = load;
        }

        public void Load()
        {
            //Console.WriteLine("Loading Files...");
            _load.LoadEntities();
            //_childClass2.LoadEntities();
        }
    }
}
