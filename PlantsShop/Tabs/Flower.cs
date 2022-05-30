using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsShop.Tabs
{
    public partial class Flower : UserControl
    {
        public Flower()
        {
            InitializeComponent();
            New.BackColor = Color.Transparent;
        }
        public int ID;
        public DateTime Date;
        public  int PPrice;
        public  int Pcount;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count.Text == "В наявності")
            {
                Program.GlobalOrder.FlowerName.Text = FlowerName.Text;
                Program.GlobalOrder.Desc.Text = Desc.Text;
                Program.GlobalOrder.Picture.Image = Picture.Image;
                Program.GlobalOrder.price.Text = price.Text;
                Program.GlobalOrder.count.Text = count.Text + " " + Pcount.ToString() + "шт.";
                Program.GlobalOrder.count.ForeColor = count.ForeColor;
                Program.GlobalOrder.Pcount = Pcount;
                Program.GlobalOrder.PPrice = PPrice;
                Program.GlobalOrder.ID = ID;
                Program.GlobalTab.HideTabs();
                Program.GlobalOrder.Visible = true;
            }
            else
            {

            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Flower_Load(object sender, EventArgs e)
        {

        }
    }
}
