using Newtonsoft.Json;
using ProjectX.Data.Database;
using ProjectX.Data.Models.Requests;
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
    public partial class ClientAddForm : Form
    {
        public ClientForm ClientForm { get; set; }

        public ClientAddForm()
        {
            InitializeComponent();
        }

        public ClientAddForm(ClientForm clientForm)
        {
            this.ClientForm = clientForm;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var addRequest = new ClientAddRequest
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                City = textBox3.Text,
                Identity = textBox4.Text,
                DrivingLisenceClass = Data.Enums.EhliyetSinifi.B,
                Notes = textBox5.Text,
            };
            var json = JsonConvert.SerializeObject(addRequest);

            using var api = new RestClient("https://localhost:7249");
            var request = new RestRequest("clients/add");
            request.AddJsonBody(json);

            var response = await api.PostAsync<ApiResponse<Client>>(request);
            if (!response.Success)
            {
                MessageBox.Show(response.Error.Message);
                return;
            }

            var client = response.Data;

            MessageBox.Show("Kaydedildi");


            this.ClientForm.button2_Click(sender, e);
        }
    }
}
