using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    class NeuronClass
    {
        List<bool> samples = new List<bool>();

        public void Pulse(bool sw=false)
        {
            samples.Add(sw);
        }

        public bool Predict()
        {
            int totalItems = samples.Count();
            int trueItems = samples.Count(item => item == true);
            return (totalItems / 2) < trueItems;
        }
    }
}
