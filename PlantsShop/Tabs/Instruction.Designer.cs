
namespace PlantsShop.Tabs
{
    partial class Instruction
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
            this.Inst = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Inst
            // 
            this.Inst.BackColor = System.Drawing.SystemColors.Control;
            this.Inst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inst.Location = new System.Drawing.Point(0, 0);
            this.Inst.Name = "Inst";
            this.Inst.Size = new System.Drawing.Size(629, 463);
            this.Inst.TabIndex = 0;
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Inst);
            this.Name = "Instruction";
            this.Size = new System.Drawing.Size(629, 463);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Inst;
    }
}
