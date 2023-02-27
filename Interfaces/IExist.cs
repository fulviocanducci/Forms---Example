namespace Interfaces
{
   public interface IExist<T> where T : class, new()
   {
      bool Exist(params object[] keys);
   }
}
