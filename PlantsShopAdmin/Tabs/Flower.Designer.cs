
using PlantsShopAdmin.Properties;

namespace PlantsShopAdmin.Tabs
{
    partial class Flower
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flower));
            this.FlowerName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.New = new System.Windows.Forms.PictureBox();
            this.count = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowerName
            // 
            this.FlowerName.AutoSize = true;
            this.FlowerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.FlowerName.Location = new System.Drawing.Point(20, 13);
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.Size = new System.Drawing.Size(148, 24);
            this.FlowerName.TabIndex = 0;
            this.FlowerName.Text = "Альстромерия";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(12, 347);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(108, 19);
            this.price.TabIndex = 5;
            this.price.Text = "Ціна: 250грн";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Controls.Add(this.New);
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.FlowerName);
            this.panel1.Controls.Add(this.price);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 378);
            this.panel1.TabIndex = 6;
            // 
            // Picture
            // 
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(16, 42);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(224, 128);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.New.Location = new System.Drawing.Point(206, 0);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(50, 50);
            this.New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.New.TabIndex = 7;
            this.New.TabStop = false;
            this.New.Visible = false;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.ForeColor = System.Drawing.Color.Red;
            this.count.Location = new System.Drawing.Point(12, 317);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(97, 19);
            this.count.TabIndex = 6;
            this.count.Text = "В наявності";
            // 
            // Desc
            // 
            this.Desc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Desc.Location = new System.Drawing.Point(13, 185);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(227, 135);
            this.Desc.TabIndex = 4;
            this.Desc.Text = "Появившийся на берегах Перу удивительный цветок, считался там волшебным растением" +
    ". Инки считали альстромерию даром бога солнца, позволяющим приобретать удивитель" +
    "ные физические  способности. \r\n\r\n\r\n";
            this.Desc.Click += new System.EventHandler(this.label1_Click);
            // 
            // Flower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "Flower";
            this.Size = new System.Drawing.Size(256, 380);
            this.Load += new System.EventHandler(this.Flower_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        public System.Windows.Forms.Label FlowerName;
        public System.Windows.Forms.Label price;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Desc;
        public System.Windows.Forms.PictureBox Picture;
        public System.Windows.Forms.Label count;
        public System.Windows.Forms.PictureBox New;
    }
}
