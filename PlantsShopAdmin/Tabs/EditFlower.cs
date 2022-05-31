using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PlantsShopAdmin.Tabs
{
    public partial class EditFlower : UserControl
    {
        public EditFlower()
        {
            InitializeComponent();
        }
        int ID;

        private void FlowersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;

            Server server = new Server();
            FlowerDate flowers = server.GetFlowerDate(FlowersName.SelectedItem.ToString());

            ID = flowers.ID;
            Fname.Text = flowers.Name;
            Desc.Text = flowers.Desc;
            Fcount.Text = flowers.Count.ToString();
            Fprice.Text = flowers.Price.ToString();
            Picture.Image = flowers.Picture;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.DeleteFromCatalog(ID);
            MessageBox.Show("Рослина видалена успішно");
            panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3_Click(sender, e);
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (Pic != "" && Fname.Text.Length > 3 && Fcount.Text != "" && Fprice.Text != "" && Desc.Text.Length > 10)
            {
                try
                {
                    Server server = new Server();
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + Fname.Text + ".png");
                    File.Copy(Pic, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Flowers\\" + Fname.Text + ".png");

             
                    server.UpdateFlower(ID, Fname.Text, Desc.Text, Convert.ToInt32(Fcount.Text), Convert.ToInt32(Fprice.Text));
                    MessageBox.Show("Товар змінено");
                    panel1.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Товар незмінено" + ex.Message);
                }
            }
        }
        string Pic;
        private void Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = ".PNG (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.OpenRead(openFileDialog1.FileName))
                {
                    Picture.Image = System.Drawing.Image.FromStream(stream);
                }
                Pic = openFileDialog1.FileName;
            }
            openFileDialog1.Dispose();
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
    }
}