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
        
        NeuronClass neuronClass = new NeuronClass(5);
        int LCount=0, RCount = 0;
        int Pass=0, Fail=0;

        public MainForm()
        {


            InitializeComponent();
            Height = 170;
#if (DEBUG)
            Height = 180 +  debuglistBox.Height ;
#endif

        }


        private void update_state(bool pulse)
        {
            bool last_predict = neuronClass.Predict();
            neuronClass.Pulse(pulse);


            if (pulse) {
                RCount++;
                RCountlabel.Text = RCount.ToString();
            }
            else
            {
                LCount++;
                LCountlabel.Text = LCount.ToString();
            }

#if (DEBUG)
            debuglistBox.Items.Add(pulse?1:0);
            neuronClass.render(NeurontreeView);
#endif


            if (last_predict==pulse)
            {
                Pass++;
                Predictlabel.ForeColor = Color.LightGreen;
                Predictlabel.Text = "Pass";
                Passlabel.Text = Pass.ToString();
            }
            else
            {
                Fail++;
                Predictlabel.ForeColor = Color.OrangeRed;
                Predictlabel.Text = "Fail";
                Faillabel.Text = Fail.ToString();
            }

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Autobutton_Click(object sender, EventArgs e)
        {
            timerAuto.Enabled = !timerAuto.Enabled;
        }

        private void timerAuto_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            update_state(rand.Next(0, 2) == 0);
        }

        private void LeftSignalbutton_Click(object sender, EventArgs e)
        {
            update_state(false);
        }

        private void RightSignalbutton_Click(object sender, EventArgs e)
        {
            update_state(true);
        }
    }
}
