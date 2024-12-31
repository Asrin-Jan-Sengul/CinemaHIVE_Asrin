using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniProje_Asrin
{
    public partial class AddFilm : Form
    {
        private AdminForm adminForm;

        public AddFilm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void AddFilm_Load(object sender, EventArgs e)
        {

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

            AddFilmToDatabase(filmAdi, tur, yil, aciklama);
            adminForm.RefreshFilmList();
            this.Close();
        }

        private void AddFilmToDatabase(string filmAdi, string tur, int yil, string aciklama)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=FinalProje";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "INSERT INTO Film (FilmAdi, Tur, Yil, Aciklama) VALUES (@filmAdi, @tur, @yil, @aciklama)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("filmAdi", filmAdi);
                    cmd.Parameters.AddWithValue("tur", tur);
                    cmd.Parameters.AddWithValue("yil", yil);
                    cmd.Parameters.AddWithValue("aciklama", aciklama);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Film başarıyla eklendi!");
        }

        private void txtFilmAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
