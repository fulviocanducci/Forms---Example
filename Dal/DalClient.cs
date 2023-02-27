using Dal.Extensions;
using Interfaces;
using Models;
using Models.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dal
{
   public class DalClient : IAdd<Client>, IUpdate<Client>, IDelete<Client>, IFind<Client>, IFindAll<Client>, IExist<Client>, IGridAll<ClientViewModel>
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
                     Id = reader.GetInt64(0),
                     Name = reader.GetString(1),
                     CityId = reader.GetInt64(2)
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
            command.AddParameter("@Name", $"%{filters[0]}%");
            command.CommandText = "SELECT Id, Name, CityId FROM Client WHERE Name LIKE @Name ORDER BY Name ASC";
            Connection.Open();
            using (IDataReader reader = command.ExecuteReader())
            {
               while (reader.Read())
               {
                  yield return new Client
                  {
                     Id = reader.GetInt64(0),
                     Name = reader.GetString(1),
                     CityId = reader.GetInt64(2)
                  };
               }
               reader.Close();
            }
            Connection.Close();
         }
      }

      public IEnumerable<ClientViewModel> GridAll(params object[] filters)
      {
         using (IDbCommand command = Connection.CreateCommand())
         {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Client.Id, Client.Name, City.Name as CityName FROM Client JOIN City ");
            sql.Append("ON Client.CityId = City.Id ");
            sql.Append("WHERE Client.Name LIKE @Name ORDER BY Client.Name ASC");
            command.AddParameter("@Name", $"%{filters[0]}%");
            command.CommandText = sql.ToString();
            Connection.Open();
            using (IDataReader reader = command.ExecuteReader())
            {
               while (reader.Read())
               {
                  yield return new ClientViewModel
                     (
                        reader.GetInt64(0), 
                        reader.GetString(1), 
                        reader.GetString(2)
                     );
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

      public bool Exist(params object[] keys)
      {
         bool result = false;
         using (IDbCommand command = Connection.CreateCommand())
         {
            command.AddParameter("@Id", keys[0]);
            command.CommandText = "SELECT COUNT(*) FROM Client WHERE Id=@Id";
            Connection.Open();
            if (long.TryParse(command.ExecuteScalar().ToString(), out long count))
            {
               return count > 0;
            }
            Connection.Close();
         }
         return result;
      }      
   }
}
