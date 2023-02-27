namespace Interfaces
{
   public interface IFind<T> where T : class, new()
   {
      T Find(params object[] keys);
   }


}
