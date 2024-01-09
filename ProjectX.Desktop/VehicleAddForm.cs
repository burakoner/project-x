using Newtonsoft.Json;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using RestSharp;
using System;
using System.Windows.Forms;

namespace ProjectX.Desktop
{
    public partial class VehicleAddForm : Form
    {
        public VehicleForm VehicleForm { get; set; }

        public VehicleAddForm()
        {
            InitializeComponent();
        }

        public VehicleAddForm(VehicleForm form)
        {
            this.VehicleForm = form;
            InitializeComponent();
        }

        private void VehicleAddForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = DateTime.Now.Year;
            numericUpDown1.Value = DateTime.Now.Year - 5;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var addRequest = new VehicleRequest
            {
                Marka = textBox1.Text,
                Model = textBox2.Text,
                YakitTuru = textBox3.Text,
                Yil = Convert.ToInt32(numericUpDown1.Value),
                DrivingLisenceClass = Data.Enums.EhliyetSinifi.B,
                Not = textBox5.Text,
            };
            var json = JsonConvert.SerializeObject(addRequest);

            using var api = new RestClient("https://localhost:7249");
            var request = new RestRequest("vehicles/add");
            request.AddJsonBody(json);

            var response = await api.PostAsync<ApiResponse<Vehicle>>(request);
            if (!response.Success)
            {
                MessageBox.Show(response.Error.Message);
                return;
            }

            var client = response.Data;

            MessageBox.Show("Kaydedildi");

            this.VehicleForm.button1_Click(sender, e);
        }
    }
}
