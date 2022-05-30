
namespace PlantsShop.Tabs
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
            this.Flowers = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TextBox();
            this.sorting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Flowers
            // 
            this.Flowers.AutoScroll = true;
            this.Flowers.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.Flowers.BackColor = System.Drawing.SystemColors.Control;
            this.Flowers.Location = new System.Drawing.Point(35, 78);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(594, 385);
            this.Flowers.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(284, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(297, 26);
            this.Search.TabIndex = 1;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // sorting
            // 
            this.sorting.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.sorting.FormattingEnabled = true;
            this.sorting.Items.AddRange(new object[] {
            "За алфавітом",
            "Спочатку дешеві",
            "Спочатку дорогі"});
            this.sorting.Location = new System.Drawing.Point(322, 39);
            this.sorting.Name = "sorting";
            this.sorting.Size = new System.Drawing.Size(259, 27);
            this.sorting.TabIndex = 2;
            this.sorting.SelectedIndexChanged += new System.EventHandler(this.sorting_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пошук";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(210, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортування";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sorting);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Flowers);
            this.Name = "Catalog";
            this.Size = new System.Drawing.Size(629, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel Flowers;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.ComboBox sorting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
