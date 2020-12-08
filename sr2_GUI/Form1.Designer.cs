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
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // but_simple
            // 
            this.but_simple.Location = new System.Drawing.Point(30, 36);
            this.but_simple.Name = "but_simple";
            this.but_simple.Size = new System.Drawing.Size(127, 46);
            this.but_simple.TabIndex = 0;
            this.but_simple.Text = "Генерация обычной матрицы";
            this.but_simple.UseVisualStyleBackColor = true;
            this.but_simple.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_sparse
            // 
            this.but_sparse.Location = new System.Drawing.Point(175, 36);
            this.but_sparse.Name = "but_sparse";
            this.but_sparse.Size = new System.Drawing.Size(135, 46);
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
            this.checkBox1.Location = new System.Drawing.Point(30, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Отображать границу матрицы";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(58, 121);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(586, 390);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // renumb_but
            // 
            this.renumb_but.Location = new System.Drawing.Point(333, 36);
            this.renumb_but.Name = "renumb_but";
            this.renumb_but.Size = new System.Drawing.Size(135, 46);
            this.renumb_but.TabIndex = 4;
            this.renumb_but.Text = "Перенумеровать";
            this.renumb_but.UseVisualStyleBackColor = true;
            this.renumb_but.Click += new System.EventHandler(this.renumb_but_Click);
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(489, 36);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(135, 46);
            this.back_but.TabIndex = 5;
            this.back_but.Text = "Восстановить";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 523);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.renumb_but);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.but_sparse);
            this.Controls.Add(this.but_simple);
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
    }
}

