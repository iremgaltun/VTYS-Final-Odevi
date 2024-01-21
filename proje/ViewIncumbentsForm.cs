using proje.baslangic2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class ViewIncumbentsForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;");
        public ViewIncumbentsForm()
        {
            InitializeComponent();
        }

        private void ExitButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewIncumbentsForm_Load(object sender, EventArgs e)
        {
            DataTable tumcalisanlar = new DataTable();
            SqlDataAdapter datumcalisanlar = new SqlDataAdapter("SELECT DISTINCT k.kullaniciAd, k.kullaniciID FROM kullanici k INNER JOIN gorev g ON k.kullaniciID = g.kullaniciID", Baglanti2.connection);

            datumcalisanlar.Fill(tumcalisanlar);
            IncumbentsComboBox3.DisplayMember = "kullaniciAd";
            IncumbentsComboBox3.ValueMember = "kullaniciID";
            IncumbentsComboBox3.DataSource = tumcalisanlar;
        }

        private void IncumbentsComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IncumbentsComboBox3.SelectedIndex != -1)
            {
                OngoingComboBox.DataSource = null;
                CompletedComboBox.DataSource = null;
                StartedComboBox.DataSource = null;
                ProjectListBox.DataSource = null;

                DataTable calisansec = new DataTable();
                SqlDataAdapter dacalisansec = new SqlDataAdapter("SELECT durum FROM gorev g WHERE g.kullaniciID = '" + IncumbentsComboBox3.SelectedValue + "' ", Baglanti2.connection);
                dacalisansec.Fill(calisansec);

                Dictionary<string, int> durumSayac = new Dictionary<string, int>
                {
                    { "Tamamlandı", 0 },
                    { "Devam Ediyor", 0 },
                    { "Başlanacak", 0 }
                };

                foreach (DataRow row in calisansec.Rows)
                {
                    string sqlDurum = row["durum"].ToString();
                    if (durumSayac.ContainsKey(sqlDurum))
                    {
                        durumSayac[sqlDurum]++;
                    }
                }

                CompletedTextBox.Text = durumSayac["Tamamlandı"].ToString();
                OngoingTextBox.Text = durumSayac["Devam Ediyor"].ToString();
                StartedTextBox.Text = durumSayac["Başlanacak"].ToString();
                string devamediyor = "Devam Ediyor";
                string tamamlandi = "Tamamlandı";
                string baslanacak = "Başlanacak";

                DataTable devameden = new DataTable();
                SqlDataAdapter dadevameden = new SqlDataAdapter("SELECT * FROM gorev g JOIN kullanici k ON g.kullaniciID = k.kullaniciID WHERE k.kullaniciID = '" + IncumbentsComboBox3.SelectedValue + "' AND g.durum = '" + devamediyor + "' ", Baglanti2.connection);
                dadevameden.Fill(devameden);
                OngoingComboBox.ValueMember = "gorevID";
                OngoingComboBox.DisplayMember = "görevAdi";
                OngoingComboBox.DataSource = devameden;

                DataTable tamamlanan = new DataTable();
                SqlDataAdapter datamamlanan = new SqlDataAdapter("SELECT * FROM gorev g JOIN kullanici k ON g.kullaniciID = k.kullaniciID WHERE k.kullaniciID = '" + IncumbentsComboBox3.SelectedValue + "' AND g.Durum = '" + tamamlandi + "' ", Baglanti2.connection);
                datamamlanan.Fill(tamamlanan);
                CompletedComboBox.ValueMember = "gorevID";
                CompletedComboBox.DisplayMember = "görevAdi";
                CompletedComboBox.DataSource = tamamlanan;

                DataTable baslaniyor = new DataTable();
                SqlDataAdapter dabaslaniyor = new SqlDataAdapter("SELECT * FROM gorev g JOIN kullanici k ON g.kullaniciID = k.kullaniciID WHERE k.kullaniciID = '" + IncumbentsComboBox3.SelectedValue + "' AND g.Durum = '" + baslanacak + "' ", Baglanti2.connection);
                dabaslaniyor.Fill(baslaniyor);
                StartedComboBox.ValueMember = "gorevID";
                StartedComboBox.DisplayMember = "görevAdi";
                StartedComboBox.DataSource = baslaniyor;

                DataTable projeler = new DataTable();
                SqlDataAdapter daprojeler = new SqlDataAdapter("SELECT * FROM proje p INNER JOIN gorev g ON g.projeID = p.ProjeID WHERE g.kullaniciID = '" + IncumbentsComboBox3.SelectedValue + "' ", Baglanti2.connection);
                daprojeler.Fill(projeler);

                ProjectListBox.DisplayMember = "projeAdi";
                ProjectListBox.ValueMember = "projeID";
                ProjectListBox.DataSource = projeler;

            }

        }
    }
}
