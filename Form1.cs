using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace DB_ACT1_046_Pattaguan
{
    public partial class Form1 : Form
    {
        string connectionStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306;";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            carFun();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            dtgResults.DataSource = null;
            cboBrand.SelectedIndex = -1;
        }

        void carFun()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MODEL");
            dt.Columns.Add("BRAND");
            dt.Columns.Add("YEAR");

            conn = new MySqlConnection(connectionStr);
            string query = "select model, brand, year from car where model like '%" + txtKeyword.Text + "%' and brand= '" + cboBrand.Text + "' ";
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgResults.DataSource = dt;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            carFun();
        }
    }
}
