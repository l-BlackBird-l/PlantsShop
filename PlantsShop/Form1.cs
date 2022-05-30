using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop
{
 

    public partial class Form1 : Form
    {
       public Tabs.Home home = new Tabs.Home();
       public Tabs.New news = new Tabs.New();
       public Tabs.Catalog catalog = new Tabs.Catalog();
       public Tabs.Instruction instruction = new Tabs.Instruction();
       public Tabs.Basket basket = new Tabs.Basket();
       public Tabs.Order order = new Tabs.Order();
       public Tabs.Buy buy = new Tabs.Buy();

        public Form1()
        {

            Program.GlobalTab = this;
            Program.GlobalOrder = order;
            Program.basket = basket;
            Program.buy = buy;
            Program.catalog = catalog;
            Program.home = home;
            Program.news = news;
            InitializeComponent();

            AddNewPlants();

            Tab.Controls.Add(home);
            Tab.Controls.Add(news);
            Tab.Controls.Add(catalog);
            Tab.Controls.Add(instruction);
            Tab.Controls.Add(basket);
            Tab.Controls.Add(order);
            Tab.Controls.Add(buy);

            HideTabs();
   

            home.Visible = true;
            AddHitsFlowers();

            AddAllPlants();

            CreateFloatingExpander("Як купити рослину?", "Перейдіть в розділ \"Каталог\", оберіть потрібну рослину, натисніть на кнопку \"Купить\", після чого товар буде додано у ваш кошик, відти ми зможете замовити товар.", 20, 100);
            CreateFloatingExpander("Як оформити замовлення?", "Зайдіть в розділ \"Корзина\", виберіть кількість товару та натисніть \"Купити\".Після цього запоніть всю інформацію для доставки.", 20, 150);
            CreateFloatingExpander("Як знайти ту чи іншу рослину?", "Перейдіть в розділ \"Каталог\", оберіть потрібну рослину, натисніть на кнопку \"Купить\", після чого товар буде додано у ваш кошик, відти ми зможете замовити товар.", 20, 200);
            CreateFloatingExpander("Скільки рослин одного виду можна купити?", "Перейдіть в розділ \"Каталог\", оберіть потрібну рослину, натисніть на кнопку \"Купить\", після чого товар буде додано у ваш кошик, відти ми зможете замовити товар.", 20, 250);

        }
        void AddHitsFlowers()
        {
            Server server = new Server();
            List<Tabs.Flower> flowers = server.Hits();
            foreach(var obj in flowers)
            {
                home.Hits.Controls.Add(obj);
            }

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

           flower =  flower.OrderBy(x => x.FlowerName.Text).ToList();
           catalog.LoadSorting(flower);

        }

        void AddNewPlants()
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
            news.LoadSorting(flower);

        }





        private void CreateFloatingExpander(string Title, string Text, int Left, int Top)
        {
            Tabs.Expander expander = new Tabs.Expander();
            expander.Size = new Size(580, 100);
            expander.Left = Left;
            expander.Top = Top;
            expander.BorderStyle = BorderStyle.FixedSingle;

            Tabs.ExpanderHelper.CreateLabelHeader(expander, Title, Properties.Resources.Collapse, Properties.Resources.Expand);

            Label labelContent = new Label();
            labelContent.Text = Text;
            labelContent.Size = new Size(expander.Width, 80);
            expander.Content = labelContent;
            labelContent.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F); ;
            expander.Toggle();
            instruction.Inst.Controls.Add(expander);
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
      public  void HideTabs()
        {
            home.Visible = false;
            news.Visible = false;
            catalog.Visible = false;
            instruction.Visible = false;
            basket.Visible = false;
            order.Visible = false;
            buy.Visible = false;
        }

        // Перекидання каретки, показ потрібного пункту
        private void Home_Click(object sender, EventArgs e)
        {
            if (Program.LastTab != 0)
            {
                carets.Top = Home.Top;
                HideTabs();
                home.Visible = true;
                Program.LastTab = 0;
                UpdateData(home.Hits);
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (Program.LastTab != 1)
            {
                carets.Top = New.Top;
                HideTabs();
                news.Visible = true;
                Program.LastTab = 1;
                UpdateData(news.Flowers);
            }
        }

       public void UpdateData(Panel panel)
        {
            Server server = new Server();
            foreach(var obj in panel.Controls)
            {

                Tabs.Flower flower = (Tabs.Flower)obj;
                int count = server.GetStatus(flower.ID);
                flower.Pcount = count;
                if (count > 0)
                {
                    flower.count.Text = "В наявності";
                    flower.Pcount = count;
                    flower.count.ForeColor = Color.FromArgb(0, 59, 145, 22);
                }
                else
                {
                    flower.count.Text = "Нема в наявності";
                    flower.count.ForeColor = Color.Red;
                }
            }
        }


        private void Catalog_Click(object sender, EventArgs e)
        {
           if(Program.LastTab != 2)
           {
                carets.Top = Catalog.Top;
                HideTabs();
                catalog.Visible = true;
                Program.LastTab = 2;
                UpdateData(catalog.Flowers);
            }
        }

        private void Instruction_Click(object sender, EventArgs e)
        {
            if (Program.LastTab != 3)
            {
                carets.Top = Instruction.Top;
                HideTabs();
                instruction.Visible = true;
                Program.LastTab = 3;
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

        private void Basket_Click(object sender, EventArgs e)
        { 
            if(Program.LastTab != 4)
            {
                carets.Top = Basket.Top;
                HideTabs();
                basket.UserBacket.Controls.Clear();
                basket.Visible = true;
                Program.LastTab = 4;
                Server server = new Server();
                List<Tabs.UserFlower> users = server.UserBusket(UniqueMachineId());

                foreach (var flower in users)
                {
                    basket.UserBacket.Controls.Add(flower);
                }
            }
  
        }

        private void Main_Click(object sender, EventArgs e)
        { Home_Click(sender, e); }

        private void pictureBox1_Click(object sender, EventArgs e)
        { Home_Click(sender, e); }

        private void label2_Click(object sender, EventArgs e)
        { New_Click(sender, e);  }

        private void pictureBox2_Click(object sender, EventArgs e)
        { New_Click(sender, e);}

        private void label4_Click(object sender, EventArgs e)
        {Catalog_Click(sender, e); }

        private void pictureBox4_Click(object sender, EventArgs e)
        {Catalog_Click(sender, e);}

        private void label3_Click(object sender, EventArgs e)
        {Instruction_Click(sender, e); }

        private void pictureBox3_Click(object sender, EventArgs e)
        {Instruction_Click(sender, e);}

        private void label5_Click(object sender, EventArgs e)
        {Basket_Click(sender, e);}

        private void pictureBox5_Click(object sender, EventArgs e)
        { Basket_Click(sender, e);}
    }
}
