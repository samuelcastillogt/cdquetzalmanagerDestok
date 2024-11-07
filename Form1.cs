namespace CduetzalDestok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}