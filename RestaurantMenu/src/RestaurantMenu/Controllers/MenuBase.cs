using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Controllers
{
    public class MenuBase
    {
        public static void Main(string[] args)
        {
            MenuItem taco = new MenuItem("Taco Plate", "Main Course", "Tasty", 2.99m, true);
            Menu menu = new Menu();

            menu.Items.Add(taco);
            foreach (MenuItem item in menu.Items)
                Console.WriteLine(item);

            Console.WriteLine(menu.Items);
            Console.ReadLine();
        }
    }
    public class Menu
    {
        public Menu()
        {
            this.Items = new List<MenuItem>();
        }
        public List<MenuItem> Items { get; set; }
    }

    public class MenuItem
    {
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

        public override string ToString()
        {
            return this.Name + " " + this.Price;
        }
    }
}

