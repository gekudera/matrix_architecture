namespace sr2_GUI
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
            this.but_simple = new System.Windows.Forms.Button();
            this.but_sparse = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.renumb_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // but_simple
            // 
            this.but_simple.Location = new System.Drawing.Point(24, 23);
            this.but_simple.Margin = new System.Windows.Forms.Padding(4);
            this.but_simple.Name = "but_simple";
            this.but_simple.Size = new System.Drawing.Size(169, 57);
            this.but_simple.TabIndex = 0;
            this.but_simple.Text = "Генерация обычной матрицы";
            this.but_simple.UseVisualStyleBackColor = true;
            this.but_simple.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_sparse
            // 
            this.but_sparse.Location = new System.Drawing.Point(201, 23);
            this.but_sparse.Margin = new System.Windows.Forms.Padding(4);
            this.but_sparse.Name = "but_sparse";
            this.but_sparse.Size = new System.Drawing.Size(180, 57);
            this.but_sparse.TabIndex = 1;
            this.but_sparse.Text = "Генерация разряженной матрицы";
            this.but_sparse.UseVisualStyleBackColor = true;
            this.but_sparse.Click += new System.EventHandler(this.but_sparse_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(75, 153);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(229, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Отображать границу матрицы";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(40, 182);
            this.picBox.Margin = new System.Windows.Forms.Padding(4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(818, 508);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // renumb_but
            // 
            this.renumb_but.Location = new System.Drawing.Point(442, 37);
            this.renumb_but.Margin = new System.Windows.Forms.Padding(4);
            this.renumb_but.Name = "renumb_but";
            this.renumb_but.Size = new System.Drawing.Size(180, 57);
            this.renumb_but.TabIndex = 4;
            this.renumb_but.Text = "Перенумеровать";
            this.renumb_but.UseVisualStyleBackColor = true;
            this.renumb_but.Click += new System.EventHandler(this.renumb_but_Click);
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(647, 37);
            this.back_but.Margin = new System.Windows.Forms.Padding(4);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(180, 57);
            this.back_but.TabIndex = 5;
            this.back_but.Text = "Восстановить";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Составная обычная матрица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Составная разряженная матрица";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "Транспонировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 703);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.renumb_but);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.but_sparse);
            this.Controls.Add(this.but_simple);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_simple;
        private System.Windows.Forms.Button but_sparse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button renumb_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

