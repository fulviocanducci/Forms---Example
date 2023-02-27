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
         textBox1 = new TextBox();
         ButClose = new Button();
         ((System.ComponentModel.ISupportInitialize)DataGridViewGeneral).BeginInit();
         SuspendLayout();
         // 
         // DataGridViewGeneral
         // 
         DataGridViewGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         DataGridViewGeneral.Location = new Point(12, 41);
         DataGridViewGeneral.Name = "DataGridViewGeneral";
         DataGridViewGeneral.RowTemplate.Height = 25;
         DataGridViewGeneral.Size = new Size(776, 367);
         DataGridViewGeneral.TabIndex = 0;
         DataGridViewGeneral.CellDoubleClick += DataGridViewGeneral_CellDoubleClick;
         DataGridViewGeneral.PreviewKeyDown += DataGridViewGeneral_PreviewKeyDown;
         // 
         // textBox1
         // 
         textBox1.Location = new Point(12, 12);
         textBox1.Name = "textBox1";
         textBox1.Size = new Size(776, 23);
         textBox1.TabIndex = 1;
         // 
         // ButClose
         // 
         ButClose.Location = new Point(713, 414);
         ButClose.Name = "ButClose";
         ButClose.Size = new Size(75, 23);
         ButClose.TabIndex = 2;
         ButClose.Text = "Fecha&r";
         ButClose.UseVisualStyleBackColor = true;
         ButClose.Click += ButClose_Click;
         // 
         // FormSearch
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(799, 444);
         Controls.Add(ButClose);
         Controls.Add(textBox1);
         Controls.Add(DataGridViewGeneral);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         KeyPreview = true;
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FormSearch";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "FormSearch";
         Load += FormSearch_Load;
         KeyUp += FormSearch_KeyUp;
         ((System.ComponentModel.ISupportInitialize)DataGridViewGeneral).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private DataGridView DataGridViewGeneral;
      private TextBox textBox1;
      private Button ButClose;
   }
}