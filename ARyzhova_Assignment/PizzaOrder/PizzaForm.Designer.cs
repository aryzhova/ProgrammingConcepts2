namespace PizzaOrder
{
    partial class PizzaForm
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
            this.pnlHowMany = new System.Windows.Forms.Panel();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.txtHowMany = new System.Windows.Forms.TextBox();
            this.lblHowMany = new System.Windows.Forms.Label();
            this.pnlPizzas = new System.Windows.Forms.Panel();
            this.pnlToppings = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.grbCheese = new System.Windows.Forms.GroupBox();
            this.rdbCheeseHeavy = new System.Windows.Forms.RadioButton();
            this.rdbCheeseNormal = new System.Windows.Forms.RadioButton();
            this.rdbCheeseLight = new System.Windows.Forms.RadioButton();
            this.rdbCheeseNone = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkOlivesGreen = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkOlivesBlack = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grbSauce = new System.Windows.Forms.GroupBox();
            this.rdbSauceNone = new System.Windows.Forms.RadioButton();
            this.rdbSauceLight = new System.Windows.Forms.RadioButton();
            this.rdbSauceNormal = new System.Windows.Forms.RadioButton();
            this.rdbSauceHeavy = new System.Windows.Forms.RadioButton();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.pnlHowMany.SuspendLayout();
            this.pnlToppings.SuspendLayout();
            this.grbCheese.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbSauce.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHowMany
            // 
            this.pnlHowMany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHowMany.Controls.Add(this.btnStartOrder);
            this.pnlHowMany.Controls.Add(this.txtHowMany);
            this.pnlHowMany.Controls.Add(this.lblHowMany);
            this.pnlHowMany.Location = new System.Drawing.Point(6, 5);
            this.pnlHowMany.Name = "pnlHowMany";
            this.pnlHowMany.Size = new System.Drawing.Size(187, 78);
            this.pnlHowMany.TabIndex = 0;
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Location = new System.Drawing.Point(91, 39);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(75, 23);
            this.btnStartOrder.TabIndex = 2;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.BtnStartOrder_Click);
            // 
            // txtHowMany
            // 
            this.txtHowMany.Location = new System.Drawing.Point(131, 13);
            this.txtHowMany.Name = "txtHowMany";
            this.txtHowMany.Size = new System.Drawing.Size(35, 20);
            this.txtHowMany.TabIndex = 1;
            // 
            // lblHowMany
            // 
            this.lblHowMany.AutoSize = true;
            this.lblHowMany.Location = new System.Drawing.Point(29, 16);
            this.lblHowMany.Name = "lblHowMany";
            this.lblHowMany.Size = new System.Drawing.Size(95, 13);
            this.lblHowMany.TabIndex = 0;
            this.lblHowMany.Text = "How many pizzas?";
            // 
            // pnlPizzas
            // 
            this.pnlPizzas.AutoScroll = true;
            this.pnlPizzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizzas.Enabled = false;
            this.pnlPizzas.Location = new System.Drawing.Point(6, 89);
            this.pnlPizzas.Name = "pnlPizzas";
            this.pnlPizzas.Size = new System.Drawing.Size(187, 424);
            this.pnlPizzas.TabIndex = 1;
            // 
            // pnlToppings
            // 
            this.pnlToppings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToppings.Controls.Add(this.btnCheckOut);
            this.pnlToppings.Controls.Add(this.lblInstructions);
            this.pnlToppings.Controls.Add(this.txtInstructions);
            this.pnlToppings.Controls.Add(this.grbCheese);
            this.pnlToppings.Controls.Add(this.grbToppings);
            this.pnlToppings.Controls.Add(this.grbSauce);
            this.pnlToppings.Enabled = false;
            this.pnlToppings.Location = new System.Drawing.Point(202, 5);
            this.pnlToppings.Name = "pnlToppings";
            this.pnlToppings.Size = new System.Drawing.Size(352, 508);
            this.pnlToppings.TabIndex = 2;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.Location = new System.Drawing.Point(12, 457);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(318, 33);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(9, 340);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(99, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Special Instructions";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(12, 356);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(318, 86);
            this.txtInstructions.TabIndex = 5;
            this.txtInstructions.TextChanged += new System.EventHandler(this.TxtInstructions_TextChanged);
            // 
            // grbCheese
            // 
            this.grbCheese.Controls.Add(this.rdbCheeseHeavy);
            this.grbCheese.Controls.Add(this.rdbCheeseNormal);
            this.grbCheese.Controls.Add(this.rdbCheeseLight);
            this.grbCheese.Controls.Add(this.rdbCheeseNone);
            this.grbCheese.Location = new System.Drawing.Point(12, 253);
            this.grbCheese.Name = "grbCheese";
            this.grbCheese.Size = new System.Drawing.Size(318, 83);
            this.grbCheese.TabIndex = 2;
            this.grbCheese.TabStop = false;
            this.grbCheese.Text = "Cheese";
            // 
            // rdbCheeseHeavy
            // 
            this.rdbCheeseHeavy.AutoSize = true;
            this.rdbCheeseHeavy.Location = new System.Drawing.Point(247, 32);
            this.rdbCheeseHeavy.Name = "rdbCheeseHeavy";
            this.rdbCheeseHeavy.Size = new System.Drawing.Size(56, 17);
            this.rdbCheeseHeavy.TabIndex = 3;
            this.rdbCheeseHeavy.Text = "Heavy";
            this.rdbCheeseHeavy.UseVisualStyleBackColor = true;
            this.rdbCheeseHeavy.Click += new System.EventHandler(this.RdbCheese_Click);
            // 
            // rdbCheeseNormal
            // 
            this.rdbCheeseNormal.AutoSize = true;
            this.rdbCheeseNormal.Checked = true;
            this.rdbCheeseNormal.Location = new System.Drawing.Point(167, 32);
            this.rdbCheeseNormal.Name = "rdbCheeseNormal";
            this.rdbCheeseNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbCheeseNormal.TabIndex = 2;
            this.rdbCheeseNormal.TabStop = true;
            this.rdbCheeseNormal.Text = "Normal";
            this.rdbCheeseNormal.UseVisualStyleBackColor = true;
            this.rdbCheeseNormal.Click += new System.EventHandler(this.RdbCheese_Click);
            // 
            // rdbCheeseLight
            // 
            this.rdbCheeseLight.AutoSize = true;
            this.rdbCheeseLight.Location = new System.Drawing.Point(93, 32);
            this.rdbCheeseLight.Name = "rdbCheeseLight";
            this.rdbCheeseLight.Size = new System.Drawing.Size(48, 17);
            this.rdbCheeseLight.TabIndex = 1;
            this.rdbCheeseLight.Text = "Light";
            this.rdbCheeseLight.UseVisualStyleBackColor = true;
            this.rdbCheeseLight.Click += new System.EventHandler(this.RdbCheese_Click);
            // 
            // rdbCheeseNone
            // 
            this.rdbCheeseNone.AutoSize = true;
            this.rdbCheeseNone.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbCheeseNone.Location = new System.Drawing.Point(19, 32);
            this.rdbCheeseNone.Name = "rdbCheeseNone";
            this.rdbCheeseNone.Size = new System.Drawing.Size(51, 17);
            this.rdbCheeseNone.TabIndex = 0;
            this.rdbCheeseNone.Text = "None";
            this.rdbCheeseNone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbCheeseNone.UseVisualStyleBackColor = true;
            this.rdbCheeseNone.Click += new System.EventHandler(this.RdbCheese_Click);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chkSpinach);
            this.grbToppings.Controls.Add(this.chkTomato);
            this.grbToppings.Controls.Add(this.chkHam);
            this.grbToppings.Controls.Add(this.chkOlivesGreen);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkPineapple);
            this.grbToppings.Controls.Add(this.chkBacon);
            this.grbToppings.Controls.Add(this.chkOlivesBlack);
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkPepperoni);
            this.grbToppings.Location = new System.Drawing.Point(12, 83);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(318, 164);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(223, 90);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(65, 17);
            this.chkSpinach.TabIndex = 10;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.CheckedChanged += new System.EventHandler(this.ChkSpinach_CheckedChanged);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(223, 56);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(62, 17);
            this.chkTomato.TabIndex = 9;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.ChkTomato_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(223, 24);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(48, 17);
            this.chkHam.TabIndex = 8;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.ChkHam_CheckedChanged);
            // 
            // chkOlivesGreen
            // 
            this.chkOlivesGreen.AutoSize = true;
            this.chkOlivesGreen.Location = new System.Drawing.Point(127, 122);
            this.chkOlivesGreen.Name = "chkOlivesGreen";
            this.chkOlivesGreen.Size = new System.Drawing.Size(87, 17);
            this.chkOlivesGreen.TabIndex = 7;
            this.chkOlivesGreen.Text = "Olives Green";
            this.chkOlivesGreen.UseVisualStyleBackColor = true;
            this.chkOlivesGreen.CheckedChanged += new System.EventHandler(this.ChkOlivesGreen_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(127, 90);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.ChkOnion_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(127, 56);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkPineapple.TabIndex = 5;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.ChkPineapple_CheckedChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(127, 24);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 4;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.ChkBacon_CheckedChanged);
            // 
            // chkOlivesBlack
            // 
            this.chkOlivesBlack.AutoSize = true;
            this.chkOlivesBlack.Location = new System.Drawing.Point(19, 122);
            this.chkOlivesBlack.Name = "chkOlivesBlack";
            this.chkOlivesBlack.Size = new System.Drawing.Size(88, 17);
            this.chkOlivesBlack.TabIndex = 3;
            this.chkOlivesBlack.Text = "Olives, Black";
            this.chkOlivesBlack.UseVisualStyleBackColor = true;
            this.chkOlivesBlack.CheckedChanged += new System.EventHandler(this.ChkOlivesBlack_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(19, 90);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 2;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.ChkGreenPeppers_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(19, 56);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.ChkMushrooms_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Checked = true;
            this.chkPepperoni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPepperoni.Location = new System.Drawing.Point(19, 24);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.ChkPepperoni_CheckedChanged);
            // 
            // grbSauce
            // 
            this.grbSauce.Controls.Add(this.rdbSauceNone);
            this.grbSauce.Controls.Add(this.rdbSauceLight);
            this.grbSauce.Controls.Add(this.rdbSauceNormal);
            this.grbSauce.Controls.Add(this.rdbSauceHeavy);
            this.grbSauce.Location = new System.Drawing.Point(12, 13);
            this.grbSauce.Name = "grbSauce";
            this.grbSauce.Size = new System.Drawing.Size(318, 64);
            this.grbSauce.TabIndex = 0;
            this.grbSauce.TabStop = false;
            this.grbSauce.Text = "Sauce";
            // 
            // rdbSauceNone
            // 
            this.rdbSauceNone.AutoSize = true;
            this.rdbSauceNone.Location = new System.Drawing.Point(19, 25);
            this.rdbSauceNone.Name = "rdbSauceNone";
            this.rdbSauceNone.Size = new System.Drawing.Size(51, 17);
            this.rdbSauceNone.TabIndex = 1;
            this.rdbSauceNone.Text = "None";
            this.rdbSauceNone.UseVisualStyleBackColor = true;
            this.rdbSauceNone.Click += new System.EventHandler(this.RdbSauce_Click);
            // 
            // rdbSauceLight
            // 
            this.rdbSauceLight.AutoSize = true;
            this.rdbSauceLight.Location = new System.Drawing.Point(93, 25);
            this.rdbSauceLight.Name = "rdbSauceLight";
            this.rdbSauceLight.Size = new System.Drawing.Size(48, 17);
            this.rdbSauceLight.TabIndex = 2;
            this.rdbSauceLight.Text = "Light";
            this.rdbSauceLight.UseVisualStyleBackColor = true;
            this.rdbSauceLight.Click += new System.EventHandler(this.RdbSauce_Click);
            // 
            // rdbSauceNormal
            // 
            this.rdbSauceNormal.AutoSize = true;
            this.rdbSauceNormal.Checked = true;
            this.rdbSauceNormal.Location = new System.Drawing.Point(167, 25);
            this.rdbSauceNormal.Name = "rdbSauceNormal";
            this.rdbSauceNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbSauceNormal.TabIndex = 3;
            this.rdbSauceNormal.TabStop = true;
            this.rdbSauceNormal.Text = "Normal";
            this.rdbSauceNormal.UseVisualStyleBackColor = true;
            this.rdbSauceNormal.Click += new System.EventHandler(this.RdbSauce_Click);
            // 
            // rdbSauceHeavy
            // 
            this.rdbSauceHeavy.AutoSize = true;
            this.rdbSauceHeavy.Location = new System.Drawing.Point(247, 25);
            this.rdbSauceHeavy.Name = "rdbSauceHeavy";
            this.rdbSauceHeavy.Size = new System.Drawing.Size(56, 17);
            this.rdbSauceHeavy.TabIndex = 4;
            this.rdbSauceHeavy.Text = "Heavy";
            this.rdbSauceHeavy.UseVisualStyleBackColor = true;
            this.rdbSauceHeavy.Click += new System.EventHandler(this.RdbSauce_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSummary.Controls.Add(this.btnNewOrder);
            this.pnlSummary.Controls.Add(this.txtSummary);
            this.pnlSummary.Location = new System.Drawing.Point(561, 5);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(254, 508);
            this.pnlSummary.TabIndex = 3;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.Green;
            this.btnNewOrder.Location = new System.Drawing.Point(19, 458);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(219, 33);
            this.btnNewOrder.TabIndex = 4;
            this.btnNewOrder.Text = "Start New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSummary.Location = new System.Drawing.Point(14, 3);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(224, 402);
            this.txtSummary.TabIndex = 1;
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 525);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlToppings);
            this.Controls.Add(this.pnlPizzas);
            this.Controls.Add(this.pnlHowMany);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.pnlHowMany.ResumeLayout(false);
            this.pnlHowMany.PerformLayout();
            this.pnlToppings.ResumeLayout(false);
            this.pnlToppings.PerformLayout();
            this.grbCheese.ResumeLayout(false);
            this.grbCheese.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbSauce.ResumeLayout(false);
            this.grbSauce.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHowMany;
        private System.Windows.Forms.TextBox txtHowMany;
        private System.Windows.Forms.Label lblHowMany;
        private System.Windows.Forms.Panel pnlPizzas;
        private System.Windows.Forms.Panel pnlToppings;
        private System.Windows.Forms.GroupBox grbSauce;
        private System.Windows.Forms.RadioButton rdbSauceNone;
        private System.Windows.Forms.RadioButton rdbSauceLight;
        private System.Windows.Forms.RadioButton rdbSauceNormal;
        private System.Windows.Forms.RadioButton rdbSauceHeavy;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkOlivesGreen;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkOlivesBlack;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox grbCheese;
        private System.Windows.Forms.RadioButton rdbCheeseHeavy;
        private System.Windows.Forms.RadioButton rdbCheeseNormal;
        private System.Windows.Forms.RadioButton rdbCheeseLight;
        private System.Windows.Forms.RadioButton rdbCheeseNone;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnNewOrder;
    }
}

