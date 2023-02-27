namespace Models
{
   public class Client
   {
      public Client()
      {
      }

      public Client(long id, string name, long cityId, City city)
      {
         Id = id;
         Name = name;
         CityId = cityId;
         City = city;
      }

      public long Id { get; set; }
      public string Name { get; set; }
      public long CityId { get; set; }
      public City City { get; set; }
   }
}
