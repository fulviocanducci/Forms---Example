using Components;
namespace Sis.Utils
{
   public static class FabricFormSearchCity
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
         columnName.Width = 602;
         columnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
         columnName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

         FormSearch FormSearch = new();
         FormSearch.SetTitle("Pesquisa - Cidades");
         FormSearch.SetColumns(columnId, columnName);
         FormSearch.SetDataSource(data);
         return FormSearch;
      }
   }
}
