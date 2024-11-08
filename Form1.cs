namespace CduetzalDestok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                int nummm = new APIService().GetCount();
                label1.Text = $"El numero de negocios registrados es {nummm}";
            }
            catch
            {
                MessageBox.Show("ERRR");
            };
        }




        private void inicoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void negociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void agregarNuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form fbBusines = new Bussines();
            fbBusines.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fDelete = new Form2();
            fDelete.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}