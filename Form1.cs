using System.Data;
using Microsoft.Data.SqlClient;

namespace tpListJeuxVideos
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\RÉMI\\SOURCE\\REPOS\\TPLISTJEUXVIDEOS\\BIBLIJEUX.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Form1()
        {
            InitializeComponent();


            //using System.Data.SqlClient;


            //List<string[]> jeux = new List<String[]>
            //{
            //    new string[] {"Bomberman","DS","Action","2005","5","Disponible"},
            //    new string[] {"Pokémon Rouge","GameBoy", "RPG", "1996", "45", "Disponible" },
            //};

            //dataTable = new DataTable();
            //dataTable.Columns.Add("Titre");
            //dataTable.Columns.Add("Plateforme");
            //dataTable.Columns.Add("Genre");
            //dataTable.Columns.Add("Date de Sortie");
            //dataTable.Columns.Add("Prix");
            //dataTable.Columns.Add("Statut");

            //foreach (string[] jeu in jeux)
            //{
            //    dataTable.Rows.Add(jeu[0], jeu[1], jeu[2], jeu[3], jeu[4], jeu[5]);
            //}
            //dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutJeu_Click(object sender, EventArgs e)
        {
            if (textBoxTitreJeu.Text == "" || textBoxPrixJeu.Text == "" || ComboBoxGenreJeu.Text == "" || ComboBoxAnnee.Text == "" || ComboBoxPlateforme.Text == "" || ComboBoxStatut.Text == "")
            {
                MessageBox.Show("Tous les champs doivent être complétés");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Jeux (Titre, Plateforme, Genre, DateSortie, Prix, Statut) VALUES (@Titre, @Plateforme, @Genre, @DateSortie, @Prix, @Statut)", conn);
                    cmd.Parameters.AddWithValue("@Titre", textBoxTitreJeu.Text);
                    cmd.Parameters.AddWithValue("@Plateforme", ComboBoxPlateforme.Text);
                    cmd.Parameters.AddWithValue("@Genre", ComboBoxGenreJeu.Text);
                    cmd.Parameters.AddWithValue("@DateSortie", ComboBoxAnnee.Text);
                    cmd.Parameters.AddWithValue("@Prix", textBoxPrixJeu.Text);
                    cmd.Parameters.AddWithValue("@Statut", ComboBoxStatut.Text);
                    cmd.ExecuteNonQuery();


                    //SqlDataAdapter da = new SqlDataAdapter("Select * FROM Jeux", conn);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);

                }
            //    dataTable.Rows.Add(textBoxTitreJeu.Text, ComboBoxPlateforme.Text, ComboBoxGenreJeu.Text, ComboBoxAnnee.Text, textBoxPrixJeu.Text, ComboBoxStatut.Text);
                MessageBox.Show("Le jeu " + textBoxTitreJeu.Text + " a été ajouté à la bibliothèque");
            }
        }

        private void btnSupprJeu_Click(object sender, EventArgs e)
        {

        }
    }
}
