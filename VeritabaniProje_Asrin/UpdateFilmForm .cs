using Npgsql;
using System;
using System.Windows.Forms;

namespace VeritabaniProje_Asrin
{
    public partial class UpdateFilmForm : Form
    {
        private int filmID;

        public UpdateFilmForm(int filmID, string filmAdi, string tur, int yil, string aciklama)
        {
            InitializeComponent();
            this.filmID = filmID;

            txtFilmAdi.Text = filmAdi;
            txtTur.Text = tur;
            txtYil.Text = yil.ToString();
            txtAciklama.Text = aciklama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filmAdi = txtFilmAdi.Text;
            string tur = txtTur.Text;
            int yil;
            bool isValidYear = int.TryParse(txtYil.Text, out yil);
            string aciklama = txtAciklama.Text;

            if (!isValidYear)
            {
                MessageBox.Show("Lütfen düzgün bir tarih girin.");
                return;
            }

            UpdateFilm(filmID, filmAdi, tur, yil, aciklama);

            this.Close();
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

            MessageBox.Show("Film başarıyla güncellendi!");
        }
    }
}
