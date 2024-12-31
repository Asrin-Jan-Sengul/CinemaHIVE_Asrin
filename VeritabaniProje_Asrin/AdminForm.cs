using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
//SELECT * FROM FilmlerView; FilmLog;
//CALL FilmEkle('Matrix', 'Bilim-Kurgu', 1999, 'Eskilerin klasiklerinden güzel bir film');


namespace VeritabaniProje_Asrin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public void LoadFilms()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=FinalProje";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT FilmID, FilmAdi, Tur, Yil, Aciklama FROM Film";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridFilms.DataSource = dataTable;

                    // Hide FilmID column
                    if (dataGridFilms.Columns.Contains("FilmID"))
                    {
                        dataGridFilms.Columns["FilmID"].Visible = false;
                    }
                }
            }
        }

        // Refresh the film list after an action (add, delete, update)
        public void RefreshFilmList()
        {
            LoadFilms();
        }

        // Delete a film by its ID
        private void DeleteFilm(int filmID)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=FinalProje";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM Film WHERE FilmID = @filmID";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("filmID", filmID);
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshFilmList(); 
        }

        private void UpdateFilm(int filmID, string filmAdi, string tur, int yil, string aciklama)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=FinalProje";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE Film SET FilmAdi = @filmAdi, Tur = @tur, Yil = @yil, Aciklama = @aciklama WHERE FilmID = @filmID";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("filmAdi", filmAdi);
                    cmd.Parameters.AddWithValue("tur", tur);
                    cmd.Parameters.AddWithValue("yil", yil);
                    cmd.Parameters.AddWithValue("aciklama", aciklama);
                    cmd.Parameters.AddWithValue("filmID", filmID);
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshFilmList(); 
        }

        private void dataGridFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int filmID = Convert.ToInt32(dataGridFilms.Rows[e.RowIndex].Cells["FilmID"].Value);
                string filmAdi = dataGridFilms.Rows[e.RowIndex].Cells["FilmAdi"].Value.ToString();
                string tur = dataGridFilms.Rows[e.RowIndex].Cells["Tur"].Value.ToString();
                int yil = Convert.ToInt32(dataGridFilms.Rows[e.RowIndex].Cells["Yil"].Value);
                string aciklama = dataGridFilms.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();

                UpdateFilmForm updateForm = new UpdateFilmForm(filmID, filmAdi, tur, yil, aciklama);
                updateForm.FormClosed += (s, args) => LoadFilms();
                updateForm.Show();
            }
        }

        private void FilmDelete_Click(object sender, EventArgs e)
        {
            if (dataGridFilms.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridFilms.SelectedRows[0].Index;
                int filmID = Convert.ToInt32(dataGridFilms.Rows[selectedRowIndex].Cells["FilmID"].Value);

                DialogResult dialogResult = MessageBox.Show("Bu filmi silmek istediğinizden emin misiniz?", "Bu filmi sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteFilm(filmID);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz filmi seçin.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddFilm addFilmForm = new AddFilm(this);
            addFilmForm.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridFilms.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridFilms.SelectedRows[0].Index;
                int filmID = Convert.ToInt32(dataGridFilms.Rows[selectedRowIndex].Cells["FilmID"].Value);

                string filmAdi = dataGridFilms.Rows[selectedRowIndex].Cells["FilmAdi"].Value.ToString();
                string tur = dataGridFilms.Rows[selectedRowIndex].Cells["Tur"].Value.ToString();
                int yil = Convert.ToInt32(dataGridFilms.Rows[selectedRowIndex].Cells["Yil"].Value);
                string aciklama = dataGridFilms.Rows[selectedRowIndex].Cells["Aciklama"].Value.ToString();

                UpdateFilmForm updateForm = new UpdateFilmForm(filmID, filmAdi, tur, yil, aciklama);
                updateForm.FormClosed += (s, args) => LoadFilms(); 
                updateForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz filmi seçin.");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadFilms();
        }
    }
}
