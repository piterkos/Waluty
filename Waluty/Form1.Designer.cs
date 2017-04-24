namespace Waluty
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Waluty_listBox = new System.Windows.Forms.ListBox();
            this.Flaga_pictureBox = new System.Windows.Forms.PictureBox();
            this.Data_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.Waluta_label = new System.Windows.Forms.Label();
            this.Kurs_label = new System.Windows.Forms.Label();
            this.rtb_historia = new System.Windows.Forms.RichTextBox();
            this.btn_wyczysc = new System.Windows.Forms.Button();
            this.btn_dodajDoHistorii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Flaga_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Waluty_listBox
            // 
            this.Waluty_listBox.FormattingEnabled = true;
            this.Waluty_listBox.Items.AddRange(new object[] {
            "Euro",
            "Dolar",
            "Funt",
            "Frank"});
            this.Waluty_listBox.Location = new System.Drawing.Point(3, 61);
            this.Waluty_listBox.Name = "Waluty_listBox";
            this.Waluty_listBox.Size = new System.Drawing.Size(85, 56);
            this.Waluty_listBox.TabIndex = 0;
            this.Waluty_listBox.SelectedIndexChanged += new System.EventHandler(this.Waluty_listBox_SelectedIndexChanged);
            // 
            // Flaga_pictureBox
            // 
            this.Flaga_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Flaga_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Flaga_pictureBox.Image = global::Waluty.Properties.Resources.EURO;
            this.Flaga_pictureBox.Location = new System.Drawing.Point(3, 4);
            this.Flaga_pictureBox.Name = "Flaga_pictureBox";
            this.Flaga_pictureBox.Size = new System.Drawing.Size(85, 50);
            this.Flaga_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flaga_pictureBox.TabIndex = 1;
            this.Flaga_pictureBox.TabStop = false;
            // 
            // Data_TimePicker
            // 
            this.Data_TimePicker.CustomFormat = "yyyy-MM-dd";
            this.Data_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Data_TimePicker.Location = new System.Drawing.Point(95, 4);
            this.Data_TimePicker.Name = "Data_TimePicker";
            this.Data_TimePicker.Size = new System.Drawing.Size(111, 20);
            this.Data_TimePicker.TabIndex = 2;
            this.Data_TimePicker.Value = new System.DateTime(2017, 3, 29, 0, 0, 0, 0);
            // 
            // Waluta_label
            // 
            this.Waluta_label.AutoSize = true;
            this.Waluta_label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Waluta_label.Location = new System.Drawing.Point(95, 31);
            this.Waluta_label.Name = "Waluta_label";
            this.Waluta_label.Size = new System.Drawing.Size(96, 16);
            this.Waluta_label.TabIndex = 3;
            this.Waluta_label.Text = "Waluta: ";
            // 
            // Kurs_label
            // 
            this.Kurs_label.AutoSize = true;
            this.Kurs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kurs_label.Location = new System.Drawing.Point(98, 61);
            this.Kurs_label.Name = "Kurs_label";
            this.Kurs_label.Size = new System.Drawing.Size(50, 20);
            this.Kurs_label.TabIndex = 4;
            this.Kurs_label.Text = "Kurs:";
            // 
            // rtb_historia
            // 
            this.rtb_historia.Location = new System.Drawing.Point(3, 124);
            this.rtb_historia.Name = "rtb_historia";
            this.rtb_historia.Size = new System.Drawing.Size(375, 173);
            this.rtb_historia.TabIndex = 5;
            this.rtb_historia.Text = "";
            // 
            // btn_wyczysc
            // 
            this.btn_wyczysc.Location = new System.Drawing.Point(3, 303);
            this.btn_wyczysc.Name = "btn_wyczysc";
            this.btn_wyczysc.Size = new System.Drawing.Size(145, 23);
            this.btn_wyczysc.TabIndex = 6;
            this.btn_wyczysc.Text = "Wyczyść historię";
            this.btn_wyczysc.UseVisualStyleBackColor = true;
            this.btn_wyczysc.Click += new System.EventHandler(this.btn_wyczysc_Click);
            // 
            // btn_dodajDoHistorii
            // 
            this.btn_dodajDoHistorii.Location = new System.Drawing.Point(102, 93);
            this.btn_dodajDoHistorii.Name = "btn_dodajDoHistorii";
            this.btn_dodajDoHistorii.Size = new System.Drawing.Size(104, 23);
            this.btn_dodajDoHistorii.TabIndex = 7;
            this.btn_dodajDoHistorii.Text = "Dodaj do historii";
            this.btn_dodajDoHistorii.UseVisualStyleBackColor = true;
            this.btn_dodajDoHistorii.Click += new System.EventHandler(this.btn_dodajDoHistorii_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 337);
            this.Controls.Add(this.btn_dodajDoHistorii);
            this.Controls.Add(this.btn_wyczysc);
            this.Controls.Add(this.rtb_historia);
            this.Controls.Add(this.Kurs_label);
            this.Controls.Add(this.Waluta_label);
            this.Controls.Add(this.Data_TimePicker);
            this.Controls.Add(this.Flaga_pictureBox);
            this.Controls.Add(this.Waluty_listBox);
            this.Name = "Form1";
            this.Text = "Waluty";
            ((System.ComponentModel.ISupportInitialize)(this.Flaga_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Waluty_listBox;
        private System.Windows.Forms.PictureBox Flaga_pictureBox;
        private System.Windows.Forms.DateTimePicker Data_TimePicker;
        private System.Windows.Forms.Label Waluta_label;
        private System.Windows.Forms.Label Kurs_label;
        private System.Windows.Forms.RichTextBox rtb_historia;
        private System.Windows.Forms.Button btn_wyczysc;
        private System.Windows.Forms.Button btn_dodajDoHistorii;
    }
}

