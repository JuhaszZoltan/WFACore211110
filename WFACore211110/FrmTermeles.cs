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
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            var reader = new SqlCommand(
                "SELECT Datum, Szin, Mennyiseg, Nev " +
                "FROM Nyul " +
                "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                "INNER JOIN Tojas ON TipusId = Tojas.Id;",
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
