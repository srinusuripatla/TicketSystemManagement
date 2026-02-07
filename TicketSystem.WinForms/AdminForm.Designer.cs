namespace TicketSystem.WinForms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridView dgvAdminComments;

        private System.Windows.Forms.GroupBox grpTickets;
        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.GroupBox grpActions;

        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.TextBox txtAssignTo;
        private System.Windows.Forms.Button btnAssign;

        private System.Windows.Forms.TextBox txtStatusTicketId;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUpdateStatus;

        private System.Windows.Forms.TextBox txtAdminComment;
        private System.Windows.Forms.Button btnAddAdminComment;

        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.Label lblStatusTicketId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblComment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            dgvTickets = new DataGridView();
            dgvAdminComments = new DataGridView();
            grpTickets = new GroupBox();
            grpComments = new GroupBox();
            grpActions = new GroupBox();
            lblTicketId = new Label();
            txtTicketId = new TextBox();
            lblAssignTo = new Label();
            txtAssignTo = new TextBox();
            btnAssign = new Button();
            lblStatusTicketId = new Label();
            txtStatusTicketId = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            lblComment = new Label();
            txtAdminComment = new TextBox();
            btnAddAdminComment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdminComments).BeginInit();
            grpTickets.SuspendLayout();
            grpComments.SuspendLayout();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.Dock = DockStyle.Fill;
            dgvTickets.Location = new Point(3, 19);
            dgvTickets.MultiSelect = false;
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersVisible = false;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.Size = new Size(744, 298);
            dgvTickets.TabIndex = 0;
            dgvTickets.SelectionChanged += dgvTickets_SelectionChanged;
            // 
            // dgvAdminComments
            // 
            dgvAdminComments.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = Color.Honeydew;
            dgvAdminComments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvAdminComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminComments.BackgroundColor = Color.White;
            dgvAdminComments.Dock = DockStyle.Fill;
            dgvAdminComments.Location = new Point(3, 19);
            dgvAdminComments.Name = "dgvAdminComments";
            dgvAdminComments.ReadOnly = true;
            dgvAdminComments.RowHeadersVisible = false;
            dgvAdminComments.Size = new Size(744, 278);
            dgvAdminComments.TabIndex = 0;
            // 
            // grpTickets
            // 
            grpTickets.Controls.Add(dgvTickets);
            grpTickets.Location = new Point(10, 10);
            grpTickets.Name = "grpTickets";
            grpTickets.Size = new Size(750, 320);
            grpTickets.TabIndex = 0;
            grpTickets.TabStop = false;
            grpTickets.Text = "Tickets";
            // 
            // grpComments
            // 
            grpComments.Controls.Add(dgvAdminComments);
            grpComments.Location = new Point(10, 340);
            grpComments.Name = "grpComments";
            grpComments.Size = new Size(750, 300);
            grpComments.TabIndex = 1;
            grpComments.TabStop = false;
            grpComments.Text = "Admin / User Comments";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(lblTicketId);
            grpActions.Controls.Add(txtTicketId);
            grpActions.Controls.Add(lblAssignTo);
            grpActions.Controls.Add(txtAssignTo);
            grpActions.Controls.Add(btnAssign);
            grpActions.Controls.Add(lblStatusTicketId);
            grpActions.Controls.Add(txtStatusTicketId);
            grpActions.Controls.Add(lblStatus);
            grpActions.Controls.Add(cmbStatus);
            grpActions.Controls.Add(btnUpdateStatus);
            grpActions.Controls.Add(lblComment);
            grpActions.Controls.Add(txtAdminComment);
            grpActions.Controls.Add(btnAddAdminComment);
            grpActions.Location = new Point(780, 10);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(400, 630);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Admin Actions";
            // 
            // lblTicketId
            // 
            lblTicketId.Location = new Point(20, 40);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(80, 20);
            lblTicketId.TabIndex = 0;
            lblTicketId.Text = "Ticket ID";
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(120, 38);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(100, 23);
            txtTicketId.TabIndex = 1;
            // 
            // lblAssignTo
            // 
            lblAssignTo.Location = new Point(20, 75);
            lblAssignTo.Name = "lblAssignTo";
            lblAssignTo.Size = new Size(120, 20);
            lblAssignTo.TabIndex = 2;
            lblAssignTo.Text = "Assign To (User ID)";
            // 
            // txtAssignTo
            // 
            txtAssignTo.Location = new Point(150, 73);
            txtAssignTo.Name = "txtAssignTo";
            txtAssignTo.Size = new Size(100, 23);
            txtAssignTo.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(20, 110);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(230, 35);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Ticket";
            btnAssign.Click += btnAssign_Click;
            // 
            // lblStatusTicketId
            // 
            lblStatusTicketId.Location = new Point(20, 170);
            lblStatusTicketId.Name = "lblStatusTicketId";
            lblStatusTicketId.Size = new Size(80, 20);
            lblStatusTicketId.TabIndex = 5;
            lblStatusTicketId.Text = "Ticket ID";
            // 
            // txtStatusTicketId
            // 
            txtStatusTicketId.Location = new Point(120, 168);
            txtStatusTicketId.Name = "txtStatusTicketId";
            txtStatusTicketId.Size = new Size(100, 23);
            txtStatusTicketId.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(20, 205);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Open", "In Progress", "Resolved", "Closed" });
            cmbStatus.Location = new Point(120, 203);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 23);
            cmbStatus.TabIndex = 8;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(20, 240);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(250, 35);
            btnUpdateStatus.TabIndex = 9;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // lblComment
            // 
            lblComment.Location = new Point(20, 300);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(120, 20);
            lblComment.TabIndex = 10;
            lblComment.Text = "Admin Comment";
            // 
            // txtAdminComment
            // 
            txtAdminComment.Location = new Point(20, 325);
            txtAdminComment.Multiline = true;
            txtAdminComment.Name = "txtAdminComment";
            txtAdminComment.ScrollBars = ScrollBars.Vertical;
            txtAdminComment.Size = new Size(350, 150);
            txtAdminComment.TabIndex = 11;
            // 
            // btnAddAdminComment
            // 
            btnAddAdminComment.Location = new Point(20, 485);
            btnAddAdminComment.Name = "btnAddAdminComment";
            btnAddAdminComment.Size = new Size(250, 35);
            btnAddAdminComment.TabIndex = 12;
            btnAddAdminComment.Text = "Add Comment";
            btnAddAdminComment.Click += btnAddAdminComment_Click;
            // 
            // AdminForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 700);
            Controls.Add(grpTickets);
            Controls.Add(grpComments);
            Controls.Add(grpActions);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard - Ticket Management";
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdminComments).EndInit();
            grpTickets.ResumeLayout(false);
            grpComments.ResumeLayout(false);
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            ResumeLayout(false);
        }
    }
}
