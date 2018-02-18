using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;

namespace CalibrationBath
{
	public partial class SettingsWindow : Form
    {
        private string[] units = { "°C", "°F", "°C/min", "°F/min" };
        private Settings settings = Settings.Default;
        private MainWindow mainWindow;
        private SerialPort port;
        private int statusTemp = 0;
        private int statusScan = 0;
        public bool ChangeStatusTemp { get; set; }
        public bool ChangeStatusScan { get; set; }
        public bool ChangeScanValue { get; set; }
        public bool ChangeNoniusValue { get; set; }
        public double MinScan { get; set; }
        public double MaxScan { get; set; }

        public SettingsWindow(MainWindow _mainWindow, SerialPort _port, int _statusScan)
        {
            mainWindow = _mainWindow;
            port = _port;
            statusScan = _statusScan;
            InitializeComponent();
            Connection();
        }

        private void Connection()
        {
            settings.Reload();

            comboTemp.Items.Clear();
            comboTemp.Items.Add("Celsjusz");
            comboTemp.Items.Add("Fahrenheit");
            statusTemp = settings.UnitTemp;
            if (statusTemp == 0)
            {
                comboTemp.SelectedIndex = 0;
            }
            else
            {
                comboTemp.SelectedIndex = 1;
            }
            ScanBoundValue();

            comboStop.Items.Clear();
            comboStop.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboOdd.Items.Clear();
            comboOdd.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboInterval.Text = settings.TransmissionInterval.ToString();
            comboDane.Text = settings.DateBytes.ToString();
            comboOdd.Text = settings.Odd.ToString();
            comboStop.Text = settings.StopBytes.ToString();
            PortList();
            
            textMax.Text = settings.MaxTemp.ToString();
            textMin.Text = settings.MinTemp.ToString();
            textMid.Text = settings.MidTemp.ToString();

            if (ComboPort.Items.Contains(settings.PortName))
            {
                ComboPort.Text = settings.PortName;
            }
            else if (ComboPort.Items.Count > 0)
            {
                ComboPort.SelectedIndex = ComboPort.Items.Count - 1;
            }
            else
            {
                MessageBox.Show(this, "Nie wykryto żadnych portów szeregowych na tym komputerze.", "Brak portów szeregowych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ComboScan.Items.Clear();
            ComboScan.Items.Add("ON");
            ComboScan.Items.Add("OFF");
            ComboScan.SelectedIndex = statusScan;
            IntervalScan.Text = settings.ScanValue.ToString();

            vernier.Text = settings.Noniusz.ToString();
        }

        private void ScanBoundValue()
        {
            switch (statusTemp)
            {
                case 0:
					MinScan = 0.001;
                    MaxScan = 5;
                    break;
                case 1:
					MinScan = 0.002;
                    MaxScan = 9;
                    break;
                default:
                    break;
            }
            infoScan.Text = "Od " + MinScan + " do " + MaxScan + " " + units[statusTemp + 2];
            UnitValue.Text = "Wartość w " + units[statusTemp];
            ScanValue.Text = "Wartość w " + units[statusTemp + 2];
        }

        private void PortList()
        {
            string pos = InsertPortList(ComboPort.Items.Cast<string>(), ComboPort.SelectedItem as string, port.IsOpen);

            if (!String.IsNullOrEmpty(pos))
            {
                ComboPort.Items.Clear();
                ComboPort.Items.AddRange(PortNames());
                ComboPort.SelectedItem = pos;
            }
        }

        private string[] PortNames()
        {
            int number;
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out number) ? number : 0).ToArray();
        }

