using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlantsShopAdmin.Tabs
{
    public partial class User : UserControl
    {
        public int Pcount;
        public int FlowerID;
        public int ID;
        public string UserID;
        public string UserName;
        public string Phone;
        public string Adress;
        public int PPrice;
        public User()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Server server = new Server();

            bool isDelete = server.DeleteFromTickets(ID, Pcount, FlowerID, true);

            if (isDelete)
            {
                Program.Orders.Orders.Controls.Clear();

                List<Tabs.User> users = server.usersOrders();
                foreach (var flower in users)
                {
                    Program.Orders.Orders.Controls.Add(flower);
                }

            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void Complite_Click(object sender, EventArgs e)
        {
            Server server = new Server();

            server.BackupFLower(UserName, UserID, Phone, Adress, FlowerID, Pcount, PPrice, ID);

            Program.Orders.Orders.Controls.Clear();

            List<Tabs.User> users = server.usersOrders();
            foreach (var flower in users)
            {
                Program.Orders.Orders.Controls.Add(flower);
            }

        }
    }
}
