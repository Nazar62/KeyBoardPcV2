using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace keyBoardForPcV2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        string data = "";
        bool clicked = false;
        Settings settings;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
            GetSettings();
            UseSettings();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateCom_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void buttonConnectCom_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort.ReadLine();
            clicked = false;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            panelConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (data == "1r\r" && !clicked)
            {
                clicked = true;
                data = "c";
                //Thread.Sleep(1000);
                SendKeys.Send(textBoxBlueRelease.Text);
            } else if (data == "1p\r" && !clicked)
            {
                clicked = true;
                data = "c";
                //Thread.Sleep(1000);
                SendKeys.Send(textBoxBluePress.Text);
            } else if (data == "2r\r" && !clicked)
            {
                clicked = true;
                data = "c";
                //Thread.Sleep(1000);
                SendKeys.Send(textBoxRedRelease.Text);
            } else if (data == "2p\r" && !clicked)
            {
                clicked = true;
                data = "c";
                //Thread.Sleep(1000);
                SendKeys.Send(textBoxRedPress.Text);
            } else if (data == "3r\r" && !clicked)
            {
                clicked = true;
                data = "c";
                //Thread.Sleep(1000);
                SendKeys.Send(textBoxWhiteRelease.Text);
            } else if (data == "3p\r" && !clicked)
            {
                clicked = true;
                data = "c";
                //Thread.Sleep(1000);
                SendKeys.Send(textBoxWhitePress.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
            Save();
        }

        #region MyMethods
        private void Update()
        {
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(SerialPort.GetPortNames());
            comboBoxCom.SelectedIndex = 0;
            comboBoxCom.Enabled = true;
        }
        private void Connect()
        {
            try
            {
                serialPort.PortName = comboBoxCom.SelectedItem.ToString();
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
                timer.Start();
                panelConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }
        }
        private void Save()
        {
            var keys = new List<KeysShortCuts>()
            {
                new KeysShortCuts()
                {
                    Name = "Blue",
                    Press = textBoxBluePress.Text,
                    Release = textBoxBlueRelease.Text
                },
                new KeysShortCuts()
                {
                    Name = "Red",
                    Press = textBoxRedPress.Text,
                    Release = textBoxRedRelease.Text
                },
                new KeysShortCuts()
                {
                    Name = "White",
                    Press = textBoxWhitePress.Text,
                    Release = textBoxWhiteRelease.Text
                }
            };
            settings = new Settings()
            {
                COM = comboBoxCom.SelectedItem.ToString(),
                Keys = keys
            };
            var json = JsonSerializer.Serialize(settings);
            File.WriteAllText("settings.json", json);
        }
        private void GetSettings()
        {
            if(File.Exists("settings.json"))
            settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText("settings.json"));
        }
        private void UseSettings()
        {
            if(File.Exists("settings.json"))
            {
                comboBoxCom.SelectedItem = settings.COM;

                var blue = settings.Keys.Where(x => x.Name == "Blue").FirstOrDefault();
                textBoxBluePress.Text = blue.Press;
                textBoxBlueRelease.Text = blue.Release;

                var red = settings.Keys.Where(x => x.Name == "Red").FirstOrDefault();
                textBoxRedPress.Text = red.Press;
                textBoxRedRelease.Text = red.Release;

                var white = settings.Keys.Where(x => x.Name == "White").FirstOrDefault();
                textBoxWhitePress.Text = white.Press;
                textBoxWhiteRelease.Text = white.Release;

                Connect();
            }
        }
        #endregion
    }
}
