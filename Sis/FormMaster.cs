using Sis.Forms;
namespace Sis
{
   public partial class FormMaster : Form
   {
      public FormMaster()
      {
         InitializeComponent();
      }

      private void MenuClienteToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (FrmClient frm = new FrmClient())
         {
            frm.ShowDialog();
         }
      }
   }
}
