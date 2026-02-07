using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Data;
using System.DirectoryServices;
using System.Text;
using System.Net.Http;
using TicketSystem.API.Models;


namespace TicketSystem.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private async void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter Username and Password");
                    return;
            }
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true
            };
            using var client = new HttpClient(handler);

            var loginObj = new LoginRequest
            {
                UserName= txtUsername.Text,
                Password = txtPassword.Text
            };

            var json = JsonConvert.SerializeObject(loginObj);
            var content = new StringContent(json, Encoding.UTF8,"application/json");

            var response = await client.PostAsync("https://localhost:7234/api/auth/login", content);

            if (!response.IsSuccessStatusCode) 
            {
                MessageBox.Show("Invaild username and  Password");
                return ;
            }

            var result = await response.Content.ReadAsStringAsync();
            API.Models.User user = JsonConvert.DeserializeObject<API.Models.User>(result);

            int? UserId = user.UserId;
            string Role = user.Role;
            MessageBox.Show($"Login successful. Role: {Role}");

            if (Role == "Admin")
            {
                var adminForm = new AdminForm(UserId);
                adminForm.Show();
            }
            else
            {
                var userForm = new UserForm(UserId);
                userForm.Show();
            }

           

            this.Hide();
        }
    }
}
