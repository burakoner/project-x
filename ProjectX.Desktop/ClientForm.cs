using ProjectX.Data.Database;
using ProjectX.Data.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.Desktop
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private async void ClientForm_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ClientAddForm(this);
            form.ShowDialog();
        }

        public async void button2_Click(object sender, EventArgs e)
        {
            using var client = new RestClient("https://localhost:7249");
            var req = new RestRequest("clients/list");
            var users = await client.GetAsync<ApiResponse<List<Client>>>(req);

            if (!users.Success) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users.Data;
        }
    }
}
