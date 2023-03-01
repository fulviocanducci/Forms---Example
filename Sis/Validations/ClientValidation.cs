using Dal;
using FluentValidation;
using Models;
namespace Sis.Validations
{
   public sealed class ClientValidation : AbstractValidator<Client>
   {
      public IDalClient DalClient { get; }
      public IDalCity DalCity { get; }
      public ClientValidation(IDalClient dalClient, IDalCity dalCity)
      {
         DalClient = dalClient;
         DalCity = dalCity;
         RuleFor(x => x.Id).Must(BeExistValidId).WithMessage("Código inexistente");
         RuleFor(x => x.Name).NotEmpty().WithMessage("Digite o nome");
         RuleFor(x => x.CityId).NotEmpty().WithMessage("Digite a cidade").Must(BeExistValidCityId).WithMessage("Cidade inexistente");         
      }

      private bool BeExistValidId(long id)
      {
         if (id == 0) return true;
         return DalClient.Exist(id);
      }

      private bool BeExistValidCityId(long id)
      {
         return DalCity.Exist(id);
      }
   }
}
