using Newtonsoft.Json;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using ProjectX.Desktop.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectX.Desktop
{
    public partial class SalesForm : Form
    {
        public Form1 MainForm { get; set; }

        public List<Client> Clients { get; set; } = [];
        public List<Vehicle> Vehicles { get; set; } = [];
        public List<Sale> Sales { get; set; } = [];
        public List<SatisDetayi> SatisDetaylari { get; set; } = [];

        public SalesForm()
        {
            InitializeComponent();
        }

        public SalesForm(Form1 form)
        {
            this.MainForm = form;
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SalesAddForm(this);
            form.ShowDialog();
        }

        public async void button2_Click(object sender, EventArgs e)
        {
            // Http Client
            using var api = new RestClient("https://localhost:7249");

            // Vehicles
            var clients = await api.GetAsync<ApiResponse<List<Client>>>(new RestRequest("clients/list"));
            var vehicles = await api.GetAsync<ApiResponse<List<Vehicle>>>(new RestRequest("vehicles/list"));
            var sales = await api.GetAsync<ApiResponse<List<Sale>>>(new RestRequest("sale/list"));

            // Check Point
            if (!clients.Success || !vehicles.Success || !sales.Success)
            {
                MessageBox.Show("Bir hata oluştu. Veriler alınamadı.");
                return;
            }

            // Set Data
            Clients = clients.Data;
            Vehicles = vehicles.Data;
            Sales = sales.Data;

            SatisDetaylari = new List<SatisDetayi>();
            foreach (var sale in sales.Data)
            {
                var satisDetayi = new SatisDetayi(sale);

                var client = clients.Data.FirstOrDefault(x => x.Id == sale.ClientId);
                if (client != null)
                {
                    satisDetayi.ClientName = client.Adi;
                    satisDetayi.ClientSurname = client.Soyadi;
                }

                var vehicle = vehicles.Data.FirstOrDefault(x => x.Id == sale.VehicleId);
                if (vehicle != null)
                {
                    satisDetayi.AracMarka = vehicle.Marka;
                    satisDetayi.AracModel = vehicle.Model;
                    satisDetayi.AracYil = vehicle.Yil;
                }

                SatisDetaylari.Add(satisDetayi);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SatisDetaylari;

            SatisDetaylari = new List<SatisDetayi>();
            foreach (var sale in sales.Data)
            {
                var satisDetayi = new SatisDetayi(sale);

                var client = clients.Data.FirstOrDefault(x => x.Id == sale.ClientId);
                if (client != null)
                {
                    satisDetayi.ClientName = client.Adi;
                    satisDetayi.ClientSurname = client.Soyadi;
                }

                var vehicle = vehicles.Data.FirstOrDefault(x => x.Id == sale.VehicleId);
                if (vehicle != null)
                {
                    satisDetayi.AracMarka = vehicle.Marka;
                    satisDetayi.AracModel = vehicle.Model;
                    satisDetayi.AracYil = vehicle.Yil;
                }

                SatisDetaylari.Add(satisDetayi);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow ==null) return;
            SatisDetayi satir = (SatisDetayi)dataGridView1.CurrentRow.DataBoundItem;


            var addRequest = new TakeACarRequest
            {
                SaleId = satir.Id,
                Notlar = satir.Notlar,
            };
            var json = JsonConvert.SerializeObject(addRequest);

            using var api = new RestClient("https://localhost:7249");
            var request = new RestRequest("sale/take");
            request.AddJsonBody(json);

            var response = await api.PostAsync<ApiResponse<Sale>>(request);
            if (!response.Success)
            {
                MessageBox.Show(response.Error.Message);
                return;
            }

            MessageBox.Show("Araç teslim alındı");  

            button2_Click(sender, e);
        }
    }
}
