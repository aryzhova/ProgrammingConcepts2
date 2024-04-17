namespace ARyzhova_Assignment3
{
    partial class ContactManagerForm
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
            this.lstContactList = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.pnlContactDetails = new System.Windows.Forms.Panel();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.txtPhoneType = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.grbTakeNote = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtTakeNote = new System.Windows.Forms.TextBox();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.picContactImage = new System.Windows.Forms.PictureBox();
            this.pnlContactDetails.SuspendLayout();
            this.grbNotes.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbTakeNote.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lstContactList
            // 
            this.lstContactList.FormattingEnabled = true;
            this.lstContactList.Location = new System.Drawing.Point(6, 12);
            this.lstContactList.Name = "lstContactList";
            this.lstContactList.Size = new System.Drawing.Size(158, 381);
            this.lstContactList.TabIndex = 0;
            this.lstContactList.SelectedIndexChanged += new System.EventHandler(this.LstContactList_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(6, 402);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(158, 23);
            this.btnAddContact.TabIndex = 2;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // pnlContactDetails
            // 
            this.pnlContactDetails.Controls.Add(this.grbNotes);
            this.pnlContactDetails.Controls.Add(this.grbPhone);
            this.pnlContactDetails.Controls.Add(this.grbTakeNote);
            this.pnlContactDetails.Controls.Add(this.grbEmail);
            this.pnlContactDetails.Controls.Add(this.grbAddress);
            this.pnlContactDetails.Controls.Add(this.txtLastName);
            this.pnlContactDetails.Controls.Add(this.txtFirstName);
            this.pnlContactDetails.Controls.Add(this.btnEditContact);
            this.pnlContactDetails.Controls.Add(this.lblLastName);
            this.pnlContactDetails.Controls.Add(this.lblFirstName);
            this.pnlContactDetails.Controls.Add(this.picContactImage);
            this.pnlContactDetails.Enabled = false;
            this.pnlContactDetails.Location = new System.Drawing.Point(170, 12);
            this.pnlContactDetails.Name = "pnlContactDetails";
            this.pnlContactDetails.Size = new System.Drawing.Size(700, 413);
            this.pnlContactDetails.TabIndex = 3;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtNotes);
            this.grbNotes.Location = new System.Drawing.Point(342, 172);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Size = new System.Drawing.Size(345, 241);
            this.grbNotes.TabIndex = 0;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(3, 16);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(336, 219);
            this.txtNotes.TabIndex = 0;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.txtPhoneType);
            this.grbPhone.Controls.Add(this.txtPhone);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(3, 356);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(330, 54);
            this.grbPhone.TabIndex = 4;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.Location = new System.Drawing.Point(232, 13);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.ReadOnly = true;
            this.txtPhoneType.Size = new System.Drawing.Size(92, 20);
            this.txtPhoneType.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(9, 19);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(173, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(200, 16);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(34, 13);
            this.lblPhoneType.TabIndex = 15;
            this.lblPhoneType.Text = "Type:";
            // 
            // grbTakeNote
            // 
            this.grbTakeNote.Controls.Add(this.btnAddNote);
            this.grbTakeNote.Controls.Add(this.txtTakeNote);
            this.grbTakeNote.Location = new System.Drawing.Point(339, 3);
            this.grbTakeNote.Name = "grbTakeNote";
            this.grbTakeNote.Size = new System.Drawing.Size(354, 166);
            this.grbTakeNote.TabIndex = 4;
            this.grbTakeNote.TabStop = false;
            this.grbTakeNote.Text = "Take a Note:";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(273, 137);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 10;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // txtTakeNote
            // 
            this.txtTakeNote.Location = new System.Drawing.Point(6, 19);
            this.txtTakeNote.Multiline = true;
            this.txtTakeNote.Name = "txtTakeNote";
            this.txtTakeNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakeNote.Size = new System.Drawing.Size(342, 112);
            this.txtTakeNote.TabIndex = 9;
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Location = new System.Drawing.Point(3, 304);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(330, 49);
            this.grbEmail.TabIndex = 0;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // txtEmailType
            // 
            this.txtEmailType.Location = new System.Drawing.Point(232, 19);
            this.txtEmailType.Name = "txtEmailType";
            this.txtEmailType.ReadOnly = true;
            this.txtEmailType.Size = new System.Drawing.Size(92, 20);
            this.txtEmailType.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(200, 27);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(34, 13);
            this.lblEmailType.TabIndex = 14;
            this.lblEmailType.Text = "Type:";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.txtAddressType);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtZip);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Location = new System.Drawing.Point(3, 137);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(330, 161);
            this.grbAddress.TabIndex = 4;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(46, 59);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(278, 20);
            this.txtStreet.TabIndex = 13;
            // 
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(46, 24);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.ReadOnly = true;
            this.txtAddressType.Size = new System.Drawing.Size(100, 20);
            this.txtAddressType.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(46, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(59, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(250, 110);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(74, 20);
            this.txtZip.TabIndex = 10;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(169, 110);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(44, 20);
            this.txtProvince.TabIndex = 9;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(219, 113);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(111, 113);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 7;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 113);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 62);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(6, 27);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(34, 13);
            this.lblAddressType.TabIndex = 4;
            this.lblAddressType.Text = "Type:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(202, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(125, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(202, 14);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(125, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(202, 97);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(75, 23);
            this.btnEditContact.TabIndex = 7;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.BtnEditContact_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(137, 51);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(137, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // picContactImage
            // 
            this.picContactImage.Image = global::ARyzhova_Assignment3.Properties.Resources.MyPicture;
            this.picContactImage.InitialImage = null;
            this.picContactImage.Location = new System.Drawing.Point(3, 3);
            this.picContactImage.Name = "picContactImage";
            this.picContactImage.Size = new System.Drawing.Size(128, 128);
            this.picContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContactImage.TabIndex = 4;
            this.picContactImage.TabStop = false;
            // 
            // ContactManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 434);
            this.Controls.Add(this.pnlContactDetails);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContactList);
            this.Name = "ContactManagerForm";
            this.Text = "Contact Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ContactManagerForm_Load);
            this.pnlContactDetails.ResumeLayout(false);
            this.pnlContactDetails.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbTakeNote.ResumeLayout(false);
            this.grbTakeNote.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContactImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstContactList;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Panel pnlContactDetails;
        private System.Windows.Forms.PictureBox picContactImage;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.TextBox txtPhoneType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtEmailType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.GroupBox grbTakeNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox txtTakeNote;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtNotes;
    }
}

