using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    class NeuronClass
    {
        const short max_data_length = 100;
        List<bool> samples = new List<bool>();

        public void Pulse(bool sw=false)
        {
            samples.Add(sw);
            if(samples.Count() > max_data_length)
                samples.RemoveRange(0, samples.Count()- max_data_length);
        }

        private int find_pattern(ref int run_length, int max_length)
        {
            int last_point = samples.Count()-1;
            int chunk_start_point = last_point - run_length;
            if(chunk_start_point>0)
            for (int track_pointer = chunk_start_point; track_pointer > run_length; track_pointer--)
            {
                int current_run_length = run_length;
                int index = 0;
                for (; index <= current_run_length; index++)
                {

                    if (index == current_run_length) // match found. start running
                        current_run_length++;

                    //bound check
                    if (last_point - index <= 0 || track_pointer - index <= 0)
                        break;

                    //not a match
                    if (samples[last_point - index] != samples[track_pointer - index])
                        break;

                    if (current_run_length == max_length)
                    {
                        run_length = max_length;
                        return track_pointer;
                    }

                }

                //not the max run but a good match found
                if (current_run_length > run_length)
                {
                    run_length = current_run_length;
                    return track_pointer;
                }

            }

            //no match found
            run_length = 0;
            return last_point;
        }

        public bool Predict()
        {
            int totalItems = samples.Count();
            int run_length = totalItems<5? totalItems:5;
            int max_length = totalItems - run_length > 0 ? totalItems - run_length : run_length;
            int track_pointer = find_pattern(ref run_length, max_length);

            if (run_length != 0 && totalItems> track_pointer) // can predict
            {
                return samples[track_pointer + 1];
            }


            //no predict, result based on sample rate
            int trueItems = samples.Count(item => item == true);
            return (totalItems / 2) < trueItems;
        }
    }
}
