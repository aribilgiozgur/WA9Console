using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA9Console.WA9Service;

namespace WA9Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WA9ServiceClient client = new WA9ServiceClient();
            List<Item> items = client.getAllItems().ToList();
            foreach (Item i in items)
            {
                Console.WriteLine(i.ItemName +"-"+i.ItemCount.ToString());
            }

            Item it = new Item();
            it.ItemName = "Konsoldan...";
            it.ItemCount = 99;
            Console.WriteLine(client.insertItem(it));


            Console.ReadLine();

        }
    }
}
