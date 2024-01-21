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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class AddProjectForm : Form
    {
        private string kullanici;

        public AddProjectForm(string ID)
        {
            InitializeComponent();
            kullanici = ID;
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;");
        private string ad;

        public string ID { get; private set; }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            string projead = ProjectTextBox.Text;
            string baslangictarihi = StartDateTextBox.Text;
            string bitistarihi = EndDateTextBox.Text;

            if (projead == "" || baslangictarihi == "" || bitistarihi == "")
            {
                MessageBox.Show("Lütfen Boş Bıraktığınız Yerleri Doldurunuz!!!");
            }
            else
            {

                Baglanti2.connection.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO proje (projeAdi, baslangıc,bitis,kullaniciID) VALUES('" + projead + "','" + baslangictarihi + "','" + bitistarihi + "','" + kullanici + "')", Baglanti2.connection);
                komut.ExecuteNonQuery();
                Baglanti2.connection.Close();
                MainPageForm mainPage = new MainPageForm(ad, ID);
                mainPage.ShowDialog();
                this.Hide();
            }
        }
            }
        }

