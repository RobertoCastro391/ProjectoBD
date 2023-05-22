using Microsoft.Data.SqlClient;
using System.Data;

namespace DATABASESQLSTAND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT STAND_Veiculos.Matricula, STAND_MarcasCarros.Marca, STAND_Veiculos.Modelo, STAND_CorVeiculo.Cor , STAND_Veiculos.Cilindrada, STAND_Veiculos.Ano, STAND_Veiculos.Quilometros, STAND_Combustiveis.Combustivel, STAND_CategoriaVeiculos.Categoria, STAND_Veiculos.Preco_Anunciado,STAND.Nome, STAND_Veiculos.Observações FROM STAND_Veiculos INNER JOIN STAND_MarcasCarros ON STAND_MarcasCarros.id = STAND_Veiculos.id_Marca INNER JOIN STAND ON STAND.id = STAND_Veiculos.id_Stand INNER JOIN STAND_CategoriaVeiculos ON STAND_CategoriaVeiculos.id = STAND_Veiculos.id_Categoria INNER JOIN STAND_CorVeiculo ON STAND_CorVeiculo.id = STAND_Veiculos.id_Cor INNER JOIN STAND_Combustiveis ON STAND_Combustiveis.id = STAND_Veiculos.id_Combustivel", CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
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
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT STAND_CompraVeiculo.NIF_Fornecedor, STAND_Entidade.nome AS Nome_Fornecedor,  STAND_CompraVeiculo.Matricula_Veiculo AS Matricula, STAND_MarcasCarros.Marca, STAND_Veiculos.Modelo, STAND_CorVeiculo.Cor , STAND_Veiculos.Cilindrada, STAND_Veiculos.Ano, STAND_Veiculos.Quilometros, STAND_Combustiveis.Combustivel, STAND_CategoriaVeiculos.Categoria, STAND_Veiculos.Preco_Anunciado,STAND.Nome AS Nome_Stand, STAND_Veiculos.Observações FROM STAND_CompraVeiculo INNER JOIN STAND_Veiculos ON STAND_Veiculos.Matricula = STAND_CompraVeiculo.Matricula_Veiculo INNER JOIN STAND_Entidade ON STAND_Entidade.NIF = STAND_CompraVeiculo.NIF_Fornecedor INNER JOIN STAND_MarcasCarros ON STAND_MarcasCarros.id = STAND_Veiculos.id_Marca INNER JOIN STAND ON STAND.id = STAND_Veiculos.id_Stand INNER JOIN STAND_CategoriaVeiculos ON STAND_CategoriaVeiculos.id = STAND_Veiculos.id_Categoria INNER JOIN STAND_CorVeiculo ON STAND_CorVeiculo.id = STAND_Veiculos.id_Cor INNER JOIN STAND_Combustiveis ON STAND_Combustiveis.id = STAND_Veiculos.id_Combustivel", CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT STAND_Veiculos.Matricula, STAND_MarcasCarros.Marca, STAND_Veiculos.Modelo, STAND_CorVeiculo.Cor , STAND_Veiculos.Cilindrada, STAND_Veiculos.Ano, STAND_Veiculos.Quilometros, STAND_Combustiveis.Combustivel, STAND_CategoriaVeiculos.Categoria, STAND_Veiculos.Preco_Anunciado,STAND.Nome, STAND_Veiculos.Observações FROM STAND_Veiculos INNER JOIN STAND_MarcasCarros ON STAND_MarcasCarros.id = STAND_Veiculos.id_Marca INNER JOIN STAND ON STAND.id = STAND_Veiculos.id_Stand INNER JOIN STAND_CategoriaVeiculos ON STAND_CategoriaVeiculos.id = STAND_Veiculos.id_Categoria INNER JOIN STAND_CorVeiculo ON STAND_CorVeiculo.id = STAND_Veiculos.id_Cor INNER JOIN STAND_Combustiveis ON STAND_Combustiveis.id = STAND_Veiculos.id_Combustivel", CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();

        }
    }
}