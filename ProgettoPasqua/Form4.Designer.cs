namespace ProgettoPasqua
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersone = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnUscire = new System.Windows.Forms.Button();
            this.cmbAttrazione = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONE ATTRAZIONI";
            // 
            // lblPersone
            // 
            this.lblPersone.AutoSize = true;
            this.lblPersone.Location = new System.Drawing.Point(72, 83);
            this.lblPersone.Name = "lblPersone";
            this.lblPersone.Size = new System.Drawing.Size(0, 13);
            this.lblPersone.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(75, 171);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(112, 85);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "ACCESSO NUOVE PERSONE";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnUscire
            // 
            this.btnUscire.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUscire.ForeColor = System.Drawing.Color.White;
            this.btnUscire.Location = new System.Drawing.Point(464, 171);
            this.btnUscire.Name = "btnUscire";
            this.btnUscire.Size = new System.Drawing.Size(112, 85);
            this.btnUscire.TabIndex = 3;
            this.btnUscire.Text = "AVVIO ATTRAZIONE";
            this.btnUscire.UseVisualStyleBackColor = false;
            this.btnUscire.Click += new System.EventHandler(this.btnUscire_Click);
            // 
            // cmbAttrazione
            // 
            this.cmbAttrazione.FormattingEnabled = true;
            this.cmbAttrazione.Location = new System.Drawing.Point(406, 98);
            this.cmbAttrazione.Name = "cmbAttrazione";
            this.cmbAttrazione.Size = new System.Drawing.Size(121, 21);
            this.cmbAttrazione.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(249, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(247, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME VISITATORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(404, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TIPO ATTRAZIONE";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbAttrazione);
            this.Controls.Add(this.btnUscire);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lblPersone);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersone;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnUscire;
        private System.Windows.Forms.ComboBox cmbAttrazione;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}