namespace WFACore211110
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }
        public FrmMain()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = TojasGyar;";
            InitializeComponent();
        }
        private void btnTermeles_Click(object sender, EventArgs e)
            => new FrmTermeles(ConnectionString).ShowDialog();
        private void BtnExit_Click(object sender, EventArgs e)
            => Application.Exit();

    }
}