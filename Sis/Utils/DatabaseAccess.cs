using Dal;
using Interfaces;
using System.Data.SQLite;

namespace Sis.Utils
{
   internal static class DatabaseAccess
   {
      public static Guid Id { get; private set; }

      private static IConnection? _instance;

      private static readonly object _lock = new();

      static DatabaseAccess() { }

      public static IConnection Instance
      {
         get
         {
            if (_instance == null)
            {
               lock (_lock)
               {
                  _instance ??= new Connection(new SQLiteConnection(@"Data Source=db.sqlite"));
                  Id = Guid.NewGuid();
               }
            }
            return _instance;
         }
      }
   }
}
