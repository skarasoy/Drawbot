using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace Drawbot
{
    public partial class Drawbot : Form
    {
        string RxString;
        int rowcounter = 0;
        int senttrows = 0;
        List<string> gcode = new List<string>();
        int stepx = 0;
        int stepy = 0;
        bool transfer;


        public Drawbot()
        {
            InitializeComponent();
        }
   
        private void connectbutton_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portname.SelectedItem.ToString();
            serialPort1.BaudRate = 9600;
            string selectedPort = portname.GetItemText(portname.SelectedItem);
            serialPort1.Open();
            disconnectbutton.Enabled = true;
            connectbutton.Enabled = false;
            portname.Enabled = false;
            enables();
        }
        private void disconnectbutton_Click(object sender, EventArgs e)
        {
            connectbutton.Enabled = true;
            disconnectbutton.Enabled = false;
            serialPort1.Close();
            portname.Enabled = true;
            disables();
        }
              
        private void loadPortSelector()
        {
            List<String> tList = new List<String>();

            portname.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                tList.Add(s);
            }

            if (tList.Count < 1)
            {
                MessageBox.Show("No serial ports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tList.Sort();
                portname.Items.AddRange(tList.ToArray());
                portname.SelectedIndex = 0;
            }
        }
        private void enables()
        {
            ClearButton.Enabled = true;
            gohomebutton.Enabled = true;
            inputfilegroup.Enabled = true;
            controlgroup.Enabled = true;
            pengroup.Enabled = true;
            startbutton.Enabled = true;
            stopbutton.Enabled = true;
            serialscreen.Enabled = true;
            PauseButton.Enabled = true;
        }
        private void disables()
        {
            serialscreen.Enabled = false;
            ClearButton.Enabled = false;
            gohomebutton.Enabled = false;
            inputfilegroup.Enabled = false;
            controlgroup.Enabled = false;
            pengroup.Enabled = false;
            startbutton.Enabled = false;
            stopbutton.Enabled = false;
            PauseButton.Enabled = false;
        }
        private void xplusButton_Click(object sender, EventArgs e)
        {
            stepx = stepx - 2;
            send_position();
        }

        private void xminusButton_Click(object sender, EventArgs e)
        {
            stepx = stepx + 2;
            send_position();
        }

        private void yminusButton_Click(object sender, EventArgs e)
        {
            stepy = stepy - 2;
            send_position();
        }

        private void yplusButton_Click(object sender, EventArgs e)
        {
            stepy = stepy + 2;
            send_position();
        }   
             
        private void gohomebutton_Click(object sender, EventArgs e)
        {
            stepx = 0;
            stepy = 0;
            send_position();
        }

        private void send_position()
        {
            serialPort1.WriteLine("G1 X" + stepx.ToString() + " Y" + stepy.ToString() + " F3000.00" + "\r\n");
            serialscreen.Items.Add("G1 X" + stepx.ToString() + " Y" + stepy.ToString() + " F3000.00" + "\r\n");
        }
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Txt (*.txt)|*.txt|Gcode (*.gcode)|*.gcode|All files (*.*)|*.*";
            dlg.Title = "Open a file";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.inputfile.Text = dlg.FileName;
                using (StreamReader reader = new StreamReader(inputfile.Text))
                {
                    string line = string.Empty;
                    if (reader != null)

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                                rowcounter++;
                        }
                    RowsInFile.Visible = true;
                    sentrows.Visible = true;
                    RowsInFile.Text = "Rows : " + rowcounter.ToString();
                }
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }

        private void pendropbutton_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("M300 S30.00" + "\r\n");
            serialscreen.Items.Add("M300 S30.00 (Pen Drop)");
        }

        private void penliftbutton_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("M300 S50.00" + "\r\n");
            serialscreen.Items.Add("M300 S50.00 (Pen Lift)");
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (File.Exists(inputfile.Text))
            {
                using (StreamReader reader = new StreamReader(inputfile.Text))
                {
                    gcode = new List<string>();
                    transfer = true;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim() != "")
                            gcode.Add(line.Trim());
                    }
                    RowsInFile.Text = "Rows: " + gcode.Count.ToString();
                    NextGCode();
                }
            }
        }
        private void NextGCode()
        {           
               if (senttrows < gcode.Count)
                    {
                     if (gcode[senttrows].ToLower().IndexOf('f') > -1)
                        {
                            int startPos = gcode[senttrows].ToLower().IndexOf('f') + 1;
                            string firstPart = gcode[senttrows].Substring(0, startPos);
                            string lastPart = gcode[senttrows].Substring(startPos);
                            gcode[senttrows] = firstPart + lastPart;
                        }
                        serialPort1.WriteLine(gcode[senttrows]);
                        senttrows++;
                        this.Invoke(new EventHandler(DisplaySentRows));
               


            }
             /*  else
                    {
                        MessageBox.Show("I finished to draw.");
                    }*/
                
            }
        private void DisplaySentRows(object sender, EventArgs e)
        {
            serialscreen.Items.Add(gcode[senttrows - 1]);
            serialscreen.TopIndex = serialscreen.Items.Count - 1;
            sentrows.Text = "Sent rows: " + senttrows.ToString();
            progressBar1.Value = (100 * senttrows) / rowcounter;
        }
        
        private void Drawbot_Load(object sender, EventArgs e)
        {
            disables();
            loadPortSelector();
            disconnectbutton.Enabled = false;
            
          
        }
           
        private void DisplayText(object sender, EventArgs e)
        {
            string[] arr = RxString.Replace("\n\r", "\r\n").Replace("\r\n", "\n").Trim('\n').Split('\n');
            foreach (string item in arr)
            {
                if (item != "ok")
                {
                    serialscreen.Items.Add(item);
                    serialscreen.TopIndex = serialscreen.Items.Count - 1;
                }
            }
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            RxString += serialPort1.ReadExisting();
            if ((RxString.EndsWith("\r\n")) || (RxString.EndsWith("\n\r")))
            {
                this.Invoke(new EventHandler(DisplayText));
                RxString = String.Empty;
                if (transfer)
                {
                    NextGCode();
                }
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadPortSelector();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            transfer = false;
            serialPort1.WriteLine("M300 S50.00" + "\r\n");
            serialPort1.WriteLine("G0 X0 Y0");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { xplusButton.PerformClick(); }
            if (e.KeyCode == Keys.Left) { xminusButton.PerformClick(); }
            if (e.KeyCode == Keys.Up)   { yplusButton.PerformClick();  }
            if (e.KeyCode == Keys.Down) { yminusButton.PerformClick(); }
            if (e.KeyCode == Keys.Enter) { startbutton.PerformClick(); }
            if (e.KeyCode == Keys.NumPad8) { penliftbutton.PerformClick(); }
            if (e.KeyCode == Keys.NumPad5) { pendropbutton.PerformClick(); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            serialscreen.Items.Clear();
            rowcounter = 0;
            senttrows = 0;
            inputfile.Text = "";
            sentrows.Text = "";
            RowsInFile.Visible = false;
            sentrows.Visible = false;
            progressBar1.Value = 0;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            transfer = false;
        }
    }
}
