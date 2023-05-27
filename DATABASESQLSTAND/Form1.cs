using Microsoft.Data.SqlClient;
using System.Data;

namespace DATABASESQLSTAND
{
    public partial class Form1 : Form
    {
        private int lastButtonIndex = -1;

        private string matricula = "";
        private string marca = "";
        private string modelo = "";
        private string cor = "";
        private string cilindrada = "";
        private string ano = "";
        private string quilometros = "";
        private string combustivel = "";
        private string categoria = "";
        private string preco_anunciado = "";
        private string nomeStand = "";
        private string obs = "";

        public Form1()
        {
            InitializeComponent();
            loadDataTodos();
            loadMarcas();
            loadCores();
            loadCombustiveis();
            loadCategorias();
            loadStandNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            lastButtonIndex = 1; // Set the last button index to 1
            loadDataComprados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastButtonIndex = 2; // Set the last button index to 2
            loadDataVendidos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lastButtonIndex = 3; // Set the last button index to 3
            loadDataEmStock();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lastButtonIndex = -1; // Set the last button index to -1 (no button pressed)
            loadDataTodos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchColumn = comboBox1.SelectedItem.ToString();
                string searchText = textBox1.Text;

                switch (lastButtonIndex)
                {
                    case 1:
                        loadDataComprados(searchColumn, searchText);
                        break;
                    case 2:
                        loadDataVendidos(searchColumn, searchText);
                        break;
                    case 3:
                        loadDataEmStock(searchColumn, searchText);
                        break;
                    default:
                        loadDataTodos(searchColumn, searchText);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \r\n" + ex.Message, "ERRO", MessageBoxButtons.OK);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Extract the category name from the selected row
                textBox2.Text = row.Cells["Matricula"].Value.ToString();
                comboBox2.SelectedItem = row.Cells["Marca"].Value.ToString();
                textBox4.Text = row.Cells["Modelo"].Value.ToString();
                comboBox3.SelectedItem = row.Cells["Cor"].Value.ToString();
                textBox7.Text = row.Cells["Cilindrada"].Value.ToString();
                textBox6.Text = row.Cells["Ano"].Value.ToString();
                textBox10.Text = row.Cells["Quilometros"].Value.ToString();
                comboBox5.SelectedItem = row.Cells["Combustivel"].Value.ToString();
                comboBox4.SelectedItem = row.Cells["Categoria"].Value.ToString();
                textBox11.Text = row.Cells["Preco_Anunciado"].Value.ToString();
                comboBox6.SelectedItem = row.Cells["Nome_Stand"].Value.ToString();
                textBox13.Text = row.Cells["Observações"].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            matricula = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            modelo = textBox4.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            cilindrada = textBox7.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ano = textBox6.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            quilometros = textBox10.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            preco_anunciado = textBox11.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            obs = textBox13.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            marca = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cor = comboBox3.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            combustivel = comboBox5.SelectedItem.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria = comboBox4.SelectedItem.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeStand = comboBox6.SelectedItem.ToString();
        }

        public void loadDataTodos(string column = "", string searchText = "")
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            string query = "SELECT * FROM STAND_ViewTodosVeiculos";

            if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(searchText))
            {
                query += " WHERE " + column + " LIKE '%" + searchText + "%'";
            }

            SqlCommand cmd = new SqlCommand(query, CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }

        public void loadDataEmStock(string column = "", string searchText = "")
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            string query = "SELECT * FROM STAND_ViewEmStockVeiculos";

            // Modify the query if column and search text are provided
            if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(searchText))
            {
                query += " WHERE " + column + " LIKE '%" + searchText + "%'";
            }

            SqlCommand cmd = new SqlCommand(query, CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }

        public void loadDataComprados(string column = "", string searchText = "")
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            string query = "SELECT * FROM STAND_ViewVeiculosComprados";

            // Modify the query if column and search text are provided
            if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(searchText))
            {
                query += " WHERE " + column + " LIKE '%" + searchText + "%'";
            }

            SqlCommand cmd = new SqlCommand(query, CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }

        public void loadDataVendidos(string column = "", string searchText = "")
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            string query = "SELECT * FROM STAND_ViewVeiculosVendidos";

            // Modify the query if column and search text are provided
            if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(searchText))
            {
                query += " WHERE " + column + " LIKE '%" + searchText + "%'";
            }

            SqlCommand cmd = new SqlCommand(query, CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }

        private void loadStandNames()
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nome FROM STAND_ViewStands", CN);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string standName = reader["Nome"].ToString();
                comboBox6.Items.Add(standName);
            }

            reader.Close();
            CN.Close();
        }

        public void loadMarcas()
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT Marca FROM STAND_ViewMarcasVeiculos", CN);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string standName = reader["Marca"].ToString();
                comboBox2.Items.Add(standName);
            }

            reader.Close();
            CN.Close();
        }

        public void loadCores()
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT Cor FROM STAND_ViewCorVeiculos", CN);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string standName = reader["Cor"].ToString();
                comboBox3.Items.Add(standName);
            }

            reader.Close();
            CN.Close();
        }

        public void loadCombustiveis()
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT Combustivel FROM STAND_ViewCombustiveis", CN);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string standName = reader["Combustivel"].ToString();
                comboBox5.Items.Add(standName);
            }

            reader.Close();
            CN.Close();
        }

        public void loadCategorias()
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT Categoria FROM STAND_ViewCategoriaVeiculos", CN);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string standName = reader["Categoria"].ToString();
                comboBox4.Items.Add(standName);
            }

            reader.Close();
            CN.Close();
        }
    }
}