
namespace PlantsShopAdmin.Tabs
{
    partial class EditFlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFlower));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Fcount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FlowersName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Accept);
            this.panel1.Controls.Add(this.Fcount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Fprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Fname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 394);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.Picture);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(28, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 133);
            this.panel2.TabIndex = 10;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // Picture
            // 
            this.Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture.Image = global::PlantsShopAdmin.Properties.Resources.add_photo;
            this.Picture.Location = new System.Drawing.Point(0, 1);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(240, 129);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 8;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(165, 306);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(183, 33);
            this.Accept.TabIndex = 9;
            this.Accept.Text = "Редагувати";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Fcount
            // 
            this.Fcount.Location = new System.Drawing.Point(118, 223);
            this.Fcount.Name = "Fcount";
            this.Fcount.Size = new System.Drawing.Size(64, 27);
            this.Fcount.TabIndex = 7;
            this.Fcount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fcount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кількість";
            // 
            // Fprice
            // 
            this.Fprice.Location = new System.Drawing.Point(373, 223);
            this.Fprice.Name = "Fprice";
            this.Fprice.Size = new System.Drawing.Size(176, 27);
            this.Fprice.TabIndex = 5;
            this.Fprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fprice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ціна за шт.";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(373, 74);
            this.Desc.MaxLength = 189;
            this.Desc.Multiline = true;
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(176, 132);
            this.Desc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Опис";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(373, 33);
            this.Fname.MaxLength = 17;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(176, 27);
            this.Fname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // FlowersName
            // 
            this.FlowersName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.FlowersName.FormattingEnabled = true;
            this.FlowersName.Location = new System.Drawing.Point(225, 33);
            this.FlowersName.Name = "FlowersName";
            this.FlowersName.Size = new System.Drawing.Size(298, 28);
            this.FlowersName.TabIndex = 2;
            this.FlowersName.SelectedIndexChanged += new System.EventHandler(this.FlowersName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(159, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Назва";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(524, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 25);
            this.panel3.TabIndex = 11;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
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
            // EditFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FlowersName);
            this.Controls.Add(this.panel1);
            this.Name = "EditFlower";
            this.Size = new System.Drawing.Size(576, 472);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.TextBox Fcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox FlowersName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
