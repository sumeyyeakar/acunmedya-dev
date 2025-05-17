using HastaRandevuSistemi.Models;
using System.Data.SqlClient;

namespace HastaRandevuSistemi
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-CV1IH9P\SQLEXPRESS;Initial Catalog=AcunMedya_CMT19;Integrated Security=SSPI;";
        int bransID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BransGetir();
        }

        public void BransGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Brans> bransListesi = null;
                try
                {
                    connection.Open();
                    string sorgu = "select * from branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    bransListesi = new List<Brans>();
                    bransListesi.Add(new Brans
                    {
                        id = -1,
                        bransi = "Branþ Seçiniz"
                    });
                    while (reader.Read())
                    {

                        bransListesi.Add(new Brans
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            bransi = (string)reader["BransAdi"]

                        });
                    }
                    cmbBrans.DataSource = bransListesi;
                    cmbBrans.DisplayMember = "bransi";
                    cmbBrans.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            cmbSaat.Items.AddRange(new string[] { "08:00", "09:00", "10:00", "11:00", "13:00", "15:00" });
        }


        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans secilenBrans = (Brans)cmbBrans.SelectedItem;
            if (secilenBrans.id > 0)
            {
                DoktorGetir(secilenBrans.id);
            }
        }

        public void DoktorGetir(int bransId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Doktor> doktorListesi = null;
                try
                {
                    connection.Open();
                    string sorgu = "select * from doktorlar where BransId=" + bransId;
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    doktorListesi = new List<Doktor>();
                    while (reader.Read())
                    {
                        int siradakiDoktorId = Convert.ToInt32(reader["ID"]);
                        string siradakiDoktor = (string)reader["DoktorAdi"].ToString();
                        doktorListesi.Add(new Doktor
                        {
                            id = siradakiDoktorId,
                            doktor = siradakiDoktor

                        });
                    }
                    cmbDoktor.DataSource = doktorListesi;
                    cmbDoktor.DisplayMember = "doktor";
                    cmbDoktor.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (cmbBrans.SelectedIndex <= 0 || cmbDoktor.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtHastaAdi.Text) || string.IsNullOrWhiteSpace(txtHastaSoyadi.Text) ||
                cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("tüm alanlarý doldurunuz.");
                return;
            }

            Brans secilenBrans = (Brans)cmbBrans.SelectedItem;
            Doktor secilenDoktor = (Doktor)cmbDoktor.SelectedItem;
            string hastaAd = txtHastaAdi.Text;
            string hastaSoyad = txtHastaSoyadi.Text;

          

            string secilenTarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            string secilenSaat = cmbSaat.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(secilenSaat))
            {
                MessageBox.Show("Lütfen bir saat seçiniz.");
                return;
            }

            string tamTarihSaat = $"{secilenTarih} {secilenSaat}";
            DateTime randevuTarihi;

            if (!DateTime.TryParse(tamTarihSaat, out randevuTarihi))
            {
                MessageBox.Show("Tarih ve saat formatý hatalý.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string kontrolSorgu = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktorID AND Tarih = @tarih";
                SqlCommand kontrolCommand = new SqlCommand(kontrolSorgu, connection);
                kontrolCommand.Parameters.AddWithValue("@doktorID", secilenDoktor.id);
                kontrolCommand.Parameters.AddWithValue("@tarih", randevuTarihi);

                int varMi = (int)kontrolCommand.ExecuteScalar();
                if (varMi > 0)
                {
                    MessageBox.Show("Bu doktor bu tarih ve saatte zaten randevu almýþ.");
                    return;
                }

                string ekleSorgu = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) " +
                                   "VALUES (@hastaAdi, @hastaSoyadi, @bransID, @doktorID, @tarih)";
                SqlCommand ekleCommand = new SqlCommand(ekleSorgu, connection);
                ekleCommand.Parameters.AddWithValue("@hastaAdi", hastaAd);
                ekleCommand.Parameters.AddWithValue("@hastaSoyadi", hastaSoyad);
                ekleCommand.Parameters.AddWithValue("@bransID", secilenBrans.id);
                ekleCommand.Parameters.AddWithValue("@doktorID", secilenDoktor.id);
                ekleCommand.Parameters.AddWithValue("@tarih", randevuTarihi);

                int sonuc = ekleCommand.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Randevu baþarýyla oluþturuldu.");
                }
                else
                {
                    MessageBox.Show("Randevu kaydedilemedi.");
                }
            }
        }

    }
}

