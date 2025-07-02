using System.Windows.Forms;

namespace pizza
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtpassword = new Label();
            txtusername = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            chkShowPassword = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 167);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.BackColor = Color.Transparent;
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.ForeColor = Color.White;
            txtpassword.Location = new Point(154, 227);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(123, 32);
            txtpassword.TabIndex = 2;
            txtpassword.Text = "Password :";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(298, 170);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(235, 31);
            txtusername.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.White;
            txtpass.ForeColor = Color.Black;
            txtpass.Location = new Point(298, 230);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(235, 31);
            txtpass.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Transparent;
            btnlogin.BackgroundImageLayout = ImageLayout.None;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(394, 324);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(139, 52);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Transparent;
            btnexit.BackgroundImageLayout = ImageLayout.None;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(582, 533);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(134, 60);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.White;
            chkShowPassword.Location = new Point(298, 267);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(156, 40);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(719, 111);
            label1.TabIndex = 8;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(719, 593);
            Controls.Add(label1);
            Controls.Add(chkShowPassword);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label txtpassword;
        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnexit;
        private CheckBox chkShowPassword;
        private Label label1;
    }
}