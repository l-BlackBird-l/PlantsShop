using System;
using System.Windows.Forms;

namespace PlantsShopAdmin.Tabs
{
    public partial class Autorization : UserControl
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aut_Click(object sender, EventArgs e)
        {
            if (password.Text == "admin" && Login.Text == "admin")
            {
                Program.Aut = true;
                Program.autor.Visible = false;
                Program.catalog.Visible = true;
            }
        }
    }
}
