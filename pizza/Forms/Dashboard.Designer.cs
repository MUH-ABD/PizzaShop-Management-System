namespace pizza.Forms
{
    partial class Dashboard
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
            label1 = new Label();
            btnaddcustomer = new Button();
            btnupdatecustomer = new Button();
            btndeletecustomer = new Button();
            btndisplaydata = new Button();
            btnexit = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1492, 113);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnaddcustomer
            // 
            btnaddcustomer.FlatStyle = FlatStyle.Flat;
            btnaddcustomer.ForeColor = Color.White;
            btnaddcustomer.Location = new Point(15, 27);
            btnaddcustomer.Name = "btnaddcustomer";
            btnaddcustomer.Size = new Size(193, 43);
            btnaddcustomer.TabIndex = 2;
            btnaddcustomer.Text = "Add Customer";
            btnaddcustomer.UseVisualStyleBackColor = true;
            btnaddcustomer.Click += btnaddcustomer_Click;
            // 
            // btnupdatecustomer
            // 
            btnupdatecustomer.FlatStyle = FlatStyle.Flat;
            btnupdatecustomer.ForeColor = Color.White;
            btnupdatecustomer.Location = new Point(15, 77);
            btnupdatecustomer.Name = "btnupdatecustomer";
            btnupdatecustomer.Size = new Size(193, 43);
            btnupdatecustomer.TabIndex = 3;
            btnupdatecustomer.Text = "Update Customer";
            btnupdatecustomer.UseVisualStyleBackColor = true;
            btnupdatecustomer.Click += btnupdatecustomer_Click;
            // 
            // btndeletecustomer
            // 
            btndeletecustomer.FlatStyle = FlatStyle.Flat;
            btndeletecustomer.ForeColor = Color.White;
            btndeletecustomer.Location = new Point(15, 177);
            btndeletecustomer.Name = "btndeletecustomer";
            btndeletecustomer.Size = new Size(193, 43);
            btndeletecustomer.TabIndex = 4;
            btndeletecustomer.Text = "All Customer Data";
            btndeletecustomer.UseVisualStyleBackColor = true;
            btndeletecustomer.Click += btndeletecustomer_Click;
            // 
            // btndisplaydata
            // 
            btndisplaydata.FlatStyle = FlatStyle.Flat;
            btndisplaydata.ForeColor = Color.White;
            btndisplaydata.Location = new Point(15, 127);
            btndisplaydata.Name = "btndisplaydata";
            btndisplaydata.Size = new Size(193, 43);
            btndisplaydata.TabIndex = 6;
            btndisplaydata.Text = "Active Customer";
            btndisplaydata.UseVisualStyleBackColor = true;
            btndisplaydata.Click += btndisplaydata_Click_1;
            // 
            // btnexit
            // 
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(15, 580);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(193, 43);
            btnexit.TabIndex = 8;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(btnaddcustomer);
            panel1.Controls.Add(btndisplaydata);
            panel1.Controls.Add(btnupdatecustomer);
            panel1.Controls.Add(btndeletecustomer);
            panel1.Location = new Point(0, 113);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 642);
            panel1.TabIndex = 9;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.famingjia_inventor_hLKf8J8qAMg_unsplash1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1492, 755);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnaddcustomer;
        private Button btnupdatecustomer;
        private Button btndeletecustomer;
        private Button btndisplaydata;
        private Button btnexit;
        private Panel panel1;
    }
}