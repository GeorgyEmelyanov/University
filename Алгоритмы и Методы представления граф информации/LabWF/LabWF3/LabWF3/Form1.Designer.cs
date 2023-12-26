namespace LabWF3
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.типЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.непрерывнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктирнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wol_5_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wol_10_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wol_15_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЛинииОбводкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cd_for_brush = new System.Windows.Forms.ColorDialog();
            this.cd_for_pen = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типЛинииToolStripMenuItem,
            this.толщинаЛинииToolStripMenuItem,
            this.цветФонаToolStripMenuItem,
            this.цветЛинииОбводкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 100);
            this.contextMenuStrip1.Text = "Меню";
            // 
            // типЛинииToolStripMenuItem
            // 
            this.типЛинииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.непрерывнаяToolStripMenuItem,
            this.пунктирнаяToolStripMenuItem});
            this.типЛинииToolStripMenuItem.Name = "типЛинииToolStripMenuItem";
            this.типЛинииToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.типЛинииToolStripMenuItem.Text = "Тип линии";
            this.типЛинииToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // непрерывнаяToolStripMenuItem
            // 
            this.непрерывнаяToolStripMenuItem.Name = "непрерывнаяToolStripMenuItem";
            this.непрерывнаяToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.непрерывнаяToolStripMenuItem.Text = "Непрерывная";
            this.непрерывнаяToolStripMenuItem.Click += new System.EventHandler(this.непрерывнаяToolStripMenuItem_Click);
            // 
            // пунктирнаяToolStripMenuItem
            // 
            this.пунктирнаяToolStripMenuItem.Name = "пунктирнаяToolStripMenuItem";
            this.пунктирнаяToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.пунктирнаяToolStripMenuItem.Text = "Пунктирная";
            this.пунктирнаяToolStripMenuItem.Click += new System.EventHandler(this.пунктирнаяToolStripMenuItem_Click);
            // 
            // толщинаЛинииToolStripMenuItem
            // 
            this.толщинаЛинииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wol_5_toolStripMenuItem,
            this.wol_10_toolStripMenuItem,
            this.wol_15_toolStripMenuItem});
            this.толщинаЛинииToolStripMenuItem.Name = "толщинаЛинииToolStripMenuItem";
            this.толщинаЛинииToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.толщинаЛинииToolStripMenuItem.Text = "Толщина линии";
            // 
            // wol_5_toolStripMenuItem
            // 
            this.wol_5_toolStripMenuItem.Name = "wol_5_toolStripMenuItem";
            this.wol_5_toolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.wol_5_toolStripMenuItem.Text = "5";
            this.wol_5_toolStripMenuItem.Click += new System.EventHandler(this.wol_5_toolStripMenuItem_Click);
            // 
            // wol_10_toolStripMenuItem
            // 
            this.wol_10_toolStripMenuItem.Name = "wol_10_toolStripMenuItem";
            this.wol_10_toolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.wol_10_toolStripMenuItem.Text = "10";
            this.wol_10_toolStripMenuItem.Click += new System.EventHandler(this.wol_10_toolStripMenuItem_Click);
            // 
            // wol_15_toolStripMenuItem
            // 
            this.wol_15_toolStripMenuItem.Name = "wol_15_toolStripMenuItem";
            this.wol_15_toolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.wol_15_toolStripMenuItem.Text = "15";
            this.wol_15_toolStripMenuItem.Click += new System.EventHandler(this.wol_15_toolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // цветЛинииОбводкиToolStripMenuItem
            // 
            this.цветЛинииОбводкиToolStripMenuItem.Name = "цветЛинииОбводкиToolStripMenuItem";
            this.цветЛинииОбводкиToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.цветЛинииОбводкиToolStripMenuItem.Text = "Цвет линии обводки";
            this.цветЛинииОбводкиToolStripMenuItem.Click += new System.EventHandler(this.цветЛинииОбводкиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(858, 829);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Лаборатная работа №3";
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЛинииОбводкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem непрерывнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктирнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wol_5_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wol_10_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wol_15_toolStripMenuItem;
        private System.Windows.Forms.ColorDialog cd_for_brush;
        private System.Windows.Forms.ColorDialog cd_for_pen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

