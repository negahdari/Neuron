using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    class Node
    {
        public Node(in Node parent, int dept, int level = 0)
        {
            this.level = level;
            parent_ = parent;
            if (level == dept) return;
            left_ = new Node(this, dept, level + 1);
            right_ = new Node(this, dept, level + 1);
        }
        int level = 0;


        public bool train(List<bool> samples, long shift_weight=1)
        {
            if (left_ == right_) return false;
            if (samples.Count() <= level) return false;

            if (samples[level])
            {
                if(!right_.train(samples, shift_weight))
                    right_.weight += shift_weight;
            }
            else
            {
                if (!left_.train(samples, shift_weight))
                    left_.weight += shift_weight;
            }
            return true;
        }


        public void forget(double factor)
        {
            if (left_ == right_) return;
            right_.forget(factor);
            left_.forget(factor);

            if (right_.weight != 0)
            {
                if (right_.weight > factor)
                    right_.weight -= factor;
                else if (right_.weight < -factor)
                    right_.weight += factor;
                else
                    right_.weight = 0;
            }

            if (left_.weight != 0)
            {
                if (left_.weight > factor)
                    left_.weight -= factor;
                else if (right_.weight < -factor)
                    left_.weight += factor;
                else
                    left_.weight = 0;
            }

        }

        public bool learn(List<bool> samples, bool win,int price)
        {
            if (left_ == right_) return false;  

            if (MaxLevels == level + 1) {
                if (left_.weight > right_.weight)
                {
                    left_.weight += win ? +price : -price;
                    return true;
                }
                else if (left_.weight < right_.weight)
                {
                    right_.weight += win ? +price : -price;
                    return true;
                }
                else return false;
            }

            if (samples.Count() <= level + 1) return false;
            if (samples[level + 1])
                return right_.learn(samples, win, price);
            else
                return left_.learn(samples, win, price);
        }

        protected double max_sub_weight
        {
            get
            {
                if (left_ == right_) return weight;
                return weight + Math.Max(left_.max_sub_weight, right_.max_sub_weight);
            }
        } 

        public bool Predict(List<bool> samples)
        {
            if (left_ == right_) return Predict();

            if(MaxLevels == level + 1)
                return left_.max_sub_weight > right_.max_sub_weight ? false : true;

            if (samples.Count() <= level + 1)
                return Predict();

            if (samples[level + 1])
                return right_.Predict(samples);
            else
                return left_.Predict(samples);
        }

        public bool Predict()
        {
            if (left_ == right_)
                return  (parent_ == null ? true : parent_.Predict());
            else
                return left_.max_sub_weight > right_.max_sub_weight ? false : true;
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
            currentnode.Text = lable + "    " + weight.ToString("0.0") ;

            if (right_ != null) right_.render(treeview, "R", currentnode);
            if (left_ != null) left_.render(treeview, "L", currentnode);

        }

        public double weight=0.0;
        public Node parent_ = null;
        public Node left_ = null;
        public Node right_ = null;
    }

    class NeuronClass
    {
        int learn_dept=3;
        double forget_dept=0;
        private Node root=null;
        int price = 0;

        public NeuronClass(int learndept=3, double forgetdept= 0.0)
        {
            learn_dept = learndept;
            forget_dept = forgetdept;
            root = new Node(null, learn_dept);
        }

        List<bool> samples = new List<bool>();

        public void Pulse(bool value, bool predict)
        {
            if (value == predict)
                price = (price >= 0)? price + 1 : 1;
            if (value != predict)
                price= (price <= 0)? price -1 : -1;

            root.learn(samples,value == predict, price<0? -price:price);
            samples.Add(value);
            if(samples.Count() > learn_dept)
                samples.RemoveRange(0, samples.Count() - learn_dept);
            root.train(samples);
            root.forget(forget_dept);
        }

        public bool Predict()
        {
            return root.Predict(samples);
        }


        public void render(System.Windows.Forms.TreeView treeview)
        {
            root.render(treeview,"Root");
        }
    }
}
