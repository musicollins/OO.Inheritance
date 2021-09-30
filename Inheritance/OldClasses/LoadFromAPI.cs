using System;

namespace Inheritance
{
    public class LoadFromAPI : IParentInterface
    {
        public void LoadEntities()
        {
            Console.WriteLine("Loading from API");
            
        }
    }
}