
namespace PlantsShopAdmin.Tabs
{
    partial class UsersOrder
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
            this.Orders = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Orders
            // 
            this.Orders.AutoScroll = true;
            this.Orders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Orders.Location = new System.Drawing.Point(0, 86);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(576, 386);
            this.Orders.TabIndex = 0;
            // 
            // UsersOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Orders);
            this.Name = "UsersOrder";
            this.Size = new System.Drawing.Size(576, 472);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel Orders;
    }
}
