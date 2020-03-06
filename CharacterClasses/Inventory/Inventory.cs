using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace DND
{
    class Inventory
    {
        public static async Task<string> GetEquipmentInformation(string equipment)
        {


            string baseUrl = "http://dnd5eapi.co/api/races/starting-equipment/1";
            baseUrl = baseUrl.Replace("starting-equipment/1", equipment);
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                            else
                            {
                                return data;
                            }
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Found ----- {0}", exception);
                return null;
            }
        }

        public async Task<string> fetchAPI(string equipment)
        {
            var infor = await GetEquipmentInformation(equipment).ConfigureAwait(false);
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject(infor);
            var fetchdata = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
            Regex.Unescape(fetchdata);
            fetchdata = fetchdata.Replace("[", "").Replace("]", "").Replace("\"", "").Replace("{", "").Replace("}", "").Replace(":", "").Replace(",", "");
            fetchdata = Regex.Replace(fetchdata, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return fetchdata;
        }

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
