namespace TicketSystem.WinForms
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpCreateTicket;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCreate;

        private System.Windows.Forms.GroupBox grpTickets;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            lblHeader = new Label();
            grpCreateTicket = new GroupBox();
            textTitle = new TextBox();
            txtDescription = new TextBox();
            btnCreate = new Button();
            grpTickets = new GroupBox();
            dgvTickets = new DataGridView();
            btnLoad = new Button();
            grpComments = new GroupBox();
            dgvComments = new DataGridView();
            txtComment = new TextBox();
            btnAddComment = new Button();
            grpCreateTicket.SuspendLayout();
            grpTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            grpComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComments).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(20, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(400, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "🎫 User Ticket Dashboard";
            // 
            // grpCreateTicket
            // 
            grpCreateTicket.Controls.Add(textTitle);
            grpCreateTicket.Controls.Add(txtDescription);
            grpCreateTicket.Controls.Add(btnCreate);
            grpCreateTicket.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpCreateTicket.Location = new Point(20, 60);
            grpCreateTicket.Name = "grpCreateTicket";
            grpCreateTicket.Size = new Size(400, 250);
            grpCreateTicket.TabIndex = 1;
            grpCreateTicket.TabStop = false;
            grpCreateTicket.Text = "Create New Ticket";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(15, 35);
            textTitle.Name = "textTitle";
            textTitle.PlaceholderText = "Ticket Subject";
            textTitle.Size = new Size(360, 25);
            textTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(15, 70);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Describe your issue...";
            txtDescription.Size = new Size(360, 100);
            txtDescription.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(15, 185);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 35);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create Ticket";
            btnCreate.Click += btnCreate_Click;
            // 
            // grpTickets
            // 
            grpTickets.Controls.Add(dgvTickets);
            grpTickets.Controls.Add(btnLoad);
            grpTickets.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpTickets.Location = new Point(440, 60);
            grpTickets.Name = "grpTickets";
            grpTickets.Size = new Size(520, 300);
            grpTickets.TabIndex = 2;
            grpTickets.TabStop = false;
            grpTickets.Text = "My Tickets";
            // 
            // dgvTickets
            // 
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.BackgroundColor = Color.White;
            dgvTickets.Location = new Point(15, 30);
            dgvTickets.MultiSelect = false;
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowTemplate.Height = 30;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.Size = new Size(490, 220);
            dgvTickets.TabIndex = 0;
            dgvTickets.SelectionChanged += dgvTickets_SelectionChanged;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(15, 255);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(120, 35);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Tickets";
            btnLoad.Click += btnLoad_Click;
            // 
            // grpComments
            // 
            grpComments.Controls.Add(dgvComments);
            grpComments.Controls.Add(txtComment);
            grpComments.Controls.Add(btnAddComment);
            grpComments.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpComments.Location = new Point(20, 330);
            grpComments.Name = "grpComments";
            grpComments.Size = new Size(940, 260);
            grpComments.TabIndex = 3;
            grpComments.TabStop = false;
            grpComments.Text = "Ticket Comments";
            // 
            // dgvComments
            // 
            dgvComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComments.BackgroundColor = Color.White;
            dgvComments.Location = new Point(15, 30);
            dgvComments.Name = "dgvComments";
            dgvComments.ReadOnly = true;
            dgvComments.RowTemplate.Height = 28;
            dgvComments.Size = new Size(910, 150);
            dgvComments.TabIndex = 0;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(15, 190);
            txtComment.Name = "txtComment";
            txtComment.PlaceholderText = "Add a comment...";
            txtComment.Size = new Size(760, 25);
            txtComment.TabIndex = 1;
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(790, 185);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(135, 35);
            btnAddComment.TabIndex = 2;
            btnAddComment.Text = "Add Comment";
            btnAddComment.Click += btnAddComment_Click;
            // 
            // UserForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 620);
            Controls.Add(lblHeader);
            Controls.Add(grpCreateTicket);
            Controls.Add(grpTickets);
            Controls.Add(grpComments);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket Management System";
            grpCreateTicket.ResumeLayout(false);
            grpCreateTicket.PerformLayout();
            grpTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            grpComments.ResumeLayout(false);
            grpComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComments).EndInit();
            ResumeLayout(false);
        }
    }
}
