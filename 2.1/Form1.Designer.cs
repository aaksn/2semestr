namespace _2._1
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
            this.gobutton = new System.Windows.Forms.Button();
            this.statuslabel = new System.Windows.Forms.Label();
            this.pathBOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gobutton
            // 
            this.gobutton.AutoSize = true;
            this.gobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gobutton.Location = new System.Drawing.Point(415, 12);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(78, 55);
            this.gobutton.TabIndex = 2;
            this.gobutton.Text = "GO!";
            this.gobutton.UseVisualStyleBackColor = true;
            this.gobutton.Click += new System.EventHandler(this.gobutton_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuslabel.Location = new System.Drawing.Point(12, 95);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(481, 47);
            this.statuslabel.TabIndex = 1;
            this.statuslabel.Text = "False";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathBOX
            // 
            this.pathBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBOX.Location = new System.Drawing.Point(12, 21);
            this.pathBOX.Name = "pathBOX";
            this.pathBOX.Size = new System.Drawing.Size(397, 38);
            this.pathBOX.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 186);
            this.Controls.Add(this.pathBOX);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.gobutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gobutton;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.TextBox pathBOX;
    }
}

