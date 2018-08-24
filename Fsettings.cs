using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.Configuration;




namespace Co2Regulation
{
    public partial class Fsettings : Form
    {
        public Fsettings()
        {
            InitializeComponent();
        }
            
        public string vcom1co2port { get; set; }
        public string vcom2arduinoport { get; set; }
        public string vchecktime { get; set; }
        public string vfiletime { get; set; }
        public string vmaxflow { get; set; }
        public string vpointongraph { get; set; }
        public bool vlinea { get; set; }
        public string vfacteur { get; set; }
        public string voffset { get; set; }
      



        private void bok_Click(object sender, EventArgs e)
        {
            this.vcom1co2port = comboBox1.Text;
            this.vcom2arduinoport = comboBox2.Text;
            this.vchecktime = CheckTimeupdown.Text;
            this.vfiletime = fileminset.Text;
            this.vpointongraph = pointsongraph.Text;
            this.vmaxflow = maxflow.Text;
            this.vlinea = radiolinear.Checked;
            this.vfacteur = numericUpDownmulti.Text;
            this.voffset = numupdownOffset.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void initialisevaleurs()
        {


            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    numericUpDownmulti.Text = appSettings["Facteur"];
                    CheckTimeupdown.Text = (appSettings["Intervalco2"]);
                    fileminset.Text = (appSettings["Intervalfichier"]);
                    numupdownOffset.Text = appSettings["Offset"];
                    pointsongraph.Text = (appSettings["pointnum"]);
                    maxflow.Text = (appSettings["maxflow"]);
                    if ((appSettings["linear"]) == "true")
                    {
                        radiolinear.Checked = true;
                        radioExp.Checked = false;
                    }
                    else {
                        radiolinear.Checked = false;
                        radioExp.Checked = true;
                    }

                }
            }
            catch
            {
                MessageBox.Show("problem reading config file");
            }


        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public List<string> portlistnames()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                return portnames.Select(n => n + "   --> " + ports.FirstOrDefault(s => s.Contains(n))).ToList();
            }
        }
        private void Fsettings_Load(object sender, EventArgs e)
        {
            int index = -1;
  
            //   ArrayComPortsNames = SerialPort.GetPortNames();

            // MessageBox.Show("hello");
            foreach (string nomport in portlistnames())
            {
                // System.Console.WriteLine(nomport);
                // MessageBox.Show(nomport);
                index++;
                comboBox1.Items.Add(nomport);
                comboBox2.Items.Add(nomport);

            }

             initialisevaleurs();
        }

        private void radioExp_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownmulti.DecimalPlaces = 4;
            numericUpDownmulti.Value = Convert.ToDecimal(0.001);
            numericUpDownmulti.Increment = Convert.ToDecimal(0.001);
        }

        private void radiolinear_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownmulti.DecimalPlaces = 1;
            numericUpDownmulti.Value = Convert.ToDecimal(4);
            numericUpDownmulti.Increment = Convert.ToDecimal(0.5);
        }
    }
}
