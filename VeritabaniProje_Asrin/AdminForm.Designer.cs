namespace VeritabaniProje_Asrin
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button3 = new Button();
            dataGridFilms = new DataGridView();
            FilmDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridFilms).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 152);
            button1.Name = "button1";
            button1.Size = new Size(143, 64);
            button1.TabIndex = 0;
            button1.Text = "Film Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(49, 246);
            button3.Name = "button3";
            button3.Size = new Size(143, 64);
            button3.TabIndex = 2;
            button3.Text = "Filmi Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridFilms
            // 
            dataGridFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFilms.Location = new Point(218, 54);
            dataGridFilms.Margin = new Padding(2);
            dataGridFilms.MultiSelect = false;
            dataGridFilms.Name = "dataGridFilms";
            dataGridFilms.ReadOnly = true;
            dataGridFilms.RowHeadersWidth = 51;
            dataGridFilms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFilms.Size = new Size(601, 353);
            dataGridFilms.TabIndex = 3;
            dataGridFilms.CellDoubleClick += dataGridFilms_CellDoubleClick;
            // 
            // FilmDelete
            // 
            FilmDelete.Location = new Point(49, 343);
            FilmDelete.Name = "FilmDelete";
            FilmDelete.Size = new Size(143, 64);
            FilmDelete.TabIndex = 4;
            FilmDelete.Text = "Filmi Sil";
            FilmDelete.UseVisualStyleBackColor = true;
            FilmDelete.Click += FilmDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(28, 76);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 5;
            label1.Text = "CinemaHIVE";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(846, 450);
            Controls.Add(label1);
            Controls.Add(FilmDelete);
            Controls.Add(dataGridFilms);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "AdminForm";
            Text = "Admin Arayüz";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridFilms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private DataGridView dataGridFilms;
        private Button FilmDelete;
        private Label label1;
    }
}
