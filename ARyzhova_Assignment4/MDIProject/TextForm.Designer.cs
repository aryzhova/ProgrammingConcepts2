﻿namespace MDIProject
{
    partial class TextForm
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
            this.txtTextDoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTextDoc
            // 
            this.txtTextDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextDoc.Location = new System.Drawing.Point(0, 0);
            this.txtTextDoc.Multiline = true;
            this.txtTextDoc.Name = "txtTextDoc";
            this.txtTextDoc.Size = new System.Drawing.Size(562, 374);
            this.txtTextDoc.TabIndex = 0;
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 374);
            this.Controls.Add(this.txtTextDoc);
            this.Name = "TextForm";
            this.Text = "Text Document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextDoc;
    }
}