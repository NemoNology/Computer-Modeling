namespace Project;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        splitContainer1 = new SplitContainer();
        outputMainView = new PictureBox();
        inputSimulationSpeed = new TrackBar();
        inputHeight = new NumericUpDown();
        inputWidth = new NumericUpDown();
        label4 = new Label();
        label2 = new Label();
        label3 = new Label();
        outputSimulationSpeed = new Label();
        label1 = new Label();
        buttonStop = new Button();
        buttonStart = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)outputMainView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)inputSimulationSpeed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)inputHeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)inputWidth).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(outputMainView);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.BackColor = SystemColors.ScrollBar;
        splitContainer1.Panel2.Controls.Add(inputSimulationSpeed);
        splitContainer1.Panel2.Controls.Add(inputHeight);
        splitContainer1.Panel2.Controls.Add(inputWidth);
        splitContainer1.Panel2.Controls.Add(label4);
        splitContainer1.Panel2.Controls.Add(label2);
        splitContainer1.Panel2.Controls.Add(label3);
        splitContainer1.Panel2.Controls.Add(outputSimulationSpeed);
        splitContainer1.Panel2.Controls.Add(label1);
        splitContainer1.Panel2.Controls.Add(buttonStop);
        splitContainer1.Panel2.Controls.Add(buttonStart);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 573;
        splitContainer1.SplitterWidth = 10;
        splitContainer1.TabIndex = 0;
        // 
        // outputMainView
        // 
        outputMainView.Dock = DockStyle.Fill;
        outputMainView.Location = new Point(0, 0);
        outputMainView.Name = "outputMainView";
        outputMainView.Size = new Size(573, 450);
        outputMainView.TabIndex = 0;
        outputMainView.TabStop = false;
        // 
        // inputSimulationSpeed
        // 
        inputSimulationSpeed.Location = new Point(19, 336);
        inputSimulationSpeed.Minimum = -9;
        inputSimulationSpeed.Name = "inputSimulationSpeed";
        inputSimulationSpeed.Size = new Size(174, 45);
        inputSimulationSpeed.TabIndex = 3;
        inputSimulationSpeed.Value = 1;
        inputSimulationSpeed.ValueChanged += SimulationSpeedValue_Changed;
        // 
        // inputHeight
        // 
        inputHeight.Location = new Point(91, 106);
        inputHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        inputHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        inputHeight.Name = "inputHeight";
        inputHeight.Size = new Size(83, 23);
        inputHeight.TabIndex = 2;
        inputHeight.Value = new decimal(new int[] { 20, 0, 0, 0 });
        inputHeight.ValueChanged += SizeValue_Changed;
        // 
        // inputWidth
        // 
        inputWidth.Location = new Point(87, 72);
        inputWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        inputWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        inputWidth.Name = "inputWidth";
        inputWidth.Size = new Size(87, 23);
        inputWidth.TabIndex = 2;
        inputWidth.Value = new decimal(new int[] { 20, 0, 0, 0 });
        inputWidth.ValueChanged += SizeValue_Changed;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(52, 302);
        label4.Name = "label4";
        label4.Size = new Size(102, 15);
        label4.TabIndex = 1;
        label4.Text = "Simulation speed";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(87, 43);
        label2.Name = "label2";
        label2.Size = new Size(30, 15);
        label2.TabIndex = 1;
        label2.Text = "Size";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(39, 74);
        label3.Name = "label3";
        label3.Size = new Size(42, 15);
        label3.TabIndex = 1;
        label3.Text = "Width:";
        // 
        // outputSimulationSpeed
        // 
        outputSimulationSpeed.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        outputSimulationSpeed.Location = new Point(19, 384);
        outputSimulationSpeed.Name = "outputSimulationSpeed";
        outputSimulationSpeed.Size = new Size(174, 25);
        outputSimulationSpeed.TabIndex = 1;
        outputSimulationSpeed.Text = "1";
        outputSimulationSpeed.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(39, 108);
        label1.Name = "label1";
        label1.Size = new Size(46, 15);
        label1.TabIndex = 1;
        label1.Text = "Height:";
        // 
        // buttonStop
        // 
        buttonStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonStop.Location = new Point(118, 231);
        buttonStop.Name = "buttonStop";
        buttonStop.Size = new Size(75, 23);
        buttonStop.TabIndex = 0;
        buttonStop.Text = "Stop";
        buttonStop.UseVisualStyleBackColor = true;
        buttonStop.Click += StopSimulation_Click;
        // 
        // buttonStart
        // 
        buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonStart.Location = new Point(19, 231);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new Size(75, 23);
        buttonStart.TabIndex = 0;
        buttonStart.Text = "Start";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += StartSimulation_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "MainForm";
        Text = "Form1";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)outputMainView).EndInit();
        ((System.ComponentModel.ISupportInitialize)inputSimulationSpeed).EndInit();
        ((System.ComponentModel.ISupportInitialize)inputHeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)inputWidth).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private PictureBox outputMainView;
    private TrackBar inputSimulationSpeed;
    private NumericUpDown inputWidth;
    private Label label2;
    private Label label3;
    private Label label1;
    private Button buttonStart;
    private NumericUpDown inputHeight;
    private Button buttonStop;
    private Label label4;
    private Label outputSimulationSpeed;
}
