namespace Zadanie7_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tryCount = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(264, 103);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 1;
            this.button_check.Text = "Проверить";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число попыток:";
            // 
            // label_tryCount
            // 
            this.label_tryCount.AutoSize = true;
            this.label_tryCount.Location = new System.Drawing.Point(260, 72);
            this.label_tryCount.Name = "label_tryCount";
            this.label_tryCount.Size = new System.Drawing.Size(13, 13);
            this.label_tryCount.TabIndex = 3;
            this.label_tryCount.Text = "0";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(155, 140);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(10, 13);
            this.label_message.TabIndex = 4;
            this.label_message.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 239);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label_tryCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tryCount;
        private System.Windows.Forms.Label label_message;
    }
}

