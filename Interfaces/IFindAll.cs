using System.Collections.Generic;

namespace Interfaces
{
   public interface IFindAll<T> where T: class, new()
   {
      IEnumerable<T> FindAll(params object[] filters);
   }
}
