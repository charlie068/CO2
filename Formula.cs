using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co2Regulation
{
    public partial class Formula : Form
    {
        public Formula()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "With Linear, the formula is output=offset+(setppm-ppmread)*factor, With exponential, the formula is offset/(1+exp(-factor*(setppm-ppmread)))";
        }
    }
}
