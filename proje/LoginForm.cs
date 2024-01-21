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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;MultipleActiveResultSets=True");

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailTextBox1.Text;
                string sifre = PasswordTextBox1.Text;

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;MultipleActiveResultSets=True"))
                {
                    connection.Open();

                    using (SqlCommand sorgu = new SqlCommand())
                    {
                        sorgu.Connection = connection;
                        sorgu.CommandText = "SELECT * FROM kullanici WHERE kullaniciMail ='" + email + "' AND Sifre ='" + sifre + "'";

                        using (SqlDataReader dr = sorgu.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string ID = dr["kullaniciID"].ToString();
                                string ad = dr["kullaniciAd"].ToString();
                                MainPageForm mainPage = new MainPageForm(ad, ID);
                                mainPage.ShowDialog();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Bilgiler Yanlış");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception, log, or display an error message
            }
        }

        private void NexAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountForm registergecis = new NewAccountForm();
            registergecis.Show();
        }
    }
}
