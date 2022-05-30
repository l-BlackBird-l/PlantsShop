
namespace PlantsShop.Tabs
{
    partial class New
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
            this.Flowers = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Flowers
            // 
            this.Flowers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flowers.AutoScroll = true;
            this.Flowers.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.Flowers.BackColor = System.Drawing.SystemColors.Control;
            this.Flowers.Location = new System.Drawing.Point(34, 65);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(594, 407);
            this.Flowers.TabIndex = 1;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Flowers);
            this.Name = "New";
            this.Size = new System.Drawing.Size(629, 472);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Flowers;
    }
}
