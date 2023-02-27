using System.Collections.Generic;

namespace Interfaces
{
   public interface IGridAll<T> where T: class, new()
   {
      IEnumerable<T> GridAll(params object[] filters);
   }
}
