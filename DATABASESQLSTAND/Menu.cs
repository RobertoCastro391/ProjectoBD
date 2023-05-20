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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 veiculos = new Form1();
            veiculos.Show(this);
        }
        private void STANDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stands stands = new Stands();
            stands.Show(this);
        }

        private void CLIENTES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show(this);
        }

        private void FUNCIONÁRIOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Show(this);
        }

        private void FORNECEDORES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show(this);

        }

        private void REGISTO_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo registo = new Registo();
            registo.Show(this);

        }

        private void OPÇÕES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opçoes opcoes = new Opçoes();
            opcoes.Show(this);
        }
    }
}
