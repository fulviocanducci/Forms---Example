using Components;
namespace Sis.Utils
{
   public static class FabricFormSearchClient
   {
      public static FormSearch Create(object data)
      {
         DataGridViewTextBoxColumn columnId = new();
         columnId.Name = "ColumnId";
         columnId.HeaderText = "Id";
         columnId.DataPropertyName = "Id";
         columnId.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         columnId.ValueType = typeof(int);
         columnId.Width = 110;
         columnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
         columnId.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

         DataGridViewTextBoxColumn columnName = new();
         columnName.Name = "ColumnName";
         columnName.HeaderText = "Nome";
         columnName.DataPropertyName = "Name";
         columnName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
         columnName.ValueType = typeof(string);
         columnName.Width = 451;
         columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
         columnName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

         DataGridViewTextBoxColumn columnCity = new();
         columnCity.Name = "ColumnName";
         columnCity.HeaderText = "Cidade";
         columnCity.DataPropertyName = "City";
         columnCity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
         columnCity.ValueType = typeof(string);
         columnCity.Width = 151;
         columnCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
         columnCity.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

         FormSearch FormSearch = new();
         FormSearch.SetTitle("Pesquisa - Clientes");
         FormSearch.SetColumns(columnId, columnName, columnCity);
         FormSearch.SetDataSource(data);
         return FormSearch;
      }
   }
}
