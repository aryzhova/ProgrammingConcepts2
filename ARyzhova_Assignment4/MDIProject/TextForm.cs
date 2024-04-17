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
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///overloaded constructor for text form
        ///takes a path of the file to read from as a parameter
        /// </summary>
        /// <param name="path"></param>
        public TextForm(string path)
        {
            InitializeComponent();
            txtTextDoc.Text = File.ReadAllText(path);
        }

        /// <summary>
        /// returns text from the text form so the user can save it
        /// from the main form
        /// </summary>
        /// <returns>text from the text form</returns>
        public string GetText()
        {
            return txtTextDoc.Text;
        }
    }
}
