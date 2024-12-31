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
using Npgsql;
using VeritabaniProje_Asrin;


namespace VeritabaniProje_Asrin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=FinalProje";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT Rol FROM Kullanici WHERE KullaniciAdi = @Username AND Sifre = @Password";
                using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    object Rol = cmd.ExecuteScalar();

                    if (Rol != null)
                    {
                        string userRole = Rol.ToString();
                        MessageBox.Show($"Giriş Başarılı! Hoşgeldiniz.");

                        if (userRole == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (userRole == "kullanici")
                        {
                            UserForm userForm = new UserForm();
                            userForm.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatali isim veya sifre.");
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
