
namespace PlantsShopAdmin.Tabs
{
    partial class Catalog
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
            this.Flowers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flowers
            // 
            this.Flowers.AutoScroll = true;
            this.Flowers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Flowers.Location = new System.Drawing.Point(0, 78);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(576, 394);
            this.Flowers.TabIndex = 0;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Flowers);
            this.Name = "Catalog";
            this.Size = new System.Drawing.Size(576, 472);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel Flowers;
    }
}
