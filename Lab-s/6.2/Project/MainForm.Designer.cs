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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        splitContainer1 = new SplitContainer();
        outputMainView = new DataGridView();
        inputHeight = new NumericUpDown();
        inputWidth = new NumericUpDown();
        label2 = new Label();
        label3 = new Label();
        label1 = new Label();
        buttonSimulateProcess = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)outputMainView).BeginInit();
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
        splitContainer1.Panel2.Controls.Add(inputHeight);
        splitContainer1.Panel2.Controls.Add(inputWidth);
        splitContainer1.Panel2.Controls.Add(label2);
        splitContainer1.Panel2.Controls.Add(label3);
        splitContainer1.Panel2.Controls.Add(label1);
        splitContainer1.Panel2.Controls.Add(buttonSimulateProcess);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 573;
        splitContainer1.SplitterWidth = 10;
        splitContainer1.TabIndex = 0;
        // 
        // outputMainView
        // 
        outputMainView.AllowUserToAddRows = false;
        outputMainView.AllowUserToDeleteRows = false;
        outputMainView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
        outputMainView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        outputMainView.BackgroundColor = SystemColors.ScrollBar;
        outputMainView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.ScrollBar;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        outputMainView.DefaultCellStyle = dataGridViewCellStyle1;
        outputMainView.Dock = DockStyle.Fill;
        outputMainView.Location = new Point(0, 0);
        outputMainView.MultiSelect = false;
        outputMainView.Name = "outputMainView";
        outputMainView.ReadOnly = true;
        outputMainView.RowTemplate.Height = 25;
        outputMainView.SelectionMode = DataGridViewSelectionMode.CellSelect;
        outputMainView.Size = new Size(573, 450);
        outputMainView.TabIndex = 0;
        outputMainView.CellMouseDoubleClick += MainViewCell_DoubleClick;
        outputMainView.PreviewKeyDown += MainView_PreviewKeyDown;
        // 
        // inputHeight
        // 
        inputHeight.Location = new Point(91, 126);
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
        inputWidth.Location = new Point(87, 92);
        inputWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        inputWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        inputWidth.Name = "inputWidth";
        inputWidth.Size = new Size(87, 23);
        inputWidth.TabIndex = 2;
        inputWidth.Value = new decimal(new int[] { 20, 0, 0, 0 });
        inputWidth.ValueChanged += SizeValue_Changed;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(87, 63);
        label2.Name = "label2";
        label2.Size = new Size(30, 15);
        label2.TabIndex = 1;
        label2.Text = "Size";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(39, 94);
        label3.Name = "label3";
        label3.Size = new Size(42, 15);
        label3.TabIndex = 1;
        label3.Text = "Width:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(39, 128);
        label1.Name = "label1";
        label1.Size = new Size(46, 15);
        label1.TabIndex = 1;
        label1.Text = "Height:";
        // 
        // buttonSimulateProcess
        // 
        buttonSimulateProcess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        buttonSimulateProcess.Location = new Point(39, 274);
        buttonSimulateProcess.Name = "buttonSimulateProcess";
        buttonSimulateProcess.Size = new Size(135, 30);
        buttonSimulateProcess.TabIndex = 0;
        buttonSimulateProcess.Text = "Simulate Process";
        buttonSimulateProcess.UseVisualStyleBackColor = true;
        buttonSimulateProcess.Click += SimulationProcess_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Game \"Life\"";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)outputMainView).EndInit();
        ((System.ComponentModel.ISupportInitialize)inputHeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)inputWidth).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private NumericUpDown inputWidth;
    private Label label2;
    private Label label3;
    private Label label1;
    private Button buttonSimulateProcess;
    private NumericUpDown inputHeight;
    private DataGridView outputMainView;
}
