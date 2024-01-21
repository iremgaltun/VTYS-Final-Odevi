using proje.baslangic2;
using proje.dmsDataSet5TableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proje
{
    public partial class MainPageForm : Form
    {
        readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;MultipleActiveResultSets=True;");
        private string kullanici;
        private string isim;
        private SqlDataReader reader; 

        public MainPageForm(string ad, string ID)
        {
            InitializeComponent();
            kullanici = ID;
            isim = ad;
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            AddProjectForm projeyegecis = new AddProjectForm(kullanici);
            projeyegecis.Show();
            this.Hide();
        }

        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            UpdateProjectForm guncellemeyegecis = new UpdateProjectForm(kullanici);
            guncellemeyegecis.Show();
            this.Hide();
        }

        private void ViewIncumbentsButton_Click(object sender, EventArgs e)
        {
            ViewIncumbentsForm calisanlaragecis = new ViewIncumbentsForm();
            calisanlaragecis.Show();
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM proje WHERE kullaniciID = '" + kullanici + "'", Baglanti2.connection);
            da.Fill(tablo);
            ProjectComboBox1.ValueMember = "projeID";
            ProjectComboBox1.DisplayMember = "projeAdi";
            ProjectComboBox1.DataSource = tablo;
        }

        private void ProjectComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectComboBox1.SelectedValue != null)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JDM81FD\\SQLEXPRESS;Initial Catalog=dms;Integrated Security=True;MultipleActiveResultSets=True;"))
                {
                    connection.Open();
                    try
                    {
                        // Close any existing DataReader
                        if (reader != null && !reader.IsClosed)
                        {
                            reader.Close();
                        }
                        // Set up data binding for ComboBox
                        ProjectComboBox1.DisplayMember = "projeAdi";
                        ProjectComboBox1.ValueMember = "projeAdi";

                        object selectedValue = ProjectComboBox1.SelectedValue;

                        if (selectedValue != null)
                        {
                            string selectedProject = selectedValue.ToString();

                            using (SqlCommand cmd = new SqlCommand("SELECT baslangıc, bitis FROM proje WHERE projeAdi = @projeAdi", connection))
                            {
                                cmd.Parameters.AddWithValue("@projeAdi", selectedProject);

                                // Execute the command and get the DataReader
                                reader = cmd.ExecuteReader();

                                if (reader.Read())
                                {
                                    StartDateTextBox.Text = reader["baslangıc"].ToString();
                                    EndDateTextBox.Text = reader["bitis"].ToString();
                                }
                            }
                        }
                        else
                        {
                            // Handle the case where SelectedValue is null.
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }


    }
}
