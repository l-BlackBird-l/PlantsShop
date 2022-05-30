
namespace PlantsShop.Tabs
{
    partial class UserFlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFlower));
            this.Picture = new System.Windows.Forms.PictureBox();
            this.FlowerName = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(15, 8);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(142, 83);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // FlowerName
            // 
            this.FlowerName.AutoSize = true;
            this.FlowerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.FlowerName.Location = new System.Drawing.Point(202, 8);
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.Size = new System.Drawing.Size(69, 24);
            this.FlowerName.TabIndex = 1;
            this.FlowerName.Text = "Веник";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(202, 63);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(236, 20);
            this.Count.TabIndex = 2;
            this.Count.Text = "Кількість: 4 Ціна: 1000грн.";
            // 
            // Buy
            // 
            this.Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buy.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Buy.Location = new System.Drawing.Point(455, 56);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(149, 35);
            this.Buy.TabIndex = 3;
            this.Buy.Text = "Замовити";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(579, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // UserFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.FlowerName);
            this.Controls.Add(this.Picture);
            this.Name = "UserFlower";
            this.Size = new System.Drawing.Size(617, 100);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Picture;
        public System.Windows.Forms.Label FlowerName;
        public System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
