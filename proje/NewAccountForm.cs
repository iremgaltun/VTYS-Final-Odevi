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
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void ExitButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ;
            if (String.IsNullOrEmpty(NameTextBox.Text) ||
                String.IsNullOrEmpty(SurnameTextBox.Text) ||
                String.IsNullOrEmpty(EmailTextBox2.Text) ||
                String.IsNullOrEmpty(PasswordTextBox2.Text))
            {
                NameTextBox.Text = "";
                SurnameTextBox.Text = "";
                PasswordTextBox2.Text = "";
                EmailTextBox2.Text = "";
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            else
            {
                SqlCommand commandResigter = new SqlCommand("Insert into kullanici (kullaniciAd,kullaniciSoyad,kullaniciMail,sifre) values(@ad,@soyad,@mail,@sifre)", Baglanti2.connection);

                Baglanti2.CheckConnection(Baglanti2.connection);

                commandResigter.Parameters.AddWithValue("@ad", NameTextBox.Text);
                commandResigter.Parameters.AddWithValue("@soyad", SurnameTextBox.Text);
                commandResigter.Parameters.AddWithValue("@mail", EmailTextBox2.Text);
                commandResigter.Parameters.AddWithValue("@sifre", PasswordTextBox2.Text);

                commandResigter.ExecuteNonQuery();

                LoginForm newform = new LoginForm();
                newform.Show();
                this.Hide();
            }
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
