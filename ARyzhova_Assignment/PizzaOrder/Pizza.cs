using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class Pizza
    {
        public string sauce;

        public bool hasPepperoni = false;
        public bool hasMushrooms = false;
        public bool hasGreenPeppers = false;
        public bool hasOlivesBlack = false;
        public bool hasBacon = false;
        public bool hasPineapple = false;
        public bool hasOnion = false;
        public bool hasOlivesGreen = false;
        public bool hasHam = false;
        public bool hasTomato = false;
        public bool hasSpinach = false;

        public string cheese;

        public string instructions;


        public Pizza()
        {
            sauce = "Normal";
            cheese = "Normal";
            instructions = "";

        }

       public string GetPizzaInfo()
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine($"Sauce: {sauce}");
            description.AppendLine("Toppings: ");

            if (hasPepperoni)
                description.Append("    -Pepperoni\r\n");
            if (hasMushrooms)
                description.Append("    -Mushrooms\r\n");
            if (hasGreenPeppers)
                description.Append("    -Green Peppers\r\n");
            if (hasOlivesBlack)
                description.Append("    -Olives, Black\r\n");
            if (hasBacon)
                description.Append("    -Bacon\r\n");
            if (hasPineapple)
                description.Append("    -Pineapple\r\n");
            if (hasOnion)
                description.Append("    -Onion\r\n");
            if (hasOlivesGreen)
                description.Append("    -Olives, Green\r\n");
            if (hasHam)
                description.Append("    -Ham\r\n");
            if (hasTomato)
                description.Append("    -Tomato\r\n");
            if (hasSpinach)
                description.Append("    -Spinach\r\n");

            description.AppendLine($"Cheese: {cheese}");
            description.AppendLine($"Instructions: {instructions}");

            return description.ToString();

        }


    }
}
