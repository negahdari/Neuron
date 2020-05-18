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


        public bool train(List<bool> samples)
        {
            if (left_ == right_) return false;
            if (samples.Count() <= level) return false;

            if (samples[level])
            {
                right_.weight += 1;
                right_.train(samples);
            }
            else
            {
                left_.weight += 1;
                left_.train(samples);
            }
            return true;
        }


        public bool learn(List<bool> samples, bool win)
        {
            if (left_ == right_) return false;
            if (samples.Count() <= level) return false;

            int value = (level + 1);
            if (win) value *= -1;

            if (samples[level])
            {
                right_.weight+= value;
                right_.learn(samples, win);
            }
            else
            {
                left_.weight+= value;
                left_.learn(samples, win);
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

        public void render(System.Windows.Forms.TreeView treeview, string lable, System.Windows.Forms.TreeNode tnode=null)
        {
            System.Windows.Forms.TreeNode currentnode=null;
            if (tnode == null) 
            {
                if (treeview.Nodes[lable] == null)
                {
                    currentnode = new System.Windows.Forms.TreeNode(lable);
                    currentnode.Name = lable;
                    treeview.Nodes.Add(currentnode);
                }
                else
                    currentnode = treeview.Nodes[lable];
            }
            else
            {
                tnode.Expand();
                if (tnode.Nodes[lable] == null)
                {
                    currentnode = new System.Windows.Forms.TreeNode(lable);
                    currentnode.Name = lable;
                    tnode.Nodes.Add(currentnode);
                }else
                    currentnode = tnode.Nodes[lable];


            }
            currentnode.Text = lable + "    " + weight ;

            if (right_ != null) right_.render(treeview, "R", currentnode);
            if (left_ != null) left_.render(treeview, "L", currentnode);

        }

        public long weight=0;
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

        public void Pulse(bool value, bool predict)
        {
            root.learn(samples,value == predict);
            samples.Insert(0, value);
            if(samples.Count() > learn_dept)
                samples.RemoveRange(learn_dept, samples.Count()- learn_dept);
            root.train(samples);
        }

        public bool Predict()
        {
            return root.Predict;
        }


        public void render(System.Windows.Forms.TreeView treeview)
        {

            root.render(treeview,"Root");
        }
    }
}
