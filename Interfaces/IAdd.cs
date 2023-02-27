namespace Interfaces
{
   public interface IAdd<T> where T : class, new()
   {
      T Add(T model);
   }
}
