using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace DewController
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        string[] ports;
        SerialPort port;
        string[] data;
        bool init = true;
        public Form1()
        {
            InitializeComponent();
            DisableControls();
            GetAvailableComPorts();
            foreach (string port in ports)
            {
                cbPort.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    cbPort.SelectedItem = ports[0];
                }
            }
        }
        private void DisableControls()
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void EnableControls()
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }

        void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void ConnectToArduino()
        {
            isConnected = true;
            string selectedPort = cbPort.GetItemText(cbPort.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            try
            {
                port.Open();
                port.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
                btnConnect.Text = "Disconnect";
                EnableControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening port: {0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate));
        }

        private void DoUpdate(object s, EventArgs e)
        {
            String temp = port.ReadLine();
            if (temp[0] == 'd')
            {
                //Debug.WriteLine(temp);
            }
            else
            {
                data = temp.Split('|');
                //Debug.WriteLine(temp);
                tbAmbientTemp.Text = data[0];
                tbAmbientHum.Text = data[1];
                tbDewPoint.Text = data[2];
                int heaterMode1 = int.Parse(data[3]);
                tbTempSensor1.Text = data[4];
                tbPower1.Text = data[5];

                int heaterMode2 = int.Parse(data[6]);
                tbTempSensor2.Text = data[7];
                tbPower2.Text = data[8];
                if (init)
                {
                    switch (heaterMode1)
                    {
                        case 0:
                            rbHeater1OFF.Checked = true;
                            rbHeater1Manual.Checked = false;
                            rbHeater1Auto.Checked = false;
                            break;
                        case 1:
                            rbHeater1OFF.Checked = false;
                            rbHeater1Manual.Checked = true;
                            rbHeater1Auto.Checked = false;
                            break;
                        case 2:
                            rbHeater1OFF.Checked = false;
                            rbHeater1Manual.Checked = false;
                            rbHeater1Auto.Checked = true;
                            break;

                    }

                    switch (heaterMode2)
                    {
                        case 0:
                            rbHeater2OFF.Checked = true;
                            rbHeater2Manual.Checked = false;
                            rbHeater2Auto.Checked = false;
                            break;
                        case 1:
                            rbHeater2OFF.Checked = false;
                            rbHeater2Manual.Checked = true;
                            rbHeater2Auto.Checked = false;
                            break;
                        case 2:
                            rbHeater2OFF.Checked = false;
                            rbHeater2Manual.Checked = false;
                            rbHeater2Auto.Checked = true;
                            break;

                    }
                    init = false;

                }
            }
        }

        private void DisconnectFromArduino()
        {
            isConnected = false;
            //port.Write("#STOP\n");
            port.Close();
            btnConnect.Text = "Connect";
            DisableControls();
        }


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                ConnectToArduino();
            }
            else
            {
                DisconnectFromArduino();
            }
        }

        private void RbHeater1OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHeater1OFF.Checked)
            {
                Heateroff(1);
            }
        }

        private void RbHeater1Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHeater1Auto.Checked)
            {
                HeaterAuto(1);
            }
        }

        private void RbHeater1Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHeater1Manual.Checked)
            {
                HeaterManual(1);
            }
        }

        private void Heateroff(int num)
        {
            if (num == 1)
            {
                rbHeater1Manual.Checked = false;
                rbHeater1Auto.Checked = false;
                string command = "#POW10\n";
                port.Write(command);
                DisableButtonPower(num);
            }
            else if (num == 2)
            {
                rbHeater2Manual.Checked = false;
                rbHeater2Auto.Checked = false;
                string command = "#POW20\n";
                port.Write(command);
                DisableButtonPower(num);
            }

        }

        private void HeaterManual(int num)
        {
            if (num == 1)
            {
                rbHeater1OFF.Checked = false;
                rbHeater1Auto.Checked = false;
                string command = "#POW11\n";
                port.Write(command);
                EnableButtonPower(num);
            }
            else if (num == 2)
            {
                rbHeater2OFF.Checked = false;
                rbHeater2Auto.Checked = false;
                string command = "#POW21\n";
                port.Write(command);
                EnableButtonPower(num);
            }
        }

        private void HeaterAuto(int num)
        {
            if (num == 1)
            {
                rbHeater1OFF.Checked = false;
                rbHeater1Manual.Checked = false;
                string command = "#POW12\n";
                //Debug.WriteLine(command);
                port.Write(command);
                DisableButtonPower(num);
            }
            else if (num == 2)
            {
                rbHeater2OFF.Checked = false;
                rbHeater2Manual.Checked = false;
                string command = "#POW22\n";
                //Debug.WriteLine(command);
                port.Write(command);
                DisableButtonPower(num);
            }

        }

        private void BtnPower1Plus_Click(object sender, EventArgs e)
        {
            if (rbHeater1Manual.Checked)
            {
                string command = "#POW11+\n";
                //Debug.WriteLine(command);
                port.Write(command);
            }
        }

        private void BtnPower1Min_Click(object sender, EventArgs e)
        {
            if (rbHeater1Manual.Checked)
            {
                string command = "#POW11-\n";
                //Debug.WriteLine(command);
                port.Write(command);
            }
        }

        private void DisableButtonPower(int num)
        {
            if (num == 1)
            {
                btnPower1Min.Enabled = false;
                btnPower1Plus.Enabled = false;
            }
            else if (num == 2)
            {
                btnPower2Min.Enabled = false;
                btnPower2Plus.Enabled = false;
            }

        }

        private void EnableButtonPower(int num)
        {
            if (num == 1)
            {
                btnPower1Min.Enabled = true;
                btnPower1Plus.Enabled = true;
            }
            else if (num == 2)
            {
                btnPower2Min.Enabled = true;
                btnPower2Plus.Enabled = true;
            }

        }

        private void RbHeater2OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHeater2OFF.Checked)
            {
                Heateroff(2);
            }
        }

        private void RbHeater2Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHeater1Auto.Checked)
            {
                HeaterAuto(2);
            }
        }

        private void RbHeater2Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHeater2Manual.Checked)
            {
                HeaterManual(2);
            }
        }

        private void BtnPower2Min_Click(object sender, EventArgs e)
        {
            if (rbHeater2Manual.Checked)
            {
                string command = "#POW21-\n";
                //Debug.WriteLine(command);
                port.Write(command);
            }
        }

        private void BtnPower2Plus_Click(object sender, EventArgs e)
        {
            if (rbHeater2Manual.Checked)
            {
                string command = "#POW21+\n";
                //Debug.WriteLine(command);
                port.Write(command);
            }
        }
    }
}
