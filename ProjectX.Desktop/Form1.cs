using ProjectX.Data.Database;
using System.Windows.Forms;

namespace ProjectX.Desktop
{
    public partial class Form1 : Form
    {
        public Operator Kasiyer { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var form = new LoginForm(this);
            form.ShowDialog();
        }

        private void operatorleriGosterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new OperatorForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void musterileriGosterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new ClientForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void araclariGosterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new VehicleForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void satislariGosterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new SalesForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
