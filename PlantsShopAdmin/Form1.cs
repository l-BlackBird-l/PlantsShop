using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PlantsShopAdmin
{


    public partial class Form1 : Form
    {
        Tabs.Autorization autorization = new Tabs.Autorization();
        Tabs.Catalog catalog = new Tabs.Catalog();
        Tabs.UsersOrder order = new Tabs.UsersOrder();
        Tabs.AddFlower add = new Tabs.AddFlower();
        Tabs.EditFlower edit = new Tabs.EditFlower();

        public Form1()
        {

            InitializeComponent();

            Program.autor = autorization;
            Program.catalog = catalog;
            Program.Aut = true;
            Program.Orders = order;
            Tab.Controls.Add(autorization);

            Tab.Controls.Add(catalog);
            Tab.Controls.Add(order);
            Tab.Controls.Add(add);
            Tab.Controls.Add(edit);

            HideTabs();
            // catalog.Visible = true;
            AddAllPlants();
        }


        void AddAllPlants()
        {
            Server server = new Server();

            List<Tabs.Flower> flower = server.LoadFlower();

            int blockY = 0;
            int blockSizeX = flower[0].Width + 35;
            int blockSizeY = flower[0].Height + 20;

            for (int i = 0; i < flower.Count; i++)
            {
                if (i % 2 != 0)
                {
                    flower[i].Left = blockSizeX;
                    flower[i].Top = blockSizeY * blockY;
                }
                else
                {
                    if (i >= 1) blockY++;
                    flower[i].Top = blockSizeY * blockY;
                }

            }

            flower = flower.OrderBy(x => x.FlowerName.Text).ToList();
            LoadSorting(flower);

        }

        public void LoadSorting(List<Tabs.Flower> flower)
        {
            for (int i = 0; i < flower.Count; i++)
            {
                flower[i].Top = 0;
                flower[i].Left = 0;
            }


            int blockY = 0;
            int blockSizeX = 0;
            int blockSizeY = 0;

            if (flower.Count > 0)
            {
                blockSizeX = flower[0].Width + 35;
                blockSizeY = flower[0].Height + 20;
            }
            for (int i = 0; i < flower.Count; i++)
            {
                if (i % 2 != 0)
                {
                    flower[i].Left = blockSizeX;
                    flower[i].Top = blockSizeY * blockY;
                }
                else
                {
                    if (i >= 1) blockY++;
                    flower[i].Top = blockSizeY * blockY;
                }


                catalog.Flowers.Controls.Add(flower[i]);
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // Перетаскування форми
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // Закриття форми
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Скриття всіх панелів
        public void HideTabs()
        {
            catalog.Visible = false;
            order.Visible = false;
            add.Visible = false;
            edit.Visible = false;

        }


        // Перекидання каретки, показ потрібного пункту
        private void Catalog_Click(object sender, EventArgs e)
        {
            if (Program.Aut)
            {
                carets.Top = Catalog.Top;
                HideTabs();
                catalog.Flowers.Controls.Clear();
                AddAllPlants();
                catalog.Visible = true;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Program.Aut)
            {
                carets.Top = AddFlowers.Top;
                HideTabs();
                add.Visible = true;
            }
        }

        public void UpdateData(Panel panel)
        {

        }


        private void Edit_Click(object sender, EventArgs e)
        {
            if (Program.Aut)
            {
                carets.Top = EditFlowers.Top;
                HideTabs();
                edit.Visible = true;
                Server server = new Server();
                edit.FlowersName.Items.Clear();

                List<string> Names = server.GetFlowersName();

                foreach (string name in Names)
                {
                    edit.FlowersName.Items.Add(name);
                }
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            if (Program.Aut)
            {
                carets.Top = Orders.Top;
                HideTabs();
                order.Visible = true;

                Server server = new Server();
                List<Tabs.User> users = server.usersOrders();
                order.Orders.Controls.Clear();

                foreach (var obj in users)
                {
                    order.Orders.Controls.Add(obj);
                }
            }
        }



        private void Main_Click(object sender, EventArgs e)
        { Catalog_Click(sender, e); }

        private void pictureBox1_Click(object sender, EventArgs e)
        { Catalog_Click(sender, e); }

        private void label2_Click(object sender, EventArgs e)
        { Add_Click(sender, e); }

        private void pictureBox2_Click(object sender, EventArgs e)
        { Add_Click(sender, e); }

        private void label4_Click(object sender, EventArgs e)
        { Edit_Click(sender, e); }

        private void pictureBox4_Click(object sender, EventArgs e)
        { Edit_Click(sender, e); }

        private void label3_Click(object sender, EventArgs e)
        { Order_Click(sender, e); }

        private void pictureBox3_Click(object sender, EventArgs e)
        { Order_Click(sender, e); }



    }
}
