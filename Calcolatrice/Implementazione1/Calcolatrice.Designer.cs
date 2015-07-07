namespace Calcolatrice.Implementazione1
{
    partial class Calcolatrice
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
            this.textNumero1 = new System.Windows.Forms.NumericUpDown();
            this.textNumero2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFattoriale = new System.Windows.Forms.Button();
            this.buttonRadiceQuadrata = new System.Windows.Forms.Button();
            this.buttonPotenza = new System.Windows.Forms.Button();
            this.buttonDivisione = new System.Windows.Forms.Button();
            this.buttonMoltiplicazione = new System.Windows.Forms.Button();
            this.buttonAddizione = new System.Windows.Forms.Button();
            this.buttonSottrazione = new System.Windows.Forms.Button();
            this.labelTotale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textNumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumero2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNumero1
            // 
            this.textNumero1.Location = new System.Drawing.Point(75, 31);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(82, 20);
            this.textNumero1.TabIndex = 0;
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(75, 57);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(82, 20);
            this.textNumero2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFattoriale);
            this.groupBox1.Controls.Add(this.buttonRadiceQuadrata);
            this.groupBox1.Controls.Add(this.buttonPotenza);
            this.groupBox1.Controls.Add(this.buttonDivisione);
            this.groupBox1.Controls.Add(this.buttonMoltiplicazione);
            this.groupBox1.Controls.Add(this.buttonAddizione);
            this.groupBox1.Controls.Add(this.buttonSottrazione);
            this.groupBox1.Location = new System.Drawing.Point(163, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operazioni";
            // 
            // buttonFattoriale
            // 
            this.buttonFattoriale.Location = new System.Drawing.Point(106, 69);
            this.buttonFattoriale.Name = "buttonFattoriale";
            this.buttonFattoriale.Size = new System.Drawing.Size(50, 44);
            this.buttonFattoriale.TabIndex = 11;
            this.buttonFattoriale.Text = "!";
            this.buttonFattoriale.UseVisualStyleBackColor = true;
            this.buttonFattoriale.Click += new System.EventHandler(this.buttonFattoriale_Click);
            // 
            // buttonRadiceQuadrata
            // 
            this.buttonRadiceQuadrata.Location = new System.Drawing.Point(56, 69);
            this.buttonRadiceQuadrata.Name = "buttonRadiceQuadrata";
            this.buttonRadiceQuadrata.Size = new System.Drawing.Size(50, 44);
            this.buttonRadiceQuadrata.TabIndex = 10;
            this.buttonRadiceQuadrata.Text = "SQRT";
            this.buttonRadiceQuadrata.UseVisualStyleBackColor = true;
            this.buttonRadiceQuadrata.Click += new System.EventHandler(this.buttonRadiceQuadrata_Click);
            // 
            // buttonPotenza
            // 
            this.buttonPotenza.Location = new System.Drawing.Point(6, 69);
            this.buttonPotenza.Name = "buttonPotenza";
            this.buttonPotenza.Size = new System.Drawing.Size(50, 44);
            this.buttonPotenza.TabIndex = 9;
            this.buttonPotenza.Text = "POW";
            this.buttonPotenza.UseVisualStyleBackColor = true;
            this.buttonPotenza.Click += new System.EventHandler(this.buttonPotenza_Click);
            // 
            // buttonDivisione
            // 
            this.buttonDivisione.Location = new System.Drawing.Point(156, 19);
            this.buttonDivisione.Name = "buttonDivisione";
            this.buttonDivisione.Size = new System.Drawing.Size(50, 44);
            this.buttonDivisione.TabIndex = 6;
            this.buttonDivisione.Text = "/";
            this.buttonDivisione.UseVisualStyleBackColor = true;
            this.buttonDivisione.Click += new System.EventHandler(this.buttonDivisione_Click);
            // 
            // buttonMoltiplicazione
            // 
            this.buttonMoltiplicazione.Location = new System.Drawing.Point(106, 19);
            this.buttonMoltiplicazione.Name = "buttonMoltiplicazione";
            this.buttonMoltiplicazione.Size = new System.Drawing.Size(50, 44);
            this.buttonMoltiplicazione.TabIndex = 8;
            this.buttonMoltiplicazione.Text = "*";
            this.buttonMoltiplicazione.UseVisualStyleBackColor = true;
            this.buttonMoltiplicazione.Click += new System.EventHandler(this.buttonMoltiplicazione_Click);
            // 
            // buttonAddizione
            // 
            this.buttonAddizione.Location = new System.Drawing.Point(6, 19);
            this.buttonAddizione.Name = "buttonAddizione";
            this.buttonAddizione.Size = new System.Drawing.Size(50, 44);
            this.buttonAddizione.TabIndex = 5;
            this.buttonAddizione.Text = "+";
            this.buttonAddizione.UseVisualStyleBackColor = true;
            this.buttonAddizione.Click += new System.EventHandler(this.buttonAddizione_Click);
            // 
            // buttonSottrazione
            // 
            this.buttonSottrazione.Location = new System.Drawing.Point(56, 19);
            this.buttonSottrazione.Name = "buttonSottrazione";
            this.buttonSottrazione.Size = new System.Drawing.Size(50, 44);
            this.buttonSottrazione.TabIndex = 7;
            this.buttonSottrazione.Text = "-";
            this.buttonSottrazione.UseVisualStyleBackColor = true;
            this.buttonSottrazione.Click += new System.EventHandler(this.buttonSottrazione_Click);
            // 
            // labelTotale
            // 
            this.labelTotale.AutoSize = true;
            this.labelTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotale.Location = new System.Drawing.Point(16, 99);
            this.labelTotale.Name = "labelTotale";
            this.labelTotale.Size = new System.Drawing.Size(71, 17);
            this.labelTotale.TabIndex = 5;
            this.labelTotale.Text = "TOTALE: ";
            // 
            // Calcolatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 156);
            this.Controls.Add(this.labelTotale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Name = "Calcolatrice";
            this.Text = "Calcolatrice";
            ((System.ComponentModel.ISupportInitialize)(this.textNumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumero2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown textNumero1;
        private System.Windows.Forms.NumericUpDown textNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDivisione;
        private System.Windows.Forms.Button buttonMoltiplicazione;
        private System.Windows.Forms.Button buttonAddizione;
        private System.Windows.Forms.Button buttonSottrazione;
        private System.Windows.Forms.Label labelTotale;
        private System.Windows.Forms.Button buttonRadiceQuadrata;
        private System.Windows.Forms.Button buttonPotenza;
        private System.Windows.Forms.Button buttonFattoriale;
    }
}