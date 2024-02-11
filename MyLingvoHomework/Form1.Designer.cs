namespace MyLingvoHomework
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
            this.InputWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ex2 = new System.Windows.Forms.ListBox();
            this.Ex1 = new System.Windows.Forms.ListBox();
            this.Tran2 = new System.Windows.Forms.ListBox();
            this.Tran1 = new System.Windows.Forms.ListBox();
            this.TransButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputWord
            // 
            this.InputWord.Location = new System.Drawing.Point(402, 208);
            this.InputWord.Name = "InputWord";
            this.InputWord.Size = new System.Drawing.Size(346, 22);
            this.InputWord.TabIndex = 0;
            this.InputWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть слово для перекладу:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ex2);
            this.groupBox1.Controls.Add(this.Ex1);
            this.groupBox1.Controls.Add(this.Tran2);
            this.groupBox1.Controls.Add(this.Tran1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Ex2
            // 
            this.Ex2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ex2.FormattingEnabled = true;
            this.Ex2.ItemHeight = 16;
            this.Ex2.Location = new System.Drawing.Point(816, 18);
            this.Ex2.Name = "Ex2";
            this.Ex2.ScrollAlwaysVisible = true;
            this.Ex2.Size = new System.Drawing.Size(248, 192);
            this.Ex2.TabIndex = 3;
            // 
            // Ex1
            // 
            this.Ex1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ex1.FormattingEnabled = true;
            this.Ex1.ItemHeight = 16;
            this.Ex1.Location = new System.Drawing.Point(518, 18);
            this.Ex1.Name = "Ex1";
            this.Ex1.ScrollAlwaysVisible = true;
            this.Ex1.Size = new System.Drawing.Size(301, 192);
            this.Ex1.TabIndex = 2;
            // 
            // Tran2
            // 
            this.Tran2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tran2.FormattingEnabled = true;
            this.Tran2.ItemHeight = 16;
            this.Tran2.Location = new System.Drawing.Point(220, 18);
            this.Tran2.Name = "Tran2";
            this.Tran2.ScrollAlwaysVisible = true;
            this.Tran2.Size = new System.Drawing.Size(298, 192);
            this.Tran2.TabIndex = 1;
            // 
            // Tran1
            // 
            this.Tran1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tran1.FormattingEnabled = true;
            this.Tran1.ItemHeight = 16;
            this.Tran1.Location = new System.Drawing.Point(3, 18);
            this.Tran1.Name = "Tran1";
            this.Tran1.ScrollAlwaysVisible = true;
            this.Tran1.Size = new System.Drawing.Size(217, 192);
            this.Tran1.TabIndex = 0;
            // 
            // TransButton
            // 
            this.TransButton.Location = new System.Drawing.Point(426, 281);
            this.TransButton.Name = "TransButton";
            this.TransButton.Size = new System.Drawing.Size(241, 39);
            this.TransButton.TabIndex = 4;
            this.TransButton.Text = "Перекласти";
            this.TransButton.UseVisualStyleBackColor = true;
            this.TransButton.Click += new System.EventHandler(this.TransButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(417, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Змінити напрямок перекладу:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TransButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputWord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Translate Program";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Ex2;
        private System.Windows.Forms.ListBox Ex1;
        private System.Windows.Forms.ListBox Tran2;
        private System.Windows.Forms.ListBox Tran1;
        private System.Windows.Forms.Button TransButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

