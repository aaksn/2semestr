namespace Graph
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.addb = new System.Windows.Forms.Button();
            this.delb = new System.Windows.Forms.Button();
            this.drawb = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.matrix.Location = new System.Drawing.Point(0, 0);
            this.matrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matrix.MultiSelect = false;
            this.matrix.Name = "matrix";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.matrix.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.matrix.RowTemplate.Height = 24;
            this.matrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrix.ShowCellToolTips = false;
            this.matrix.Size = new System.Drawing.Size(452, 309);
            this.matrix.TabIndex = 1;
            // 
            // addb
            // 
            this.addb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addb.Location = new System.Drawing.Point(9, 314);
            this.addb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(34, 37);
            this.addb.TabIndex = 1;
            this.addb.Text = "+";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // delb
            // 
            this.delb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delb.Location = new System.Drawing.Point(47, 314);
            this.delb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delb.Name = "delb";
            this.delb.Size = new System.Drawing.Size(34, 37);
            this.delb.TabIndex = 2;
            this.delb.Text = "-";
            this.delb.UseVisualStyleBackColor = true;
            this.delb.Click += new System.EventHandler(this.delb_Click);
            // 
            // drawb
            // 
            this.drawb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawb.Location = new System.Drawing.Point(356, 314);
            this.drawb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawb.Name = "drawb";
            this.drawb.Size = new System.Drawing.Size(88, 37);
            this.drawb.TabIndex = 3;
            this.drawb.Text = "Draw";
            this.drawb.UseVisualStyleBackColor = true;
            this.drawb.Click += new System.EventHandler(this.drawb_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(258, 314);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(88, 37);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // liste
            // 
            this.liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liste.FormattingEnabled = true;
            this.liste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.liste.Location = new System.Drawing.Point(189, 318);
            this.liste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(60, 28);
            this.liste.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 360);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.search);
            this.Controls.Add(this.drawb);
            this.Controls.Add(this.delb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.matrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button delb;
        private System.Windows.Forms.Button drawb;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox liste;
    }
}

