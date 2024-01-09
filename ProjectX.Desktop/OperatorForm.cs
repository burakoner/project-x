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
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        private async void OperatorForm_Load(object sender, EventArgs e)
        {
            using var client = new RestClient("https://localhost:7249");
            var req = new RestRequest("Operator/all");
            var users = await client.GetAsync<ApiResponse<List<Operator>>>(req);

            if (!users.Success) return;

            dataGridView1.DataSource = users.Data; 
        }
    }
}
