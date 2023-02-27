using Dal.Extensions;
using Interfaces;
using Models;
using System.Collections.Generic;
using System.Data;
namespace Dal
{
   public class DalClient : IAdd<Client>, IUpdate<Client>, IDelete<Client>, IFind<Client>, IFindAll<Client>
   {
      private IConnection Connection { get; }

      public DalClient(IConnection connection)
      {
         Connection = connection;
      }

      public Client Add(Client model)
      {
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Name", model.Name);
            command.AddParameter("@CityId", model.CityId);
            command.CommandText = "INSERT INTO Client (Name, CityId) VALUES(@Name, @CityId);".GetInsertId();
            Connection.Open();
            object result = command.ExecuteScalar();
            if (long.TryParse(result.ToString(), out long id))
            {
               model.Id = id;
            }
            Connection.Close();
         }
         return model;
      }

      public Client Find(params object[] keys)
      {
         Client model = null;
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Id", (long)keys[0]);
            command.CommandText = "SELECT Id, Name, CityId FROM Client WHERE Id=@Id";
            Connection.Open();
            using (IDataReader reader = command.ExecuteReader())
            {
               if (reader.Read())
               {
                  model = new Client
                  {
                     Id = reader.GetInt64(1),
                     Name = reader.GetString(2),
                     CityId = reader.GetInt64(3)
                  };
               }
               reader.Close();
            }
            Connection.Close();
         }
         return model;
      }

      public IEnumerable<Client> FindAll(params object[] filters)
      {
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Name", filters[0]);
            command.CommandText = "SELECT Id, Name, CityId FROM Client WHERE Name LIKE @Name ORDER BY Name ASC";
            Connection.Open();
            using (IDataReader reader = command.ExecuteReader())
            {
               while (reader.Read())
               {
                  yield return new Client
                  {
                     Id = reader.GetInt64(1),
                     Name = reader.GetString(2),
                     CityId = reader.GetInt64(3)
                  };
               }
               reader.Close();
            }
            Connection.Close();
         }
      }

      public bool Update(Client model)
      {
         bool result = false;
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Name", model.Name);
            command.AddParameter("@CityId", model.CityId);
            command.AddParameter("@Id", model.Id);
            command.CommandText = "UPDATE Client SET Name=@Name, CityId=@CityId WHERE Id=@Id";
            Connection.Open();
            result = command.ExecuteNonQuery() > 0;
            Connection.Close();
         }
         return result;
      }

      public bool Delete(params object[] keys)
      {
         bool result = false;
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Id", (long)keys[0]);
            command.CommandText = "DELETE FROM Client WHERE Id=@Id";
            Connection.Open();
            result = command.ExecuteNonQuery() > 0;
            Connection.Close();
         }
         return result;
      }
   }
}
