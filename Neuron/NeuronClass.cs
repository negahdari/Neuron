using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    class Node
    {
        public Node(int dept, int level = 0)
        {
            this.level = level;
            if (level == dept) return;
            left_ =new Node(dept, level + 1);
            right_ = new Node(dept, level + 1);
        }
        int level = 0;

        public bool teach(List<bool> samples)
        {
            if (left_ == right_) return false;
            if (samples.Count() <= level) return false;
            if (samples[level])
            {
                right_.weight+= 0.1;
                left_.weight -= 0.05;
                right_.teach(samples);
            }
            else
            {
                left_.weight+= 0.1;
                right_.weight -= 0.05;
                left_.teach(samples);
            }
            return true;
        }

        protected double max_sub_weight
        {
            get
            {
                if (left_ == right_) return weight;
                return weight + Math.Max(left_.max_sub_weight, right_.max_sub_weight);
            }
        } 

        public bool Predict
        {
            get
            {
                return left_.max_sub_weight> right_.max_sub_weight?false:true;
            }
        }

        public int MaxLevels
        {
            get{
                if (left_ == right_)
                    return level;
                else
                    return Math.Max(left_.MaxLevels, right_.MaxLevels);
            }
        }

        public double weight=0.0;
        public Node left_ = null;
        public Node right_ = null;
    }

    class NeuronClass
    {
        int learn_dept;
        private Node root=null;

        public NeuronClass(int learndept=3)
        {
            learn_dept = learndept;
            root = new Node(learn_dept);
        }

        List<bool> samples = new List<bool>();

        public void Pulse(bool sw)
        {
            samples.Insert(0,sw);
            if(samples.Count() > learn_dept)
                samples.RemoveRange(learn_dept, samples.Count()- learn_dept);
            root.teach(samples);
        }

        public bool Predict()
        {
            return root.Predict;
        }
    }
}
