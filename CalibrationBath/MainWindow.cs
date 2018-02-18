using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace CalibrationBath
{
	public partial class MainWindow : Form
    {
        private string[] units = { "°C", "°F", "°C/min", "°F/min" };
        private Settings settings = Settings.Default;
        private SerialPort port = new SerialPort();
        private int statusTemp = 0;
        private int statusScan = 0;
        private double minTemp = 0;
        private double maxTemp = 0;
        private double midTemp = 0;

        public MainWindow()
        {
            InitializeComponent();
            DefaultSettings();

            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            ConnectIO();
            EndData();
        }

        public void EndData()
        {
            SendData("sc\x0D");
            System.Threading.Thread.Sleep(150);
            SendData("sr\x0D");
            System.Threading.Thread.Sleep(150);
            SendData("v\x0D");
            System.Threading.Thread.Sleep(150);
        }

        public void DefaultSettings()
        {
            settings.Reload();

            port.BaudRate = settings.TransmissionInterval;
            port.DataBits = settings.DateBytes;
            port.StopBits = settings.StopBytes;
            port.Parity = settings.Odd;
            port.PortName = settings.PortName;

            statusTemp = settings.UnitTemp;
            minTemp = settings.MinTemp;
            maxTemp = settings.MaxTemp;
            midTemp = settings.MidTemp;

            label1.Text = maxTemp.ToString();
            label2.Text = minTemp.ToString();
            Terminal.Items.Clear();
        }

        public void ConnectIO()
        {
            bool error = false;

            if (!port.IsOpen)
            {
                try
                {
                    port.Open();
                }
                catch
                {
                    error = true;
                }

                if (error)
                    MessageBox.Show(this, "Nie można połączyć z portem.", "Port niedostępny", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                port.Close();
        }

        public void SendData(string command)
        {
            if (!port.IsOpen)
                return;

            try
            {
                command = command.Replace(",", ".");
                byte[] pack = ASCIIEncoding.ASCII.GetBytes(command);
                port.Write(pack, 0, pack.Length);

                if (command.StartsWith("t="))
                {
                    LastValue.Text = TextTemperature.Text;
                    TextTemperature.SelectAll();
                }
            }
            catch
            {
                MessageBox.Show(this, "Wysłanie wiadomości nie powiodło się.", "Błąd 404", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void SettingsChange(bool przyciskOK, bool nowyStatusTemp, bool nowyStatusSkanowania, bool nowaWartoscSkanowania, bool nowaWartoscNoniusza)
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectIO();
            SettingsWindow wnd = new SettingsWindow(this, port, statusScan);
			wnd.FormClosed += Wnd_FormClose;
            wnd.ShowDialog();
        }

		private void Wnd_FormClose(object sender, FormClosedEventArgs e)
		{
			var wnd = sender as SettingsWindow;
			wnd.FormClosed -= Wnd_FormClose;

			ConnectIO();

			if (wnd.ChangeStatusTemp)
				if (statusTemp == 0)
					SendData("u=c\x0D");
				else
					SendData("u=f\x0D");

			if (wnd.ChangeStatusScan)
				if (settings.ScanIO == 0)
				{
					SendData("sc=on\x0D");
					statusScan = 0;
				}
				else
				{
					SendData("sc=of\x0D");
					statusScan = 1;
				}

			if (wnd.ChangeScanValue)
				SendData("sr=" + settings.ScanValue + "\x0D");

			if (wnd.ChangeNoniusValue)
				SendData("v=" + settings.Nonius + "\x0D");

			EndData();
		}

		private void textTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 45;

            if (e.KeyChar == 13)
            {
                bool error = false;
                double textValue = double.Parse(TextTemperature.Text);
                if (textValue < maxTemp && textValue > minTemp)
                {
                    if (!String.IsNullOrEmpty(TextTemperature.Text))
                    {
                        double readValue = Math.Round(double.Parse(TextTemperature.Text), 2);
                        SendData("t=" + readValue + "\x0D");
                    }
                    else
                        error = true;
                }
                else
                    error = true;

                if (error)
                    MessageBox.Show(this, "Pole danych wypełnione zostało niepoprawnie.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!port.IsOpen) 
                return;

            int byteCount = port.BytesToRead;
            byte[] bytes = new byte[byteCount];
            port.Read(bytes, 0, byteCount);

            string message = ASCIIEncoding.ASCII.GetString(bytes, 0, bytes.Length);
            if (message.EndsWith("\x0D\x0A"))
            {
                message.Substring(0, message.Length - 2);
                string[] array = ReplaceString(message);

                string temp = null;
                if (array[0].Equals("t:") || array[0].Equals("set:"))
                {
                    temp += array[1] + " ";
                    if (array[2].Equals("C"))
                        temp += units[0];
                    else
                        temp += units[1];

                    ListViewItem pos = new ListViewItem(DateTime.Now.ToString("hh:mm ss"));
                    pos.SubItems.Add(temp);
                    Terminal.Items.Insert(0, pos);
                }
                else if (array[0].Equals("srat:"))
                {
                    TextScanInterval.Text = array[1];
                    if (array[2].Equals("C/min"))
                        TextScanInterval.Text += units[2];
                    else
                        TextScanInterval.Text += units[3];
                }
                else if (array[0].Equals("v:"))
                {
                    wartoscNoniusza.Text = array[1];
                }
                else if (array[0].Equals("scan:"))
                {
                    if (array[1].Equals("ON"))
                        statusScan = 0;
                    else if (array[1].Equals("OFF"))
                        statusScan = 1;
                }
                message = null;
            }
        }

        private string[] ReplaceString(string value)
        {
            return Regex.Replace(value, @"\s+", " ").Split(' ');
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectIO();
        }
    }
}