        private string InsertPortList(IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
        {
            string selected = null;
            string[] PortList = SerialPort.GetPortNames();

            if (PreviousPortNames.Except(PortList).Count() > 0 || PortList.Except(PreviousPortNames).Count() > 0)
            {
                PortList = PortNames();
                string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

                if (PortOpen)
                {
                    if (PortList.Contains(CurrentSelection)) 
                        selected = CurrentSelection;
                    else if (!String.IsNullOrEmpty(newest)) 
                        selected = newest;
                    else 
                        selected = PortList.LastOrDefault();
                }
                else
                {
                    if (!String.IsNullOrEmpty(newest)) 
                        selected = newest;
                    else if (PortList.Contains(CurrentSelection)) 
                        selected = CurrentSelection;
                    else 
                        selected = PortList.LastOrDefault();
                }
            }
            return selected;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!String.IsNullOrEmpty(textMax.Text) && !String.IsNullOrEmpty(textMin.Text) && !String.IsNullOrEmpty(textMid.Text) && !String.IsNullOrEmpty(IntervalScan.Text) && !String.IsNullOrEmpty(vernier.Text))
            {
                double temp = Math.Round(double.Parse(IntervalScan.Text), 3);
                if (temp <= MaxScan && temp >= MinScan)
                {
                    settings.PortName = ComboPort.Text;
                    settings.TransmissionInterval = int.Parse(comboInterval.Text);
                    settings.DateBytes = int.Parse(comboDane.Text);
                    settings.Odd = (Parity)Enum.Parse(typeof(Parity), comboOdd.Text);
                    settings.StopBytes = (StopBits)Enum.Parse(typeof(StopBits), comboStop.Text);

                    settings.UnitTemp = comboTemp.SelectedIndex;
                    settings.MaxTemp = Math.Round(double.Parse(textMax.Text), 2);
                    settings.MinTemp = Math.Round(double.Parse(textMin.Text), 2);
                    settings.MidTemp = Math.Round(double.Parse(textMid.Text), 2);

                    settings.ScanIO = ComboScan.SelectedIndex;
                    settings.ScanValue = temp;

                    settings.Noniusz = Math.Round(double.Parse(vernier.Text), 5);

                    settings.Save();
                    mainWindow.DefaultSettings();
					Close();
                }
                else
                    error = true;
            }
            else
                error = true;
            
            if (error)
                MessageBox.Show(this, "Pozostawiono pole bez wartości lub wpisano nie odpowiednią wartość.", "Błąd uzupełnienia pola", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void comboTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusTemp != comboTemp.SelectedIndex)
            {
                statusTemp = comboTemp.SelectedIndex;
                if (statusTemp == 0)
                {
                    textMax.Text = Math.Round(ConvertFahrenheitToCelsius(double.Parse(textMax.Text)), 2).ToString();
                    textMin.Text = Math.Round(ConvertFahrenheitToCelsius(double.Parse(textMin.Text)), 2).ToString();
                    textMid.Text = Math.Round(ConvertFahrenheitToCelsius(double.Parse(textMid.Text)), 2).ToString();
                }
                else
                {
                    textMax.Text = Math.Round(ConvertCelsiusToFahrenheit(double.Parse(textMax.Text)), 2).ToString();
                    textMin.Text = Math.Round(ConvertCelsiusToFahrenheit(double.Parse(textMin.Text)), 2).ToString();
                    textMid.Text = Math.Round(ConvertCelsiusToFahrenheit(double.Parse(textMid.Text)), 2).ToString();
                }
                ScanBoundValue();
            }

			ChangeStatusTemp = statusTemp != settings.UnitTemp;
        }

        public double ConvertCelsiusToFahrenheit(double tempC)
        {
            return (tempC * (1.8)) + 32;
        }

        public double ConvertFahrenheitToCelsius(double tempF)
        {
            return (0.5555) * (tempF - 32);
        }

        private void TextMax_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44;
        }

        private void TextMin_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44;
        }

        private void Interval_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44;
        }

        private void Vernier_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44;
        }

        private void ComboScan_SelectedIndexChanged(object sender, EventArgs e)
        {
			ChangeStatusScan = ComboScan.SelectedIndex == settings.ScanIO;
        }

        private void Interval_TextChanged(object sender, EventArgs e)
        {
			ChangeScanValue = !IntervalScan.Text.Equals(settings.ScanValue.ToString());
        }

        private void Vernier_TextChanged(object sender, EventArgs e)
        {
			ChangeNoniusValue = !vernier.Text.Equals(settings.Noniusz.ToString());
        }
    }
}
