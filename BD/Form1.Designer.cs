namespace BD
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.департаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.табельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетЗарплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.табельToolStripMenuItem,
            this.расчетЗарплатыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(817, 28);
            this.menuStrip3.TabIndex = 6;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.фирмыToolStripMenuItem,
            this.департаментыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.операцииToolStripMenuItem.Text = "Операции";
            this.операцииToolStripMenuItem.Click += new System.EventHandler(this.операцииToolStripMenuItem_Click);
            // 
            // фирмыToolStripMenuItem
            // 
            this.фирмыToolStripMenuItem.Name = "фирмыToolStripMenuItem";
            this.фирмыToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.фирмыToolStripMenuItem.Text = "Фирмы";
            this.фирмыToolStripMenuItem.Click += new System.EventHandler(this.фирмыToolStripMenuItem_Click);
            // 
            // департаментыToolStripMenuItem
            // 
            this.департаментыToolStripMenuItem.Name = "департаментыToolStripMenuItem";
            this.департаментыToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.департаментыToolStripMenuItem.Text = "Департаменты";
            this.департаментыToolStripMenuItem.Click += new System.EventHandler(this.департаментыToolStripMenuItem_Click);
            // 
            // табельToolStripMenuItem
            // 
            this.табельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаToolStripMenuItem,
            this.назначенияToolStripMenuItem});
            this.табельToolStripMenuItem.Name = "табельToolStripMenuItem";
            this.табельToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.табельToolStripMenuItem.Text = "Табели";
            // 
            // работаToolStripMenuItem
            // 
            this.работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            this.работаToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.работаToolStripMenuItem.Text = "Работа";
            this.работаToolStripMenuItem.Click += new System.EventHandler(this.работаToolStripMenuItem_Click);
            // 
            // назначенияToolStripMenuItem
            // 
            this.назначенияToolStripMenuItem.Name = "назначенияToolStripMenuItem";
            this.назначенияToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.назначенияToolStripMenuItem.Text = "Назначения";
            this.назначенияToolStripMenuItem.Click += new System.EventHandler(this.назначенияToolStripMenuItem_Click);
            // 
            // расчетЗарплатыToolStripMenuItem
            // 
            this.расчетЗарплатыToolStripMenuItem.Name = "расчетЗарплатыToolStripMenuItem";
            this.расчетЗарплатыToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.расчетЗарплатыToolStripMenuItem.Text = "Расчет зарплаты";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.menuStrip3);
            this.Name = "Form1";
            this.Text = "Сдельная заработная плата";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фирмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem департаментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem табельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетЗарплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначенияToolStripMenuItem;
    }
}

