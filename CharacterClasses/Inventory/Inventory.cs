using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class Inventory
    {
        //Eigenschaften
        public List<ItemStack> Items { get; set; } = new List<ItemStack>();

        public decimal TotalWeight()
        {
            decimal weight = 0;
            foreach (ItemStack itemstack in Items)
            {
                weight += itemstack.Quantity * itemstack.WeightPerItem;
            }
            return weight; 
        }
    }
}
