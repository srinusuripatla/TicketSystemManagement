using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using TicketSystem.API.Models;

namespace TicketSystem.WinForms
{
    public partial class AdminForm : Form
    {
        private readonly int _adminUserId;
        public AdminForm(int? UserId)
        {
            InitializeComponent();
            _adminUserId = UserId ?? 1;

            Load += (s, e) => LoadTickets();
        }

        private async void LoadTickets()
        {
            try
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback =
                        (message, cert, chain, sslPolicyErrors) => true
                };

                using var client = new HttpClient(handler);

                string url =
                    $"https://localhost:7234/api/Ticketes/list?UserId={_adminUserId}&Role=Admin";

                var json = await client.GetStringAsync(url);

                var tickets = JsonConvert.DeserializeObject<List<Ticket>>(json);

                dgvTickets.AutoGenerateColumns = true;
                dgvTickets.DataSource = tickets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tickets: " + ex.Message);
            }
        }



        private async void LoadAdminComments(int ticketId)
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    (message, cert, chain, errors) => true
            };

            using var client = new HttpClient(handler);

            try
            {
                var json = await client.GetStringAsync(
                    $"https://localhost:7234/api/Ticketes/comments/{ticketId}");

                var comments = JsonConvert.DeserializeObject<List<Ticketcomment>>(json);

                dgvAdminComments.DataSource = comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load comments\n" + ex.Message);
            }
        }


        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
                return;

            int ticketId = Convert.ToInt32(
                dgvTickets.CurrentRow.Cells["TicketId"].Value
            );

            LoadAdminComments(ticketId);
        }


        private async void btnAssign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTicketId.Text) ||
                string.IsNullOrWhiteSpace(txtAssignTo.Text))
            {
                MessageBox.Show("Please enter Ticket Id and User Id");
                return;
            }

            var data = new
            {
                TicketId = int.Parse(txtTicketId.Text),
                AssignedTo = int.Parse(txtAssignTo.Text),
                AssignedBy = _adminUserId
            };

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                (message, cert, chain, sslPolicyErrors) => true
            };

            using var client = new HttpClient(handler);

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(
                "https://localhost:7234/api/Ticketes/assign",
                content
            );

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket assigned successfully");
                LoadTickets();
                txtTicketId.Clear();
                txtAssignTo.Clear();


            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Assign failed: " + error);
            }
        }


        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStatusTicketId.Text) ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please enter Ticket Id and select Status");
                return;
            }

            int ticketId = int.Parse(txtStatusTicketId.Text);
            string newStatus = cmbStatus.SelectedItem.ToString();
            int updatedBy = _adminUserId;

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    (message, cert, chain, errors) => true
            };

            using var client = new HttpClient(handler);

            string url =
                $"https://localhost:7234/api/Ticketes/status" +
                $"?ticketId={ticketId}" +
                $"&newStatus={newStatus}" +
                $"&updatedBy={updatedBy}";

            var response = await client.PutAsync(url, null);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Status updated successfully");
                LoadTickets();
                txtStatusTicketId.Clear();
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Update failed:\n" + error);
            }
        }

        private async void btnAddAdminComment_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Select a ticket first");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdminComment.Text))
            {
                MessageBox.Show("Enter comment");
                return;
            }

            int ticketId = Convert.ToInt32(
                dgvTickets.CurrentRow.Cells["TicketId"].Value);

            var request = new AddCommentRequest
            {
                TicketId = ticketId,
                Comment = txtAdminComment.Text,
                CommentedBy = _adminUserId
            };

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    (message, cert, chain, errors) => true
            };

            using var client = new HttpClient(handler);

            var content = new StringContent(
                JsonConvert.SerializeObject(request),
                Encoding.UTF8,
                "application/json");

            var response = await client.PostAsync(
                "https://localhost:7234/api/Ticketes/comment",
                content);

            if (response.IsSuccessStatusCode)
            {
                txtAdminComment.Clear();
                LoadAdminComments(ticketId); 
                MessageBox.Show("Comment added");
            }
            else
            {
                MessageBox.Show("Failed to add comment");
            }
        }

        
    }
}
