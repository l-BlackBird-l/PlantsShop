
namespace PlantsShopAdmin
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftBar = new System.Windows.Forms.Panel();
            this.Orders = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EditFlowers = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AddFlowers = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Catalog = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Label();
            this.carets = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftBar.SuspendLayout();
            this.Orders.SuspendLayout();
            this.EditFlowers.SuspendLayout();
            this.AddFlowers.SuspendLayout();
            this.Catalog.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LeftBar.Controls.Add(this.Orders);
            this.LeftBar.Controls.Add(this.EditFlowers);
            this.LeftBar.Controls.Add(this.AddFlowers);
            this.LeftBar.Controls.Add(this.Catalog);
            this.LeftBar.Controls.Add(this.carets);
            this.LeftBar.Location = new System.Drawing.Point(0, 0);
            this.LeftBar.Margin = new System.Windows.Forms.Padding(0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(275, 526);
            this.LeftBar.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.pictureBox3);
            this.Orders.Controls.Add(this.label3);
            this.Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders.Location = new System.Drawing.Point(13, 308);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(250, 44);
            this.Orders.TabIndex = 18;
            this.Orders.Click += new System.EventHandler(this.Order_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(65, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Перегляд чеків";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EditFlowers
            // 
            this.EditFlowers.Controls.Add(this.pictureBox4);
            this.EditFlowers.Controls.Add(this.label4);
            this.EditFlowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditFlowers.Location = new System.Drawing.Point(13, 238);
            this.EditFlowers.Name = "EditFlowers";
            this.EditFlowers.Size = new System.Drawing.Size(250, 44);
            this.EditFlowers.TabIndex = 17;
            this.EditFlowers.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(65, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Редагувати товар";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddFlowers
            // 
            this.AddFlowers.Controls.Add(this.label2);
            this.AddFlowers.Controls.Add(this.pictureBox2);
            this.AddFlowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFlowers.Location = new System.Drawing.Point(13, 169);
            this.AddFlowers.Name = "AddFlowers";
            this.AddFlowers.Size = new System.Drawing.Size(250, 44);
            this.AddFlowers.TabIndex = 16;
            this.AddFlowers.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(65, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Додати товар";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Catalog
            // 
            this.Catalog.Controls.Add(this.pictureBox1);
            this.Catalog.Controls.Add(this.Main);
            this.Catalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Catalog.Location = new System.Drawing.Point(13, 96);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(250, 44);
            this.Catalog.TabIndex = 15;
            this.Catalog.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Main.Location = new System.Drawing.Point(65, 11);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(87, 24);
            this.Main.TabIndex = 6;
            this.Main.Text = "Каталог";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // carets
            // 
            this.carets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(145)))), ((int)(((byte)(22)))));
            this.carets.Location = new System.Drawing.Point(0, 95);
            this.carets.Name = "carets";
            this.carets.Size = new System.Drawing.Size(7, 44);
            this.carets.TabIndex = 4;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(145)))), ((int)(((byte)(22)))));
            this.TopBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopBar.Location = new System.Drawing.Point(275, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(651, 12);
            this.TopBar.TabIndex = 1;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(145)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Location = new System.Drawing.Point(275, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 116);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flowers";
            // 
            // Tab
            // 
            this.Tab.Location = new System.Drawing.Point(275, 50);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(576, 476);
            this.Tab.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = global::PlantsShopAdmin.Properties.Resources.Close;
            this.Close.Location = new System.Drawing.Point(817, 18);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(16, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(70, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PlantsShopAdmin.Properties.Resources.order;
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PlantsShopAdmin.Properties.Resources.edit;
            this.pictureBox4.Location = new System.Drawing.Point(15, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PlantsShopAdmin.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(15, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlantsShopAdmin.Properties.Resources.Catalog;
            this.pictureBox1.Location = new System.Drawing.Point(15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 526);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.LeftBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LeftBar.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            this.EditFlowers.ResumeLayout(false);
            this.EditFlowers.PerformLayout();
            this.AddFlowers.ResumeLayout(false);
            this.AddFlowers.PerformLayout();
            this.Catalog.ResumeLayout(false);
            this.Catalog.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftBar;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel carets;
        private System.Windows.Forms.Label Main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel Tab;
        private System.Windows.Forms.Panel Orders;
        private System.Windows.Forms.Panel EditFlowers;
        private System.Windows.Forms.Panel AddFlowers;
        private System.Windows.Forms.Panel Catalog;
    }
}

