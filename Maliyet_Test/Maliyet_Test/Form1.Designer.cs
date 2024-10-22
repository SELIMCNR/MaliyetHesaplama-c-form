namespace Maliyet_Test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Stokgetir = new System.Windows.Forms.Button();
            this.Btn_MalzemeStokEkle = new System.Windows.Forms.Button();
            this.Txt_StokNotlar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_StokFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Stok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_StokAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_StokId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ve = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ürüngüncelle = new System.Windows.Forms.Button();
            this.Btn_ürünekle = new System.Windows.Forms.Button();
            this.Txt_ürünmalzemesatışfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ürünmalzemefiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_ÜrünStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_ÜrünAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Ürünİd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.cmbÜrün = new System.Windows.Forms.ComboBox();
            this.Btn_ürünoluşturekle = new System.Windows.Forms.Button();
            this.Txt_ürünmalzememaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_ürünmalzememiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_kasa = new System.Windows.Forms.Button();
            this.btnmalzeme = new System.Windows.Forms.Button();
            this.btnurun = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lst_listeleürün = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnKasaGiris = new System.Windows.Forms.Button();
            this.Btn_Kasaçıkış = new System.Windows.Forms.Button();
            this.LBLKASA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Stokgetir);
            this.groupBox1.Controls.Add(this.Btn_MalzemeStokEkle);
            this.groupBox1.Controls.Add(this.Txt_StokNotlar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_StokFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Stok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_StokAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_StokId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Girişi";
            // 
            // btn_Stokgetir
            // 
            this.btn_Stokgetir.Location = new System.Drawing.Point(188, 53);
            this.btn_Stokgetir.Name = "btn_Stokgetir";
            this.btn_Stokgetir.Size = new System.Drawing.Size(62, 27);
            this.btn_Stokgetir.TabIndex = 2;
            this.btn_Stokgetir.Text = "Getir";
            this.btn_Stokgetir.UseVisualStyleBackColor = true;
            // 
            // Btn_MalzemeStokEkle
            // 
            this.Btn_MalzemeStokEkle.Location = new System.Drawing.Point(74, 161);
            this.Btn_MalzemeStokEkle.Name = "Btn_MalzemeStokEkle";
            this.Btn_MalzemeStokEkle.Size = new System.Drawing.Size(109, 40);
            this.Btn_MalzemeStokEkle.TabIndex = 2;
            this.Btn_MalzemeStokEkle.Text = "Malzeme Ekle";
            this.Btn_MalzemeStokEkle.UseVisualStyleBackColor = true;
            this.Btn_MalzemeStokEkle.Click += new System.EventHandler(this.Btn_MalzemeStokEkle_Click);
            // 
            // Txt_StokNotlar
            // 
            this.Txt_StokNotlar.Location = new System.Drawing.Point(74, 135);
            this.Txt_StokNotlar.Name = "Txt_StokNotlar";
            this.Txt_StokNotlar.Size = new System.Drawing.Size(109, 20);
            this.Txt_StokNotlar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NOTLAR:";
            // 
            // Txt_StokFiyat
            // 
            this.Txt_StokFiyat.Location = new System.Drawing.Point(74, 109);
            this.Txt_StokFiyat.Name = "Txt_StokFiyat";
            this.Txt_StokFiyat.Size = new System.Drawing.Size(109, 20);
            this.Txt_StokFiyat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "FİYAT:";
            // 
            // Txt_Stok
            // 
            this.Txt_Stok.Location = new System.Drawing.Point(74, 83);
            this.Txt_Stok.Name = "Txt_Stok";
            this.Txt_Stok.Size = new System.Drawing.Size(109, 20);
            this.Txt_Stok.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "STOK:";
            // 
            // Txt_StokAd
            // 
            this.Txt_StokAd.Location = new System.Drawing.Point(74, 57);
            this.Txt_StokAd.Name = "Txt_StokAd";
            this.Txt_StokAd.Size = new System.Drawing.Size(109, 20);
            this.Txt_StokAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD:";
            // 
            // Txt_StokId
            // 
            this.Txt_StokId.Location = new System.Drawing.Point(74, 31);
            this.Txt_StokId.Name = "Txt_StokId";
            this.Txt_StokId.Size = new System.Drawing.Size(109, 20);
            this.Txt_StokId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // ve
            // 
            this.ve.Controls.Add(this.dataGridView1);
            this.ve.Location = new System.Drawing.Point(12, 362);
            this.ve.Name = "ve";
            this.ve.Size = new System.Drawing.Size(712, 131);
            this.ve.TabIndex = 1;
            this.ve.TabStop = false;
            this.ve.Text = "Veri Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 112);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKasaGiris);
            this.groupBox3.Controls.Add(this.btn_ürüngüncelle);
            this.groupBox3.Controls.Add(this.Btn_ürünekle);
            this.groupBox3.Controls.Add(this.Txt_ürünmalzemesatışfiyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Txt_ürünmalzemefiyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Txt_ÜrünStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Txt_ÜrünAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Txt_Ürünİd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(275, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 225);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Girişi";
            // 
            // btn_ürüngüncelle
            // 
            this.btn_ürüngüncelle.Location = new System.Drawing.Point(6, 185);
            this.btn_ürüngüncelle.Name = "btn_ürüngüncelle";
            this.btn_ürüngüncelle.Size = new System.Drawing.Size(107, 27);
            this.btn_ürüngüncelle.TabIndex = 2;
            this.btn_ürüngüncelle.Text = "Güncelle";
            this.btn_ürüngüncelle.UseVisualStyleBackColor = true;
            this.btn_ürüngüncelle.Click += new System.EventHandler(this.btn_ürüngüncelle_Click);
            // 
            // Btn_ürünekle
            // 
            this.Btn_ürünekle.Location = new System.Drawing.Point(74, 149);
            this.Btn_ürünekle.Name = "Btn_ürünekle";
            this.Btn_ürünekle.Size = new System.Drawing.Size(132, 30);
            this.Btn_ürünekle.TabIndex = 2;
            this.Btn_ürünekle.Text = "Ürün Ekle";
            this.Btn_ürünekle.UseVisualStyleBackColor = true;
            this.Btn_ürünekle.Click += new System.EventHandler(this.Btn_ürünekle_Click);
            // 
            // Txt_ürünmalzemesatışfiyat
            // 
            this.Txt_ürünmalzemesatışfiyat.Location = new System.Drawing.Point(74, 123);
            this.Txt_ürünmalzemesatışfiyat.Name = "Txt_ürünmalzemesatışfiyat";
            this.Txt_ürünmalzemesatışfiyat.Size = new System.Drawing.Size(132, 20);
            this.Txt_ürünmalzemesatışfiyat.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "S.FİYAT:";
            // 
            // Txt_ürünmalzemefiyat
            // 
            this.Txt_ürünmalzemefiyat.Location = new System.Drawing.Point(74, 97);
            this.Txt_ürünmalzemefiyat.Name = "Txt_ürünmalzemefiyat";
            this.Txt_ürünmalzemefiyat.Size = new System.Drawing.Size(132, 20);
            this.Txt_ürünmalzemefiyat.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "M.FİYAT:";
            // 
            // Txt_ÜrünStok
            // 
            this.Txt_ÜrünStok.Location = new System.Drawing.Point(74, 71);
            this.Txt_ÜrünStok.Name = "Txt_ÜrünStok";
            this.Txt_ÜrünStok.Size = new System.Drawing.Size(132, 20);
            this.Txt_ÜrünStok.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "STOK:";
            // 
            // Txt_ÜrünAd
            // 
            this.Txt_ÜrünAd.Location = new System.Drawing.Point(74, 45);
            this.Txt_ÜrünAd.Name = "Txt_ÜrünAd";
            this.Txt_ÜrünAd.Size = new System.Drawing.Size(132, 20);
            this.Txt_ÜrünAd.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "AD:";
            // 
            // Txt_Ürünİd
            // 
            this.Txt_Ürünİd.Location = new System.Drawing.Point(74, 19);
            this.Txt_Ürünİd.Name = "Txt_Ürünİd";
            this.Txt_Ürünİd.Size = new System.Drawing.Size(132, 20);
            this.Txt_Ürünİd.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbMalzeme);
            this.groupBox4.Controls.Add(this.cmbÜrün);
            this.groupBox4.Controls.Add(this.Btn_ürünoluşturekle);
            this.groupBox4.Controls.Add(this.Txt_ürünmalzememaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Txt_ürünmalzememiktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(503, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 218);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Oluştur";
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(74, 44);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(132, 21);
            this.cmbMalzeme.TabIndex = 3;
            // 
            // cmbÜrün
            // 
            this.cmbÜrün.FormattingEnabled = true;
            this.cmbÜrün.Location = new System.Drawing.Point(74, 17);
            this.cmbÜrün.Name = "cmbÜrün";
            this.cmbÜrün.Size = new System.Drawing.Size(132, 21);
            this.cmbÜrün.TabIndex = 3;
            // 
            // Btn_ürünoluşturekle
            // 
            this.Btn_ürünoluşturekle.Location = new System.Drawing.Point(74, 129);
            this.Btn_ürünoluşturekle.Name = "Btn_ürünoluşturekle";
            this.Btn_ürünoluşturekle.Size = new System.Drawing.Size(132, 30);
            this.Btn_ürünoluşturekle.TabIndex = 2;
            this.Btn_ürünoluşturekle.Text = "Ekle";
            this.Btn_ürünoluşturekle.UseVisualStyleBackColor = true;
            this.Btn_ürünoluşturekle.Click += new System.EventHandler(this.Btn_ürünoluşturekle_Click);
            // 
            // Txt_ürünmalzememaliyet
            // 
            this.Txt_ürünmalzememaliyet.Location = new System.Drawing.Point(74, 97);
            this.Txt_ürünmalzememaliyet.Name = "Txt_ürünmalzememaliyet";
            this.Txt_ürünmalzememaliyet.Size = new System.Drawing.Size(132, 20);
            this.Txt_ürünmalzememaliyet.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "MALİYET:";
            // 
            // Txt_ürünmalzememiktar
            // 
            this.Txt_ürünmalzememiktar.Location = new System.Drawing.Point(74, 71);
            this.Txt_ürünmalzememiktar.Name = "Txt_ürünmalzememiktar";
            this.Txt_ürünmalzememiktar.Size = new System.Drawing.Size(132, 20);
            this.Txt_ürünmalzememiktar.TabIndex = 1;
            this.Txt_ürünmalzememiktar.TextChanged += new System.EventHandler(this.Txt_ürünmalzememiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_cikis);
            this.groupBox5.Controls.Add(this.btn_kasa);
            this.groupBox5.Controls.Add(this.btnmalzeme);
            this.groupBox5.Controls.Add(this.btnurun);
            this.groupBox5.Location = new System.Drawing.Point(732, 356);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(238, 137);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İŞLEMLER";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(16, 106);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(203, 23);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_kasa
            // 
            this.btn_kasa.Location = new System.Drawing.Point(16, 77);
            this.btn_kasa.Name = "btn_kasa";
            this.btn_kasa.Size = new System.Drawing.Size(203, 23);
            this.btn_kasa.TabIndex = 0;
            this.btn_kasa.Text = "KASA";
            this.btn_kasa.UseVisualStyleBackColor = true;
            this.btn_kasa.Click += new System.EventHandler(this.btn_kasa_Click);
            // 
            // btnmalzeme
            // 
            this.btnmalzeme.Location = new System.Drawing.Point(16, 48);
            this.btnmalzeme.Name = "btnmalzeme";
            this.btnmalzeme.Size = new System.Drawing.Size(203, 23);
            this.btnmalzeme.TabIndex = 0;
            this.btnmalzeme.Text = "MALZEME LİSTESİ";
            this.btnmalzeme.UseVisualStyleBackColor = true;
            this.btnmalzeme.Click += new System.EventHandler(this.btnmalzeme_Click);
            // 
            // btnurun
            // 
            this.btnurun.Location = new System.Drawing.Point(16, 19);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(203, 23);
            this.btnurun.TabIndex = 0;
            this.btnurun.Text = "ÜRÜN LİSTESİ";
            this.btnurun.UseVisualStyleBackColor = true;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lst_listeleürün);
            this.groupBox6.Location = new System.Drawing.Point(731, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 219);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ÜRÜN OLUŞTUR";
            // 
            // lst_listeleürün
            // 
            this.lst_listeleürün.FormattingEnabled = true;
            this.lst_listeleürün.Location = new System.Drawing.Point(6, 13);
            this.lst_listeleürün.Name = "lst_listeleürün";
            this.lst_listeleürün.Size = new System.Drawing.Size(226, 199);
            this.lst_listeleürün.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(15, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 119);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kasa listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(479, 100);
            this.dataGridView2.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "KASA HARCAMATOPLAM";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.Txt_ürünmalzememiktar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "KASA AÇIKLAMA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.LBLKASA);
            this.groupBox7.Controls.Add(this.Btn_Kasaçıkış);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(503, 244);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(294, 116);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "KASA";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // btnKasaGiris
            // 
            this.btnKasaGiris.Location = new System.Drawing.Point(115, 185);
            this.btnKasaGiris.Name = "btnKasaGiris";
            this.btnKasaGiris.Size = new System.Drawing.Size(101, 27);
            this.btnKasaGiris.TabIndex = 2;
            this.btnKasaGiris.Text = "KASA GİRİŞ";
            this.btnKasaGiris.UseVisualStyleBackColor = true;
            this.btnKasaGiris.Click += new System.EventHandler(this.btnKasaGiris_Click_1);
            // 
            // Btn_Kasaçıkış
            // 
            this.Btn_Kasaçıkış.Location = new System.Drawing.Point(142, 68);
            this.Btn_Kasaçıkış.Name = "Btn_Kasaçıkış";
            this.Btn_Kasaçıkış.Size = new System.Drawing.Size(132, 28);
            this.Btn_Kasaçıkış.TabIndex = 2;
            this.Btn_Kasaçıkış.Text = "KASA ÇIKIŞ";
            this.Btn_Kasaçıkış.UseVisualStyleBackColor = true;
            this.Btn_Kasaçıkış.Click += new System.EventHandler(this.Btn_Kasaçıkış_Click);
            // 
            // LBLKASA
            // 
            this.LBLKASA.AutoSize = true;
            this.LBLKASA.Location = new System.Drawing.Point(6, 83);
            this.LBLKASA.Name = "LBLKASA";
            this.LBLKASA.Size = new System.Drawing.Size(82, 13);
            this.LBLKASA.TabIndex = 3;
            this.LBLKASA.Text = "KASA BAKİYE :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(982, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ve);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_StokId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_StokNotlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_StokFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Stok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_StokAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_MalzemeStokEkle;
        private System.Windows.Forms.Button btn_Stokgetir;
        private System.Windows.Forms.GroupBox ve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ürüngüncelle;
        private System.Windows.Forms.Button Btn_ürünekle;
        private System.Windows.Forms.TextBox Txt_ürünmalzemesatışfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_ürünmalzemefiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_ÜrünStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_ÜrünAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Ürünİd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_ürünoluşturekle;
        private System.Windows.Forms.TextBox Txt_ürünmalzememaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_ürünmalzememiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_kasa;
        private System.Windows.Forms.Button btnmalzeme;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lst_listeleürün;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.ComboBox cmbÜrün;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnKasaGiris;
        private System.Windows.Forms.Button Btn_Kasaçıkış;
        private System.Windows.Forms.Label LBLKASA;
    }
}

