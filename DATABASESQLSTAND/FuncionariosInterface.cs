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
    public partial class FuncionariosInterface : Form
    {
        BindingSource FuncionariosbindingSource = new BindingSource();
        public FuncionariosInterface()
        {
            InitializeComponent();
            FuncionariosDAO funcionariosDAO = new FuncionariosDAO();

            FuncionariosbindingSource.DataSource = funcionariosDAO.getAllFuncionarios();
            dataGridView1.DataSource = FuncionariosbindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);
        }
    }
}
