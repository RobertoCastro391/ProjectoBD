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
    public partial class StandsInterface : Form
    {
        BindingSource StandsbindingSource = new BindingSource();
        public StandsInterface()
        {
            InitializeComponent();
            StandsDAO standsDAO = new StandsDAO();

            StandsbindingSource.DataSource = standsDAO.getAllStands();
            dataGridView1.DataSource = StandsbindingSource;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
