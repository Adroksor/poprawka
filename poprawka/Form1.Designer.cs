namespace poprawka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaJednostek = new System.Windows.Forms.ComboBox();
            this.DodajRekord = new System.Windows.Forms.Button();
            this.Nazwa = new System.Windows.Forms.TextBox();
            this.Ilosc = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaJednostek
            // 
            this.ListaJednostek.FormattingEnabled = true;
            this.ListaJednostek.Location = new System.Drawing.Point(73, 73);
            this.ListaJednostek.Name = "ListaJednostek";
            this.ListaJednostek.Size = new System.Drawing.Size(121, 21);
            this.ListaJednostek.TabIndex = 0;
            // 
            // DodajRekord
            // 
            this.DodajRekord.Location = new System.Drawing.Point(522, 73);
            this.DodajRekord.Name = "DodajRekord";
            this.DodajRekord.Size = new System.Drawing.Size(75, 23);
            this.DodajRekord.TabIndex = 1;
            this.DodajRekord.Text = "Zapisz";
            this.DodajRekord.UseVisualStyleBackColor = true;
            this.DodajRekord.Click += new System.EventHandler(this.DodajRekord_Click);
            // 
            // Nazwa
            // 
            this.Nazwa.Location = new System.Drawing.Point(218, 73);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(100, 20);
            this.Nazwa.TabIndex = 2;
            // 
            // Ilosc
            // 
            this.Ilosc.Location = new System.Drawing.Point(369, 73);
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.Size = new System.Drawing.Size(100, 20);
            this.Ilosc.TabIndex = 3;
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 288);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(376, 150);
            this.GridView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Ilosc);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.DodajRekord);
            this.Controls.Add(this.ListaJednostek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaJednostek;
        private System.Windows.Forms.Button DodajRekord;
        private System.Windows.Forms.TextBox Nazwa;
        private System.Windows.Forms.TextBox Ilosc;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button button1;
    }
}

