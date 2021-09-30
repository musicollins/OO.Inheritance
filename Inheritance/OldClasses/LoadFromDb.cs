using static System.Console;
namespace Inheritance
{
    public class LoadFromDb : IParentInterface
    {
        public LoadFromDb()
        {
            WriteLine("Helper class instantiated!");
        }

        public void LoadEntities()
        {
            WriteLine("Loading Entities From DB");
            var conversionHelper = new HelpLoading();
            conversionHelper.ConvertToDomainObject();
        }





    }
}
