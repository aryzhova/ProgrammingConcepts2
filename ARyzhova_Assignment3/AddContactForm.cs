using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARyzhova_Assignment3
{
    public partial class AddContactForm : Form
    {
        //public contact that will be accessible from the main form
        public Contact secondFormContact;
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File(*.jpg; *.jpeg)|*jpg; *jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picContactImage.ImageLocation = ofd.FileName;
            }
        }

        /// <summary>
        /// checking if user entered both first name and last name. Also 
        /// making sure that the names are at least 2 characters long,
        /// because we need first 2 characters to create a text file for notes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please enter contact's first and last name");
            }
            else if (txtFirstName.Text.Length < 2 || txtLastName.Text.Length < 2)
            {
                MessageBox.Show("Names cannot be less then 2 characters long");
            }
            else
            {
                if (secondFormContact == null)
                {
                    secondFormContact = new Contact(txtFirstName.Text, txtLastName.Text);
                }

                secondFormContact.PathToImage = picContactImage.ImageLocation;

                if (cboAddressType.SelectedIndex != -1)
                {
                    secondFormContact.AddressType = cboAddressType.SelectedItem.ToString();
                }

                secondFormContact.Street = txtStreet.Text;
                secondFormContact.City = txtCity.Text;

                if (cboProvince.SelectedIndex != -1)
                {
                    secondFormContact.Province = cboProvince.SelectedItem.ToString();
                }

                secondFormContact.Zip = mskZip.Text;
                secondFormContact.Email = txtEmail.Text;

                if (cboEmailType.SelectedIndex != -1)
                {
                    secondFormContact.EmailType = cboEmailType.SelectedItem.ToString();
                }

                secondFormContact.Phone = mskPhone.Text;

                if (cboPhoneType.SelectedIndex != -1)
                {
                    secondFormContact.PhoneType = cboPhoneType.SelectedItem.ToString();
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// receiving the selected contact from the main form 
        /// when userclicks Edit button
        /// </summary>
        /// <param name="displayedContact"></param>
        internal void ShowDialog(Contact displayedContact)
        {
            secondFormContact = displayedContact;

            txtFirstName.Text = secondFormContact.FirstName;
            txtLastName.Text = secondFormContact.LastName;
            picContactImage.ImageLocation = secondFormContact.PathToImage;
            cboAddressType.SelectedItem = secondFormContact.AddressType;
            txtStreet.Text = secondFormContact.Street;
            txtCity.Text = secondFormContact.City;
            cboProvince.SelectedItem = secondFormContact.Province;
            mskZip.Text = secondFormContact.Zip;
            txtEmail.Text = secondFormContact.Email;
            cboEmailType.SelectedItem = secondFormContact.EmailType;
            mskPhone.Text = secondFormContact.Phone;
            cboPhoneType.SelectedItem = secondFormContact.PhoneType;
        }
    }
}
