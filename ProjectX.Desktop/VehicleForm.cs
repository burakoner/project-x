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
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private async void VehicleForm_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            using var client = new RestClient("https://localhost:7249");
            var req = new RestRequest("vehicles/list");
            var vehicles = await client.GetAsync<ApiResponse<List<Vehicle>>>(req);

            if (!vehicles.Success) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vehicles.Data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new VehicleAddForm(this);
            form.ShowDialog();
        }
    }
}
