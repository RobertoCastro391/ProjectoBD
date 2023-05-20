namespace DATABASESQLSTAND
{
    public partial class Form1 : Form
    {
        BindingSource VeiculosbindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            VeiculosDAO veiculosDAO = new VeiculosDAO();
            

            VeiculosbindingSource.DataSource = veiculosDAO.getAllVeiculos();
            dataGridView1.DataSource = VeiculosbindingSource;
        }
    }
}