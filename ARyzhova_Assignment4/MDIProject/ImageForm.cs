﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIProject
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        public ImageForm(string path)
        {
            InitializeComponent();
            picImage.ImageLocation = path;
        }
    }
}
