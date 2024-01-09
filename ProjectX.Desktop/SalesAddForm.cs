using Newtonsoft.Json;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using RestSharp;
using System;
using System.Windows.Forms;

namespace ProjectX.Desktop
{
    public partial class SalesAddForm : Form
    {
        public SalesForm SalesForm { get; set; }

        public SalesAddForm()
        {
            InitializeComponent();
        }

        public SalesAddForm(SalesForm form)
        {
            this.SalesForm = form;
            InitializeComponent();
        }

        private void SalesAddForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SalesForm.Vehicles;
            comboBox2.DataSource = SalesForm.Clients;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var vehicleId = (int)comboBox1.SelectedValue;
            var clientId = (int)comboBox2.SelectedValue;


            var addRequest = new RentACarRequest
            {
                VehicleId = vehicleId,
                ClientId = clientId,
                OperatorId = this.SalesForm.MainForm.Kasiyer.Id,
                GunSayisi = Convert.ToInt32(numericUpDown1.Value),
                GunlukKiraBedeli = Convert.ToDecimal(numericUpDown2.Value),
                YakitMiktari = Convert.ToDecimal(numericUpDown3.Value),
                Notlar = textBox1.Text,
            };
            var json = JsonConvert.SerializeObject(addRequest);

            using var api = new RestClient("https://localhost:7249");
            var request = new RestRequest("sale/rent");
            request.AddJsonBody(json);

            var response = await api.PostAsync<ApiResponse<Sale>>(request);
            if (!response.Success)
            {
                MessageBox.Show(response.Error.Message);
                return;
            }

            MessageBox.Show("Araç Kiralandı");

            this.SalesForm.button2_Click(sender, e);
        }
    }
}
