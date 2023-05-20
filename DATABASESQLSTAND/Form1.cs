namespace DATABASESQLSTAND
{
    public partial class Form1 : Form
    {
        BindingSource VeiculosbindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            VeiculosDAO veiculosDAO = new VeiculosDAO();

            VeiculosbindingSource.DataSource = veiculosDAO.getAllVeiculos();
            dataGridView1.DataSource = VeiculosbindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VeiculosDAO veiculosDAO = new VeiculosDAO();

            VeiculosbindingSource.DataSource = veiculosDAO.getAllVeiculos();
            dataGridView1.DataSource = VeiculosbindingSource;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            VeiculosDAO veiculosDAO = new VeiculosDAO();
            VeiculosbindingSource.DataSource = veiculosDAO.getAllVeiculos();
            dataGridView1.DataSource = VeiculosbindingSource;
        }
    }
}