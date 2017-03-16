using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuItem taco = new MenuItem("taco", "mexican", "Tasty", 2.99m, true);
            Menu menu = new Menu();
            menu.Items.Add(taco);

            Console.WriteLine(menu.Items);
            Console.ReadLine();
        }
    }
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
    }

    public class MenuItem
    {
        /* 
         * List<int> itemId = new List<int>();
        List<string> catagoryName = new List<string>();
        List<string> itemName = new List<string>();
        List<string> itemDescription = new List<string>();
        List<bool> itemNew = new List<bool>();
        string NewItem;
        */

        public string Name { get; set; }
        public string Catagory { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool NewItem { get; set; }

        public MenuItem(string name, string catagory, string description, decimal price, bool newItem)
        {
            Name = name;
            Catagory = catagory;
            Description = description;
            Price = price;
            NewItem = newItem;
        }
    }
}
