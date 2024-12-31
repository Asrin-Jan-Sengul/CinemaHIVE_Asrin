namespace VeritabaniProje_Asrin
{
    partial class AddFilm
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
            txtFilmAdi = new TextBox();
            txtTur = new TextBox();
            txtYil = new TextBox();
            txtAciklama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtFilmAdi
            // 
            txtFilmAdi.Location = new Point(233, 52);
            txtFilmAdi.Name = "txtFilmAdi";
            txtFilmAdi.Size = new Size(146, 27);
            txtFilmAdi.TabIndex = 5;
            txtFilmAdi.TextChanged += txtFilmAdi_TextChanged;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(233, 125);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(146, 27);
            txtTur.TabIndex = 4;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(233, 185);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(84, 27);
            txtYil.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(233, 241);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(227, 105);
            txtAciklama.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Film Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 128);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Film Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 185);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "Film Yılı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 241);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Açıklama";
            // 
            // button1
            // 
            button1.Location = new Point(273, 383);
            button1.Name = "button1";
            button1.Size = new Size(149, 55);
            button1.TabIndex = 10;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAciklama);
            Controls.Add(txtYil);
            Controls.Add(txtTur);
            Controls.Add(txtFilmAdi);
            Name = "AddFilm";
            Text = "AddFilm";
            Load += AddFilm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilmAdi;
        private TextBox txtTur;
        private TextBox txtYil;
        private TextBox txtAciklama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}