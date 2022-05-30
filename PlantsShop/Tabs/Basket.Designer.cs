
namespace PlantsShop.Tabs
{
    partial class Basket
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
            this.UserBacket = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // UserBacket
            // 
            this.UserBacket.Location = new System.Drawing.Point(0, 82);
            this.UserBacket.Name = "UserBacket";
            this.UserBacket.Size = new System.Drawing.Size(629, 381);
            this.UserBacket.TabIndex = 0;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserBacket);
            this.Name = "Basket";
            this.Size = new System.Drawing.Size(629, 463);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel UserBacket;
    }
}
