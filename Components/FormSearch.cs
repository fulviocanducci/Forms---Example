namespace Components
{
   public partial class FormSearch : Form
   {
      public object? Item { get; private set; }

      public FormSearch()
      {
         InitializeComponent();
      }

      public void SetDataSource(object data)
      {
         DataGridViewGeneral.DataSource = data;
      }

      public void SetColumns(params DataGridViewColumn[] columns)
      {
         DataGridViewGeneral.AutoGenerateColumns = false;
         DataGridViewGeneral.AllowUserToAddRows = false;
         DataGridViewGeneral.AllowUserToDeleteRows = false;
         DataGridViewGeneral.AllowUserToResizeRows = false;
         DataGridViewGeneral.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         DataGridViewGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         DataGridViewGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
         DataGridViewGeneral.Columns.Clear();
         DataGridViewGeneral.Columns.AddRange(columns);
      }

      public void SetTitle(string title)
      {
         Text = title;
      }

      private void FormSearch_Load(object sender, EventArgs e)
      {

      }

      private void DataGridViewGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (sender != null && e != null && e.RowIndex > -1 && DataGridViewGeneral.CurrentRow != null && DataGridViewGeneral.Rows.Count > 0)
         {
            Item = DataGridViewGeneral.Rows[e.RowIndex].Cells[0].Value;
            Close();
         }
      }

      private void DataGridViewGeneral_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            if (sender != null && e != null && DataGridViewGeneral.CurrentRow != null && DataGridViewGeneral.Rows.Count > 0)
            {
               Item = DataGridViewGeneral.CurrentRow.Cells[0].Value;
               Close();
            }
         }
      }

      private void FormSearch_KeyUp(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Escape)
         {
            Item = null;
            Close();
         }
      }

      private void ButClose_Click(object sender, EventArgs e)
      {
         Item = null;
         Close();
      }
   }
}
