namespace Sis
{
   internal static class Program
   {
      [STAThread]
      static void Main()
      {
         ApplicationConfiguration.Initialize();
         Application.Run(new FormMaster());
      }
   }
}