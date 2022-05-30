
namespace PlantsShopAdmin.Tabs
{
    partial class AddFlower
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fcount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 394);
            this.panel1.TabIndex = 0;
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
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(373, 33);
            this.Fname.MaxLength = 17;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(176, 27);
            this.Fname.TabIndex = 1;
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
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(165, 306);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(183, 33);
            this.Accept.TabIndex = 9;
            this.Accept.Text = "Додати";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
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
            // AddFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddFlower";
            this.Size = new System.Drawing.Size(576, 472);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox Fcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
