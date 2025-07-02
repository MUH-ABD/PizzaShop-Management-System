namespace pizza.Forms
{
    partial class Addcustomer
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
            lbl1 = new Label();
            lbl2 = new Label();
            txtpizzaname = new Label();
            txtsalad = new Label();
            txtdrink = new Label();
            label69 = new Label();
            label9 = new Label();
            txtCustomerName = new TextBox();
            txtPhoneNo = new TextBox();
            cmbPizzaFlavor = new ComboBox();
            cmbSalad = new ComboBox();
            cmbDrinkSize = new ComboBox();
            btnback = new Button();
            btnexit = new Button();
            btnPlaceOrder = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbPizzaSize = new ComboBox();
            cmbSaladSize = new ComboBox();
            cmbDrink = new ComboBox();
            txtGovtTax = new TextBox();
            txtTotal = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1514, 132);
            label1.TabIndex = 0;
            label1.Text = "ADD CUSTOMER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(527, 170);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(141, 25);
            lbl1.TabIndex = 1;
            lbl1.Text = "Customer Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(527, 215);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(91, 25);
            lbl2.TabIndex = 2;
            lbl2.Text = "Phone No";
            // 
            // txtpizzaname
            // 
            txtpizzaname.AutoSize = true;
            txtpizzaname.Location = new Point(527, 275);
            txtpizzaname.Name = "txtpizzaname";
            txtpizzaname.Size = new Size(103, 25);
            txtpizzaname.TabIndex = 3;
            txtpizzaname.Text = "Pizza Name";
            // 
            // txtsalad
            // 
            txtsalad.AutoSize = true;
            txtsalad.Location = new Point(527, 380);
            txtsalad.Name = "txtsalad";
            txtsalad.Size = new Size(55, 25);
            txtsalad.TabIndex = 4;
            txtsalad.Text = "Salad";
            // 
            // txtdrink
            // 
            txtdrink.AutoSize = true;
            txtdrink.Location = new Point(527, 557);
            txtdrink.Name = "txtdrink";
            txtdrink.Size = new Size(128, 25);
            txtdrink.TabIndex = 5;
            txtdrink.Text = "Drink Volume :";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label69.Location = new Point(527, 619);
            label69.Name = "label69";
            label69.Size = new Size(145, 40);
            label69.TabIndex = 6;
            label69.Text = "Govt Tax :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(575, 679);
            label9.Name = "label9";
            label9.Size = new Size(95, 40);
            label9.TabIndex = 9;
            label9.Text = "Total :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(765, 168);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(233, 31);
            txtCustomerName.TabIndex = 10;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(765, 213);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(233, 31);
            txtPhoneNo.TabIndex = 13;
            // 
            // cmbPizzaFlavor
            // 
            cmbPizzaFlavor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaFlavor.FormattingEnabled = true;
            cmbPizzaFlavor.Location = new Point(765, 273);
            cmbPizzaFlavor.Name = "cmbPizzaFlavor";
            cmbPizzaFlavor.Size = new Size(233, 33);
            cmbPizzaFlavor.TabIndex = 14;
            // 
            // cmbSalad
            // 
            cmbSalad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalad.FormattingEnabled = true;
            cmbSalad.Location = new Point(765, 378);
            cmbSalad.Name = "cmbSalad";
            cmbSalad.Size = new Size(233, 33);
            cmbSalad.TabIndex = 15;
            // 
            // cmbDrinkSize
            // 
            cmbDrinkSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrinkSize.FormattingEnabled = true;
            cmbDrinkSize.Location = new Point(765, 554);
            cmbDrinkSize.Name = "cmbDrinkSize";
            cmbDrinkSize.Size = new Size(233, 33);
            cmbDrinkSize.TabIndex = 16;
            // 
            // btnback
            // 
            btnback.Location = new Point(16, 747);
            btnback.Name = "btnback";
            btnback.Size = new Size(156, 62);
            btnback.TabIndex = 17;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1343, 747);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(156, 62);
            btnexit.TabIndex = 18;
            btnexit.Text = "Close";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(761, 747);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(156, 62);
            btnPlaceOrder.TabIndex = 19;
            btnPlaceOrder.Text = "Add";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 493);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 5;
            label3.Text = "Drink";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 433);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 5;
            label4.Text = "Salad Size :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 325);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 4;
            label5.Text = "Pizza Size : ";
            // 
            // cmbPizzaSize
            // 
            cmbPizzaSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaSize.FormattingEnabled = true;
            cmbPizzaSize.Location = new Point(765, 323);
            cmbPizzaSize.Name = "cmbPizzaSize";
            cmbPizzaSize.Size = new Size(233, 33);
            cmbPizzaSize.TabIndex = 14;
            // 
            // cmbSaladSize
            // 
            cmbSaladSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaladSize.FormattingEnabled = true;
            cmbSaladSize.Location = new Point(765, 431);
            cmbSaladSize.Name = "cmbSaladSize";
            cmbSaladSize.Size = new Size(233, 33);
            cmbSaladSize.TabIndex = 14;
            // 
            // cmbDrink
            // 
            cmbDrink.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrink.FormattingEnabled = true;
            cmbDrink.Location = new Point(765, 491);
            cmbDrink.Name = "cmbDrink";
            cmbDrink.Size = new Size(233, 33);
            cmbDrink.TabIndex = 15;
            // 
            // txtGovtTax
            // 
            txtGovtTax.BorderStyle = BorderStyle.None;
            txtGovtTax.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtGovtTax.Location = new Point(690, 622);
            txtGovtTax.Name = "txtGovtTax";
            txtGovtTax.ReadOnly = true;
            txtGovtTax.Size = new Size(227, 38);
            txtGovtTax.TabIndex = 13;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtTotal.Location = new Point(690, 680);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(227, 38);
            txtTotal.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(479, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(568, 694);
            dataGridView1.TabIndex = 20;
            // 
            // Addcustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 820);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(cmbDrinkSize);
            Controls.Add(cmbDrink);
            Controls.Add(cmbSalad);
            Controls.Add(cmbSaladSize);
            Controls.Add(cmbPizzaSize);
            Controls.Add(cmbPizzaFlavor);
            Controls.Add(txtTotal);
            Controls.Add(txtGovtTax);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtCustomerName);
            Controls.Add(label9);
            Controls.Add(label69);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtdrink);
            Controls.Add(label5);
            Controls.Add(txtsalad);
            Controls.Add(txtpizzaname);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Addcustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addcustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl1;
        private Label lbl2;
        private Label txtpizzaname;
        private Label txtsalad;
        private Label txtdrink;
        private Label label69;
        private Label label9;
        private TextBox txtCustomerName;
        private TextBox txtPhoneNo;
        private ComboBox cmbPizzaFlavor;
        private ComboBox cmbSalad;
        private ComboBox cmbDrinkSize;
        private Button btnback;
        private Button btnexit;
        private Button btnPlaceOrder;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbPizzaSize;
        private ComboBox cmbSaladSize;
        private ComboBox cmbDrink;
        private TextBox txtGovtTax;
        private TextBox txtTotal;
        private DataGridView dataGridView1;
    }
}