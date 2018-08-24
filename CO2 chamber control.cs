using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;


using System.Configuration;
//using AboutBox1;


namespace Co2Regulation
{


    public partial class Form1 : Form
    {
        int maxppm, minppm;
        byte[] cmdByteArray = new byte[1];
        string RxString;
        string path = @"ppmaverage_reading.txt";
        //  int maxppm, minppm =0;
        bool is_reading = false;

        string numcomportco2, numcomportarduino = null;
        int tcheck, tfile, numpoint, maxflow,  offs;
        decimal facteur;
        bool lineaire;





        // public object aTimer;
        System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer fTimer = new System.Windows.Forms.Timer();






        List<coordinate> tablsec = new List<coordinate>();
        //  int[] tableauseconds;
        //   int[] tableauheures;
        //  int[] tableaujours;
















        public Form1()
        {
            InitializeComponent();

            chartseconds.Series.Clear();

            chartseconds.Titles.Add("ppm");

            aTimer.Tick += new EventHandler(OnTimedreadEvent);

            fTimer.Tick += new EventHandler(OnTimedFileEvent);




        }
        public class coordinate
        {
            public DateTime XVal { get; set; }
            public int YVal { get; set; }
        }




        public void buttonStart_Click(object sender, EventArgs e)
        {
            minppm = maxppm = 0;
            //  MessageBox.Show(numcomportarduino.Substring(0, 5).Trim());
            RxString = "";
            is_reading = false;
            if ((numcomportco2 == "") || (numcomportarduino == ""))
            { MessageBox.Show("Choose Port COM!"); }
            else if (numcomportco2 == numcomportarduino)
            {
                MessageBox.Show("Choose different Port COM!");
            }
            else {
                if (serialPort1.IsOpen == false)
                {
                    // Console.WriteLine("ser1");
                    serialPort1.PortName = numcomportco2.Substring(0, 5).Trim();
                    serialPort1.BaudRate = 19200;
                    serialPort1.Open();
                }
                if (serialPortArduino.IsOpen == false)
                {
                    //  Console.WriteLine("ardu");
                    serialPortArduino.PortName = numcomportarduino.Substring(0, 5).Trim();
                    serialPortArduino.BaudRate = 9600;
                    serialPortArduino.Open();
                }

                if (!(serialPortArduino.IsOpen) || (!(serialPort1.IsOpen)))
                { return; }
                else
                {
                    //  Console.WriteLine("open");
                    LabelStatus.Text = "Port Open";
                    buttonStart.Enabled = false;
                    buttonStop.Enabled = true;



                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    cmdByteArray[0] = 0x0d;
                    while ((serialPort1.BytesToRead == 0) && (stopWatch.Elapsed.Seconds <= 5))
                    {
                        // await Task.Delay(25);
                        serialPort1.Write(cmdByteArray, 0, 1);
                    }
                    stopWatch.Stop();
                    if (stopWatch.Elapsed.Seconds >= 5)
                    {
                        MessageBox.Show("problem with probe connection (error 1)");
                        LabelStatus.Text = "Problem with probe connection ";
                        Form_Ending();
                    }
                    else {
                        LabelStatus.Text = "Probe Connected";
                        Thread.Sleep(1500);

                        serialPort1.Write("send " + tcheck);
                        serialPort1.Write(cmdByteArray, 0, 1);
                        is_reading = false;
                        stopWatch.Start();
                        while (!(serialPort1.ReadByte() == 0x3e) && (stopWatch.Elapsed.Seconds <= 30))
                        {
                            ;
                        }
                        stopWatch.Stop();
                        if (stopWatch.Elapsed.Seconds >= 30)
                        {
                            MessageBox.Show("problem with connection (error 2");
                            LabelStatus.Text = "Port Not Ready";
                            Form_Ending();
                        }
                        else {

                            LabelStatus.Text = "Port Ready";

                            readstart();
                        }
                    }
                }
            }
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
                    facteur = Convert.ToDecimal(appSettings["Facteur"]);
                    numericUpDownppm.Text = appSettings["Concentration"];
                    tcheck = Convert.ToInt32(appSettings["Intervalco2"]);
                    tfile = Convert.ToInt32(appSettings["Intervalfichier"]);
                    offs= Convert.ToInt32(appSettings["Offset"]);
                    numpoint = Convert.ToInt32(appSettings["pointnum"]);
                    maxflow = Convert.ToInt32(appSettings["maxflow"]);
                    numcomportco2 = appSettings["co2com"];
                    numcomportarduino = appSettings["arduinocom"];
                    lineaire = ((appSettings["linear"]) == "true");

                    //try
                    //{ comboBox1.SelectedIndex = Int32.Parse(appSettings["co2com"]);
                    //    comboBox2.SelectedIndex = Int32.Parse(appSettings["arduinocom"]); }
                    //catch { Console.Write("problem"); }
                    ////  comboBox1  //co2
                    ////  comboBox2  //arduino
                }

            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
        public void enregistrevaleurs(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }



   

