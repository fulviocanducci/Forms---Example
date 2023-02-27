using Dal.Extensions;
using Interfaces;
using Models;
using System.Collections.Generic;
using System.Data;
namespace Dal
{
   public sealed class DalCity : IFind<City>, IFindAll<City>
   {
      private IConnection Connection { get; }

      public DalCity(IConnection connection)
      {
         Connection = connection;
      }

      public City Find(params object[] keys)
      {
         City model = null;
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Id", (long)keys[0]);
            command.CommandText = "SELECT Id, Name FROM City WHERE Id=@Id";
            Connection.Open();
            using (IDataReader reader = command.ExecuteReader())
            {
               if (reader.Read())
               {
                  model = new City
                  {
                     Id = reader.GetInt64(1),
                     Name = reader.GetString(2)
                  };
               }
               reader.Close();
            }
            Connection.Close();
         }
         return model;
      }

      public IEnumerable<City> FindAll(params object[] filters)
      {
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Name", filters[0]);
            command.CommandText = "SELECT Id, Name FROM City WHERE Name LIKE @Name ORDER BY Name ASC";
            Connection.Open();
            using (IDataReader reader = command.ExecuteReader())
            {
               while (reader.Read())
               {
                  yield return new City
                  {
                     Id = reader.GetInt64(1),
                     Name = reader.GetString(2)
                  };
               }
               reader.Close();
            }
            Connection.Close();
         }
      }
   }
}
