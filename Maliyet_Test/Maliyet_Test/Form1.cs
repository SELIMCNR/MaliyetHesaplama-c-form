using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Maliyet_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Data Source=DESKTOP-BC3LOP2\SQLEXPRESS01;Initial Catalog=TestMaliyet;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS01;Initial Catalog=TestMaliyet;Integrated Security=True");




   

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            ürünler();
            malzemeler();
            KasaListe();
            KasaBakiyeGoster();
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            UrunListe();
        }

        private void btnmalzeme_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btn_kasa_Click(object sender, EventArgs e)
        {
            KasaListe();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txt_Ürünİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txt_ÜrünAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(MALIYET) from tbl_fırın where URUNID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", Txt_Ürünİd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txt_ürünmalzemefiyat.Text = dr[0].ToString();
            }
            baglanti.Close();
        }


        private void btn_ürüngüncelle_Click(object sender, EventArgs e)
        {
            // Ürün ID, yeni ürün adı, maliyet fiyatı, satış fiyatı ve stok miktarının boş olmadığını kontrol edin
            if (string.IsNullOrWhiteSpace(Txt_Ürünİd.Text.Trim()) || string.IsNullOrWhiteSpace(Txt_ÜrünAd.Text.Trim()) ||
                string.IsNullOrWhiteSpace(Txt_ürünmalzemefiyat.Text.Trim()) || string.IsNullOrWhiteSpace(Txt_ürünmalzemesatışfiyat.Text.Trim()) ||
                string.IsNullOrWhiteSpace(Txt_ÜrünStok.Text.Trim()))
            {
                MessageBox.Show("Lütfen gerekli tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // SQL UPDATE komutunu hazırla
                SqlCommand komut = new SqlCommand("UPDATE TBLURUNLER SET AD = @p1, MFİYAT = @p3, SFİYAT = @p4, STOK = @p5 WHERE URUNID = @p2", baglanti);
                komut.Parameters.AddWithValue("@p1", Txt_ÜrünAd.Text.Trim());  // Yeni ürün adı
                komut.Parameters.AddWithValue("@p2", Txt_Ürünİd.Text.Trim());  // Ürün ID
                komut.Parameters.AddWithValue("@p3", decimal.Parse(Txt_ürünmalzemefiyat.Text.Trim()));  // Maliyet fiyatı
                komut.Parameters.AddWithValue("@p4", decimal.Parse(Txt_ürünmalzemesatışfiyat.Text.Trim()));    // Satış fiyatı
                komut.Parameters.AddWithValue("@p5", int.Parse(Txt_ÜrünStok.Text.Trim()));  // Stok miktarı



                // Komutu çalıştır
                int sonuc = komut.ExecuteNonQuery();  // Güncellenen satır sayısını döner

                // Eğer en az bir satır güncellenmişse başarılı bir güncelleme olmuştur
                if (sonuc > 0)
                {
                    MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız oldu. Lütfen geçerli bir ürün seçtiğinizden emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }

            // Güncelleme sonrası ürün listesini yenile
            UrunListe();
        }

        // Ürünleri listeleme fonksiyonu
        void ürünler()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da3 = new SqlDataAdapter("Select * From TBLURUNLER", baglanti);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                cmbÜrün.ValueMember = "URUNID";
                cmbÜrün.DisplayMember = "AD";
                cmbÜrün.DataSource = dt3;
            }
            finally
            {
                baglanti.Close();
            }
        }

        // Malzemeleri listeleme fonksiyonu
        void malzemeler()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_malzemeler", baglanti);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmbMalzeme.ValueMember = "MALZEMEID";
                cmbMalzeme.DisplayMember = "AD";
                cmbMalzeme.DataSource = dt2;
            }
            finally
            {
                baglanti.Close();
            }
        }

        // Veritabanından malzeme listesini datagridview'a doldurma
        void MalzemeListe()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_malzemeler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            finally
            {
                baglanti.Close();
            }
        }

        // Ürün listesini doldurma
        void UrunListe()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("Select * From TBLURUNLER", baglanti);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            finally
            {
                baglanti.Close();
            }
        }

        // Form yüklenirken yapılacak işlemler
   

        // Ürün ekleme işlemi
        private void Btn_ürünekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", Txt_ÜrünAd.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                baglanti.Close();
            }
            UrunListe();
            ürünler();
        }

        // Malzeme ekleme işlemi
        private void Btn_MalzemeStokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_malzemeler (AD,STOK,FİYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", Txt_StokAd.Text);
                komut.Parameters.AddWithValue("@p2", decimal.Parse(Txt_Stok.Text));
                komut.Parameters.AddWithValue("@p3", decimal.Parse(Txt_StokFiyat.Text));
                komut.Parameters.AddWithValue("@p4", Txt_StokNotlar.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                baglanti.Close();
            }
            MalzemeListe();
            malzemeler();
        }
        public decimal malzememaliyet;
        // Ürün oluşturma ve malzeme ekleme işlemi
        private void Btn_ürünoluşturekle_Click(object sender, EventArgs e)
        {
            if (cmbÜrün.SelectedValue == null || cmbMalzeme.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir ürün ve malzeme seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_fırın (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", cmbÜrün.SelectedValue);
                komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(Txt_ürünmalzememiktar.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(Txt_ürünmalzememaliyet.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lst_listeleürün.Items.Add(cmbMalzeme.Text + " - " + Txt_ürünmalzememaliyet.Text);
                malzememaliyet = decimal.Parse(Txt_ürünmalzememiktar.Text);
            }
            finally
            {
                baglanti.Close();
            }
            UrunListe();
            ürünler();
        }

        // Malzeme fiyatını ve miktarını hesaplama
        private void Txt_ürünmalzememiktar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_ürünmalzememiktar.Text))
            {
                Txt_ürünmalzememiktar.Text = "0";
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select FİYAT from Tbl_malzemeler where MALZEMEID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    double maliyet = Convert.ToDouble(dr["FİYAT"]) / 1000 * Convert.ToDouble(Txt_ürünmalzememiktar.Text);
                    Txt_ürünmalzememaliyet.Text = maliyet.ToString();
                }
            }
            finally
            {
                baglanti.Close();
            }


        }
        private void BtnKasaGiris_Click(object sender, EventArgs e)
        {
        }
        private void BtnKasaCikis_Click(object sender, EventArgs e)
        {
      
        }
        private void KasaBakiyeGoster()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT SUM(CASE WHEN ISLEM_TURU = 'GİRİŞ' THEN TUTAR ELSE -TUTAR END) AS BAKIYE FROM Tbl_Kasa", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    double bakiye = Convert.ToDouble(dr["BAKIYE"]);

                    // Eğer bakiye 0'dan büyük veya eşitse göster
                    if (bakiye >= 0)
                    {
                        LBLKASA.Text = "Kasa Bakiyesi: " + bakiye.ToString("N2") + " TL";
                    }
                    else
                    {
                        // Eğer bakiye 0'dan küçükse farklı bir mesaj göster
                        LBLKASA.Text = "Kasa bakiyesi negatif: " + bakiye.ToString("N2") + " TL. Dikkat!";
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void KasaListe()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Kasa", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
            KasaBakiyeGoster();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btnKasaGiris_Click_1(object sender, EventArgs e)
        {
            decimal toplam = 0;
            toplam = Decimal.Parse(Txt_ürünmalzemesatışfiyat.Text) * Decimal.Parse( Txt_ÜrünStok.Text);

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kasa (ISLEM_TURU, TUTAR, ACIKLAMA, TARIH) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", "GİRİŞ");
                komut.Parameters.AddWithValue("@p2", decimal.Parse(toplam.ToString()));
                komut.Parameters.AddWithValue("@p3", Txt_ÜrünAd .Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);

                komut.ExecuteNonQuery();
                MessageBox.Show("Gelir kasaya eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
                KasaListe();  // Kasa listesini güncelle
            }
            KasaBakiyeGoster();
        }

        private void Btn_Kasaçıkış_Click(object sender, EventArgs e)
        {
            decimal toplam =malzememaliyet+ decimal.Parse(textBox2.Text);

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kasa (ISLEM_TURU, TUTAR, ACIKLAMA, TARIH) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", "ÇIKIŞ");
                komut.Parameters.AddWithValue("@p2", decimal.Parse( toplam.ToString()));
                komut.Parameters.AddWithValue("@p3", textBox1.Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);

                komut.ExecuteNonQuery();
                MessageBox.Show("Gider kasadan çıkış yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
                KasaListe();  // Kasa listesini güncelle
            }
            KasaBakiyeGoster();
        }
    }
}