        public void Form_Ending()
        {
            enregistrevaleures();
            cmdByteArray[0] = 0x0d;
            aTimer.Stop();
            aTimer.Dispose();
            fTimer.Stop();
            fTimer.Dispose();
            is_reading = false;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("EXIT");
                serialPort1.Write(cmdByteArray, 0, 1);
                // serialPort1.Close();
            }
            if (serialPortArduino.IsOpen)
            {
                serialPortArduino.Write("0");
                serialPortArduino.Write(cmdByteArray, 0, 1);
                serialPortArduino.Close();
            }
        
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            LabelStatus.Text = "Port Closed";

        }
        public void enregistrevaleures() {
            enregistrevaleurs("Facteur", Convert.ToString(facteur));
            enregistrevaleurs("Concentration", numericUpDownppm.Text);
            enregistrevaleurs("Intervalco2", Convert.ToString(tcheck));
            enregistrevaleurs("Intervalfichier", Convert.ToString(tfile));
            enregistrevaleurs("Offset", Convert.ToString(offs));
            enregistrevaleurs("co2com", numcomportco2);
            enregistrevaleurs("arduinocom", numcomportarduino);
            enregistrevaleurs("pointnum", Convert.ToString(numpoint));
            enregistrevaleurs("maxflow", Convert.ToString(maxflow));
            if (lineaire)
            {
                enregistrevaleurs("linear", "true");
            }
            else {
                enregistrevaleurs("linear", "false");
            } }
public void buttonStop_Click(object sender, EventArgs e)
        {

            Form_Ending();



        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Ending();

        }

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            RxString += serialPort1.ReadExisting();

