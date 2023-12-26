namespace LabAFF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CCButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbScaleY = new System.Windows.Forms.TextBox();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRotate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMoveY = new System.Windows.Forms.TextBox();
            this.tbMoveX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseColor = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CCButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbScaleY);
            this.groupBox1.Controls.Add(this.tbScaleX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbRotate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMoveY);
            this.groupBox1.Controls.Add(this.tbMoveX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1613, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CCButton
            // 
            this.CCButton.Location = new System.Drawing.Point(31, 265);
            this.CCButton.Name = "CCButton";
            this.CCButton.Size = new System.Drawing.Size(135, 23);
            this.CCButton.TabIndex = 1;
            this.CCButton.Text = "Изменить цвет";
            this.CCButton.UseVisualStyleBackColor = true;
            this.CCButton.Click += new System.EventHandler(this.CCButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вернуть в исходное состояние";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "По Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "По X";
            // 
            // tbScaleY
            // 
            this.tbScaleY.Location = new System.Drawing.Point(9, 217);
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(100, 22);
            this.tbScaleY.TabIndex = 10;
            // 
            // tbScaleX
            // 
            this.tbScaleX.Location = new System.Drawing.Point(9, 189);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(100, 22);
            this.tbScaleX.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сжатие/Растяжение";
            // 
            // tbRotate
            // 
            this.tbRotate.Location = new System.Drawing.Point(9, 124);
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(100, 22);
            this.tbRotate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поворот";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "По Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "По Х";
            // 
            // tbMoveY
            // 
            this.tbMoveY.Location = new System.Drawing.Point(9, 66);
            this.tbMoveY.Name = "tbMoveY";
            this.tbMoveY.Size = new System.Drawing.Size(100, 22);
            this.tbMoveY.TabIndex = 2;
            // 
            // tbMoveX
            // 
            this.tbMoveX.Location = new System.Drawing.Point(9, 38);
            this.tbMoveX.Name = "tbMoveX";
            this.tbMoveX.Size = new System.Drawing.Size(100, 22);
            this.tbMoveX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Движение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1595, 709);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1825, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа - Аффинные преобразования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbScaleY;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRotate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMoveY;
        private System.Windows.Forms.TextBox tbMoveX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CCButton;
        private System.Windows.Forms.ColorDialog ChooseColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

