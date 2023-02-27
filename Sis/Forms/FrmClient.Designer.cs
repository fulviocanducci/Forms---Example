namespace Sis.Forms
{
   partial class FrmClient
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
         LblId = new Label();
         LblName = new Label();
         LblCity = new Label();
         TxtId = new TextBox();
         TxtName = new TextBox();
         TxtCityId = new TextBox();
         TxtCityName = new TextBox();
         ButSalvar = new Button();
         ButSair = new Button();
         ButCancelar = new Button();
         SuspendLayout();
         // 
         // LblId
         // 
         LblId.AutoSize = true;
         LblId.Location = new Point(6, 16);
         LblId.Name = "LblId";
         LblId.Size = new Size(49, 15);
         LblId.TabIndex = 0;
         LblId.Text = "Código:";
         // 
         // LblName
         // 
         LblName.AutoSize = true;
         LblName.Location = new Point(6, 48);
         LblName.Name = "LblName";
         LblName.Size = new Size(43, 15);
         LblName.TabIndex = 1;
         LblName.Text = "Nome:";
         // 
         // LblCity
         // 
         LblCity.AutoSize = true;
         LblCity.Location = new Point(6, 78);
         LblCity.Name = "LblCity";
         LblCity.Size = new Size(47, 15);
         LblCity.TabIndex = 2;
         LblCity.Text = "Cidade:";
         // 
         // TxtId
         // 
         TxtId.Location = new Point(62, 8);
         TxtId.Name = "TxtId";
         TxtId.PlaceholderText = "Código";
         TxtId.Size = new Size(384, 23);
         TxtId.TabIndex = 3;
         TxtId.KeyPress += TxtId_KeyPress;
         // 
         // TxtName
         // 
         TxtName.Location = new Point(62, 40);
         TxtName.Name = "TxtName";
         TxtName.PlaceholderText = "Nome";
         TxtName.Size = new Size(384, 23);
         TxtName.TabIndex = 4;
         // 
         // TxtCityId
         // 
         TxtCityId.Location = new Point(62, 70);
         TxtCityId.Name = "TxtCityId";
         TxtCityId.PlaceholderText = "Cidade";
         TxtCityId.Size = new Size(64, 23);
         TxtCityId.TabIndex = 5;
         TxtCityId.TextAlign = HorizontalAlignment.Center;
         TxtCityId.KeyPress += TxtCityId_KeyPress;
         // 
         // TxtCityName
         // 
         TxtCityName.Location = new Point(132, 70);
         TxtCityName.Name = "TxtCityName";
         TxtCityName.ReadOnly = true;
         TxtCityName.Size = new Size(314, 23);
         TxtCityName.TabIndex = 6;
         // 
         // ButSalvar
         // 
         ButSalvar.Location = new Point(9, 103);
         ButSalvar.Name = "ButSalvar";
         ButSalvar.Size = new Size(75, 23);
         ButSalvar.TabIndex = 7;
         ButSalvar.Text = "&Salvar";
         ButSalvar.UseVisualStyleBackColor = true;
         ButSalvar.Click += ButSalvar_Click;
         // 
         // ButSair
         // 
         ButSair.Location = new Point(371, 103);
         ButSair.Name = "ButSair";
         ButSair.Size = new Size(75, 23);
         ButSair.TabIndex = 8;
         ButSair.Text = "Sai&r";
         ButSair.UseVisualStyleBackColor = true;
         ButSair.Click += ButSair_Click;
         // 
         // ButCancelar
         // 
         ButCancelar.Location = new Point(90, 103);
         ButCancelar.Name = "ButCancelar";
         ButCancelar.Size = new Size(75, 23);
         ButCancelar.TabIndex = 9;
         ButCancelar.Text = "&Cancelar";
         ButCancelar.UseVisualStyleBackColor = true;
         ButCancelar.Click += ButCancelar_Click;
         // 
         // FrmClient
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(454, 134);
         Controls.Add(ButCancelar);
         Controls.Add(ButSair);
         Controls.Add(ButSalvar);
         Controls.Add(TxtCityName);
         Controls.Add(TxtCityId);
         Controls.Add(TxtName);
         Controls.Add(TxtId);
         Controls.Add(LblCity);
         Controls.Add(LblName);
         Controls.Add(LblId);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         KeyPreview = true;
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FrmClient";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Clientes";
         Load += FrmClient_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label LblId;
      private Label LblName;
      private Label LblCity;
      private TextBox TxtId;
      private TextBox TxtName;
      private TextBox TxtCityId;
      private TextBox TxtCityName;
      private Button ButSalvar;
      private Button ButSair;
      private Button ButCancelar;
   }
}