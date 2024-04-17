using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARyzhova_Assignment3
{
    public partial class ContactManagerForm : Form
    {
        string path = "Contacts.txt";
        Contact displayedContact;
        public ContactManagerForm()
        {
            InitializeComponent();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            if (addContactForm.ShowDialog(this) == DialogResult.OK)
            {
                pnlContactDetails.Enabled = true;

                //fetching the contact from the secondary form
                displayedContact = addContactForm.secondFormContact;

                //adding the contact from secondary form to the list
                lstContactList.Items.Add(displayedContact);
                lstContactList.SelectedIndex = lstContactList.Items.Count - 1;
                ShowContact(displayedContact);
            }
        }

        /// <summary>
        /// Method accepting a contact object as a parameter
        /// and displaying it in the Details panel
        /// </summary>
        /// <param name="contact"></param>
        internal void ShowContact(Contact contact)
        {
            displayedContact = contact;

            txtFirstName.Text = displayedContact.FirstName;
            txtLastName.Text = displayedContact.LastName;
            if (displayedContact.PathToImage != "")
            {
                picContactImage.ImageLocation = displayedContact.PathToImage;
            }
            else
            {
                picContactImage.Image = Properties.Resources.MyPicture;
            }
            txtAddressType.Text = displayedContact.AddressType;
            txtStreet.Text = displayedContact.Street;
            txtCity.Text = displayedContact.City;
            txtProvince.Text = displayedContact.Province;
            txtZip.Text = displayedContact.Zip;
            txtEmail.Text = displayedContact.Email;
            txtEmailType.Text = displayedContact.EmailType;
            txtPhone.Text = displayedContact.Phone;
            txtPhoneType.Text = displayedContact.PhoneType;

            txtNotes.Clear();

            txtNotes.Text = displayedContact.DisplayNotes();
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            if (txtTakeNote.Text == "")
            {
                MessageBox.Show("Please enter something");
            }
            else
            {
                Note note = new Note(txtTakeNote.Text);
                displayedContact.AddNote(note);
                txtTakeNote.Clear();
                txtTakeNote.Focus();

                txtNotes.Text = displayedContact.DisplayNotes();

            }
        }

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog(displayedContact);
            if (addContactForm.ShowDialog() == DialogResult.OK)
            {
                displayedContact = addContactForm.secondFormContact;

                ShowContact(displayedContact);
            }

        }

        private void LstContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContactList.SelectedIndex != -1)
            {
                displayedContact = (Contact)lstContactList.SelectedItem;
                ShowContact(displayedContact);
                pnlContactDetails.Enabled = true;
            }
        }

        /// <summary>
        /// Method reading previously added contacts and displaying 
        /// them on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactManagerForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    while (r.EndOfStream == false)
                    {
                        string[] parameters = r.ReadLine().Split('|');
                        Contact uploadedContact = new Contact(parameters[0],
                                                             parameters[1],
                                                             parameters[2],
                                                             parameters[3],
                                                             parameters[4],
                                                             parameters[5],
                                                             parameters[6],
                                                             parameters[7],
                                                             parameters[8],
                                                             parameters[9],
                                                             parameters[10],
                                                             parameters[11]);
                        uploadedContact.PathToNotes = parameters[12];

                        using (StreamReader r2 = new StreamReader(uploadedContact.PathToNotes))
                        {
                            while(r2.EndOfStream == false)
                            {
                                Note note = new Note(r2.ReadLine());
                                note.DateAndTime = Convert.ToDateTime(r2.ReadLine());
                                uploadedContact.NoteList.Add(note);
                            }
                        }

                        lstContactList.Items.Add(uploadedContact);
                    }
                }
            }
        }

        /// <summary>
        /// saving contacts on closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter wr = new StreamWriter(path))
            {
                foreach (Contact contact in lstContactList.Items)
                {
                    contact.AppendToFile(wr);
                }
            }
        }
    }
}
