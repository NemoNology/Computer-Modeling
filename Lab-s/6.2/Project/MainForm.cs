namespace Project;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private float _simulationSpeed = 1;

    private void SizeValue_Changed(object sender, EventArgs e)
    {

    }

    private void StartSimulation_Click(object sender, EventArgs e)
    {

    }

    private void StopSimulation_Click(object sender, EventArgs e)
    {

    }

    private void SimulationSpeedValue_Changed(object sender, EventArgs e)
    {
        var value = inputSimulationSpeed.Value;

        if (value > 0)
        {
            _simulationSpeed = value;
        }
        else
        {
            _simulationSpeed = (10f + value) / 10;
        }

        outputSimulationSpeed.Text = $"{_simulationSpeed}";
    }
}
