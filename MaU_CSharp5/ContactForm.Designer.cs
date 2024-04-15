namespace MaU_CSharp5
{
    partial class ContactForm
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
            grpName = new GroupBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            grpEmailAndPhone = new GroupBox();
            txtEmailPrivate = new TextBox();
            txtEmailBusiness = new TextBox();
            txtCellPhone = new TextBox();
            txtHomePhone = new TextBox();
            lblEmailPrivate = new Label();
            lblEmailBusiness = new Label();
            lblCellPhone = new Label();
            lblHomePhone = new Label();
            grpAddress = new GroupBox();
            cmbCountry = new ComboBox();
            lblCountry = new Label();
            txtZipCode = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblStreet = new Label();
            txtStreet = new TextBox();
            lblZipCode = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            grpName.SuspendLayout();
            grpEmailAndPhone.SuspendLayout();
            grpAddress.SuspendLayout();
            SuspendLayout();
            // 
            // grpName
            // 
            grpName.Controls.Add(txtLastName);
            grpName.Controls.Add(lblLastName);
            grpName.Controls.Add(txtFirstName);
            grpName.Controls.Add(lblFirstName);
            grpName.Location = new Point(12, 12);
            grpName.Name = "grpName";
            grpName.Size = new Size(362, 100);
            grpName.TabIndex = 0;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(119, 58);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(216, 23);
            txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(18, 61);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(119, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(216, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(18, 31);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // grpEmailAndPhone
            // 
            grpEmailAndPhone.Controls.Add(txtEmailPrivate);
            grpEmailAndPhone.Controls.Add(txtEmailBusiness);
            grpEmailAndPhone.Controls.Add(txtCellPhone);
            grpEmailAndPhone.Controls.Add(txtHomePhone);
            grpEmailAndPhone.Controls.Add(lblEmailPrivate);
            grpEmailAndPhone.Controls.Add(lblEmailBusiness);
            grpEmailAndPhone.Controls.Add(lblCellPhone);
            grpEmailAndPhone.Controls.Add(lblHomePhone);
            grpEmailAndPhone.Location = new Point(12, 118);
            grpEmailAndPhone.Name = "grpEmailAndPhone";
            grpEmailAndPhone.Size = new Size(362, 164);
            grpEmailAndPhone.TabIndex = 1;
            grpEmailAndPhone.TabStop = false;
            grpEmailAndPhone.Text = "Email and Phone";
            // 
            // txtEmailPrivate
            // 
            txtEmailPrivate.Location = new Point(119, 121);
            txtEmailPrivate.Name = "txtEmailPrivate";
            txtEmailPrivate.Size = new Size(216, 23);
            txtEmailPrivate.TabIndex = 7;
            // 
            // txtEmailBusiness
            // 
            txtEmailBusiness.Location = new Point(119, 91);
            txtEmailBusiness.Name = "txtEmailBusiness";
            txtEmailBusiness.Size = new Size(216, 23);
            txtEmailBusiness.TabIndex = 6;
            // 
            // txtCellPhone
            // 
            txtCellPhone.Location = new Point(119, 62);
            txtCellPhone.Name = "txtCellPhone";
            txtCellPhone.Size = new Size(216, 23);
            txtCellPhone.TabIndex = 5;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(119, 33);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(216, 23);
            txtHomePhone.TabIndex = 4;
            // 
            // lblEmailPrivate
            // 
            lblEmailPrivate.AutoSize = true;
            lblEmailPrivate.Location = new Point(18, 124);
            lblEmailPrivate.Name = "lblEmailPrivate";
            lblEmailPrivate.Size = new Size(78, 15);
            lblEmailPrivate.TabIndex = 3;
            lblEmailPrivate.Text = "Email, Private";
            // 
            // lblEmailBusiness
            // 
            lblEmailBusiness.AutoSize = true;
            lblEmailBusiness.Location = new Point(18, 93);
            lblEmailBusiness.Name = "lblEmailBusiness";
            lblEmailBusiness.Size = new Size(87, 15);
            lblEmailBusiness.TabIndex = 2;
            lblEmailBusiness.Text = "Email, Business";
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.Location = new Point(18, 65);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(64, 15);
            lblCellPhone.TabIndex = 1;
            lblCellPhone.Text = "Cell Phone";
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Location = new Point(18, 36);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(77, 15);
            lblHomePhone.TabIndex = 0;
            lblHomePhone.Text = "Home Phone";
            // 
            // grpAddress
            // 
            grpAddress.Controls.Add(cmbCountry);
            grpAddress.Controls.Add(lblCountry);
            grpAddress.Controls.Add(txtZipCode);
            grpAddress.Controls.Add(lblCity);
            grpAddress.Controls.Add(txtCity);
            grpAddress.Controls.Add(lblStreet);
            grpAddress.Controls.Add(txtStreet);
            grpAddress.Controls.Add(lblZipCode);
            grpAddress.Location = new Point(12, 288);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(362, 160);
            grpAddress.TabIndex = 2;
            grpAddress.TabStop = false;
            grpAddress.Text = "Address";
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(119, 120);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(216, 23);
            cmbCountry.TabIndex = 15;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(18, 123);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 14;
            lblCountry.Text = "Country";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(119, 90);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(216, 23);
            txtZipCode.TabIndex = 13;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(18, 64);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 9;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(119, 61);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(216, 23);
            txtCity.TabIndex = 12;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(18, 35);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(37, 15);
            lblStreet.TabIndex = 8;
            lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(119, 32);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(216, 23);
            txtStreet.TabIndex = 11;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(18, 92);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(55, 15);
            lblZipCode.TabIndex = 10;
            lblZipCode.Text = "Zip Code";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(131, 454);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(272, 454);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 497);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(grpAddress);
            Controls.Add(grpEmailAndPhone);
            Controls.Add(grpName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactForm";
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            grpEmailAndPhone.ResumeLayout(false);
            grpEmailAndPhone.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private GroupBox grpEmailAndPhone;
        private TextBox txtEmailPrivate;
        private TextBox txtEmailBusiness;
        private TextBox txtCellPhone;
        private TextBox txtHomePhone;
        private Label lblEmailPrivate;
        private Label lblEmailBusiness;
        private Label lblCellPhone;
        private Label lblHomePhone;
        private GroupBox grpAddress;
        private TextBox txtZipCode;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblStreet;
        private TextBox txtStreet;
        private Label lblZipCode;
        private ComboBox cmbCountry;
        private Label lblCountry;
        private Button btnOk;
        private Button btnCancel;
    }
}