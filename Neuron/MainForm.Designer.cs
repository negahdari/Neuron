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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftSignalbutton = new System.Windows.Forms.Button();
            this.LCountlabel = new System.Windows.Forms.Label();
            this.Predictlabel = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.debuglistBox = new System.Windows.Forms.ListBox();
            this.RightSignalbutton = new System.Windows.Forms.Button();
            this.RCountlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.Faillabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftSignalbutton
            // 
            this.LeftSignalbutton.BackColor = System.Drawing.Color.Transparent;
            this.LeftSignalbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftSignalbutton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.LeftSignalbutton.FlatAppearance.BorderSize = 3;
            this.LeftSignalbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftSignalbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LeftSignalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftSignalbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LeftSignalbutton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LeftSignalbutton.Location = new System.Drawing.Point(75, 57);
            this.LeftSignalbutton.Margin = new System.Windows.Forms.Padding(2);
            this.LeftSignalbutton.Name = "LeftSignalbutton";
            this.LeftSignalbutton.Size = new System.Drawing.Size(130, 47);
            this.LeftSignalbutton.TabIndex = 0;
            this.LeftSignalbutton.Text = "<<<";
            this.LeftSignalbutton.UseVisualStyleBackColor = false;
            this.LeftSignalbutton.Click += new System.EventHandler(this.LeftSignalbutton_Click);
            // 
            // LCountlabel
            // 
            this.LCountlabel.BackColor = System.Drawing.Color.Transparent;
            this.LCountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LCountlabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.LCountlabel.Location = new System.Drawing.Point(75, 9);
            this.LCountlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCountlabel.Name = "LCountlabel";
            this.LCountlabel.Size = new System.Drawing.Size(130, 40);
            this.LCountlabel.TabIndex = 2;
            this.LCountlabel.Text = "-";
            this.LCountlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Exitbutton.ForeColor = System.Drawing.Color.Aqua;
            this.Exitbutton.Location = new System.Drawing.Point(375, 114);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(69, 47);
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
            // RightSignalbutton
            // 
            this.RightSignalbutton.BackColor = System.Drawing.Color.Transparent;
            this.RightSignalbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightSignalbutton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.RightSignalbutton.FlatAppearance.BorderSize = 3;
            this.RightSignalbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RightSignalbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RightSignalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightSignalbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RightSignalbutton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.RightSignalbutton.Location = new System.Drawing.Point(233, 57);
            this.RightSignalbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RightSignalbutton.Name = "RightSignalbutton";
            this.RightSignalbutton.Size = new System.Drawing.Size(130, 47);
            this.RightSignalbutton.TabIndex = 8;
            this.RightSignalbutton.Text = ">>>";
            this.RightSignalbutton.UseVisualStyleBackColor = false;
            this.RightSignalbutton.Click += new System.EventHandler(this.RightSignalbutton_Click);
            // 
            // RCountlabel
            // 
            this.RCountlabel.BackColor = System.Drawing.Color.Transparent;
            this.RCountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RCountlabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.RCountlabel.Location = new System.Drawing.Point(233, 9);
            this.RCountlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RCountlabel.Name = "RCountlabel";
            this.RCountlabel.Size = new System.Drawing.Size(130, 40);
            this.RCountlabel.TabIndex = 9;
            this.RCountlabel.Text = "-";
            this.RCountlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "You :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Me :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passlabel
            // 
            this.Passlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Passlabel.ForeColor = System.Drawing.Color.LightGreen;
            this.Passlabel.Location = new System.Drawing.Point(75, 132);
            this.Passlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(61, 40);
            this.Passlabel.TabIndex = 12;
            this.Passlabel.Text = "-";
            this.Passlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Faillabel
            // 
            this.Faillabel.BackColor = System.Drawing.Color.Transparent;
            this.Faillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Faillabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.Faillabel.Location = new System.Drawing.Point(302, 132);
            this.Faillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Faillabel.Name = "Faillabel";
            this.Faillabel.Size = new System.Drawing.Size(61, 40);
            this.Faillabel.TabIndex = 13;
            this.Faillabel.Text = "-";
            this.Faillabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(450, 514);
            this.Controls.Add(this.Faillabel);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RCountlabel);
            this.Controls.Add(this.RightSignalbutton);
            this.Controls.Add(this.debuglistBox);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Predictlabel);
            this.Controls.Add(this.LCountlabel);
            this.Controls.Add(this.LeftSignalbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuron";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LeftSignalbutton;
        private System.Windows.Forms.Label LCountlabel;
        private System.Windows.Forms.Label Predictlabel;
        private System.Windows.Forms.Button Exitbutton;
        public System.Windows.Forms.ListBox debuglistBox;
        private System.Windows.Forms.Button RightSignalbutton;
        private System.Windows.Forms.Label RCountlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Label Faillabel;
    }
}

