using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class PizzaForm : Form
    {
        private Pizza activePizza;
        //declaring an array where we will store user's pizzas
        //we will be looping through all pizzas to create order summary
        Pizza[] newOrder = null; 
        public PizzaForm()
        {
            InitializeComponent();
        }

        private void BtnStartOrder_Click(object sender, EventArgs e)
        {

            int userInput;

            //checking if user entered an integer
            if (int.TryParse(txtHowMany.Text, out userInput))
            {
                //checking if user's choice is within required range
                if (userInput > 0 && userInput < 9)
                {

                    pnlPizzas.Enabled = true;//enabling pizza panel
                    int xLocation = 20;
                    int yLocation = 20;
                    int ySpacing = 10;

                    newOrder = new Pizza[userInput];
                    //creating pizza pies on the pizza panel
                    for (int i = 0; i < userInput; i++)
                    {
                        RadioButton pizzaButton = new RadioButton();
                        pizzaButton.Appearance = Appearance.Button;
                        pizzaButton.Width = 130;
                        pizzaButton.Height = 130;
                        pizzaButton.Name = $"Pizza{i + 1}";
                        pizzaButton.Text = $"Pizza {i + 1}";
                        //adding radiobuttons to panel Pizzas 
                        pizzaButton.Location =new Point(xLocation, yLocation +
                            pizzaButton.Height * i + ySpacing * i);

                        this.pnlPizzas.Controls.Add(pizzaButton);

                        //storing each new pizza in array
                        newOrder[i] = new Pizza();
                        //storing pizza object in radiobutton tag
                        pizzaButton.Tag = newOrder[i];

                        pizzaButton.Click += new EventHandler(PizzaHandler);

                        if (i == 0)
                        {
                            activePizza = (Pizza)pizzaButton.Tag;
                            pizzaButton.Checked = true;
                            pnlToppings.Enabled = true;
                        }
                    }
                }
                else  //error message if user's choice is >9
                {
                    MessageBox.Show("Please limit your choice to 9 pizzas");
                }

            }
            else   //showing error message if input is not an integer
            {
                MessageBox.Show("Your input is invalid");
            }
        }
        private void PizzaHandler(object sender, EventArgs e)
        {
            pnlToppings.Enabled = true;

            RadioButton rdb = (RadioButton)sender;

            //setting active pizza to be the one that has been clicked on
            activePizza = (Pizza)rdb.Tag;

            //lines 87-132 uploading previous choices from the active piiza
            switch (activePizza.sauce)
            {
                case "None":
                    rdbSauceNone.Checked = true;
                    break;
                case "Light":
                    rdbSauceLight.Checked = true;
                    break;
                case "Normal":
                    rdbSauceNormal.Checked = true;
                    break;
                case "Heavy":
                    rdbSauceHeavy.Checked = true;
                    break;
            }
            chkPepperoni.Checked = activePizza.hasPepperoni;
            chkMushrooms.Checked = activePizza.hasMushrooms;
            chkGreenPeppers.Checked = activePizza.hasGreenPeppers;
            chkOlivesBlack.Checked = activePizza.hasOlivesBlack;
            chkBacon.Checked = activePizza.hasBacon;
            chkPineapple.Checked = activePizza.hasPineapple;
            chkOnion.Checked = activePizza.hasOnion;
            chkOlivesGreen.Checked = activePizza.hasOlivesGreen;
            chkHam.Checked = activePizza.hasHam;
            chkTomato.Checked = activePizza.hasTomato;
            chkSpinach.Checked = activePizza.hasSpinach;

            switch (activePizza.cheese)
            {
                case "None":
                    rdbCheeseNone.Checked = true;
                    break;
                case "Light":
                    rdbCheeseLight.Checked = true;
                    break;
                case "Normal":
                    rdbCheeseNormal.Checked = true;
                    break;
                case "Heavy":
                    rdbCheeseHeavy.Checked = true;
                    break;
            }

            txtInstructions.Text = activePizza.instructions;
        }

        //lines 135 - 216 writing down user choices into active pizza
        private void RdbSauce_Click(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            activePizza.sauce = rdb.Text;
        }
        private void ChkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasPepperoni = check.Checked;
        }

        private void ChkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasMushrooms = check.Checked;
        }

        private void ChkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasGreenPeppers = check.Checked;
        }

        private void ChkOlivesBlack_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasOlivesBlack = check.Checked;
        }

        private void ChkBacon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasBacon = check.Checked;
        }

        private void ChkPineapple_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasPineapple = check.Checked;
        }

        private void ChkOnion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasOnion = check.Checked;
        }

        private void ChkOlivesGreen_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasOlivesGreen = check.Checked;
        }

        private void ChkHam_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasHam = check.Checked;
        }

        private void ChkTomato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasTomato = check.Checked;
        }

        private void ChkSpinach_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            activePizza.hasSpinach = check.Checked;
        }

        private void RdbCheese_Click(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            activePizza.cheese = radio.Text;
        }

        private void TxtInstructions_TextChanged(object sender, EventArgs e)
        {
            activePizza.instructions = txtInstructions.Text;
        }
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {   
            //stretching the form to show summary
            this.Width = 839;

            pnlHowMany.Enabled = false;
            pnlToppings.Enabled = false;
            pnlPizzas.Enabled = false;

            //preparing output
            StringBuilder summaryString = new StringBuilder("Order Summary:");
            summaryString.AppendLine();
            summaryString.AppendLine("-------------------------");
            summaryString.AppendLine();

            for(int i= 0; i < newOrder.Length; i++)//looping through array of created pizzas
            {
                summaryString.AppendLine($"Pizza {i+1} ");
                                
                //  add the summary string for each pizza in the array to the 
                // summary we are building

                summaryString.AppendLine(newOrder[i].GetPizzaInfo());
            }
            // print this summary to the textbox provided for this purpose
            txtSummary.Text = summaryString.ToString();  

        }
 

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            //disposing old form and starting a new one
            PizzaForm NewForm = new PizzaForm();
            NewForm.Show();
            this.Dispose(false);      
        }
    }
}
