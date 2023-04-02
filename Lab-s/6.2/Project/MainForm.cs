namespace Project;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        _cells = new bool[(int)inputHeight.Value + 2, (int)inputWidth.Value + 2];
        ResizeMainView();
    }

    private bool[,] _cells;

    private void SizeValue_Changed(object sender, EventArgs e)
    {
        _cells = new bool[(int)inputHeight.Value + 2, (int)inputWidth.Value + 2];
        ResizeMainView();
    }

    private void SimulationProcess_Click(object sender, EventArgs e)
    {
        bool[,] buffer = (bool[,])_cells.Clone();

        for (int y = 1; y < _cells.GetLength(0) - 1; y++)
        {
            for (int x = 1; x < _cells.GetLength(1) - 1; x++)
            {
                var nc = CountNeighbors(x, y);

                // Rules
                if (!_cells[y, x] &&
                    nc == 3)
                {
                    buffer[y, x] = true;
                }
                else if (_cells[y, x] &&
                    (nc < 2 || nc > 3))
                {
                    buffer[y, x] = false;
                }
            }
        }

        _cells = buffer;
        
        RedrawMainView();
    }

    private int CountNeighbors(int x, int y)
    {
        int res = 0;

        // Up-Left
        if (_cells[y - 1, x - 1])
        {
            res++;
        }

        // Up
        if (_cells[y - 1, x])
        {
            res++;
        }

        // Up-Right
        if (_cells[y - 1, x + 1])
        {
            res++;
        }

        // Left
        if (_cells[y, x - 1])
        {
            res++;
        }

        // Right
        if (_cells[y, x + 1])
        {
            res++;
        }

        // Down-Left
        if (_cells[y + 1, x - 1])
        {
            res++;
        }

        // Down
        if (_cells[y + 1, x])
        {
            res++;
        }

        // Down-Right
        if (_cells[y + 1, x + 1])
        {
            res++;
        }

        return res;
    }

    private void RedrawMainView()
    {
        for (int y = 1; y < _cells.GetLength(0) - 1; y++)
        {
            for (int x = 1; x < _cells.GetLength(1) - 1; x++)
            {
                if (_cells[y, x])
                {
                    outputMainView.Rows[y - 1].Cells[x - 1].Style.BackColor = Color.Black;
                }
                else
                {
                    outputMainView.Rows[y - 1].Cells[x - 1].Style.BackColor = Color.White;
                }
            }
        }
    }

    private void ResizeMainView()
    {
        outputMainView.Rows.Clear();

        outputMainView.RowCount = (int)inputHeight.Value;
        outputMainView.ColumnCount = (int)inputWidth.Value;

        for (int y = 0; y < outputMainView.RowCount; y++)
        {
            for (int x = 0; x < outputMainView.ColumnCount; x++)
            {
                outputMainView.Rows[y].Cells[x].Value = " ";
            }
        }
    }

    private void MainViewCell_DoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (outputMainView.SelectedCells.Count == 0)
        {
            return;
        }

        var x = outputMainView.SelectedCells[0].ColumnIndex + 1;
        var y = outputMainView.SelectedCells[0].RowIndex + 1;

        _cells[y, x] = !_cells[y, x];

        RedrawMainView();

        outputMainView.ClearSelection();
    }

    private void MainView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.N)
        {
            SizeValue_Changed(this, EventArgs.Empty);
        }
    }
}
