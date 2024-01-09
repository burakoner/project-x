using Newtonsoft.Json;
using ProjectX.Data.Database;
using ProjectX.Data.Models;
using ProjectX.Data.Models.Requests;
using RestSharp;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX.Desktop
{
    public partial class LoginForm : Form
    {
        public Form1 Form1;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Form1 form1)
        {
            this.Form1 = form1;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /* GET Örneği
            using var client = new RestClient("https://api.binance.com");
            var req = new RestRequest("api/v3/exchangeInfo");
            var resp = client.Get(req);
            var text = resp.Content;
            */

            var email = txtEmail.Text;
            var passw = txtPassword.Text;

            var loginRequest = new LoginRequest();
            loginRequest.Email = email;
            loginRequest.Password = passw;
            var loginJson = JsonConvert.SerializeObject(loginRequest);

            using var client = new RestClient("https://localhost:7249");
            var request = new RestRequest("Operator/login");
            request.AddJsonBody(loginJson);

            var response = await client.PostAsync(request);
            var responseText = response.Content;
            var responseObject = JsonConvert.DeserializeObject<ApiResponse<Operator>>(responseText);

            if (!responseObject.Success)
            {
                MessageBox.Show(responseObject.Error.Message);
                return;
            }

            var user = responseObject.Data;
            this.Form1.Kasiyer = user;

            MessageBox.Show("Hoşgeldiniz " + user.Adi + " " + user.Soyadi);
            this.Hide();
        }
    }
}
