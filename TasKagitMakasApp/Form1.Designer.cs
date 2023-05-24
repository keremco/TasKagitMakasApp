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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}