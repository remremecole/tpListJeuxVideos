using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace tpListJeuxVideos
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;

        private int idSuppr;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\RÉMI\\SOURCE\\REPOS\\TPLISTJEUXVIDEOS\\BIBLIJEUX.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Form1()
        {
            InitializeComponent();





            List<string[]> jeux = new List<String[]>
            {
                //    new string[] {"Bomberman","DS","Action","2005","5","Disponible"},
                //    new string[] {"Pokémon Rouge","GameBoy", "RPG", "1996", "45", "Disponible" },
            };

            dataTable = new DataTable();
            dataTable.Columns.Add("Titre");
            dataTable.Columns.Add("Plateforme");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("Date de Sortie");
            dataTable.Columns.Add("Prix");
            dataTable.Columns.Add("Statut");

            foreach (string[] jeu in jeux)
            {
                dataTable.Rows.Add(jeu[0], jeu[1], jeu[2], jeu[3], jeu[4], jeu[5]);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = Form1.GetAllGames();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * FROM Jeux", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }


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

                    /*Fonction Reload*/
                    SqlDataAdapter da = new SqlDataAdapter("select * FROM Jeux", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                dataTable.Rows.Add(textBoxTitreJeu.Text, ComboBoxPlateforme.Text, ComboBoxGenreJeu.Text, ComboBoxAnnee.Text, textBoxPrixJeu.Text, ComboBoxStatut.Text);
                MessageBox.Show("Le jeu " + textBoxTitreJeu.Text + " a été ajouté à la bibliothèque");
            }
        }

        private void btnSupprJeu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                //SqlCommand cmd = new SqlCommand("delete FROM Jeux where Titre = '555'", conn);
                //SqlCommand cmd = new SqlCommand("delete FROM Jeux where Titre = @Titre", conn);
                //cmd.Parameters.AddWithValue("@Titre", textBoxTitreJeu.Text);
                SqlCommand cmd = new SqlCommand("delete FROM Jeux where ID = @IDSuppr", conn);
                //cmd.Parameters.AddWithValue("@IDSuppr", textBoxID.Text);

                cmd.Parameters.AddWithValue("@IDSuppr", idSuppr.ToString());


                //cmd.Parameters.AddWithValue("@id", dataGridView1.Columns["btnSupprimer"]);
                cmd.ExecuteNonQuery();


                /*Fonction Reload*/
                SqlDataAdapter da = new SqlDataAdapter("select * FROM Jeux", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // dataGridView1.DataSource = Form1.GetAllGames();

            //DataGridViewRow numeroLignedataGridView1 = dataGridView1.Rows[e.RowIndex];

            // btnSuppLigne


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int numeroLignedataGridView1 = (int)this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                conn.Open();

            
                //MessageBox.Show(numeroLignedataGridView1.ToString(), "Titre du MessageBox");
               

                idSuppr = numeroLignedataGridView1 ;

                /*Fonction Reload*/
                SqlDataAdapter da = new SqlDataAdapter("select * FROM Jeux", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            //  int numeroLignedataGridView1 = (int)this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            //MessageBox.Show((int)this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            //int numeroLignedataGridView1 = (int)this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
