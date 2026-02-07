using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using TicketSystem.API.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace TicketSystem.WinForms
{
    public partial class UserForm : Form
    {


        private readonly int _userId;

        public UserForm(int? UserId)
        {
            InitializeComponent();
            _userId = UserId ?? -1;
        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true

            };
            using var client = new HttpClient(handler);
            var ticket = new CreateTicket
            {
                Subject = textTitle.Text,
                Description = txtDescription.Text,
                CreatedBy = _userId

            };

            var json = JsonConvert.SerializeObject(ticket);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7234/api/Ticketes/create", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Tickte is created successfull");
                textTitle.Clear();
                txtDescription.Clear();


            }
            else
                MessageBox.Show("Failed to create ticket");

        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMyTickets();
        }
        private async void LoadMyTickets()

        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true

            };
            using var client = new HttpClient(handler);

            var json = await client.GetStringAsync($"https://localhost:7234/api/Ticketes/list?userId={_userId}&role=User");


            var tickets = JsonConvert.DeserializeObject<List<Ticket>>(json);


            dgvTickets.DataSource = tickets;
        }
        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                int ticketId = Convert.ToInt32(
                    dgvTickets.SelectedRows[0].Cells["TicketId"].Value);

                LoadComments(ticketId);
            }
        }
        private async void LoadComments(int ticketId)
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => true
            };

            using var client = new HttpClient(handler);

            var json = await client.GetStringAsync(
                $"https://localhost:7234/api/Ticketes/comments/{ticketId}");

            var comments = JsonConvert.DeserializeObject<List<Ticketcomment>>(json);
            dgvComments.DataSource = comments;
        }


        private async void btnAddComment_Click(object sender, EventArgs e)
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true

            };
            using var client = new HttpClient(handler);
            if (dgvTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a ticket first");
                return;
            }

            int ticketId = Convert.ToInt32(
                dgvTickets.SelectedRows[0].Cells["TicketId"].Value);

            var data = new
            {
                TicketId = ticketId,
                Comment = txtComment.Text,
                CommentedBy = _userId
            };

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(
                "https://localhost:7234/api/Ticketes/comment", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Comment added");
                txtComment.Clear();
                LoadComments(ticketId);
            }
        }

       
    }
}
