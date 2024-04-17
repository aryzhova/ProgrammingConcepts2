namespace ARyzhova_Assignment3
{
    partial class AddContactForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboAddressType = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.cboEmailType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.cboPhoneType = new System.Windows.Forms.ComboBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.picContactImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbAddress.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(149, 18);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(149, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(216, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(216, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(152, 105);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(72, 23);
            this.btnAddPhoto.TabIndex = 5;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.BtnAddPhoto_Click);
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.mskZip);
            this.grbAddress.Controls.Add(this.cboProvince);
            this.grbAddress.Controls.Add(this.cboAddressType);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Location = new System.Drawing.Point(9, 143);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(361, 152);
            this.grbAddress.TabIndex = 6;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(299, 100);
            this.mskZip.Mask = "L0L 0L0 ";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(56, 20);
            this.mskZip.TabIndex = 12;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cboProvince.Location = new System.Drawing.Point(182, 97);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(70, 21);
            this.cboProvince.TabIndex = 11;
            // 
            // cboAddressType
            // 
            this.cboAddressType.FormattingEnabled = true;
            this.cboAddressType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cboAddressType.Location = new System.Drawing.Point(46, 19);
            this.cboAddressType.Name = "cboAddressType";
            this.cboAddressType.Size = new System.Drawing.Size(121, 21);
            this.cboAddressType.TabIndex = 10;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(268, 100);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 9;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(125, 100);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 8;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 58);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(6, 22);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(34, 13);
            this.lblAddressType.TabIndex = 4;
            this.lblAddressType.Text = "Type:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(46, 97);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(73, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(46, 55);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(309, 20);
            this.txtStreet.TabIndex = 1;
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.cboEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Location = new System.Drawing.Point(6, 301);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(364, 55);
            this.grbEmail.TabIndex = 0;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // cboEmailType
            // 
            this.cboEmailType.FormattingEnabled = true;
            this.cboEmailType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboEmailType.Location = new System.Drawing.Point(261, 19);
            this.cboEmailType.Name = "cboEmailType";
            this.cboEmailType.Size = new System.Drawing.Size(97, 21);
            this.cboEmailType.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(3, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(221, 25);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(34, 13);
            this.lblEmailType.TabIndex = 7;
            this.lblEmailType.Text = "Type:";
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.cboPhoneType);
            this.grbPhone.Controls.Add(this.mskPhone);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(6, 362);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(364, 50);
            this.grbPhone.TabIndex = 0;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // cboPhoneType
            // 
            this.cboPhoneType.FormattingEnabled = true;
            this.cboPhoneType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboPhoneType.Location = new System.Drawing.Point(261, 13);
            this.cboPhoneType.Name = "cboPhoneType";
            this.cboPhoneType.Size = new System.Drawing.Size(97, 21);
            this.cboPhoneType.TabIndex = 14;
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(3, 16);
            this.mskPhone.Mask = "(000) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(215, 20);
            this.mskPhone.TabIndex = 13;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(221, 16);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(34, 13);
            this.lblPhoneType.TabIndex = 8;
            this.lblPhoneType.Text = "Type:";
            // 
            // picContactImage
            // 
            this.picContactImage.Image = global::ARyzhova_Assignment3.Properties.Resources.MyPicture;
            this.picContactImage.Location = new System.Drawing.Point(6, 4);
            this.picContactImage.Name = "picContactImage";
            this.picContactImage.Size = new System.Drawing.Size(128, 128);
            this.picContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContactImage.TabIndex = 0;
            this.picContactImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 460);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picContactImage);
            this.Name = "AddContactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Contact";
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContactImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picContactImage;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.ComboBox cboAddressType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.ComboBox cboEmailType;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.ComboBox cboPhoneType;
    }
}