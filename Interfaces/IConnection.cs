using System;
using System.Data;
namespace Interfaces
{
   public interface IConnection : IDisposable
   {
      IDbCommand CreateCommand();
      void Open();
      void Close();
   }
}
