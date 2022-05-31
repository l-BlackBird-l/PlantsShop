using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PlantsShopAdmin.Tabs
{
    public partial class AddFlower : UserControl
    {
        public AddFlower()
        {
            InitializeComponent();
        }
        string Pic;
        private void Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = ".PNG (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = Image.FromStream(GetImageFromPicPath(openFileDialog1.FileName));
                Pic = openFileDialog1.FileName;
            }
        }

        public static Stream GetImageFromPicPath(string path)
        {
            System.IO.FileStream f = new System.IO.FileStream(path, FileMode.Open, FileAccess.Read);
            return f;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Picture_Click(sender, e);
        }

        private void Fcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void Fprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        void ClearDate()
        {
            Pic = "";
            Fname.Text = "";
            Fcount.Text = "";
            Fprice.Text = "";
            Desc.Text = "";
            Picture.Image = Properties.Resources.add_photo;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (Pic != "" && Fname.Text.Length > 3 && Fcount.Text != "" && Fprice.Text != "" && Desc.Text.Length > 10)
            {
                try
                {
                    File.Copy(Pic, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + Fname.Text + ".png");
                    Server server = new Server();
                    server.AddFlower(Fname.Text, Desc.Text, Convert.ToInt32(Fcount.Text), Convert.ToInt32(Fprice.Text));
                    MessageBox.Show("Товар додано!");
                    ClearDate();

                }
                catch (Exception)
                {
                    MessageBox.Show("Упсс... Можливо цей товар вже існує");
                }
            }
        }
    }
}
