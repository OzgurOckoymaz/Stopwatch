using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnStop.BackColor = Color.Red;
            btnReset.Visible = true;
            btnReset.BackColor = Color.Blue;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Green;
            btnStop.Visible = false;
            btnReset.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "Continue")
            {
                btnStop.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                btnStop.Text = "Continue";
            }
        }

        int millisecond = 0;
        int second = 0;
        int minute = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            millisecond++;
            label5.Text = millisecond.ToString();

            if (millisecond == 100)
            {
                millisecond = 0;
                second++;
                label3.Text = second.ToString();
                if (second == 60)
                {
                    second = 0;
                    minute++;
                    label1.Text = minute.ToString();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "00";
            label3.Text = "00";
            label5.Text = "00";

            btnReset.Visible = false;
            btnStop.Visible = false;
            btnStart.Visible = true;

        }
    }
}
