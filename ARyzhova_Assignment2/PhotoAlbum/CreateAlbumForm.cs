using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class CreateAlbumForm : Form
    {
        string textFromBox = "";
        public string TextFromBox
        {
            get => textFromBox;
        }

        public CreateAlbumForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();           
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ((PhotoAlbumForm)Owner).GetAlbumNameFromSecondaryForm(txtAlbumName.Text);
            this.Close();
        }

        private void TxtAlbumName_Leave(object sender, EventArgs e)
        {
            textFromBox = txtAlbumName.Text;
        }
    }
}
