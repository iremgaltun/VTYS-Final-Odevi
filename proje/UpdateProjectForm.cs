using proje.baslangic2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class UpdateProjectForm : Form
    {
        public UpdateProjectForm(string ID)
        {
            InitializeComponent();
            kullanici = ID;
        }
        private void ExitButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int projeID1;
        public int kullaniciID1;
        public string kullanici;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;");
        private string ad;

        public string ID { get; private set; }

        private void UpdateProjectForm_Load(object sender, EventArgs e)
        {
            DataTable proje = new DataTable();
            SqlDataAdapter daproje = new SqlDataAdapter("SELECT * FROM proje WHERE kullaniciID = '" + kullanici + "'", Baglanti2.connection);
            daproje.Fill(proje);
            ProjectComboBox2.ValueMember = "projeID";
            ProjectComboBox2.DisplayMember = "ProjeAdi";
            ProjectComboBox2.DataSource = proje;
            // Seçilen öğenin DataRowView olduğunu varsayalım
            DataRowView selectedRow = (DataRowView)ProjectComboBox2.SelectedItem;

            // DataRowView üzerinden ProjeID değerini al
            int projeID = Convert.ToInt32(selectedRow["projeID"]);
            projeID1 = projeID;

            DataTable calisanlar = new DataTable();
            SqlDataAdapter dacalisan = new SqlDataAdapter("SELECT * FROM kullanici", Baglanti2.connection);
            dacalisan.Fill(calisanlar);
            IncumbentComboBox2.DisplayMember = "kullaniciAd";
            IncumbentComboBox2.ValueMember = "kullaniciID";
            IncumbentComboBox2.DataSource = calisanlar;
        }
        private void ProjectComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectComboBox2.SelectedIndex != -1)
            {
                DataTable projeid = new DataTable();
                SqlDataAdapter daproje = new SqlDataAdapter("SELECT * FROM proje WHERE projeID = '" + ProjectComboBox2.SelectedValue + "'", Baglanti2.connection);
                daproje.Fill(projeid);
                ProjectComboBox2.DisplayMember = "projeAdi";
                ProjectComboBox2.ValueMember = "projeID";
                ProjectComboBox2.DataSource = projeid;
                // Seçilen öğenin DataRowView olduğunu varsayalım
                DataRowView Row = (DataRowView)ProjectComboBox2.SelectedItem;

                // DataRowView üzerinden ProjeID değerini al
                int projeID = Convert.ToInt32(Row["projeID"]);
                projeID1 = projeID;
            }
        }
        private void IncumbentComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (IncumbentComboBox2.SelectedIndex != -1)
            {
                DataTable calisanlar = new DataTable();
                SqlDataAdapter dacalisan = new SqlDataAdapter("SELECT * FROM kullanici WHERE kullaniciID = '" + IncumbentComboBox2.SelectedValue + "'", Baglanti2.connection);
                dacalisan.Fill(calisanlar);
                IncumbentComboBox2.DisplayMember = "kullaniciAd";
                IncumbentComboBox2.ValueMember = "kullaniciID";
                IncumbentComboBox2.DataSource = calisanlar;
                // Seçilen öğenin DataRowView olduğunu varsayalım
                DataRowView Row = (DataRowView)IncumbentComboBox2.SelectedItem;

                // DataRowView üzerinden ProjeID değerini al
                int kullaniciID = Convert.ToInt32(Row["kullaniciID"]);
                kullaniciID1 = kullaniciID;
            }
        }
        private void UpdateProjectButton2_Click(object sender, EventArgs e)
        {
            string gorevad = NewTaskTextBox.Text;
            string baslangictarihi = StartDateTextBox.Text;
            string bitistarihi = EndDateTextBox.Text;
            string durum = "Başlanacak";

            if (gorevad == "" || baslangictarihi == "" || bitistarihi == "")
            {
                MessageBox.Show("Lütfen Boş Bıraktığınız Yerleri Doldurunuz!!!");
            }
            else
            {

                Baglanti2.connection.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO gorev (baslangicT, bitisT, görevAdi, projeID, durum, kullaniciID) VALUES('" + baslangictarihi + "','" + bitistarihi + "','" + gorevad + "','" + projeID1 + "','" + durum + "','" + kullaniciID1 + "')", Baglanti2.connection);

                komut.ExecuteNonQuery();
                Baglanti2.connection.Close();
            }
            MainPageForm mainPage = new MainPageForm(ad, ID);
            mainPage.ShowDialog();
            this.Hide();
        }

    }
}