            this.Invoke(new EventHandler((readarduino)));

        }


        public void readstart()
        {
            LabelStatus.Text = "Reading";
            is_reading = true;
            if ((!serialPort1.IsOpen) || ((!serialPortArduino.IsOpen))) return;
            read();

        }


        public void read()
        {


            aTimer.Interval = (Convert.ToInt32(tcheck)* 1000);
            aTimer.Start();
            fTimer.Interval = (Convert.ToInt32(tfile) * 60000);
            fTimer.Start();


            //      } while ((tmrread2.timedout == false));
        }

        // Specify what you want to happen when the Elapsed event is raised.
        public void OnTimedreadEvent(object sender, EventArgs e)
        {
            byte[] cmdByteArray = new byte[1];

            cmdByteArray[0] = 0x0d;
            serialPort1.Write("send");
            serialPort1.Write(cmdByteArray, 0, 1);

            // Console.WriteLine("reading");
        }

        public void readarduino(object sender, EventArgs e)
        {

            int ppmnum;
            try
            {
                if (!(is_reading))
                {
                    RxString = "";
                }
                else

                {
                    // Console.WriteLine("int try");
                    if (RxString != null)
                    {
                        //  Console.WriteLine("RxString");
                        //  Console.WriteLine(RxString);
                        //  Console.WriteLine(RxString.Length);
                        if (RxString.Length >= 3)
                        {
                            int index1 = RxString.IndexOf("\x09");
                            int index2 = RxString.LastIndexOf("\x09");
                            //   Console.WriteLine("index1");

                            //    Console.WriteLine(index1);
                            //   Console.WriteLine("index2:");
                            //   Console.WriteLine(index2);

                            if ((index1 != -1) && ((index2 != -1)))
                            {
                                string ppmlevelnow = "";
                                if (index1 != index2)
                                {
                                    ppmlevelnow = RxString.Substring((index1 + 1), (index2 - index1));
                                }
                                else if (index1 == index2)
                                {
                                    ppmlevelnow = RxString.Substring(0, 4);
                                }

                                ppmlevelnow = ppmlevelnow.Trim();
                                Regex reNum = new Regex(@"^\d+$");
                                bool isNumeric = reNum.Match(ppmlevelnow).Success;

                                //   Console.WriteLine(ppmlevelnow);
                                if (isNumeric)
                                {
                                    //  Console.WriteLine("ppm");
                                    //  Console.WriteLine(ppmlevelnow);
                                    // Console.WriteLine("after is num");
                                    label2.Text = ppmlevelnow;


                                    // ppmlevelnow = ppmlevelnow.Trim();

                                    if (int.TryParse(ppmlevelnow, out ppmnum))
                                    {
                                        if (ppmnum > 0)
                                        {
                                            arduinocom();
                                            faisgraphique(ppmnum);

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            finally { RxString = ""; }
        }
        public void faisgraphique(int ppm)
        { coordinate corsec = new coordinate();
            corsec.XVal = DateTime.Now;
            corsec.YVal = ppm;
            tablsec.Add(corsec);
            // Console.WriteLine(tablsec.Count);
            if (tablsec.Count > numpoint) {
                tablsec.RemoveRange(0, (tablsec.Count - Decimal.ToInt32(numpoint)));
                
            };
            LabAverage.Text = tablsec.Average(r => r.YVal).ToString("N0");
            chartseconds.Series.Clear();
            Series series = this.chartseconds.Series.Add("ppm");
            series.ChartType = SeriesChartType.Spline;
            chartseconds.ChartAreas[0].AxisY.IsStartedFromZero = false;

            for (int i = 0; i < tablsec.Count; i++)
            {
                {

                    series.Points.AddXY(tablsec[i].XVal.ToLongTimeString(), tablsec[i].YVal);
                }
            }

        }
        public void arduinocom()
        {

            byte[] cmdByteArray = new byte[1];

            cmdByteArray[0] = 0x0d;


            //  Console.WriteLine(setppmtxtbox.Text);
            //  Console.WriteLine(label2.Text);
            int setppm = (Convert.ToInt32(numericUpDownppm.Text));
           // int Offset = (Convert.ToInt32(offs.Text));
            int ppmreadin = (Convert.ToInt32(label2.Text));
            if ((ppmreadin > maxppm) || (minppm == 0)) {
                maxppm = ppmreadin;
                labelmax.Text = maxppm.ToString();
            };
            if ((ppmreadin < minppm) || (minppm == 0)) {
                minppm = ppmreadin;
                labelmin.Text = minppm.ToString();
            };

            if (ppmreadin > 300)  // in case reading is wrong, when high co2>3000, reading is negative
            {
                int setvalue;
                int maxivalue = Convert.ToInt32(maxflow);
                if (lineaire) {
                    Console.Write("setppm: " + setppm);
                    Console.Write("ppmreadin: " + ppmreadin);
                    setvalue = (Convert.ToInt32((Convert.ToDecimal(facteur) * ((setppm - ppmreadin) + offs))));
                }
                else {
                    //   Console.Write("setvalue: " + setvalue);
                    double facteurb;
                    double.TryParse(Convert.ToString(((Convert.ToDecimal(facteur) * (setppm - ppmreadin)))), out facteurb);
                    setvalue = Convert.ToInt32((offs + 4095) / (1 + Math.Exp(-facteurb)));
                }
                //Lsetvalue.Text = Convert.ToString(setvalue);
                if (setvalue > maxivalue)
                { setvalue = maxivalue; }
                else if (setvalue < 0)
                { setvalue = 0; }


                string setvaluestring = Convert.ToString(setvalue);
                serialPortArduino.Write(setvaluestring);
                LabelArduinoSet.Text = setvaluestring;
                serialPortArduino.Write(cmdByteArray, 0, 1);
            }
            else
            {
                serialPortArduino.Write("0");
                serialPortArduino.Write(cmdByteArray, 0, 1);
            }

        }
        public void OnTimedFileEvent(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Date: " + d1 + " Average: " + LabAverage.Text + " Now: " + label2.Text);
            }

            //  Console.Write("Date :" + d1 + " ppmaverage :" + LabAverage.Text);
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form timetbl = new TimeTable();

            if (timetbl.ShowDialog(this) == DialogResult.OK)
            {
                timetbl.Dispose();
            }
        }

        private void CheckTimeupdown_ValueChanged(object sender, EventArgs e)
        {
            aTimer.Interval = Convert.ToInt32((tcheck) * 1000);


        }

        private void fileminset_ValueChanged(object sender, EventArgs e)
        {
            fTimer.Interval = Convert.ToInt32((tfile) * 60000);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            minppm = maxppm = 0;
            chartseconds.Series.Clear();
            tablsec.Clear();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)   ///about
        {

            AboutBox1 aboutBox = new AboutBox1();  

            if (aboutBox.ShowDialog(this) == DialogResult.OK)
                {
                aboutBox.Dispose();
                }
        
    }

        private void setupToolStripMenuItem1_Click(object sender, EventArgs e) ///settings
        {
            using (var fsettings = new Fsettings())
            {
                var result = fsettings.ShowDialog();
                if (result == DialogResult.OK)
                {

                    facteur = Convert.ToDecimal(fsettings.vfacteur);
                    tcheck = Convert.ToInt32(fsettings.vchecktime);
                    tfile = Convert.ToInt32(fsettings.vfiletime);
                    offs = Convert.ToInt32(fsettings.voffset);
                    numpoint = Convert.ToInt32(fsettings.vpointongraph);
                    maxflow = Convert.ToInt32(fsettings.vmaxflow);
                    if (fsettings.vcom1co2port != "") { numcomportco2 = fsettings.vcom1co2port; }
                    if (fsettings.vcom2arduinoport != "") { numcomportarduino = fsettings.vcom2arduinoport; }
                    lineaire = fsettings.vlinea;
                    //MessageBox.Show("done");
                    enregistrevaleures();

                    fsettings.Dispose();
                }

            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            initialisevaleurs();
        //    SerialPort ComPort = new SerialPort();
        //    string[] ArrayComPortsNames = null;

            // string ComPortName = null;



        }
      }
}



