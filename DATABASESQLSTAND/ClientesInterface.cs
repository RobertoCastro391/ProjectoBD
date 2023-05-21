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
    public partial class ClientesInterface : Form
    {
        BindingSource ClientesbindingSource = new BindingSource();
        public ClientesInterface()
        {
            InitializeComponent();
            ClientesDAO clientesDAO = new ClientesDAO();

            ClientesbindingSource.DataSource = clientesDAO.getAllClientes();
            dataGridView1.DataSource = ClientesbindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
