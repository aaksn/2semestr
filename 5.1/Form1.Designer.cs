namespace _5._1
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
            this.listbox = new System.Windows.Forms.TextBox();
            this.findbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numofelement = new System.Windows.Forms.Label();
            this.findelementBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listbox.Location = new System.Drawing.Point(12, 12);
            this.listbox.MaxLength = 100;
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(528, 34);
            this.listbox.TabIndex = 0;
            // 
            // findbutton
            // 
            this.findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findbutton.Location = new System.Drawing.Point(378, 57);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(102, 34);
            this.findbutton.TabIndex = 3;
            this.findbutton.Text = "Найти";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Элемент для поиска:";
            // 
            // numofelement
            // 
            this.numofelement.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numofelement.Location = new System.Drawing.Point(12, 107);
            this.numofelement.Name = "numofelement";
            this.numofelement.Size = new System.Drawing.Size(528, 89);
            this.numofelement.TabIndex = 3;
            this.numofelement.Text = "0";
            this.numofelement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // findelementBox
            // 
            this.findelementBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findelementBox.Location = new System.Drawing.Point(267, 57);
            this.findelementBox.MaxLength = 10;
            this.findelementBox.Name = "findelementBox";
            this.findelementBox.Size = new System.Drawing.Size(105, 34);
            this.findelementBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 225);
            this.Controls.Add(this.findelementBox);
            this.Controls.Add(this.numofelement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "5.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listbox;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numofelement;
        private System.Windows.Forms.TextBox findelementBox;
    }
}

