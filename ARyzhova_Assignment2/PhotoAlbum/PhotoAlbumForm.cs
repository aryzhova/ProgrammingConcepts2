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

namespace PhotoAlbum
{
    public partial class PhotoAlbumForm : Form
    {
        PhotoAlbum album = null;
        Photo newPhoto;
        int index = 0;

        public PhotoAlbumForm()
        {
            InitializeComponent();
        }

        //method for changing canvas color
        private void RdbColor_Changed(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            switch (radio.Text)
            {
                case "Black":
                    picPictureBox.BackColor = Color.Black;
                    break;
                case "White":
                    picPictureBox.BackColor = Color.White;
                    break;
                case "Grey":
                    picPictureBox.BackColor = Color.Gray;
                    break;
            }
        }

        private void BtnAddPhotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.jpeg)|*.bmp; *jpg; *jpeg";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPictureBox.ImageLocation = openFileDialog.FileName;

                //fetching creation date of the photo
                lblCreationDate.Text = $"Photo created: {Convert.ToString(File.GetCreationTime(openFileDialog.FileName))}";
            }
            //initializing a list of photos in album class
            album.listOfPhotos = new List<Photo>();

            //adding each photo to the list
            foreach (string fileName in openFileDialog.FileNames)
            {
                newPhoto = new Photo(fileName); //sending path as a parameter
                album.listOfPhotos.Add(newPhoto);

            }

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
        }

        private void BtnCreateAlbum_Click(object sender, EventArgs e)
        { 
            //checking of there is an album open and if it was saved
            //if the album doesnt have a path yet, asking user is he wants to save it
            if (album != null && album.pathToAlbum == null)
            {
                AskIfUserWantsToSaveAlbum();
            }

            //clearing info about the previous album before creating a new one
            picPictureBox.Image = null; 
            this.Text = "Photo Album"; 
            lblCreationDate.Text = "";
            txtDescription.Text = "";

            //opening a secondary form and getting the name of the album from that form
            CreateAlbumForm createAlbum = new CreateAlbumForm();
            if (createAlbum.ShowDialog(this) == DialogResult.OK)
            {
                this.Text += createAlbum.TextFromBox;
            }
        }

        private void AskIfUserWantsToSaveAlbum()
        {
            DialogResult result = MessageBox.Show("Do  you want to save existing album?", "Warning", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    SaveAlbum();
                    break;

                case DialogResult.No:
                    album = null;
                    picPictureBox.Image = null;
                    this.Text = "Photo Album";
                    lblCreationDate.Text = "";
                    txtDescription.Text = "";
                    break;
            }
        }

        private void SaveAlbum()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Alb Files(*.alb)|*.alb";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                album.Save(saveFileDialog.FileName); //method in PhotoAlbum class

                this.Text += album.pathToAlbum;
                MessageBox.Show($"Album {album.albumName} saved!");
            }

        }
        public void GetAlbumNameFromSecondaryForm(string name)
        {
            this.Text += $" - {name}";
            album = new PhotoAlbum();
            album.albumName = name;
            btnSaveAlbum.Enabled = true;
            btnAddPhotos.Enabled = true;
        }

        private void BtnSaveAlbum_Click(object sender, EventArgs e)
        {
            SaveAlbum();
        }
        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            //fetching photo description when user leaves textbox
            album.listOfPhotos[index].Description = txtDescription.Text;
        }
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            txtDescription.Focus(); //returning focus to textbox(for usability)

            index--; //decrementing index to see previous photo

            if (index < 0)  
            {
                //returning to the end of the list if the user reached the 1st photo
                index = album.listOfPhotos.Count - 1;
            }
            picPictureBox.ImageLocation = album.listOfPhotos[index].PathToPhoto;
            txtDescription.Text = album.listOfPhotos[index].Description;
            lblCreationDate.Text = $"Photo created: {Convert.ToString(File.GetCreationTime(album.listOfPhotos[index].PathToPhoto))}";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            txtDescription.Focus(); //returning focus to textbox(for usability)

            index++; //incrementing index to see next photo

            if (index == album.listOfPhotos.Count) 
            { 
                //returning to the 1st photo if the user is at the end of the list
                index = 0;
            }
            picPictureBox.ImageLocation = album.listOfPhotos[index].PathToPhoto;
            txtDescription.Text = album.listOfPhotos[index].Description;
            lblCreationDate.Text = $"Photo created: {Convert.ToString(File.GetCreationTime(album.listOfPhotos[index].PathToPhoto))}";
        }

        private void BtnOpenAlbum_Click(object sender, EventArgs e)
        {
            if (album != null && album.pathToAlbum == null)
            {
                AskIfUserWantsToSaveAlbum();
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Alb Files (*.alb)|*.alb";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                index = 0; //setting index back to 0

                album = new PhotoAlbum();

                album.listOfPhotos = new List<Photo>();

                album.Open(openFileDialog.FileName); //method in PhotoAlbum Class

                this.Text = $"Photo Album  {album.albumName}  {album.pathToAlbum}";
                btnAddPhotos.Enabled = true;

                //checking if there are any pictures in the album
                if (album.listOfPhotos.Count != 0)
                {
                    picPictureBox.ImageLocation = album.listOfPhotos[0].PathToPhoto;
                    txtDescription.Text = album.listOfPhotos[0].Description;
                    
                    lblCreationDate.Text = $"File created: {Convert.ToString(File.GetCreationTime(album.listOfPhotos[0].PathToPhoto))}";
                    
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                }
            }
        }
        private void PhotoAlbumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //checking if the is an unsaved album and asking if user wants to save it
            if (album != null && album.pathToAlbum == null)
            {
                DialogResult result = MessageBox.Show("Do you want to save album before closing?",
                                                      "Warning", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveAlbum();
                        break;

                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }

        }
    }
}
