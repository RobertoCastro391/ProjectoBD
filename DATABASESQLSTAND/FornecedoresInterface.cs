using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DATABASESQLSTAND
{
    public partial class FornecedoresInterface : Form
    {
        public FornecedoresInterface()
        {
            InitializeComponent();
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT STAND_Fornecedor.NIF, STAND_Entidade.nome, STAND_Entidade.telefone, STAND_Entidade.endereco, STAND_Entidade.email FROM STAND_Fornecedor INNER JOIN STAND_Entidade ON STAND_Fornecedor.NIF = STAND_Entidade.NIF", CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
