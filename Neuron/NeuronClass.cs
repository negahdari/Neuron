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
                right_.weight+= 1 * (level+1);
                right_.teach(samples);
            }
            else
            {
                left_.weight+= 1 * (level+1);
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


        public void render(System.Windows.Forms.TreeView treeview)
        {

            root.render(treeview,"Root");
        }
    }
}
