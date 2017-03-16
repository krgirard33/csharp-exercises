using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    public class Menu
    {

    }

    public class MenuItem 
    {
        List<int> itemId = new List<int>();
        List<string> catagoryName = new List<string>();
        List<string> itemName = new List<string>();
        List<string> itemDescription = new List<string>();
        List<bool> itemNew = new List<bool>();
        string NewItem;

        public int ID { get; set; }
        public string Catagory { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool New { get; set; } 
    }

    public class Item
    {

    }
}
