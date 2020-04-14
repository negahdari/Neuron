namespace Neuron
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Signalbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Countlabel = new System.Windows.Forms.Label();
            this.Countertimer = new System.Windows.Forms.Timer(this.components);
            this.Predictlabel = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.debuglistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Signalbutton
            // 
            this.Signalbutton.BackColor = System.Drawing.Color.Transparent;
            this.Signalbutton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.Signalbutton.FlatAppearance.BorderSize = 3;
            this.Signalbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Signalbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Signalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signalbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Signalbutton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Signalbutton.Location = new System.Drawing.Point(139, 57);
            this.Signalbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Signalbutton.Name = "Signalbutton";
            this.Signalbutton.Size = new System.Drawing.Size(157, 47);
            this.Signalbutton.TabIndex = 0;
            this.Signalbutton.Text = "Press or Pass";
            this.Signalbutton.UseVisualStyleBackColor = false;
            this.Signalbutton.Click += new System.EventHandler(this.Signalbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.Transparent;
            this.Startbutton.FlatAppearance.BorderSize = 0;
            this.Startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Startbutton.ForeColor = System.Drawing.Color.Aqua;
            this.Startbutton.Location = new System.Drawing.Point(8, 8);
            this.Startbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(79, 47);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Go";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Countlabel
            // 
            this.Countlabel.BackColor = System.Drawing.Color.Transparent;
            this.Countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Countlabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.Countlabel.Location = new System.Drawing.Point(162, 14);
            this.Countlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(112, 40);
            this.Countlabel.TabIndex = 2;
            this.Countlabel.Text = "-";
            this.Countlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Countertimer
            // 
            this.Countertimer.Interval = 1000;
            this.Countertimer.Tick += new System.EventHandler(this.Countertimer_Tick);
            // 
            // Predictlabel
            // 
            this.Predictlabel.BackColor = System.Drawing.Color.Transparent;
            this.Predictlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Predictlabel.ForeColor = System.Drawing.Color.Gold;
            this.Predictlabel.Location = new System.Drawing.Point(96, 114);
            this.Predictlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Predictlabel.Name = "Predictlabel";
            this.Predictlabel.Size = new System.Drawing.Size(253, 40);
            this.Predictlabel.TabIndex = 5;
            this.Predictlabel.Text = "-";
            this.Predictlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Exitbutton.ForeColor = System.Drawing.Color.Aqua;
            this.Exitbutton.Location = new System.Drawing.Point(365, 114);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(79, 47);
            this.Exitbutton.TabIndex = 6;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // debuglistBox
            // 
            this.debuglistBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.debuglistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debuglistBox.ColumnWidth = 10;
            this.debuglistBox.ForeColor = System.Drawing.Color.White;
            this.debuglistBox.FormattingEnabled = true;
            this.debuglistBox.Location = new System.Drawing.Point(12, 177);
            this.debuglistBox.MultiColumn = true;
            this.debuglistBox.Name = "debuglistBox";
            this.debuglistBox.Size = new System.Drawing.Size(188, 325);
            this.debuglistBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(450, 171);
            this.Controls.Add(this.debuglistBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Predictlabel);
            this.Controls.Add(this.Countlabel);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Signalbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuron";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Signalbutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Timer Countertimer;
        private System.Windows.Forms.Label Predictlabel;
        private System.Windows.Forms.Button Exitbutton;
        public System.Windows.Forms.ListBox debuglistBox;
    }
}

