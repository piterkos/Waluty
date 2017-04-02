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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Data_TimePicker);
            this.Controls.Add(this.Flaga_pictureBox);
            this.Controls.Add(this.Waluty_listBox);
            this.Name = "Form1";
            this.Text = "Waluty";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Flaga_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Waluty_listBox;
        private System.Windows.Forms.PictureBox Flaga_pictureBox;
        private System.Windows.Forms.DateTimePicker Data_TimePicker;
    }
}

