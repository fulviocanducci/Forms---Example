using Interfaces;
using Models;
using Models.ViewModels;

namespace Dal
{
   public interface IDalClient : IAdd<Client>, IUpdate<Client>, IDelete<Client>, IFind<Client>, IFindAll<Client>, IExist<Client>, IGridAll<ClientViewModel> { }
}
