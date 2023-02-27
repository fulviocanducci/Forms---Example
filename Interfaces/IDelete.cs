namespace Interfaces
{
   public interface IDelete<T> where T : class, new()
   {
      bool Delete(params object[] keys);
   }


}
