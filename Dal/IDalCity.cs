using Interfaces;
using Models;
namespace Dal
{
   public interface IDalCity: IFind<City>, IFindAll<City>, IExist<City> { }
}
