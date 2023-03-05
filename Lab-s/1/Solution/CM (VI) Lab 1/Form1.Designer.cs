
namespace CM__VI__Lab_1
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainView = new System.Windows.Forms.PictureBox();
            this.calculatedPI = new System.Windows.Forms.Label();
            this.deviation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lengthL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.repeatsAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.but_calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calculatedPI);
            this.splitContainer1.Panel2.Controls.Add(this.deviation);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lengthL);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.repeatsAmount);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.but_calculate);
            this.splitContainer1.Size = new System.Drawing.Size(984, 705);
            this.splitContainer1.SplitterDistance = 733;
            this.splitContainer1.TabIndex = 1;
            // 
            // MainView
            // 
            this.MainView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainView.Location = new System.Drawing.Point(3, 3);
            this.MainView.Name = "MainView";
            this.MainView.Size = new System.Drawing.Size(727, 699);
            this.MainView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainView.TabIndex = 0;
            this.MainView.TabStop = false;
            // 
            // calculatedPI
            // 
            this.calculatedPI.AutoSize = true;
            this.calculatedPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatedPI.Location = new System.Drawing.Point(51, 275);
            this.calculatedPI.Name = "calculatedPI";
            this.calculatedPI.Size = new System.Drawing.Size(21, 20);
            this.calculatedPI.TabIndex = 1;
            this.calculatedPI.Text = "...";
            // 
            // deviation
            // 
            this.deviation.AutoSize = true;
            this.deviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviation.Location = new System.Drawing.Point(90, 313);
            this.deviation.Name = "deviation";
            this.deviation.Size = new System.Drawing.Size(21, 20);
            this.deviation.TabIndex = 1;
            this.deviation.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Deviation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "~π =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "π = 3.141592653589793...";
            // 
            // lengthL
            // 
            this.lengthL.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthL.Location = new System.Drawing.Point(135, 185);
            this.lengthL.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthL.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthL.Name = "lengthL";
            this.lengthL.Size = new System.Drawing.Size(91, 20);
            this.lengthL.TabIndex = 2;
            this.lengthL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length L:";
            // 
            // repeatsAmount
            // 
            this.repeatsAmount.Location = new System.Drawing.Point(135, 141);
            this.repeatsAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.repeatsAmount.Name = "repeatsAmount";
            this.repeatsAmount.Size = new System.Drawing.Size(91, 20);
            this.repeatsAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Repeats amount:";
            // 
            // but_calculate
            // 
            this.but_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_calculate.Location = new System.Drawing.Point(3, 417);
            this.but_calculate.Name = "but_calculate";
            this.but_calculate.Size = new System.Drawing.Size(241, 60);
            this.but_calculate.TabIndex = 0;
            this.but_calculate.Text = "Calculate";
            this.but_calculate.UseVisualStyleBackColor = true;
            this.but_calculate.Click += new System.EventHandler(this.but_calculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Задача Бюффона";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox MainView;
        private System.Windows.Forms.Label calculatedPI;
        private System.Windows.Forms.Label deviation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lengthL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown repeatsAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_calculate;
    }
}

