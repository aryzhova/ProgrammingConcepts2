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

namespace MDIProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void NewTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTextDocument();
        }

        private void CreateTextDocument()
        {
            TextForm textForm = new TextForm();
            textForm.MdiParent = this;
            textForm.Show();
        }

        private void OpenTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextForm textForm = new TextForm(ofd.FileName);
                textForm.MdiParent = this;
                textForm.Show();
            }
        }
        private void ImageDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.bmp)|*.jpg;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageForm imageForm = new ImageForm(ofd.FileName);
                imageForm.MdiParent = this;
                imageForm.Show();
            }

        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild is TextForm)
            {
                lblStatus.Text = "Text Document active";
                saveAsToolStripMenuItem.Enabled = true;
            }
            else if (ActiveMdiChild is ImageForm)
            {
                lblStatus.Text = "Image Document active";
                saveAsToolStripMenuItem.Enabled = false;
            }
            else
            {
                lblStatus.Text = "No Form Active";
                saveAsToolStripMenuItem.Enabled = false;
            }
        }
        private void CascadeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextForm childForm = (TextForm)this.ActiveMdiChild;
                File.WriteAllText(sfd.FileName, childForm.GetText());
            }
        }

        //Exit button from the menu makes the form close
        //When the form is closing FormClosing event (line102) is triggered
        //and the user is asked if they want to save text documents
        //the same event is triggered when user clicks X in the right upper corner
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i] is TextForm)
                {
                    this.ActivateMdiChild(this.MdiChildren[i]);
                    MdiChildren[i].BringToFront();
                    DialogResult result = MessageBox.Show
                                         ("Would you like to save this document?",
                                          "Save document?",
                                          MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SaveItem();
                    }
                }
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            CreateTextDocument();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt|Image files(*.jpg;*.bmp;*.jpeg)|*.jpg;*.bmp;*.jpeg";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(ofd.FileName) == ".txt")
                {
                    TextForm textForm = new TextForm(ofd.FileName);
                    textForm.MdiParent = this;
                    textForm.Show();
                }
                else
                {
                    ImageForm imageForm = new ImageForm(ofd.FileName);
                    imageForm.MdiParent = this;
                    imageForm.Show();
                }
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild is TextForm)
            {
                SaveItem();
            }
            else
            {
                MessageBox.Show("Only text documents can be saved!");
            }
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
