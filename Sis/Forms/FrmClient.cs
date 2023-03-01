using Components;
using Dal;
using FluentValidation.Results;
using Models;
using Models.ViewModels;
using Sis.Utils;
using Sis.Validations;
namespace Sis.Forms
{
   public partial class FrmClient : Form
   {
      private IDalClient DalClient { get; }
      private IDalCity DalCity { get; }
      private ClientValidation ClientValidation { get; }

      public FrmClient()
      {
         InitializeComponent();
         DalClient = new DalClient(DatabaseAccess.Instance);
         DalCity = new DalCity(DatabaseAccess.Instance);
         ClientValidation = new ClientValidation(DalClient, DalCity);
      }

      private void ButSair_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void ButCancelar_Click(object sender, EventArgs e)
      {
         Clear_TextBox();
      }

      private void Clear_TextBox()
      {
         TxtId.Text = "";
         TxtName.Text = "";
         TxtCityId.Text = "";
         TxtCityName.Text = "";
         Tag = "Add";
         TxtId.Focus();
      }

      private void Load_ClientGetById(long id)
      {
         Clear_TextBox();
         Client client = DalClient.Find(id);
         if (client != null)
         {
            TxtId.Text = client.Id.ToString();
            TxtName.Text = client.Name;
            TxtCityId.Text = client.CityId.ToString();
            City city = DalCity.Find(client.CityId);
            TxtCityName.Text = city != null ? city.Name : "";
            TxtName.Focus();
            TxtName.SelectAll();
            Tag = "Update";
         }
         else
         {
            MessageBox.Show("Cliente inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      private void Load_CityGetById(long id)
      {
         City city = DalCity.Find(id);
         if (city != null)
         {
            TxtCityId.Text = city.Id.ToString();
            TxtCityName.Text = city.Name;
         }
         else
         {
            MessageBox.Show("Cidade inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 13)
         {
            if (string.IsNullOrEmpty(TxtId.Text))
            {
               Tag = "Add";
               TxtId.Text = "<Novo>";
               TxtName.Focus();
            }
            else
            {
               if (long.TryParse(TxtId.Text, out long id))
               {
                  Load_ClientGetById(id);
               }
               else
               {
                  List<ClientViewModel> data = DalClient.GridAll(TxtId.Text).ToList();
                  if (data.Count == 0)
                  {
                     MessageBox.Show("Pesquisa sem resultados", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  else
                  {
                     using FormSearch frm = FabricFormSearchClient.Create(data);
                     frm.ShowDialog();
                     object? item = frm.Item;
                     if (item != null)
                     {
                        if (long.TryParse(item.ToString(), out id))
                        {
                           Load_ClientGetById(id);
                        }
                     }
                  }
               }
            }
         }
      }

      private void TxtCityId_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 13)
         {
            if (long.TryParse(TxtCityId.Text, out long id))
            {
               Load_CityGetById(id);
            }
            else
            {
               List<City> data = DalCity.FindAll(TxtCityId.Text).ToList();
               using FormSearch frm = FabricFormSearchCity.Create(data);
               frm.ShowDialog();
               object? item = frm.Item;
               if (item != null)
               {
                  if (long.TryParse(item.ToString(), out id))
                  {
                     Load_CityGetById(id);
                  }
               }
            }
         }
      }

      private void ButSalvar_Click(object sender, EventArgs e)
      {
         Client client = new()
         {
            Id = 0
         };
         if (!string.IsNullOrEmpty(TxtId.Text) && long.TryParse(TxtId.Text, out long id))
         {
            client.Id = id;
         }
         if (!string.IsNullOrEmpty(TxtName.Text))
         {
            client.Name = TxtName.Text;
         }
         if (!string.IsNullOrEmpty(TxtCityId.Text) && long.TryParse(TxtCityId.Text, out long cityId))
         {
            client.CityId = cityId;
         }
         ValidationResult result = ClientValidation.Validate(client);
         if (result.IsValid)
         {
            switch (Tag.ToString())
            {
               case "Add":
                  {
                     client = DalClient.Add(client);
                     TxtId.Text = client.Id.ToString();
                     MessageBox.Show("Dados inseridos.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     break;
                  }
               case "Update":
                  {
                     DalClient.Update(client);
                     MessageBox.Show("Dados alterados.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     break;
                  }
               default:
                  {
                     break;
                  }
            }
         }
         else
         {
            Alert.Show("Cliente - Erros", result);
         }
      }

      private void FrmClient_Load(object sender, EventArgs e)
      {
         Tag = "Add";
      }
   }
}
