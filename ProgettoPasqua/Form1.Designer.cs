namespace ProgettoPasqua
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnApri1 = new System.Windows.Forms.Button();
            this.btnApri2 = new System.Windows.Forms.Button();
            this.btnApri3 = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApri1
            // 
            this.btnApri1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApri1.ForeColor = System.Drawing.Color.White;
            this.btnApri1.Location = new System.Drawing.Point(32, 240);
            this.btnApri1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApri1.Name = "btnApri1";
            this.btnApri1.Size = new System.Drawing.Size(100, 67);
            this.btnApri1.TabIndex = 0;
            this.btnApri1.Text = "APRI GESTIONE BIGLIETTI";
            this.btnApri1.UseVisualStyleBackColor = false;
            this.btnApri1.Click += new System.EventHandler(this.btnApri1_Click);
            // 
            // btnApri2
            // 
            this.btnApri2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApri2.ForeColor = System.Drawing.Color.White;
            this.btnApri2.Location = new System.Drawing.Point(325, 240);
            this.btnApri2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApri2.Name = "btnApri2";
            this.btnApri2.Size = new System.Drawing.Size(113, 67);
            this.btnApri2.TabIndex = 1;
            this.btnApri2.Text = "APRI GESTIONE GIOSTRE";
            this.btnApri2.UseVisualStyleBackColor = false;
            this.btnApri2.Click += new System.EventHandler(this.btnApri2_Click);
            // 
            // btnApri3
            // 
            this.btnApri3.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApri3.ForeColor = System.Drawing.Color.White;
            this.btnApri3.Location = new System.Drawing.Point(614, 240);
            this.btnApri3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApri3.Name = "btnApri3";
            this.btnApri3.Size = new System.Drawing.Size(109, 67);
            this.btnApri3.TabIndex = 2;
            this.btnApri3.Text = "APRI GESTIONE ATTRAZIONI";
            this.btnApri3.UseVisualStyleBackColor = false;
            this.btnApri3.Click += new System.EventHandler(this.btnApri3_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChiudi.ForeColor = System.Drawing.Color.White;
            this.btnChiudi.Location = new System.Drawing.Point(301, 340);
            this.btnChiudi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(145, 57);
            this.btnChiudi.TabIndex = 3;
            this.btnChiudi.Text = "CHIUDI PROGRAMMA";
            this.btnChiudi.UseVisualStyleBackColor = false;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(309, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "FANTASIA PARK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 91);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnApri3);
            this.Controls.Add(this.btnApri2);
            this.Controls.Add(this.btnApri1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gestionale interno del Parco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApri1;
        private System.Windows.Forms.Button btnApri2;
        private System.Windows.Forms.Button btnApri3;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

