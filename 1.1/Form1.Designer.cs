namespace _1._1
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

        

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.Button();
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sc_label = new System.Windows.Forms.Label();
            this.syc_label = new System.Windows.Forms.Label();
            this.stringcounter = new System.Windows.Forms.Label();
            this.symbolcounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFile.Location = new System.Drawing.Point(143, 13);
            this.openFile.Margin = new System.Windows.Forms.Padding(4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(227, 70);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Открыть файл";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // inputOpenFileDialog
            // 
            this.inputOpenFileDialog.DefaultExt = "txt";
            this.inputOpenFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // sc_label
            // 
            this.sc_label.AutoSize = true;
            this.sc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sc_label.Location = new System.Drawing.Point(12, 104);
            this.sc_label.Name = "sc_label";
            this.sc_label.Size = new System.Drawing.Size(188, 25);
            this.sc_label.TabIndex = 1;
            this.sc_label.Text = "Количество строк:";
            // 
            // syc_label
            // 
            this.syc_label.AutoSize = true;
            this.syc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.syc_label.Location = new System.Drawing.Point(295, 104);
            this.syc_label.Name = "syc_label";
            this.syc_label.Size = new System.Drawing.Size(226, 25);
            this.syc_label.TabIndex = 2;
            this.syc_label.Text = "Количество символов:";
            // 
            // stringcounter
            // 
            this.stringcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringcounter.Location = new System.Drawing.Point(17, 129);
            this.stringcounter.Name = "stringcounter";
            this.stringcounter.Size = new System.Drawing.Size(183, 91);
            this.stringcounter.TabIndex = 3;
            this.stringcounter.Text = "0";
            this.stringcounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // symbolcounter
            // 
            this.symbolcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolcounter.Location = new System.Drawing.Point(300, 129);
            this.symbolcounter.Name = "symbolcounter";
            this.symbolcounter.Size = new System.Drawing.Size(221, 91);
            this.symbolcounter.TabIndex = 4;
            this.symbolcounter.Text = "0";
            this.symbolcounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 271);
            this.Controls.Add(this.symbolcounter);
            this.Controls.Add(this.stringcounter);
            this.Controls.Add(this.syc_label);
            this.Controls.Add(this.sc_label);
            this.Controls.Add(this.openFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.Label sc_label;
        private System.Windows.Forms.Label syc_label;
        private System.Windows.Forms.Label stringcounter;
        private System.Windows.Forms.Label symbolcounter;
    }
}

