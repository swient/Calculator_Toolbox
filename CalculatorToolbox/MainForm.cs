using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace CalculatorToolbox
{
    public partial class MainForm : Form
    {
        private readonly Calculator calculator = new();

        public MainForm()
        {
            InitializeComponent();
            calculator.Dock = DockStyle.Fill;
            this.Controls.Add(calculator);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = !menuPanel.Visible;
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            btnCalculator.BackColor = SystemColors.ControlLight;
            btnCurrencyConverter.BackColor = Color.WhiteSmoke;
            btnUnitConverter.BackColor = Color.WhiteSmoke;
            menuPanel.Visible = false;
            calculator.Visible = true;
        }

        private void BtnCurrencyConverter_Click(object sender, EventArgs e)
        {
            btnCalculator.BackColor = Color.WhiteSmoke;
            btnCurrencyConverter.BackColor = SystemColors.ControlLight;
            btnUnitConverter.BackColor = Color.WhiteSmoke;
            menuPanel.Visible = false;
        }

        private void BtnUnitConverter_Click(object sender, EventArgs e)
        {
            btnCalculator.BackColor = Color.WhiteSmoke;
            btnCurrencyConverter.BackColor = Color.WhiteSmoke;
            btnUnitConverter.BackColor = SystemColors.ControlLight;
            menuPanel.Visible = false;
        }
    }
}
