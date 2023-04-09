namespace Project
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.outputBaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputFurryChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputFurryChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputFurryChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.inputStringLength = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.inputStartAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputStartSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputStart = new System.Windows.Forms.Button();
            this.inputStop = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.outputBaseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFurryChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFurryChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFurryChart3)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBaseChart
            // 
            chartArea1.Name = "ChartArea1";
            this.outputBaseChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.outputBaseChart.Legends.Add(legend1);
            this.outputBaseChart.Location = new System.Drawing.Point(12, 12);
            this.outputBaseChart.Name = "outputBaseChart";
            this.outputBaseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.outputBaseChart.Series.Add(series1);
            this.outputBaseChart.Size = new System.Drawing.Size(291, 356);
            this.outputBaseChart.TabIndex = 0;
            this.outputBaseChart.Text = "chart1";
            // 
            // outputFurryChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.outputFurryChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.outputFurryChart2.Legends.Add(legend2);
            this.outputFurryChart2.Location = new System.Drawing.Point(12, 377);
            this.outputFurryChart2.Name = "outputFurryChart2";
            this.outputFurryChart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.outputFurryChart2.Series.Add(series2);
            this.outputFurryChart2.Size = new System.Drawing.Size(291, 356);
            this.outputFurryChart2.TabIndex = 0;
            this.outputFurryChart2.Text = "chart1";
            // 
            // outputFurryChart1
            // 
            chartArea3.Name = "ChartArea1";
            this.outputFurryChart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.outputFurryChart1.Legends.Add(legend3);
            this.outputFurryChart1.Location = new System.Drawing.Point(329, 12);
            this.outputFurryChart1.Name = "outputFurryChart1";
            this.outputFurryChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.outputFurryChart1.Series.Add(series3);
            this.outputFurryChart1.Size = new System.Drawing.Size(291, 356);
            this.outputFurryChart1.TabIndex = 0;
            this.outputFurryChart1.Text = "chart1";
            // 
            // outputFurryChart3
            // 
            chartArea4.Name = "ChartArea1";
            this.outputFurryChart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.outputFurryChart3.Legends.Add(legend4);
            this.outputFurryChart3.Location = new System.Drawing.Point(329, 377);
            this.outputFurryChart3.Name = "outputFurryChart3";
            this.outputFurryChart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.outputFurryChart3.Series.Add(series4);
            this.outputFurryChart3.Size = new System.Drawing.Size(291, 356);
            this.outputFurryChart3.TabIndex = 0;
            this.outputFurryChart3.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(666, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String length:";
            // 
            // inputStringLength
            // 
            this.inputStringLength.Location = new System.Drawing.Point(755, 238);
            this.inputStringLength.Name = "inputStringLength";
            this.inputStringLength.Size = new System.Drawing.Size(100, 20);
            this.inputStringLength.TabIndex = 2;
            this.inputStringLength.Text = "0,1";
            this.inputStringLength.TextChanged += new System.EventHandler(this.InputStringLength_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 747);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(675, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Angle:";
            // 
            // inputStartAngle
            // 
            this.inputStartAngle.Location = new System.Drawing.Point(755, 277);
            this.inputStartAngle.Name = "inputStartAngle";
            this.inputStartAngle.Size = new System.Drawing.Size(100, 20);
            this.inputStartAngle.TabIndex = 2;
            this.inputStartAngle.Text = "30";
            this.inputStartAngle.TextChanged += new System.EventHandler(this.InputStartAngle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(673, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Start speed:";
            // 
            // inputStartSpeed
            // 
            this.inputStartSpeed.Location = new System.Drawing.Point(755, 317);
            this.inputStartSpeed.Name = "inputStartSpeed";
            this.inputStartSpeed.Size = new System.Drawing.Size(100, 20);
            this.inputStartSpeed.TabIndex = 2;
            this.inputStartSpeed.Text = "5";
            this.inputStartSpeed.TextChanged += new System.EventHandler(this.InputStartSpeed_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(861, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "°/s";
            // 
            // inputStart
            // 
            this.inputStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStart.Location = new System.Drawing.Point(697, 414);
            this.inputStart.Name = "inputStart";
            this.inputStart.Size = new System.Drawing.Size(75, 23);
            this.inputStart.TabIndex = 5;
            this.inputStart.Text = "Start";
            this.inputStart.UseVisualStyleBackColor = true;
            // 
            // inputStop
            // 
            this.inputStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputStop.Location = new System.Drawing.Point(787, 414);
            this.inputStop.Name = "inputStop";
            this.inputStop.Size = new System.Drawing.Size(75, 23);
            this.inputStop.TabIndex = 5;
            this.inputStop.Text = "Stop";
            this.inputStop.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(16, 17);
            this.status.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(924, 769);
            this.Controls.Add(this.inputStop);
            this.Controls.Add(this.inputStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.inputStartSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputStartAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputStringLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputFurryChart3);
            this.Controls.Add(this.outputFurryChart1);
            this.Controls.Add(this.outputFurryChart2);
            this.Controls.Add(this.outputBaseChart);
            this.Name = "MainForm";
            this.Text = "Harmonic Pendulum";
            ((System.ComponentModel.ISupportInitialize)(this.outputBaseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFurryChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFurryChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFurryChart3)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart outputBaseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart outputFurryChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart outputFurryChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart outputFurryChart3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStringLength;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputStartAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputStartSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button inputStart;
        private System.Windows.Forms.Button inputStop;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

