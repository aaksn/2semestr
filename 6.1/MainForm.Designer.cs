namespace _6._1
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.bubble = new System.Windows.Forms.Button();
            this.shaker = new System.Windows.Forms.Button();
            this.sr = new System.Windows.Forms.Button();
            this.pe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Демонстрация работы сортировки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "График количества";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bubble
            // 
            this.bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bubble.Location = new System.Drawing.Point(12, 50);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(166, 52);
            this.bubble.TabIndex = 2;
            this.bubble.Text = "Пузырьковая";
            this.bubble.UseVisualStyleBackColor = true;
            this.bubble.Click += new System.EventHandler(this.bubble_Click);
            // 
            // shaker
            // 
            this.shaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shaker.Location = new System.Drawing.Point(262, 50);
            this.shaker.Name = "shaker";
            this.shaker.Size = new System.Drawing.Size(166, 52);
            this.shaker.TabIndex = 3;
            this.shaker.Text = "Шейкерная";
            this.shaker.UseVisualStyleBackColor = true;
            this.shaker.Click += new System.EventHandler(this.shaker_Click);
            // 
            // sr
            // 
            this.sr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sr.Location = new System.Drawing.Point(12, 182);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(166, 52);
            this.sr.TabIndex = 4;
            this.sr.Text = "Сравнений";
            this.sr.UseVisualStyleBackColor = true;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // pe
            // 
            this.pe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pe.Location = new System.Drawing.Point(262, 182);
            this.pe.Name = "pe";
            this.pe.Size = new System.Drawing.Size(166, 52);
            this.pe.TabIndex = 5;
            this.pe.Text = "Перестановок";
            this.pe.UseVisualStyleBackColor = true;
            this.pe.Click += new System.EventHandler(this.pe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 256);
            this.Controls.Add(this.pe);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.shaker);
            this.Controls.Add(this.bubble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bubble;
        private System.Windows.Forms.Button shaker;
        private System.Windows.Forms.Button sr;
        private System.Windows.Forms.Button pe;
    }
}

