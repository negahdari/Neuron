using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Neuron
{

    public partial class MainForm : Form
    {
        NeuronClass neuronClass = new NeuronClass();
        int counter;
        bool pass_interval = false;
        public MainForm()
        {
            InitializeComponent();
        }


        private void Signalbutton_Click(object sender, EventArgs e)
        {
            if (!Countertimer.Enabled)
            {
                counter = 3;
                Countertimer.Enabled = true;
                Startbutton.Text = "Stop";
                return;
            }

            Countlabel.Text = "...";
            Signalbutton.Enabled = false;
            neuronClass.Pulse(true);
            counter = 3;
            pass_interval = true;
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (!Countertimer.Enabled)
            {
                counter = 3;
                Countertimer.Enabled = true;
                Startbutton.Text = "Stop";
            }
            else
            {
                Countertimer.Enabled = false;
                Startbutton.Text = "Go";
            }

        }

        private void Countertimer_Tick(object sender, EventArgs e)
        {

            if (pass_interval)
            {
                Countlabel.Text = "...";
                if (neuronClass.Predict())
                {
                    Predictlabel.ForeColor = Color.LightGreen;
                    Predictlabel.Text = "Prediction Passed!";
                }
                else
                {
                    Predictlabel.ForeColor = Color.OrangeRed;
                    Predictlabel.Text = "Prediction Failed!";
                }
                pass_interval = false;
                return;
            }


            Countlabel.Text = counter.ToString();
            if (counter == 0)
            {
                neuronClass.Pulse();
                Signalbutton.Enabled = false;
                if (!neuronClass.Predict())
                {
                    Predictlabel.ForeColor = Color.LightGreen;
                    Predictlabel.Text = "Prediction Passed!";
                }
                else
                {
                    Predictlabel.ForeColor = Color.OrangeRed;
                    Predictlabel.Text = "Prediction Failed!";
                }

                counter = 3;
                return;
            }

            if (!Signalbutton.Enabled )
                Signalbutton.Enabled = true;

            counter--;

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
