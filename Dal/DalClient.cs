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
            CreateParameter(command, model, true);
            command.CommandText = "INSERT INTO Client (Name, CityId) VALUES(@Name, @CityId); SELECT last_insert_rowid()";
            object result = command.ExecuteScalar();
            if (long.TryParse(result.ToString(), out long id))
            {
               model.Id = id;
            }
         }
         return model;
      }

      public Client Find(params object[] keys)
      {
         Client model = null;
         using (IDbCommand command = Connection.CreateCommand())
         {
            CreateParameterId(command, (long)keys[0]);
            command.CommandText = "SELECT Id, Name, CityId FROM Client WHERE Id=@Id";
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
         }
         return model;
      }

      public IEnumerable<Client> FindAll(params object[] filters)
      {
         using (IDbCommand command = Connection.CreateCommand())
         {
            CreateParameter(command, "@Name", filters[0]);
            command.CommandText = "SELECT Id, Name, CityId FROM Client WHERE Name LIKE @Name";
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
         }
      }

      public bool Update(Client model)
      {
         bool result = false;
         using (IDbCommand command = Connection.CreateCommand())
         {
            CreateParameter(command, model, false);
            command.CommandText = "UPDATE Client SET Name=@Name, CityId=@CityId WHERE Id=@Id";
            result = command.ExecuteNonQuery() > 0;
         }
         return result;
      }

      public bool Delete(params object[] keys)
      {
         bool result = false;
         using (IDbCommand command = Connection.CreateCommand())
         {
            CreateParameterId(command, (long)keys[0]);
            command.CommandText = "DELETE FROM Client WHERE Id=@Id";
            result = command.ExecuteNonQuery() > 0;
         }
         return result;
      }

      internal void CreateParameter(IDbCommand command, Client model, bool insert = true)
      {
         CreateParameter(command, "@Name", model.Name);
         CreateParameter(command, "@CityId", model.CityId);
         if (insert == false)
         {
            CreateParameterId(command, model.Id);
         }
      }

      internal void CreateParameterId(IDbCommand command, long id)
      {
         CreateParameter(command, "@Id", id);
      }

      internal void CreateParameter(IDbCommand command, string parameterName, object value)
      {
         IDbDataParameter param = command.CreateParameter();
         param.ParameterName = parameterName;
         param.Value = value;
         command.Parameters.Add(param);
      }
   }
}
