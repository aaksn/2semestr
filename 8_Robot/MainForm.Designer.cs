namespace _8_Robot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.addb = new System.Windows.Forms.Button();
            this.delb = new System.Windows.Forms.Button();
            this.drawb = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.r1 = new System.Windows.Forms.Label();
            this.pointr1 = new System.Windows.Forms.ComboBox();
            this.pointr1l = new System.Windows.Forms.Label();
            this.speedr1l = new System.Windows.Forms.Label();
            this.speedr1 = new System.Windows.Forms.ListBox();
            this.speedr2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointr2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedr3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pointr3 = new System.Windows.Forms.ComboBox();
            this.r3chek = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.AllowUserToResizeColumns = false;
            this.matrix.AllowUserToResizeRows = false;
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.matrix.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.matrix.Location = new System.Drawing.Point(0, 0);
            this.matrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matrix.MultiSelect = false;
            this.matrix.Name = "matrix";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.matrix.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.matrix.RowTemplate.Height = 24;
            this.matrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrix.ShowCellToolTips = false;
            this.matrix.Size = new System.Drawing.Size(663, 380);
            this.matrix.TabIndex = 1;
            // 
            // addb
            // 
            this.addb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addb.Location = new System.Drawing.Point(12, 386);
            this.addb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(45, 46);
            this.addb.TabIndex = 1;
            this.addb.Text = "+";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // delb
            // 
            this.delb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delb.Location = new System.Drawing.Point(63, 386);
            this.delb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delb.Name = "delb";
            this.delb.Size = new System.Drawing.Size(45, 46);
            this.delb.TabIndex = 2;
            this.delb.Text = "-";
            this.delb.UseVisualStyleBackColor = true;
            this.delb.Click += new System.EventHandler(this.delb_Click);
            // 
            // drawb
            // 
            this.drawb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawb.Location = new System.Drawing.Point(534, 386);
            this.drawb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawb.Name = "drawb";
            this.drawb.Size = new System.Drawing.Size(117, 46);
            this.drawb.TabIndex = 3;
            this.drawb.Text = "Draw";
            this.drawb.UseVisualStyleBackColor = true;
            this.drawb.Click += new System.EventHandler(this.drawb_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(411, 386);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(117, 46);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r1.Location = new System.Drawing.Point(12, 443);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(91, 25);
            this.r1.TabIndex = 5;
            this.r1.Text = "Робот 1:";
            // 
            // pointr1
            // 
            this.pointr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointr1.FormattingEnabled = true;
            this.pointr1.Location = new System.Drawing.Point(123, 465);
            this.pointr1.Name = "pointr1";
            this.pointr1.Size = new System.Drawing.Size(81, 33);
            this.pointr1.TabIndex = 6;
            // 
            // pointr1l
            // 
            this.pointr1l.AutoSize = true;
            this.pointr1l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointr1l.Location = new System.Drawing.Point(12, 473);
            this.pointr1l.Name = "pointr1l";
            this.pointr1l.Size = new System.Drawing.Size(105, 25);
            this.pointr1l.TabIndex = 8;
            this.pointr1l.Text = "Из пункта";
            // 
            // speedr1l
            // 
            this.speedr1l.AutoSize = true;
            this.speedr1l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedr1l.Location = new System.Drawing.Point(12, 508);
            this.speedr1l.Name = "speedr1l";
            this.speedr1l.Size = new System.Drawing.Size(100, 25);
            this.speedr1l.TabIndex = 9;
            this.speedr1l.Text = "Скорость";
            // 
            // speedr1
            // 
            this.speedr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedr1.FormattingEnabled = true;
            this.speedr1.ItemHeight = 25;
            this.speedr1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.speedr1.Location = new System.Drawing.Point(123, 504);
            this.speedr1.Name = "speedr1";
            this.speedr1.Size = new System.Drawing.Size(81, 29);
            this.speedr1.TabIndex = 11;
            // 
            // speedr2
            // 
            this.speedr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedr2.FormattingEnabled = true;
            this.speedr2.ItemHeight = 25;
            this.speedr2.Items.AddRange(new object[] {
            "1",
            "2"});
            this.speedr2.Location = new System.Drawing.Point(348, 504);
            this.speedr2.Name = "speedr2";
            this.speedr2.Size = new System.Drawing.Size(81, 29);
            this.speedr2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(237, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(237, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Из пункта";
            // 
            // pointr2
            // 
            this.pointr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointr2.FormattingEnabled = true;
            this.pointr2.Location = new System.Drawing.Point(348, 465);
            this.pointr2.Name = "pointr2";
            this.pointr2.Size = new System.Drawing.Size(81, 33);
            this.pointr2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Робот 2:";
            // 
            // speedr3
            // 
            this.speedr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedr3.FormattingEnabled = true;
            this.speedr3.ItemHeight = 25;
            this.speedr3.Items.AddRange(new object[] {
            "1",
            "2"});
            this.speedr3.Location = new System.Drawing.Point(568, 504);
            this.speedr3.Name = "speedr3";
            this.speedr3.Size = new System.Drawing.Size(81, 29);
            this.speedr3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(458, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Скорость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(458, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Из пункта";
            // 
            // pointr3
            // 
            this.pointr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointr3.FormattingEnabled = true;
            this.pointr3.Location = new System.Drawing.Point(569, 465);
            this.pointr3.Name = "pointr3";
            this.pointr3.Size = new System.Drawing.Size(81, 33);
            this.pointr3.TabIndex = 18;
            // 
            // r3chek
            // 
            this.r3chek.AutoSize = true;
            this.r3chek.Checked = true;
            this.r3chek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.r3chek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r3chek.Location = new System.Drawing.Point(464, 442);
            this.r3chek.Name = "r3chek";
            this.r3chek.Size = new System.Drawing.Size(113, 29);
            this.r3chek.TabIndex = 22;
            this.r3chek.Text = "Робот 3:";
            this.r3chek.UseVisualStyleBackColor = true;
            this.r3chek.CheckedChanged += new System.EventHandler(this.r3chek_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 550);
            this.Controls.Add(this.speedr3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointr3);
            this.Controls.Add(this.speedr2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pointr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedr1);
            this.Controls.Add(this.speedr1l);
            this.Controls.Add(this.pointr1l);
            this.Controls.Add(this.pointr1);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.drawb);
            this.Controls.Add(this.delb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.r3chek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button delb;
        private System.Windows.Forms.Button drawb;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label r1;
        private System.Windows.Forms.ComboBox pointr1;
        private System.Windows.Forms.Label pointr1l;
        private System.Windows.Forms.Label speedr1l;
        private System.Windows.Forms.ListBox speedr1;
        private System.Windows.Forms.ListBox speedr2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointr2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox speedr3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pointr3;
        private System.Windows.Forms.CheckBox r3chek;
    }
}

