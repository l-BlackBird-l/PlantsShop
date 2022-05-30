
namespace PlantsShop
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
            this.Basket = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Instruction = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Catalog = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Label();
            this.carets = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Tab = new System.Windows.Forms.Panel();
            this.LeftBar.SuspendLayout();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Instruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.New.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LeftBar.Controls.Add(this.Basket);
            this.LeftBar.Controls.Add(this.Instruction);
            this.LeftBar.Controls.Add(this.Catalog);
            this.LeftBar.Controls.Add(this.New);
            this.LeftBar.Controls.Add(this.Home);
            this.LeftBar.Controls.Add(this.carets);
            this.LeftBar.Location = new System.Drawing.Point(0, 0);
            this.LeftBar.Margin = new System.Windows.Forms.Padding(0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(214, 526);
            this.LeftBar.TabIndex = 0;
            // 
            // Basket
            // 
            this.Basket.Controls.Add(this.pictureBox5);
            this.Basket.Controls.Add(this.label5);
            this.Basket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Basket.Location = new System.Drawing.Point(13, 380);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(184, 44);
            this.Basket.TabIndex = 19;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(70, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кошик";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Instruction
            // 
            this.Instruction.Controls.Add(this.pictureBox3);
            this.Instruction.Controls.Add(this.label3);
            this.Instruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Instruction.Location = new System.Drawing.Point(13, 308);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(184, 44);
            this.Instruction.TabIndex = 18;
            this.Instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(70, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Інструкція";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Catalog
            // 
            this.Catalog.Controls.Add(this.pictureBox4);
            this.Catalog.Controls.Add(this.label4);
            this.Catalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Catalog.Location = new System.Drawing.Point(13, 238);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(184, 44);
            this.Catalog.TabIndex = 17;
            this.Catalog.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(70, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Каталог";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // New
            // 
            this.New.Controls.Add(this.label2);
            this.New.Controls.Add(this.pictureBox2);
            this.New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New.Location = new System.Drawing.Point(13, 169);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(184, 44);
            this.New.TabIndex = 16;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(70, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Новинки";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.Main);
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Location = new System.Drawing.Point(13, 96);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(184, 44);
            this.Home.TabIndex = 15;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Main.Location = new System.Drawing.Point(70, 11);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(91, 24);
            this.Main.TabIndex = 6;
            this.Main.Text = "Головна";
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
            this.TopBar.Location = new System.Drawing.Point(213, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(713, 12);
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
            // Close
            // 
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(817, 18);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Tab
            // 
            this.Tab.Location = new System.Drawing.Point(222, 50);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(629, 476);
            this.Tab.TabIndex = 0;
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
            this.Basket.ResumeLayout(false);
            this.Basket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Instruction.ResumeLayout(false);
            this.Instruction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Catalog.ResumeLayout(false);
            this.Catalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.New.ResumeLayout(false);
            this.New.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel Tab;
        private System.Windows.Forms.Panel Basket;
        private System.Windows.Forms.Panel Instruction;
        private System.Windows.Forms.Panel Catalog;
        private System.Windows.Forms.Panel New;
        private System.Windows.Forms.Panel Home;
    }
}

