using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DND
{
    class ItemStack
    {
        //Eigenschaften
        public string Name { get; set; }
        public UInt32 Quantity { get; set; }
        public decimal WeightPerItem { 
            get
            {
                MessageBox.Show("TODO: Das Gewicht aus der Klasse ItemStack.cs muss noch aus der API gezogen werden.");
                return 0;
            } 
        }

        //Konstruktor
        public ItemStack(string name, UInt32 quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}
