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
    public partial class Catalog : UserControl
    {
        public Catalog()
        {
            InitializeComponent();
            sorting.SelectedIndex = 0;

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Flowers.Controls.Clear();
            AddPlants(Search.Text);
        }

        void AddPlants(string Plant)
        {
            Server server = new Server();

            List<Flower> flower = server.SearchFlower(Plant);

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


                Flowers.Controls.Add(flower[i]);

            }
        }

      public  void LoadSorting(List<Flower> flower)
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


                Flowers.Controls.Add(flower[i]);
            }

        }


        private void sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(sorting.SelectedIndex == 0)
            {
                var Sort = Flowers.Controls.OfType<Flower>().OrderBy(x => x.FlowerName.Text).ToList();
                Flowers.Controls.Clear();
                LoadSorting(Sort);
            }
            if (sorting.SelectedIndex == 1)
            {
                var Sort = Flowers.Controls.OfType<Flower>().OrderBy(x => x.PPrice).ToList();
                Flowers.Controls.Clear();
                LoadSorting(Sort);
            }
            if(sorting.SelectedIndex == 2)
            {
                var Sort = Flowers.Controls.OfType<Flower>().OrderBy(x => x.PPrice).ToList();
                Sort.Reverse();
                Flowers.Controls.Clear();
                LoadSorting(Sort);
            }
            
        }
    }
}
