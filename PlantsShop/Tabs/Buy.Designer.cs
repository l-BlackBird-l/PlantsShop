
namespace PlantsShop.Tabs
{
    partial class Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserNumber = new System.Windows.Forms.TextBox();
            this.UserAdress = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.BuyFlower = new System.Windows.Forms.Button();
            this.FlowerCount = new System.Windows.Forms.Label();
            this.FlowerName = new System.Windows.Forms.Label();
            this.TopText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.UserNumber);
            this.panel1.Controls.Add(this.UserAdress);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Controls.Add(this.BuyFlower);
            this.panel1.Controls.Add(this.FlowerCount);
            this.panel1.Controls.Add(this.FlowerName);
            this.panel1.Controls.Add(this.TopText);
            this.panel1.Location = new System.Drawing.Point(1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 393);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(312, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(319, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(340, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ім\'я";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.UserName.Location = new System.Drawing.Point(390, 75);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(203, 27);
            this.UserName.TabIndex = 9;
            // 
            // UserNumber
            // 
            this.UserNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.UserNumber.Location = new System.Drawing.Point(390, 120);
            this.UserNumber.Name = "UserNumber";
            this.UserNumber.Size = new System.Drawing.Size(203, 27);
            this.UserNumber.TabIndex = 8;
            // 
            // UserAdress
            // 
            this.UserAdress.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.UserAdress.Location = new System.Drawing.Point(390, 165);
            this.UserAdress.Name = "UserAdress";
            this.UserAdress.Size = new System.Drawing.Size(203, 27);
            this.UserAdress.TabIndex = 7;
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(45, 331);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(127, 39);
            this.Back.TabIndex = 6;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ціна: 500грн.";
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(19, 78);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(170, 89);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 4;
            this.Picture.TabStop = false;
            // 
            // BuyFlower
            // 
            this.BuyFlower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyFlower.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyFlower.Location = new System.Drawing.Point(45, 249);
            this.BuyFlower.Name = "BuyFlower";
            this.BuyFlower.Size = new System.Drawing.Size(127, 39);
            this.BuyFlower.TabIndex = 3;
            this.BuyFlower.Text = "Замовити";
            this.BuyFlower.UseVisualStyleBackColor = true;
            this.BuyFlower.Click += new System.EventHandler(this.BuyFlower_Click);
            // 
            // FlowerCount
            // 
            this.FlowerCount.AutoSize = true;
            this.FlowerCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlowerCount.Location = new System.Drawing.Point(16, 179);
            this.FlowerCount.Name = "FlowerCount";
            this.FlowerCount.Size = new System.Drawing.Size(106, 20);
            this.FlowerCount.TabIndex = 2;
            this.FlowerCount.Text = "Кількість: 3";
            // 
            // FlowerName
            // 
            this.FlowerName.AutoSize = true;
            this.FlowerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlowerName.Location = new System.Drawing.Point(16, 51);
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.Size = new System.Drawing.Size(56, 20);
            this.FlowerName.TabIndex = 1;
            this.FlowerName.Text = "Name";
            this.FlowerName.Click += new System.EventHandler(this.label2_Click);
            // 
            // TopText
            // 
            this.TopText.AutoSize = true;
            this.TopText.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.TopText.Location = new System.Drawing.Point(16, 16);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(184, 24);
            this.TopText.TabIndex = 0;
            this.TopText.Text = "Ваше замовлення";
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Buy";
            this.Size = new System.Drawing.Size(629, 472);
            this.Load += new System.EventHandler(this.Buy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button BuyFlower;
        public System.Windows.Forms.Label FlowerCount;
        public System.Windows.Forms.Label FlowerName;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserNumber;
        private System.Windows.Forms.TextBox UserAdress;
    }
}
