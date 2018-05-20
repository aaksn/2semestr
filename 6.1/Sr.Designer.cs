namespace _6._1
{
    partial class Sr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gpe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.processinglabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gpe)).BeginInit();
            this.SuspendLayout();
            // 
            // gpe
            // 
            this.gpe.BackColor = System.Drawing.SystemColors.Control;
            this.gpe.BorderlineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Title = "Количество элементов";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "Количетсво сравнений";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.gpe.ChartAreas.Add(chartArea1);
            this.gpe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.HeaderSeparatorColor = System.Drawing.SystemColors.Control;
            legend1.ItemColumnSeparatorColor = System.Drawing.SystemColors.Control;
            legend1.Name = "Legend1";
            this.gpe.Legends.Add(legend1);
            this.gpe.Location = new System.Drawing.Point(0, 0);
            this.gpe.Name = "gpe";
            this.gpe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.gpe.Size = new System.Drawing.Size(631, 530);
            this.gpe.TabIndex = 0;
            this.gpe.Text = "График сравнеий";
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title1.BorderWidth = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "График сравнений";
            this.gpe.Titles.Add(title1);
            // 
            // processinglabel
            // 
            this.processinglabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processinglabel.Location = new System.Drawing.Point(0, 0);
            this.processinglabel.Name = "processinglabel";
            this.processinglabel.Size = new System.Drawing.Size(631, 530);
            this.processinglabel.TabIndex = 1;
            this.processinglabel.Text = "Processing...";
            this.processinglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.processinglabel.Visible = false;
            this.processinglabel.VisibleChanged += new System.EventHandler(this.processinglabel_VisibleChanged);
            // 
            // Sr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 530);
            this.Controls.Add(this.gpe);
            this.Controls.Add(this.processinglabel);
            this.Name = "Sr";
            this.Text = "Sr";
            ((System.ComponentModel.ISupportInitialize)(this.gpe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart gpe;
        private System.Windows.Forms.Label processinglabel;
    }
}