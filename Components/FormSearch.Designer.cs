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
         ButClose = new Button();
         ((System.ComponentModel.ISupportInitialize)DataGridViewGeneral).BeginInit();
         SuspendLayout();
         // 
         // DataGridViewGeneral
         // 
         DataGridViewGeneral.AllowUserToAddRows = false;
         DataGridViewGeneral.AllowUserToDeleteRows = false;
         DataGridViewGeneral.AllowUserToResizeColumns = false;
         DataGridViewGeneral.AllowUserToResizeRows = false;
         DataGridViewGeneral.BackgroundColor = Color.FromArgb(255, 255, 192);
         DataGridViewGeneral.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
         DataGridViewGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         DataGridViewGeneral.EditMode = DataGridViewEditMode.EditProgrammatically;
         DataGridViewGeneral.GridColor = SystemColors.Control;
         DataGridViewGeneral.Location = new Point(5, 6);
         DataGridViewGeneral.Name = "DataGridViewGeneral";
         DataGridViewGeneral.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         DataGridViewGeneral.RowTemplate.Height = 25;
         DataGridViewGeneral.ScrollBars = ScrollBars.Vertical;
         DataGridViewGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         DataGridViewGeneral.ShowCellErrors = false;
         DataGridViewGeneral.ShowEditingIcon = false;
         DataGridViewGeneral.ShowRowErrors = false;
         DataGridViewGeneral.Size = new Size(776, 367);
         DataGridViewGeneral.TabIndex = 0;
         DataGridViewGeneral.CellDoubleClick += DataGridViewGeneral_CellDoubleClick;
         DataGridViewGeneral.PreviewKeyDown += DataGridViewGeneral_PreviewKeyDown;
         // 
         // ButClose
         // 
         ButClose.Location = new Point(706, 379);
         ButClose.Name = "ButClose";
         ButClose.Size = new Size(75, 23);
         ButClose.TabIndex = 1;
         ButClose.Text = "Fecha&r";
         ButClose.UseVisualStyleBackColor = true;
         ButClose.Click += ButClose_Click;
         // 
         // FormSearch
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         CancelButton = ButClose;
         ClientSize = new Size(786, 410);
         Controls.Add(ButClose);
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
      }

      #endregion

      private DataGridView DataGridViewGeneral;
      private Button ButClose;
   }
}