using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop.Tabs
{
    public partial class Buy : UserControl
    {
        public int ID;
        public int FlowerID;
        public int Pcount;
        public int PPrice;
        public Buy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Program.GlobalTab.HideTabs();
            int Last = Program.LastTab;
            switch (Last)
            {
                case 0:
                    Program.GlobalTab.home.Visible = true;
                    break;
                case 1:
                    Program.GlobalTab.news.Visible = true;
                    break;
                case 2:
                    Program.GlobalTab.catalog.Visible = true;
                    break;
                case 3:
                    Program.GlobalTab.instruction.Visible = true;
                    break;
                case 4:
                    Program.GlobalTab.basket.Visible = true;
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        static string UniqueMachineId()
        {
            StringBuilder builder = new StringBuilder();

            String query = "SELECT * FROM Win32_BIOS";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            //  This should only find one
            foreach (ManagementObject item in searcher.Get())
            {
                Object obj = item["SerialNumber"];
                builder.Append(Convert.ToString(obj));
            }

            return builder.ToString();
        }

        private void BuyFlower_Click(object sender, EventArgs e)
        {
            if((UserAdress.Text.Length > 5) && (UserName.Text.Length >= 3) && (UserNumber.Text.Length > 8))
            {
                Server server = new Server();
                server.DeleteFromBacket(ID, Pcount, FlowerID, false);
                server.OrderFlower(ID, Pcount, FlowerID, UniqueMachineId(), UserAdress.Text, UserName.Text, UserNumber.Text, PPrice);
                MessageBox.Show("Дякуюємо за покупку, Очікуйте дзвінка");
                Back_Click(sender, e);

                Program.basket.UserBacket.Controls.Clear();

                List<Tabs.UserFlower> users = server.UserBusket(UniqueMachineId());

                foreach (var flower in users)
                {
                    Program.basket.UserBacket.Controls.Add(flower);
                }
            }
            else MessageBox.Show("Будь ласка, перевірте коректність даних");
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            Server server = new Server();
            UsersData data = server.Data(UniqueMachineId());
            UserName.Text = data.UserName;
            UserAdress.Text = data.UserAdress;
            UserNumber.Text = data.UserPhone;
        }
    }
}
