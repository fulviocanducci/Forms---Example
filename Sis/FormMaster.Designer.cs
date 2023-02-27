namespace Sis
{
   partial class FormMaster
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         menuStrip1 = new MenuStrip();
         MenuCadastroToolStripMenuItem = new ToolStripMenuItem();
         MenuClienteToolStripMenuItem = new ToolStripMenuItem();
         menuStrip1.SuspendLayout();
         SuspendLayout();
         // 
         // menuStrip1
         // 
         menuStrip1.Items.AddRange(new ToolStripItem[] { MenuCadastroToolStripMenuItem });
         menuStrip1.Location = new Point(0, 0);
         menuStrip1.Name = "menuStrip1";
         menuStrip1.Size = new Size(800, 24);
         menuStrip1.TabIndex = 0;
         menuStrip1.Text = "menuStrip1";
         // 
         // MenuCadastroToolStripMenuItem
         // 
         MenuCadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuClienteToolStripMenuItem });
         MenuCadastroToolStripMenuItem.Name = "MenuCadastroToolStripMenuItem";
         MenuCadastroToolStripMenuItem.Size = new Size(66, 20);
         MenuCadastroToolStripMenuItem.Text = "Cadastro";
         // 
         // MenuClienteToolStripMenuItem
         // 
         MenuClienteToolStripMenuItem.Name = "MenuClienteToolStripMenuItem";
         MenuClienteToolStripMenuItem.Size = new Size(180, 22);
         MenuClienteToolStripMenuItem.Text = "Cliente";
         MenuClienteToolStripMenuItem.Click += MenuClienteToolStripMenuItem_Click;
         // 
         // FormMaster
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(menuStrip1);
         KeyPreview = true;
         MainMenuStrip = menuStrip1;
         Name = "FormMaster";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Sistema";
         WindowState = FormWindowState.Maximized;
         menuStrip1.ResumeLayout(false);
         menuStrip1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private MenuStrip menuStrip1;
      private ToolStripMenuItem MenuCadastroToolStripMenuItem;
      private ToolStripMenuItem MenuClienteToolStripMenuItem;
   }
}