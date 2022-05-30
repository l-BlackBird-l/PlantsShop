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
    public partial class Order : UserControl
    {
        public  int PPrice;
        public  int Pcount;
        public int ID;
        public int TotalPrice;
   

        public Order()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void Buy_Click(object sender, EventArgs e)
        {
            if (UserCount.Value <= Pcount && UserCount.Value.ToString() != "") 
            {
                  Server server = new Server();
                server.BuyFlower(UniqueMachineId(), ID, Convert.ToInt32(UserCount.Value), TotalPrice);

                MessageBox.Show("Товар додано до вашого кошику");
                Program.GlobalTab.UpdateData(Program.catalog.Flowers);
                Back_Click(sender, e);
                Program.GlobalTab.UpdateData(Program.home.Hits);
                Program.GlobalTab.UpdateData(Program.catalog.Flowers);
                Program.GlobalTab.UpdateData(Program.news.Flowers);
            }
            else
            {
                MessageBox.Show("Немає такої кількості товару");
            }
        }

        private void Order_Load(object sender, EventArgs e)
        { UserCount.Maximum = Pcount; label2.Text = "Загальна ціна: " + PPrice + "грн."; TotalPrice = PPrice; UserCount.Value = 1; }


        private void UserCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (UserCount.Value <= Pcount && UserCount.Value.ToString() != "")
            {
                int FullPrice = Convert.ToInt32(UserCount.Value) * PPrice;
                TotalPrice = FullPrice;

                label2.Text = "Загальна ціна: " + FullPrice.ToString() + "грн.";

            }
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
    }
}
