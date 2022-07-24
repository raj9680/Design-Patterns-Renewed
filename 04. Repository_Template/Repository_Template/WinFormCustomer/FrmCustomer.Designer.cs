
namespace WinFormCustomer
{
    partial class FrmCustomer
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
            this.CustomerTypeLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.BillAmountLabel = new System.Windows.Forms.Label();
            this.BillDateLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.BillDate = new System.Windows.Forms.TextBox();
            this.BillAmount = new System.Windows.Forms.TextBox();
            this.CustomerType = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerTypeLabel
            // 
            this.CustomerTypeLabel.AutoSize = true;
            this.CustomerTypeLabel.Location = new System.Drawing.Point(18, 13);
            this.CustomerTypeLabel.Name = "CustomerTypeLabel";
            this.CustomerTypeLabel.Size = new System.Drawing.Size(111, 20);
            this.CustomerTypeLabel.TabIndex = 0;
            this.CustomerTypeLabel.Text = "Customer  Type";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(18, 55);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(116, 20);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(18, 95);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(104, 20);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "PhoneNumber";
            // 
            // BillAmountLabel
            // 
            this.BillAmountLabel.AutoSize = true;
            this.BillAmountLabel.Location = new System.Drawing.Point(400, 13);
            this.BillAmountLabel.Name = "BillAmountLabel";
            this.BillAmountLabel.Size = new System.Drawing.Size(87, 20);
            this.BillAmountLabel.TabIndex = 3;
            this.BillAmountLabel.Text = "Bill Amount";
            // 
            // BillDateLabel
            // 
            this.BillDateLabel.AutoSize = true;
            this.BillDateLabel.Location = new System.Drawing.Point(400, 55);
            this.BillDateLabel.Name = "BillDateLabel";
            this.BillDateLabel.Size = new System.Drawing.Size(66, 20);
            this.BillDateLabel.TabIndex = 4;
            this.BillDateLabel.Text = "Bill Date";
            this.BillDateLabel.Click += new System.EventHandler(this.BillDateLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(401, 95);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(62, 20);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(163, 53);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(158, 27);
            this.CustomerName.TabIndex = 6;
            this.CustomerName.TextChanged += new System.EventHandler(this.CustomerName_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(163, 93);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(159, 27);
            this.PhoneNumber.TabIndex = 7;
            this.PhoneNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BillDate
            // 
            this.BillDate.Location = new System.Drawing.Point(509, 52);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(173, 27);
            this.BillDate.TabIndex = 8;
            this.BillDate.TextChanged += new System.EventHandler(this.BillDate_TextChanged);
            // 
            // BillAmount
            // 
            this.BillAmount.Location = new System.Drawing.Point(509, 11);
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.Size = new System.Drawing.Size(173, 27);
            this.BillAmount.TabIndex = 9;
            this.BillAmount.Text = "0";
            this.BillAmount.TextChanged += new System.EventHandler(this.BillAmount_TextChanged);
            // 
            // CustomerType
            // 
            this.CustomerType.FormattingEnabled = true;
            this.CustomerType.Items.AddRange(new object[] {
            "Customer",
            "Lead"});
            this.CustomerType.Location = new System.Drawing.Point(163, 13);
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.Size = new System.Drawing.Size(159, 28);
            this.CustomerType.TabIndex = 10;
            this.CustomerType.Text = "Select CX Type";
            this.CustomerType.SelectedIndexChanged += new System.EventHandler(this.CustomerType_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(509, 95);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(259, 75);
            this.Address.TabIndex = 11;
            this.Address.Text = "";
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(18, 141);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(116, 29);
            this.ValidateBtn.TabIndex = 12;
            this.ValidateBtn.Text = "Validate";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.CustomerType);
            this.Controls.Add(this.BillAmount);
            this.Controls.Add(this.BillDate);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.BillDateLabel);
            this.Controls.Add(this.BillAmountLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerTypeLabel);
            this.Name = "FrmCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerTypeLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label BillAmountLabel;
        private System.Windows.Forms.Label BillDateLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox BillDate;
        private System.Windows.Forms.TextBox BillAmount;
        private System.Windows.Forms.ComboBox CustomerType;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.Button btnAdd;
    }
}

