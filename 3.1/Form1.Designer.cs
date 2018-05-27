namespace _3._1
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
            this.openFile = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.checkbutton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.marksl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFile.Location = new System.Drawing.Point(13, 12);
            this.openFile.Margin = new System.Windows.Forms.Padding(4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(288, 70);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Открыть файл";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            this.openFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openFile_KeyDown);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(13, 381);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(581, 33);
            this.status.TabIndex = 1;
            this.status.Text = "Долгов нет!";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.status.Visible = false;
            // 
            // studentsBox
            // 
            this.studentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.ItemHeight = 22;
            this.studentsBox.Location = new System.Drawing.Point(13, 90);
            this.studentsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(583, 246);
            this.studentsBox.TabIndex = 2;
            this.studentsBox.DoubleClick += new System.EventHandler(this.studentsBox_DoubleClick);
            // 
            // checkbutton
            // 
            this.checkbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkbutton.Location = new System.Drawing.Point(307, 12);
            this.checkbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(288, 70);
            this.checkbutton.TabIndex = 3;
            this.checkbutton.Text = "Проверить студента";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "dat";
            this.openFileDialog.FileName = "Students.dat";
            this.openFileDialog.Filter = "Типизированный файл (*.dat)|*.dat|Все файлы (*.*)|*.*";
            this.openFileDialog.InitialDirectory = "../";
            // 
            // marksl
            // 
            this.marksl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marksl.Location = new System.Drawing.Point(15, 338);
            this.marksl.Name = "marksl";
            this.marksl.Size = new System.Drawing.Size(581, 33);
            this.marksl.TabIndex = 4;
            this.marksl.Text = "Долгов нет!";
            this.marksl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.marksl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 422);
            this.Controls.Add(this.marksl);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.openFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "3.1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label marksl;
    }
}

