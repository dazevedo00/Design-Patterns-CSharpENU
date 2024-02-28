using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    // This class represents the product
    internal abstract class Pizza
    {
        // Private field for storing ingredients
        private readonly List<string> ingredients = new List<string>();

        // Properties for pizza attributes
        protected string Name { get; set; }
        protected string Dough;
        protected string Sauce;

        // Method to make a pizza with a template algorithm
        public string MakePizza()
        {
            // StringBuilder for efficient string concatenation
            StringBuilder sb = new StringBuilder();

            // Append pizza-making steps to StringBuilder
            sb.AppendLine($"Making {Name}");
            sb.AppendLine(Dough);
            sb.AppendLine("Ingredients");
            sb.AppendLine(string.Join(Environment.NewLine, ingredients));
            sb.AppendLine(Cook());
            sb.AppendLine(Slice());
            sb.AppendLine(Pack());

            // Return the final pizza-making details
            return sb.ToString();
        }

        // Template method for cooking the pizza
        protected virtual string Cook()
        {
            return "Cook 35 min with 180º";
        }

        // Template method for slicing the pizza
        protected virtual string Slice()
        {
            return "Slice into 8 pieces";
        }

        // Template method for packing the pizza
        protected virtual string Pack()
        {
            return "Official package";
        }

        // Property to expose ingredients as readonly
        protected List<string> Ingredients => ingredients;

        // Method to add an ingredient to the pizza
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }
    }
}
