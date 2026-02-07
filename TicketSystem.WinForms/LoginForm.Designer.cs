namespace TicketSystem.WinForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            PlnLogin = new TableLayoutPanel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            PlnLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PlnLogin
            // 
            PlnLogin.Anchor = AnchorStyles.None;
            PlnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlnLogin.ColumnCount = 2;
            PlnLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PlnLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PlnLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PlnLogin.Controls.Add(txtPassword, 1, 1);
            PlnLogin.Controls.Add(label2, 0, 1);
            PlnLogin.Controls.Add(txtUsername, 1, 0);
            PlnLogin.Controls.Add(label1, 0, 0);
            PlnLogin.Controls.Add(button1, 0, 2);
            PlnLogin.Location = new Point(251, 143);
            PlnLogin.Name = "PlnLogin";
            PlnLogin.RowCount = 3;
            PlnLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 54F));
            PlnLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 46F));
            PlnLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            PlnLogin.Size = new Size(240, 104);
            PlnLogin.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(123, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(123, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(3, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(PlnLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PlnLogin.ResumeLayout(false);
            PlnLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel PlnLogin;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private Button button1;
        private TextBox txtPassword;
    }
}
