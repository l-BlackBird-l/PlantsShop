using System;
using System.Windows.Forms;

namespace PlantsShopAdmin
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static bool Aut = false;
        public static Tabs.Autorization autor;
        public static Tabs.Catalog catalog;
        public static Tabs.UsersOrder Orders;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
