using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace VeritabaniProje_Asrin
{
    public partial class UserForm : Form
    {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=FinalProje";

        public UserForm()
        {
            InitializeComponent();
            LoadFilms();
        }

        private void LoadFilms()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Film";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Read-only ayarı
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadFilms();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
