using Interfaces;
using System.Data;
namespace Dal
{
   public sealed class Connection : IConnection
   {
      private IDbConnection Connect { get; set; }

      public Connection(IDbConnection connect)
      {
         Connect = connect;
      }

      public void Close()
      {
         if (Connect != null && Connect.State == ConnectionState.Open)
         {
            Connect.Close();
         }
      }

      public IDbCommand CreateCommand()
      {
         return Connect.CreateCommand();
      }

      public void Dispose()
      {
         Connect.Dispose();
      }

      public void Open()
      {
         if (Connect != null && Connect.State == ConnectionState.Closed)
         {
            Connect.Open();
         }
      }
   }
}
