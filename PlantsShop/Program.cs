using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop
{
    static class Program
    {
        public static Tabs.Order GlobalOrder;
        public static Form1 GlobalTab;
        public static int LastTab;
        public static Tabs.Basket basket;
        public static Tabs.Buy buy;
        public static Tabs.Catalog catalog;
        public static Tabs.Home home;
        public static Tabs.New news;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
