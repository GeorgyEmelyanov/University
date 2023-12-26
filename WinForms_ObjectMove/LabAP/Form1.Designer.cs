namespace LabAP
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveX = new System.Windows.Forms.TextBox();
            this.moveY = new System.Windows.Forms.TextBox();
            this.rotation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeY = new System.Windows.Forms.TextBox();
            this.sizeX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сдвиг";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonDo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sizeY);
            this.groupBox1.Controls.Add(this.sizeX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rotation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.moveY);
            this.groupBox1.Controls.Add(this.moveX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 766);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // moveX
            // 
            this.moveX.Location = new System.Drawing.Point(6, 37);
            this.moveX.Name = "moveX";
            this.moveX.Size = new System.Drawing.Size(100, 22);
            this.moveX.TabIndex = 1;
            // 
            // moveY
            // 
            this.moveY.Location = new System.Drawing.Point(6, 65);
            this.moveY.Name = "moveY";
            this.moveY.Size = new System.Drawing.Size(100, 22);
            this.moveY.TabIndex = 2;
            // 
            // rotation
            // 
            this.rotation.Location = new System.Drawing.Point(112, 37);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(100, 22);
            this.rotation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поворот";
            // 
            // sizeY
            // 
            this.sizeY.Location = new System.Drawing.Point(219, 65);
            this.sizeY.Name = "sizeY";
            this.sizeY.Size = new System.Drawing.Size(100, 22);
            this.sizeY.TabIndex = 8;
            // 
            // sizeX
            // 
            this.sizeX.Location = new System.Drawing.Point(219, 37);
            this.sizeX.Name = "sizeX";
            this.sizeX.Size = new System.Drawing.Size(100, 22);
            this.sizeX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изменение размера";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(367, 18);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(130, 76);
            this.buttonDo.TabIndex = 2;
            this.buttonDo.Text = "Применить преобразования";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(503, 18);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 76);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Сброс параметров";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1751, 878);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sizeY;
        private System.Windows.Forms.TextBox sizeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox moveY;
        private System.Windows.Forms.TextBox moveX;
    }
}

