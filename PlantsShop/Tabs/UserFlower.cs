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
    public partial class UserFlower : UserControl
    {
        public int ID;
        public int FlowerID;
        public int Pcount;
        public int PPrice;
        public UserFlower()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Server server = new Server();

            bool isDelete = server.DeleteFromBacket(ID, Pcount, FlowerID, true);
            if (isDelete)
            {
                Program.basket.UserBacket.Controls.Clear();

                List<Tabs.UserFlower> users = server.UserBusket(UniqueMachineId());

                foreach (var flower in users)
                {
                    Program.basket.UserBacket.Controls.Add(flower);
                }
                
            }
           
            
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

        private void panel1_Click(object sender, EventArgs e)
        { pictureBox2_Click(sender, e);}

        private void Buy_Click(object sender, EventArgs e)
        {
            Program.buy.FlowerName.Text = FlowerName.Text;
            Program.buy.FlowerCount.Text = "Кількість: " + Pcount;
            Program.buy.Picture.Image = Picture.Image;
            Program.buy.ID = ID;
            Program.buy.Pcount = Pcount;
            Program.buy.PPrice = PPrice;
            Program.buy.FlowerID = FlowerID;
            Program.GlobalTab.HideTabs();
            Program.buy.Visible = true;
        }
    }
}
