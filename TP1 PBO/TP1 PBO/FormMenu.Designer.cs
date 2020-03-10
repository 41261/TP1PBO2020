namespace TP1_PBO
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.comboBoxHarga = new System.Windows.Forms.ComboBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonBeli = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelBarang = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSemua = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(187, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKatalog.Image = ((System.Drawing.Image)(resources.GetObject("buttonKatalog.Image")));
            this.buttonKatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKatalog.Location = new System.Drawing.Point(30, 129);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(136, 60);
            this.buttonKatalog.TabIndex = 2;
            this.buttonKatalog.Text = "Katalog";
            this.buttonKatalog.UseVisualStyleBackColor = true;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonKatalog_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(30, 378);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(136, 60);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJenis.Location = new System.Drawing.Point(394, 21);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(121, 25);
            this.comboBoxJenis.TabIndex = 5;
            this.comboBoxJenis.Text = "Jenis Barang";
            this.comboBoxJenis.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenis_SelectedIndexChanged);
            // 
            // comboBoxHarga
            // 
            this.comboBoxHarga.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHarga.Location = new System.Drawing.Point(546, 21);
            this.comboBoxHarga.Name = "comboBoxHarga";
            this.comboBoxHarga.Size = new System.Drawing.Size(121, 25);
            this.comboBoxHarga.TabIndex = 6;
            this.comboBoxHarga.Text = "Harga";
            this.comboBoxHarga.SelectedIndexChanged += new System.EventHandler(this.comboBoxHarga_SelectedIndexChanged);
            // 
            // buttonCari
            // 
            this.buttonCari.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.Location = new System.Drawing.Point(699, 21);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 7;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(576, 421);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(180, 20);
            this.labelNama.TabIndex = 8;
            this.labelNama.Text = "1800066 - Muhammad Argi Nafisa";
            this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
            // 
            // buttonBeli
            // 
            this.buttonBeli.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeli.Image = ((System.Drawing.Image)(resources.GetObject("buttonBeli.Image")));
            this.buttonBeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBeli.Location = new System.Drawing.Point(30, 69);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.Size = new System.Drawing.Size(136, 54);
            this.buttonBeli.TabIndex = 1;
            this.buttonBeli.Text = "Menu Beli";
            this.buttonBeli.UseVisualStyleBackColor = true;
            this.buttonBeli.Click += new System.EventHandler(this.buttonBeli_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 59);
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // flowLayoutPanelBarang
            // 
            this.flowLayoutPanelBarang.Location = new System.Drawing.Point(200, 103);
            this.flowLayoutPanelBarang.Name = "flowLayoutPanelBarang";
            this.flowLayoutPanelBarang.Size = new System.Drawing.Size(574, 309);
            this.flowLayoutPanelBarang.TabIndex = 12;
            this.flowLayoutPanelBarang.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelBarang_Paint);
            // 
            // labelSemua
            // 
            this.labelSemua.AutoSize = true;
            this.labelSemua.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemua.Location = new System.Drawing.Point(200, 69);
            this.labelSemua.Name = "labelSemua";
            this.labelSemua.Size = new System.Drawing.Size(86, 20);
            this.labelSemua.TabIndex = 13;
            this.labelSemua.Text = "Semua Barang:";
            this.labelSemua.Click += new System.EventHandler(this.labelSemua_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(699, 23);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Kembali";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(209, 69);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(77, 20);
            this.labelHasil.TabIndex = 15;
            this.labelHasil.Text = "Hasil Barang:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelSemua);
            this.Controls.Add(this.flowLayoutPanelBarang);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.comboBoxHarga);
            this.Controls.Add(this.comboBoxJenis);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonKatalog);
            this.Controls.Add(this.buttonBeli);
            this.Controls.Add(this.splitter1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonBeli;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.ComboBox comboBoxHarga;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBarang;
        private System.Windows.Forms.Label labelSemua;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHasil;
    }
}