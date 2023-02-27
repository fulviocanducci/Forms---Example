namespace Dal.Extensions
{
   internal static class SQLString
   {
      public static string GetInsertId(this string text)
      {
         return SQLiteCommandInsertId(text);
      }

      public static string SQLiteCommandInsertId(this string text)
      {
         return text + "SELECT last_insert_rowid()";
      }
   }
}
