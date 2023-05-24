namespace TasKagitMakasApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ddlHareket = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBasla = new System.Windows.Forms.Button();
            this.lKazanan = new System.Windows.Forms.Label();
            this.rbKagit = new System.Windows.Forms.RadioButton();
            this.rbTas = new System.Windows.Forms.RadioButton();
            this.rbMakas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ddlHareket
            // 
            this.ddlHareket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlHareket.FormattingEnabled = true;
            this.ddlHareket.Location = new System.Drawing.Point(87, 6);
            this.ddlHareket.Name = "ddlHareket";
            this.ddlHareket.Size = new System.Drawing.Size(121, 23);
            this.ddlHareket.TabIndex = 0;
            this.ddlHareket.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hareket Seç";
            // 
            // bBasla
            // 
            this.bBasla.Location = new System.Drawing.Point(214, 6);
            this.bBasla.Name = "bBasla";
            this.bBasla.Size = new System.Drawing.Size(75, 23);
            this.bBasla.TabIndex = 2;
            this.bBasla.Text = "Başla";
            this.bBasla.UseVisualStyleBackColor = true;
            this.bBasla.Click += new System.EventHandler(this.bBasla_Click);
            // 
            // lKazanan
            // 
            this.lKazanan.Location = new System.Drawing.Point(12, 136);
            this.lKazanan.Name = "lKazanan";
            this.lKazanan.Size = new System.Drawing.Size(277, 49);
            this.lKazanan.TabIndex = 3;
            this.lKazanan.Text = "lKazanan";
            this.lKazanan.Visible = false;
            this.lKazanan.Click += new System.EventHandler(this.lKazanan_Click);
            // 
            // rbKagit
            // 
            this.rbKagit.AutoSize = true;
            this.rbKagit.Location = new System.Drawing.Point(12, 35);
            this.rbKagit.Name = "rbKagit";
            this.rbKagit.Size = new System.Drawing.Size(63, 19);
            this.rbKagit.TabIndex = 4;
            this.rbKagit.TabStop = true;
            this.rbKagit.Text = "rbKagit";
            this.rbKagit.UseVisualStyleBackColor = true;
            // 
            // rbTas
            // 
            this.rbTas.AutoSize = true;
            this.rbTas.Location = new System.Drawing.Point(117, 35);
            this.rbTas.Name = "rbTas";
            this.rbTas.Size = new System.Drawing.Size(52, 19);
            this.rbTas.TabIndex = 5;
            this.rbTas.TabStop = true;
            this.rbTas.Text = "rbTas";
            this.rbTas.UseVisualStyleBackColor = true;
            // 
            // rbMakas
            // 
            this.rbMakas.AutoSize = true;
            this.rbMakas.Location = new System.Drawing.Point(212, 35);
            this.rbMakas.Name = "rbMakas";
            this.rbMakas.Size = new System.Drawing.Size(70, 19);
            this.rbMakas.TabIndex = 6;
            this.rbMakas.TabStop = true;
            this.rbMakas.Text = "rbMakas";
            this.rbMakas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 194);
            this.Controls.Add(this.rbMakas);
            this.Controls.Add(this.rbTas);
            this.Controls.Add(this.rbKagit);
            this.Controls.Add(this.lKazanan);
            this.Controls.Add(this.bBasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlHareket);
            this.Name = "Form1";
            this.Text = "Taş Kağıt Makas Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ddlHareket;
        private Label label1;
        private Button bBasla;
        private Label lKazanan;
        private RadioButton rbKagit;
        private RadioButton rbTas;
        private RadioButton rbMakas;
    }
}