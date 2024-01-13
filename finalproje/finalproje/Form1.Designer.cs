namespace finalproje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEtutOlustur = new System.Windows.Forms.Button();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dERSADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğretmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğrenciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarıhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.etutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet1 = new finalproje.finalDataSet1();
            this.finalDataSet = new finalproje.finalDataSet();
            this.etutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etutTableAdapter = new finalproje.finalDataSetTableAdapters.EtutTableAdapter();
            this.etutTableAdapter1 = new finalproje.finalDataSet1TableAdapters.EtutTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtDers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.BtnOgretmenEkle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSınıf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbDersAdı = new System.Windows.Forms.ComboBox();
            this.TxtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.BtnEtutOlustur);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEtutOlustur
            // 
            this.BtnEtutOlustur.Location = new System.Drawing.Point(149, 236);
            this.BtnEtutOlustur.Name = "BtnEtutOlustur";
            this.BtnEtutOlustur.Size = new System.Drawing.Size(151, 46);
            this.BtnEtutOlustur.TabIndex = 8;
            this.BtnEtutOlustur.Text = "OLUŞTUR";
            this.BtnEtutOlustur.UseVisualStyleBackColor = true;
            this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(138, 182);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(180, 22);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(138, 141);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(180, 22);
            this.MskTarih.TabIndex = 6;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(138, 94);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(180, 24);
            this.CmbOgretmen.TabIndex = 5;
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(138, 46);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(180, 24);
            this.CmbDers.TabIndex = 4;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "öğretmen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ders";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(441, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(164, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Etut ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.Location = new System.Drawing.Point(114, 130);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(155, 45);
            this.BtnEtutVer.TabIndex = 4;
            this.BtnEtutVer.Text = "ETÜT VER";
            this.BtnEtutVer.UseVisualStyleBackColor = true;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(888, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.dERSADDataGridViewTextBoxColumn,
            this.öğretmenDataGridViewTextBoxColumn,
            this.öğrenciDataGridViewTextBoxColumn,
            this.tarıhDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.etutBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dERSADDataGridViewTextBoxColumn
            // 
            this.dERSADDataGridViewTextBoxColumn.DataPropertyName = "DERSAD";
            this.dERSADDataGridViewTextBoxColumn.HeaderText = "DERSAD";
            this.dERSADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dERSADDataGridViewTextBoxColumn.Name = "dERSADDataGridViewTextBoxColumn";
            this.dERSADDataGridViewTextBoxColumn.Width = 125;
            // 
            // öğretmenDataGridViewTextBoxColumn
            // 
            this.öğretmenDataGridViewTextBoxColumn.DataPropertyName = "Öğretmen";
            this.öğretmenDataGridViewTextBoxColumn.HeaderText = "Öğretmen";
            this.öğretmenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.öğretmenDataGridViewTextBoxColumn.Name = "öğretmenDataGridViewTextBoxColumn";
            this.öğretmenDataGridViewTextBoxColumn.ReadOnly = true;
            this.öğretmenDataGridViewTextBoxColumn.Width = 125;
            // 
            // öğrenciDataGridViewTextBoxColumn
            // 
            this.öğrenciDataGridViewTextBoxColumn.DataPropertyName = "Öğrenci";
            this.öğrenciDataGridViewTextBoxColumn.HeaderText = "Öğrenci";
            this.öğrenciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.öğrenciDataGridViewTextBoxColumn.Name = "öğrenciDataGridViewTextBoxColumn";
            this.öğrenciDataGridViewTextBoxColumn.ReadOnly = true;
            this.öğrenciDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarıhDataGridViewTextBoxColumn
            // 
            this.tarıhDataGridViewTextBoxColumn.DataPropertyName = "tarıh";
            this.tarıhDataGridViewTextBoxColumn.HeaderText = "tarıh";
            this.tarıhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarıhDataGridViewTextBoxColumn.Name = "tarıhDataGridViewTextBoxColumn";
            this.tarıhDataGridViewTextBoxColumn.Width = 125;
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "saat";
            this.saatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            this.saatDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            this.durumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // etutBindingSource1
            // 
            this.etutBindingSource1.DataMember = "Etut";
            this.etutBindingSource1.DataSource = this.finalDataSet1;
            // 
            // finalDataSet1
            // 
            this.finalDataSet1.DataSetName = "finalDataSet1";
            this.finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "finalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etutBindingSource
            // 
            this.etutBindingSource.DataMember = "Etut";
            this.etutBindingSource.DataSource = this.finalDataSet;
            // 
            // etutTableAdapter
            // 
            this.etutTableAdapter.ClearBeforeFill = true;
            // 
            // etutTableAdapter1
            // 
            this.etutTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Controls.Add(this.TxtDers);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.BtnDersEkle);
            this.groupBox4.Location = new System.Drawing.Point(441, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // TxtDers
            // 
            this.TxtDers.Location = new System.Drawing.Point(132, 48);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(132, 22);
            this.TxtDers.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Dersin Adı";
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.Location = new System.Drawing.Point(132, 108);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(146, 32);
            this.BtnDersEkle.TabIndex = 2;
            this.BtnDersEkle.Text = "Ders Ekle";
            this.BtnDersEkle.UseVisualStyleBackColor = true;
            this.BtnDersEkle.Click += new System.EventHandler(this.BtnDersEkle_Click);
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(51, 220);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(146, 33);
            this.BtnOgrenciEkle.TabIndex = 0;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = true;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // BtnOgretmenEkle
            // 
            this.BtnOgretmenEkle.Location = new System.Drawing.Point(88, 173);
            this.BtnOgretmenEkle.Name = "BtnOgretmenEkle";
            this.BtnOgretmenEkle.Size = new System.Drawing.Size(146, 30);
            this.BtnOgretmenEkle.TabIndex = 1;
            this.BtnOgretmenEkle.Text = "Öğretmen Ekle";
            this.BtnOgretmenEkle.UseVisualStyleBackColor = true;
            this.BtnOgretmenEkle.Click += new System.EventHandler(this.BtnOgretmen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Controls.Add(this.MskTelefon);
            this.groupBox5.Controls.Add(this.TxtMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TxtSoyad);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TxtSınıf);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(903, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 348);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(76, 147);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(132, 22);
            this.MskTelefon.TabIndex = 16;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(76, 175);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(132, 22);
            this.TxtMail.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "MAİL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "TELEFON";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(76, 91);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(132, 22);
            this.TxtSoyad.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "SOYAD";
            // 
            // TxtSınıf
            // 
            this.TxtSınıf.Location = new System.Drawing.Point(76, 119);
            this.TxtSınıf.Name = "TxtSınıf";
            this.TxtSınıf.Size = new System.Drawing.Size(132, 22);
            this.TxtSınıf.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "SINIF";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(76, 61);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(132, 22);
            this.TxtAd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "AD";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(903, 358);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 182);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "FOTOĞRAF YÜKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Lime;
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.CmbDersAdı);
            this.groupBox7.Controls.Add(this.TxtOgretmenSoyad);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.TxtOgretmenAd);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.BtnOgretmenEkle);
            this.groupBox7.Location = new System.Drawing.Point(1159, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 532);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "DERS";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CmbDersAdı
            // 
            this.CmbDersAdı.FormattingEnabled = true;
            this.CmbDersAdı.Location = new System.Drawing.Point(88, 103);
            this.CmbDersAdı.Name = "CmbDersAdı";
            this.CmbDersAdı.Size = new System.Drawing.Size(132, 24);
            this.CmbDersAdı.TabIndex = 17;
            // 
            // TxtOgretmenSoyad
            // 
            this.TxtOgretmenSoyad.Location = new System.Drawing.Point(88, 73);
            this.TxtOgretmenSoyad.Name = "TxtOgretmenSoyad";
            this.TxtOgretmenSoyad.Size = new System.Drawing.Size(132, 22);
            this.TxtOgretmenSoyad.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "SOYAD";
            // 
            // TxtOgretmenAd
            // 
            this.TxtOgretmenAd.Location = new System.Drawing.Point(88, 43);
            this.TxtOgretmenAd.Name = "TxtOgretmenAd";
            this.TxtOgretmenAd.Size = new System.Drawing.Size(132, 22);
            this.TxtOgretmenAd.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "AD";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1430, 573);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etutBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Button BtnEtutOlustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private finalDataSet finalDataSet;
        private System.Windows.Forms.BindingSource etutBindingSource;
        private finalDataSetTableAdapters.EtutTableAdapter etutTableAdapter;
        private finalDataSet1 finalDataSet1;
        private System.Windows.Forms.BindingSource etutBindingSource1;
        private finalDataSet1TableAdapters.EtutTableAdapter etutTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dERSADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğretmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğrenciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarıhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnOgretmenEkle;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSınıf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbDersAdı;
        private System.Windows.Forms.TextBox TxtOgretmenSoyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOgretmenAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

