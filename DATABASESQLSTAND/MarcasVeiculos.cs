﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASESQLSTAND
{
    public partial class MarcasVeiculos : Form
    {
        private string Marca_Veiculo = "";
        public MarcasVeiculos()
        {
            InitializeComponent();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opçoes Opçoes = new Opçoes();
            Opçoes.Show(this);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Set the category name in the textBox1 input field
                textBox1.Text = row.Cells["Marca"].Value.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Marca_Veiculo != "")
            {
                try
                {
                    SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
                    CN.Open();
                    SqlCommand cmd = new SqlCommand("dbo.STAND_AdicionarMarca", CN);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@marca", Marca_Veiculo);
                    cmd.ExecuteNonQuery();
                    CN.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: \r\n" + ex.Message, "ERRO", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha a marca !");
            }
            loadData();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Marca_Veiculo = textBox1.Text;
        }

        public void loadData()
        {
            SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true");
            CN.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STAND_ViewMarcasVeiculos", CN);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(detailsTable);
            dataGridView1.DataSource = detailsTable;
            dataGridView1.Visible = true;
            CN.Close();
        }
    }
}
