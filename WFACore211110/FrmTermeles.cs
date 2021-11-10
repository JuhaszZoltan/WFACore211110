using Microsoft.Data.SqlClient;

namespace WFACore211110
{
    public partial class FrmTermeles : Form
    {
        public string ConnectionString { get; set; }
        public FrmTermeles(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e)
        {
            UpdateDGV();

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            var reader = new SqlCommand("SELECT Szin FROM Tojas;", connection)
                .ExecuteReader();
            while (reader.Read()) cbTojas.Items.Add(reader[0]);
            reader.Close();

            reader = new SqlCommand("SELECT Nev FROM Nyul;", connection)
                .ExecuteReader();
            while (reader.Read()) cbMunkas.Items.Add(reader[0]);
            reader.Close();

            cbTojas.SelectedIndex = 0;
            cbMunkas.SelectedIndex = 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            var reader = new SqlCommand(
                $"SELECT Id FROM Nyul WHERE Nev LIKE '{cbMunkas.Text}';",
                connection).ExecuteReader();
            reader.Read();
            int nyulID = reader.GetInt32(0);
            reader.Close();

            reader = new SqlCommand(
                $"SELECT Id FROM Tojas WHERE Szin LIKE '{cbTojas.Text}';",
                connection).ExecuteReader();
            reader.Read();
            int tojasID = reader.GetInt32(0);
            reader.Close();

            new SqlCommand(
                "INSERT INTO Termeles VALUES " +
                $"('{dtpDatum.Value.ToString("yyyy-MM-dd")}', {tojasID}, {nyulID}, {nudDB.Value});",
                connection).ExecuteNonQuery();

            MessageBox.Show("bejegyzés rögzítése megtörtént!");

            UpdateDGV();
        }

        private void UpdateDGV()
        {
            dgvTermeles.Rows.Clear();

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            var reader = new SqlCommand(
                "SELECT Datum, Szin, Mennyiseg, Nev " +
                "FROM Nyul " +
                "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                "ORDER BY Datum ASC;",
                connection).ExecuteReader();

            while (reader.Read())
            {
                dgvTermeles.Rows.Add(
                    reader.GetDateTime(0).ToString("yyyy-MM-dd"),
                    reader[1],
                    reader[2] + " db",
                    reader[3]);
            }
        }
    }
}
