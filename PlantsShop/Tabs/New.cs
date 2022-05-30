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
    public partial class New : UserControl
    {
        public New()
        {
            InitializeComponent();
        }

        public void LoadSorting(List<Flower> flower)
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
            int f = 0;
            for (int i = 0; i < flower.Count; i++)
            {
                if (flower[i].New.Visible == true)
                {
                    flower[i].Left = blockSizeX * f;
                    f++;

                    Flowers.Controls.Add(flower[i]);
                }
            }

        }

    }
}
