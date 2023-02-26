namespace Components
{
   partial class FormSearch
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
         DataGridViewGeneral = new DataGridView();
         ((System.ComponentModel.ISupportInitialize)DataGridViewGeneral).BeginInit();
         SuspendLayout();
         // 
         // DataGridViewGeneral
         // 
         DataGridViewGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         DataGridViewGeneral.Location = new Point(12, 12);
         DataGridViewGeneral.Name = "DataGridViewGeneral";
         DataGridViewGeneral.RowTemplate.Height = 25;
         DataGridViewGeneral.Size = new Size(776, 426);
         DataGridViewGeneral.TabIndex = 0;
         DataGridViewGeneral.CellDoubleClick += DataGridViewGeneral_CellDoubleClick;
         DataGridViewGeneral.PreviewKeyDown += DataGridViewGeneral_PreviewKeyDown;
         // 
         // FormSearch
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(DataGridViewGeneral);
         Name = "FormSearch";
         Text = "FormSearch";
         Load += FormSearch_Load;
         KeyUp += FormSearch_KeyUp;
         ((System.ComponentModel.ISupportInitialize)DataGridViewGeneral).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private DataGridView DataGridViewGeneral;
   }
}