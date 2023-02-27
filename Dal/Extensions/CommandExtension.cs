using System.Data;

namespace Dal.Extensions
{
   internal static class CommandExtension
   {
      public static void AddParameter(this IDbCommand command, string parameterName, object value)
      {
         IDbDataParameter param = command.CreateParameter();
         param.ParameterName = parameterName;
         param.Value = value;
         command.Parameters.Add(param);
      }
   }
}
