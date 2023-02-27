namespace Models.ViewModels
{
   public class ClientViewModel
   {
      public ClientViewModel()
      {
      }

      public ClientViewModel(long id, string name, string city)
      {
         Id = id;
         Name = name;
         City = city;
      }

      public long Id { get; private set; }
      public string Name { get; private set; }
      public string City { get; private set; }
   }
}
