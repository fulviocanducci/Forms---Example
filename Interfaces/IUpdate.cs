namespace Interfaces
{
   public interface IUpdate<T> where T : class, new()
   {
      bool Update(T model);
   }


}
