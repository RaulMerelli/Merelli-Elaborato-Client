namespace PCX_uploder
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
            this.Sfoglia = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveImg = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.ComboBox();
            this.convert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sfoglia
            // 
            this.Sfoglia.Location = new System.Drawing.Point(346, 10);
            this.Sfoglia.Name = "Sfoglia";
            this.Sfoglia.Size = new System.Drawing.Size(75, 23);
            this.Sfoglia.TabIndex = 0;
            this.Sfoglia.Text = "Sfoglia...";
            this.Sfoglia.UseVisualStyleBackColor = true;
            this.Sfoglia.Click += new System.EventHandler(this.Sfoglia_ClickAsync);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(15, 12);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(325, 20);
            this.FilePath.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "stato: pronto";
            // 
            // SaveImg
            // 
            this.SaveImg.Enabled = false;
            this.SaveImg.Location = new System.Drawing.Point(589, 10);
            this.SaveImg.Name = "SaveImg";
            this.SaveImg.Size = new System.Drawing.Size(110, 23);
            this.SaveImg.TabIndex = 10;
            this.SaveImg.Text = "Salva immagine";
            this.SaveImg.UseVisualStyleBackColor = true;
            this.SaveImg.Click += new System.EventHandler(this.SaveImg_Click);
            // 
            // format
            // 
            this.format.DisplayMember = "jpeg";
            this.format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format.FormattingEnabled = true;
            this.format.Items.AddRange(new object[] {
            ".bmp",
            ".gif",
            ".ico",
            ".jpeg",
            ".png",
            ".tiff",
            ".wmf"});
            this.format.Location = new System.Drawing.Point(427, 11);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(75, 21);
            this.format.TabIndex = 11;
            this.format.Tag = "";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(508, 10);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 12;
            this.convert.Text = "Converti";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.convert);
            this.panel1.Controls.Add(this.FilePath);
            this.panel1.Controls.Add(this.format);
            this.panel1.Controls.Add(this.Sfoglia);
            this.panel1.Controls.Add(this.SaveImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sfoglia;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveImg;
        private System.Windows.Forms.ComboBox format;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Panel panel1;
    }
}

