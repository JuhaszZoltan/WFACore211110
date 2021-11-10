using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WFACore211110
{
    public partial class FrmStatisztika : Form
    {
        public string ConnectionString { get; set; }

        public FrmStatisztika(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmStatisztika_Load(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var reader = new SqlCommand("SELECT Nev FROM Nyul;", connection)
                .ExecuteReader();
            while (reader.Read()) cbMunkas.Items.Add(reader[0]);
            reader.Close();
            cbMunkas.SelectedIndex = 0;
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            dgvStat.Rows.Clear();

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            var reader = new SqlCommand(
                "SELECT Datum, Szin, Mennyiseg " +
                "FROM Nyul " +
                "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                $"WHERE Nev LIKE '{cbMunkas.Text}' " +
                $"AND MONTH(Datum) = {nudHonap.Value} " +
                "ORDER BY Datum ASC;",
                connection).ExecuteReader();

            while (reader.Read())
            {
                dgvStat.Rows.Add(
                    reader.GetDateTime(0).ToString("yyyy-MM-dd"),
                    reader[1],
                    reader[2] + " db");
            }
            reader.Close();

            if (dgvStat.Rows.Count != 0)
            {
                reader = new SqlCommand(
                    "SELECT TOP 1 Szin, SUM(Mennyiseg) " +
                    "FROM Nyul " +
                    "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                    "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                    $"WHERE Nev LIKE '{cbMunkas.Text}' " +
                    $"AND MONTH(Datum) = {nudHonap.Value} " +
                    "GROUP BY Szin " +
                    "ORDER BY SUM(Mennyiseg) DESC;",
                    connection).ExecuteReader();
                reader.Read();
                tbSzinDB.Text = $"{reader[0]}, ({reader[1]} db)";
                reader.Close();

                reader = new SqlCommand(
                    "SELECT SUM(Suly * Mennyiseg) " +
                    "FROM Nyul " +
                    "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                    "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                    $"WHERE Nev LIKE '{cbMunkas.Text}' " +
                    $"AND MONTH(Datum) = {nudHonap.Value};",
                    connection).ExecuteReader();
                reader.Read();
                tbSulySum.Text = $"{reader.GetInt32(0) / 1000F} Kg";
            }
        }
        private void NudHonap_ValueChanged(object sender, EventArgs e)
            => UpdateDGV();
        private void CbMunkas_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateDGV();
    }
}
