namespace LavWF4
{
    partial class ObjectCreater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectChoose = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.objectSize = new System.Windows.Forms.TextBox();
            this.objectCoord = new System.Windows.Forms.TextBox();
            this.buttnoCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectChoose
            // 
            this.objectChoose.FormattingEnabled = true;
            this.objectChoose.Items.AddRange(new object[] {
            "Точка",
            "Линия",
            "Прямоугольник",
            "Эллипс",
            "Строка"});
            this.objectChoose.Location = new System.Drawing.Point(218, 65);
            this.objectChoose.Name = "objectChoose";
            this.objectChoose.Size = new System.Drawing.Size(323, 24);
            this.objectChoose.TabIndex = 0;
            this.objectChoose.SelectedIndexChanged += new System.EventHandler(this.objectChoose_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.objectSize);
            this.groupBox1.Controls.Add(this.objectCoord);
            this.groupBox1.Location = new System.Drawing.Point(177, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Размеры объекта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Координаты объекта";
            // 
            // objectSize
            // 
            this.objectSize.Location = new System.Drawing.Point(41, 114);
            this.objectSize.Name = "objectSize";
            this.objectSize.Size = new System.Drawing.Size(323, 22);
            this.objectSize.TabIndex = 1;
            // 
            // objectCoord
            // 
            this.objectCoord.Location = new System.Drawing.Point(41, 37);
            this.objectCoord.Name = "objectCoord";
            this.objectCoord.Size = new System.Drawing.Size(323, 22);
            this.objectCoord.TabIndex = 0;
            // 
            // buttnoCreate
            // 
            this.buttnoCreate.Location = new System.Drawing.Point(314, 308);
            this.buttnoCreate.Name = "buttnoCreate";
            this.buttnoCreate.Size = new System.Drawing.Size(142, 70);
            this.buttnoCreate.TabIndex = 2;
            this.buttnoCreate.Text = "Создать";
            this.buttnoCreate.UseVisualStyleBackColor = true;
            this.buttnoCreate.Click += new System.EventHandler(this.buttnoCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип объекта";
            // 
            // ObjectCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttnoCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.objectChoose);
            this.Name = "ObjectCreater";
            this.Text = "Создание объекта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox objectChoose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox objectSize;
        private System.Windows.Forms.TextBox objectCoord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttnoCreate;
        private System.Windows.Forms.Label label3;
    }
}