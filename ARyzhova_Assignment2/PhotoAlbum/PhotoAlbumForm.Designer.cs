namespace PhotoAlbum
{
    partial class PhotoAlbumForm
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
            this.picPictureBox = new System.Windows.Forms.PictureBox();
            this.grbCanvasColor = new System.Windows.Forms.GroupBox();
            this.rdbGray = new System.Windows.Forms.RadioButton();
            this.rbdWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddPhotos = new System.Windows.Forms.Button();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCreateAlbum = new System.Windows.Forms.Button();
            this.btnOpenAlbum = new System.Windows.Forms.Button();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPictureBox)).BeginInit();
            this.grbCanvasColor.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPictureBox
            // 
            this.picPictureBox.BackColor = System.Drawing.Color.Black;
            this.picPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPictureBox.Location = new System.Drawing.Point(12, 12);
            this.picPictureBox.Name = "picPictureBox";
            this.picPictureBox.Size = new System.Drawing.Size(518, 379);
            this.picPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPictureBox.TabIndex = 0;
            this.picPictureBox.TabStop = false;
            // 
            // grbCanvasColor
            // 
            this.grbCanvasColor.Controls.Add(this.rdbGray);
            this.grbCanvasColor.Controls.Add(this.rbdWhite);
            this.grbCanvasColor.Controls.Add(this.rdbBlack);
            this.grbCanvasColor.Location = new System.Drawing.Point(536, 230);
            this.grbCanvasColor.Name = "grbCanvasColor";
            this.grbCanvasColor.Size = new System.Drawing.Size(260, 86);
            this.grbCanvasColor.TabIndex = 1;
            this.grbCanvasColor.TabStop = false;
            this.grbCanvasColor.Text = "Canvas Color";
            // 
            // rdbGray
            // 
            this.rdbGray.AutoSize = true;
            this.rdbGray.Location = new System.Drawing.Point(190, 42);
            this.rdbGray.Name = "rdbGray";
            this.rdbGray.Size = new System.Drawing.Size(47, 17);
            this.rdbGray.TabIndex = 2;
            this.rdbGray.Tag = "";
            this.rdbGray.Text = "Grey";
            this.rdbGray.UseVisualStyleBackColor = true;
            this.rdbGray.CheckedChanged += new System.EventHandler(this.RdbColor_Changed);
            // 
            // rbdWhite
            // 
            this.rbdWhite.AutoSize = true;
            this.rbdWhite.Location = new System.Drawing.Point(103, 42);
            this.rbdWhite.Name = "rbdWhite";
            this.rbdWhite.Size = new System.Drawing.Size(53, 17);
            this.rbdWhite.TabIndex = 1;
            this.rbdWhite.Tag = "";
            this.rbdWhite.Text = "White";
            this.rbdWhite.UseVisualStyleBackColor = true;
            this.rbdWhite.CheckedChanged += new System.EventHandler(this.RdbColor_Changed);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Checked = true;
            this.rdbBlack.Location = new System.Drawing.Point(18, 42);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Tag = "";
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.RdbColor_Changed);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnNext);
            this.pnlNavigation.Controls.Add(this.btnPrevious);
            this.pnlNavigation.Controls.Add(this.btnAddPhotos);
            this.pnlNavigation.Controls.Add(this.lblCreationDate);
            this.pnlNavigation.Controls.Add(this.lblDescription);
            this.pnlNavigation.Controls.Add(this.txtDescription);
            this.pnlNavigation.Location = new System.Drawing.Point(536, 12);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(260, 212);
            this.pnlNavigation.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(185, 157);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(94, 157);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnAddPhotos
            // 
            this.btnAddPhotos.Enabled = false;
            this.btnAddPhotos.Location = new System.Drawing.Point(3, 157);
            this.btnAddPhotos.Name = "btnAddPhotos";
            this.btnAddPhotos.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhotos.TabIndex = 3;
            this.btnAddPhotos.Text = "Add Photos";
            this.btnAddPhotos.UseVisualStyleBackColor = true;
            this.btnAddPhotos.Click += new System.EventHandler(this.BtnAddPhotos_Click);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(3, 137);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(0, 13);
            this.lblCreationDate.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(0, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 112);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.Location = new System.Drawing.Point(539, 342);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(78, 23);
            this.btnCreateAlbum.TabIndex = 3;
            this.btnCreateAlbum.Text = "Create Album";
            this.btnCreateAlbum.UseVisualStyleBackColor = true;
            this.btnCreateAlbum.Click += new System.EventHandler(this.BtnCreateAlbum_Click);
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Location = new System.Drawing.Point(630, 342);
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAlbum.TabIndex = 4;
            this.btnOpenAlbum.Text = "Open Album";
            this.btnOpenAlbum.UseVisualStyleBackColor = true;
            this.btnOpenAlbum.Click += new System.EventHandler(this.BtnOpenAlbum_Click);
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Enabled = false;
            this.btnSaveAlbum.Location = new System.Drawing.Point(721, 342);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAlbum.TabIndex = 5;
            this.btnSaveAlbum.Text = "Save Album";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.BtnSaveAlbum_Click);
            // 
            // PhotoAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.btnSaveAlbum);
            this.Controls.Add(this.btnOpenAlbum);
            this.Controls.Add(this.btnCreateAlbum);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.grbCanvasColor);
            this.Controls.Add(this.picPictureBox);
            this.MaximizeBox = false;
            this.Name = "PhotoAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhotoAlbumForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picPictureBox)).EndInit();
            this.grbCanvasColor.ResumeLayout(false);
            this.grbCanvasColor.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPictureBox;
        private System.Windows.Forms.GroupBox grbCanvasColor;
        private System.Windows.Forms.RadioButton rdbGray;
        private System.Windows.Forms.RadioButton rbdWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddPhotos;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnCreateAlbum;
        private System.Windows.Forms.Button btnOpenAlbum;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

