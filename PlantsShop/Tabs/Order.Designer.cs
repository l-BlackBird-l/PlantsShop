
namespace PlantsShop.Tabs
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.ord = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserCount = new System.Windows.Forms.NumericUpDown();
            this.Back = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.FlowerName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.ord.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ord
            // 
            this.ord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ord.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ord.BackColor = System.Drawing.SystemColors.Control;
            this.ord.Controls.Add(this.panel1);
            this.ord.Controls.Add(this.count);
            this.ord.Controls.Add(this.Desc);
            this.ord.Controls.Add(this.FlowerName);
            this.ord.Controls.Add(this.price);
            this.ord.Controls.Add(this.panel2);
            this.ord.Location = new System.Drawing.Point(0, 65);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(629, 407);
            this.ord.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.UserCount);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Buy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(357, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 198);
            this.panel1.TabIndex = 16;
            // 
            // UserCount
            // 
            this.UserCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UserCount.Location = new System.Drawing.Point(115, 39);
            this.UserCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserCount.Name = "UserCount";
            this.UserCount.Size = new System.Drawing.Size(44, 20);
            this.UserCount.TabIndex = 18;
            this.UserCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserCount_KeyUp);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.Back.Location = new System.Drawing.Point(25, 159);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(224, 36);
            this.Back.TabIndex = 16;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Buy
            // 
            this.Buy.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.Buy.Location = new System.Drawing.Point(25, 108);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(224, 36);
            this.Buy.TabIndex = 9;
            this.Buy.Text = "Купити";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Загальна ціна: 0грн";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Кількість:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.SystemColors.ControlLight;
            this.count.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.ForeColor = System.Drawing.Color.Red;
            this.count.Location = new System.Drawing.Point(17, 219);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(97, 19);
            this.count.TabIndex = 12;
            this.count.Text = "В наявності";
            // 
            // Desc
            // 
            this.Desc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Desc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Desc.Location = new System.Drawing.Point(18, 99);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(321, 139);
            this.Desc.TabIndex = 10;
            this.Desc.Text = "Появившийся на берегах Перу удивительный цветок, считался там волшебным растением" +
    ". Инки считали альстромерию даром бога солнца, позволяющим приобретать удивитель" +
    "ные физические  способности. \r\n\r\n\r\n";
            // 
            // FlowerName
            // 
            this.FlowerName.AutoSize = true;
            this.FlowerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FlowerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.FlowerName.Location = new System.Drawing.Point(132, 60);
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.Size = new System.Drawing.Size(148, 24);
            this.FlowerName.TabIndex = 7;
            this.FlowerName.Text = "Альстромерия";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.price.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(17, 249);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(108, 19);
            this.price.TabIndex = 11;
            this.price.Text = "Ціна: 250грн";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.Picture);
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 249);
            this.panel2.TabIndex = 17;
            // 
            // Picture
            // 
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(368, 46);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(236, 129);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 8;
            this.Picture.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ord);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(629, 472);
            this.Load += new System.EventHandler(this.Order_Load);
            this.ord.ResumeLayout(false);
            this.ord.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ord;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Picture;
        public System.Windows.Forms.Label count;
        public System.Windows.Forms.Label Desc;
        public System.Windows.Forms.Label FlowerName;
        private System.Windows.Forms.Button Buy;
        public System.Windows.Forms.Label price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
        public System.Windows.Forms.NumericUpDown UserCount;
    }
}
