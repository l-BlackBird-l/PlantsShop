
namespace PlantsShopAdmin.Tabs
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.UserInfo = new System.Windows.Forms.Label();
            this.FlowerInfo = new System.Windows.Forms.Label();
            this.Complite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.Location = new System.Drawing.Point(13, 7);
            this.UserInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(491, 43);
            this.UserInfo.TabIndex = 0;
            this.UserInfo.Text = "label1";
            // 
            // FlowerInfo
            // 
            this.FlowerInfo.Location = new System.Drawing.Point(13, 54);
            this.FlowerInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FlowerInfo.Name = "FlowerInfo";
            this.FlowerInfo.Size = new System.Drawing.Size(491, 34);
            this.FlowerInfo.TabIndex = 1;
            this.FlowerInfo.Text = "label2";
            // 
            // Complite
            // 
            this.Complite.Location = new System.Drawing.Point(339, 91);
            this.Complite.Name = "Complite";
            this.Complite.Size = new System.Drawing.Size(138, 33);
            this.Complite.TabIndex = 2;
            this.Complite.Text = "Виконано";
            this.Complite.UseVisualStyleBackColor = true;
            this.Complite.Click += new System.EventHandler(this.Complite_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(509, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
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
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Complite);
            this.Controls.Add(this.FlowerInfo);
            this.Controls.Add(this.UserInfo);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "User";
            this.Size = new System.Drawing.Size(544, 136);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label UserInfo;
        public System.Windows.Forms.Label FlowerInfo;
        private System.Windows.Forms.Button Complite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
