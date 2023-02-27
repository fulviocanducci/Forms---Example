namespace Models
{
   public class City
   {
      public City()
      {
      }

      public City(long id, string name)
      {
         Id = id;
         Name = name;
      }

      public long Id { get; set; }
      public string Name { get; set; }
   }
}
