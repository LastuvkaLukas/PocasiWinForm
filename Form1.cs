using System;
using System.Windows.Forms;
using PocasiWinForm.TemperatureConfig;
using PocasiWinForm.SourceTemperature;

namespace PocasiWinForm
{
    public partial class PocasiWinForm1 : Form
    {
        //MyFields
        private readonly int _timerSpeed = 500;
        private Temperature _temperature = null;
        private readonly Temperature[] _sourceTemp =
        {
            new Venek_FEI(),
            new Ucebna_PC102(),
            new Kancl_FEI(),
            new Sternberk()
        };

        //MyMethods
        private void Settings()
        {
            //events (Změna jednotky)
            rbC.CheckedChanged += (sender, e) => { SetUnit(Degree.Celsius); ClearChart(); };
            rbF.CheckedChanged += (sender, e) => { SetUnit(Degree.Fahrenheit); ClearChart(); };

            timer.Interval = _timerSpeed;

            cbSelect.Items.AddRange(_sourceTemp);

            cbSelect.SelectedIndex = 0;

            timer.Start();
        }

        private void LoadTemp() => _temperature.Update();

        private void WriteTemp() => lbTemp.Text = _temperature.GetDegreeString();

        private void SetUnit(Degree s) => _temperature.Unit = s;

        private void Rewrite() => lbName.Text = _temperature.ToString();

        private void SelectTemp() => _temperature = cbSelect.SelectedItem as Temperature;

        private void SelectUnit()
        {
            if (_temperature.Unit == Degree.Celsius) rbC.Select();
            else rbF.Select();
        }

        private void CheckError() => lbErr.Visible = double.IsNaN(_temperature.GetDegree());

        private void ClearChart() => chChart.Series[0].Points.Clear();

        private void PutToChart()
        {
            if (!double.IsNaN(_temperature.GetDegree())) chChart.Series[0].Points.Add(_temperature.GetDegree());
        }


        // -- Designer -- //

        public PocasiWinForm1()
        {
            InitializeComponent();

            Settings();
            SelectTemp();
            Rewrite();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadTemp();
            CheckError();
            WriteTemp();
            PutToChart();
        }

        private void CbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTemp();
            SelectUnit();
            ClearChart();
            Rewrite();
        }
    }
}
