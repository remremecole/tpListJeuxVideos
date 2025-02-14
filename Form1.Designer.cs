namespace tpListJeuxVideos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTitreJeu = new Label();
            LabelGenreJeu = new Label();
            LabelAnnéeJeu = new Label();
            LabelPrixJeu = new Label();
            LabelStatutJeu = new Label();
            groupBox1 = new GroupBox();
            ComboBoxPlateforme = new ComboBox();
            LabelPlateforme = new Label();
            ComboBoxAnnee = new ComboBox();
            ComboBoxStatut = new ComboBox();
            ComboBoxGenreJeu = new ComboBox();
            btnSupprJeu = new Button();
            btnAjoutJeu = new Button();
            textBoxPrixJeu = new TextBox();
            textBoxTitreJeu = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LabelTitreJeu
            // 
            LabelTitreJeu.AutoSize = true;
            LabelTitreJeu.Location = new Point(37, 48);
            LabelTitreJeu.Name = "LabelTitreJeu";
            LabelTitreJeu.Size = new Size(102, 25);
            LabelTitreJeu.TabIndex = 0;
            LabelTitreJeu.Text = "Titre du Jeu";
            // 
            // LabelGenreJeu
            // 
            LabelGenreJeu.AutoSize = true;
            LabelGenreJeu.Location = new Point(36, 125);
            LabelGenreJeu.Name = "LabelGenreJeu";
            LabelGenreJeu.Size = new Size(58, 25);
            LabelGenreJeu.TabIndex = 1;
            LabelGenreJeu.Text = "Genre";
            // 
            // LabelAnnéeJeu
            // 
            LabelAnnéeJeu.AutoSize = true;
            LabelAnnéeJeu.Location = new Point(36, 162);
            LabelAnnéeJeu.Name = "LabelAnnéeJeu";
            LabelAnnéeJeu.Size = new Size(138, 25);
            LabelAnnéeJeu.TabIndex = 2;
            LabelAnnéeJeu.Text = "Année de Sortie";
            // 
            // LabelPrixJeu
            // 
            LabelPrixJeu.AutoSize = true;
            LabelPrixJeu.Location = new Point(40, 198);
            LabelPrixJeu.Name = "LabelPrixJeu";
            LabelPrixJeu.Size = new Size(40, 25);
            LabelPrixJeu.TabIndex = 3;
            LabelPrixJeu.Text = "Prix";
            // 
            // LabelStatutJeu
            // 
            LabelStatutJeu.AutoSize = true;
            LabelStatutJeu.Location = new Point(41, 236);
            LabelStatutJeu.Name = "LabelStatutJeu";
            LabelStatutJeu.Size = new Size(58, 25);
            LabelStatutJeu.TabIndex = 4;
            LabelStatutJeu.Text = "Statut";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboBoxPlateforme);
            groupBox1.Controls.Add(LabelPlateforme);
            groupBox1.Controls.Add(ComboBoxAnnee);
            groupBox1.Controls.Add(ComboBoxStatut);
            groupBox1.Controls.Add(ComboBoxGenreJeu);
            groupBox1.Controls.Add(btnSupprJeu);
            groupBox1.Controls.Add(btnAjoutJeu);
            groupBox1.Controls.Add(LabelTitreJeu);
            groupBox1.Controls.Add(textBoxPrixJeu);
            groupBox1.Controls.Add(LabelGenreJeu);
            groupBox1.Controls.Add(LabelAnnéeJeu);
            groupBox1.Controls.Add(textBoxTitreJeu);
            groupBox1.Controls.Add(LabelPrixJeu);
            groupBox1.Controls.Add(LabelStatutJeu);
            groupBox1.Location = new Point(36, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 510);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // ComboBoxPlateforme
            // 
            ComboBoxPlateforme.FormattingEnabled = true;
            ComboBoxPlateforme.Items.AddRange(new object[] { "GameBoy", "GameBoy Advenced", "DS", "3DS", "Switch", "Switch 2", "PS1", "PS2", "PS3", "PS4", "PS5", "XBox", "XBox360", "XBox One", "Autre" });
            ComboBoxPlateforme.Location = new Point(185, 82);
            ComboBoxPlateforme.Name = "ComboBoxPlateforme";
            ComboBoxPlateforme.Size = new Size(329, 33);
            ComboBoxPlateforme.TabIndex = 15;
            // 
            // LabelPlateforme
            // 
            LabelPlateforme.AutoSize = true;
            LabelPlateforme.Location = new Point(41, 85);
            LabelPlateforme.Name = "LabelPlateforme";
            LabelPlateforme.Size = new Size(98, 25);
            LabelPlateforme.TabIndex = 14;
            LabelPlateforme.Text = "Plateforme";
            // 
            // ComboBoxAnnee
            // 
            ComboBoxAnnee.FormattingEnabled = true;
            ComboBoxAnnee.Items.AddRange(new object[] { "Inconnu", "2035", "2034", "2033", "2032", "2031", "2030", "2029", "2028", "2027", "2026", "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950" });
            ComboBoxAnnee.Location = new Point(185, 159);
            ComboBoxAnnee.Name = "ComboBoxAnnee";
            ComboBoxAnnee.Size = new Size(329, 33);
            ComboBoxAnnee.TabIndex = 13;
            // 
            // ComboBoxStatut
            // 
            ComboBoxStatut.FormattingEnabled = true;
            ComboBoxStatut.Items.AddRange(new object[] { "Disponible", "Prêté", "Vendu" });
            ComboBoxStatut.Location = new Point(185, 236);
            ComboBoxStatut.Name = "ComboBoxStatut";
            ComboBoxStatut.Size = new Size(329, 33);
            ComboBoxStatut.TabIndex = 12;
            // 
            // ComboBoxGenreJeu
            // 
            ComboBoxGenreJeu.FormattingEnabled = true;
            ComboBoxGenreJeu.Items.AddRange(new object[] { "Action", "RPG", "Sport", "Combat", "Autre", "Inconnu" });
            ComboBoxGenreJeu.Location = new Point(185, 121);
            ComboBoxGenreJeu.Name = "ComboBoxGenreJeu";
            ComboBoxGenreJeu.Size = new Size(329, 33);
            ComboBoxGenreJeu.TabIndex = 6;
            // 
            // btnSupprJeu
            // 
            btnSupprJeu.Location = new Point(36, 342);
            btnSupprJeu.Name = "btnSupprJeu";
            btnSupprJeu.Size = new Size(478, 34);
            btnSupprJeu.TabIndex = 11;
            btnSupprJeu.Text = "Supprimer un jeu";
            btnSupprJeu.UseVisualStyleBackColor = true;
            btnSupprJeu.Click += btnSupprJeu_Click;
            // 
            // btnAjoutJeu
            // 
            btnAjoutJeu.Location = new Point(36, 273);
            btnAjoutJeu.Name = "btnAjoutJeu";
            btnAjoutJeu.Size = new Size(478, 34);
            btnAjoutJeu.TabIndex = 6;
            btnAjoutJeu.Text = "Ajouter à la Collection";
            btnAjoutJeu.UseVisualStyleBackColor = true;
            btnAjoutJeu.Click += btnAjoutJeu_Click;
            // 
            // textBoxPrixJeu
            // 
            textBoxPrixJeu.Location = new Point(185, 198);
            textBoxPrixJeu.Name = "textBoxPrixJeu";
            textBoxPrixJeu.Size = new Size(329, 31);
            textBoxPrixJeu.TabIndex = 8;
            // 
            // textBoxTitreJeu
            // 
            textBoxTitreJeu.Location = new Point(185, 45);
            textBoxTitreJeu.Name = "textBoxTitreJeu";
            textBoxTitreJeu.Size = new Size(329, 31);
            textBoxTitreJeu.TabIndex = 6;
            textBoxTitreJeu.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(682, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1046, 514);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1799, 604);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTitreJeu;
        private Label LabelGenreJeu;
        private Label LabelAnnéeJeu;
        private Label LabelPrixJeu;
        private Label LabelStatutJeu;
        private GroupBox groupBox1;
        private Button btnSupprJeu;
        private Button btnAjoutJeu;
        private TextBox textBoxPrixJeu;
        private TextBox textBox2;
        private TextBox textBoxTitreJeu;
        private ComboBox ComboBoxGenreJeu;
        private ComboBox ComboBoxStatut;
        private Label LabelPlateforme;
        private ComboBox ComboBoxAnnee;
        private ComboBox ComboBoxPlateforme;
        private DataGridView dataGridView1;
    }
}
