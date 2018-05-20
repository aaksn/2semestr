namespace _7._1
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
            this.outtreeonform = new System.Windows.Forms.TextBox();
            this.outfile = new System.Windows.Forms.Button();
            this.rndbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // outtreeonform
            // 
            this.outtreeonform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outtreeonform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outtreeonform.Location = new System.Drawing.Point(12, 12);
            this.outtreeonform.Multiline = true;
            this.outtreeonform.Name = "outtreeonform";
            this.outtreeonform.ReadOnly = true;
            this.outtreeonform.Size = new System.Drawing.Size(873, 483);
            this.outtreeonform.TabIndex = 5;
            this.outtreeonform.TabStop = false;
            this.outtreeonform.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nЗдесь отобразится дерево\r\nА при нажатии на \"Выгрузить\" в файл зап" +
    "ишутся пути от листьев к корню";
            this.outtreeonform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outfile
            // 
            this.outfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outfile.Location = new System.Drawing.Point(726, 501);
            this.outfile.Name = "outfile";
            this.outfile.Size = new System.Drawing.Size(159, 40);
            this.outfile.TabIndex = 2;
            this.outfile.Text = "Выгрузить";
            this.outfile.UseVisualStyleBackColor = true;
            this.outfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // rndbutton
            // 
            this.rndbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rndbutton.Location = new System.Drawing.Point(557, 501);
            this.rndbutton.Name = "rndbutton";
            this.rndbutton.Size = new System.Drawing.Size(90, 40);
            this.rndbutton.TabIndex = 1;
            this.rndbutton.Text = "OK";
            this.rndbutton.UseVisualStyleBackColor = true;
            this.rndbutton.Click += new System.EventHandler(this.rndbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество элементов для случайного дерева:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(477, 506);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(74, 30);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "8";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.FileName = "Pathsfromtree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 552);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rndbutton);
            this.Controls.Add(this.outfile);
            this.Controls.Add(this.outtreeonform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outtreeonform;
        private System.Windows.Forms.Button outfile;
        private System.Windows.Forms.Button rndbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

