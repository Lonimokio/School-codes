namespace Vs_Harjoitukset_Switch
{
    partial class Switch
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
            this.C1 = new System.Windows.Forms.ComboBox();
            this.AB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Choice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CLB = new System.Windows.Forms.CheckedListBox();
            this.TB = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.NU = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU)).BeginInit();
            this.SuspendLayout();
            // 
            // C1
            // 
            this.C1.FormattingEnabled = true;
            this.C1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.C1.Location = new System.Drawing.Point(34, 89);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(121, 21);
            this.C1.TabIndex = 0;
            this.C1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AB
            // 
            this.AB.Enabled = false;
            this.AB.Location = new System.Drawing.Point(44, 109);
            this.AB.Name = "AB";
            this.AB.Size = new System.Drawing.Size(100, 20);
            this.AB.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 68);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choice
            // 
            this.Choice.FormattingEnabled = true;
            this.Choice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Choice.Location = new System.Drawing.Point(34, 220);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(121, 95);
            this.Choice.TabIndex = 4;
            this.Choice.SelectedIndexChanged += new System.EventHandler(this.Choice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select one";
            // 
            // CLB
            // 
            this.CLB.CheckOnClick = true;
            this.CLB.FormattingEnabled = true;
            this.CLB.IntegralHeight = false;
            this.CLB.Items.AddRange(new object[] {
            "20",
            "30",
            "100",
            "50",
            "5"});
            this.CLB.Location = new System.Drawing.Point(586, 128);
            this.CLB.Name = "CLB";
            this.CLB.Size = new System.Drawing.Size(120, 96);
            this.CLB.TabIndex = 6;
            this.CLB.SelectedIndexChanged += new System.EventHandler(this.CLB_SelectedIndexChanged);
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(597, 240);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(100, 20);
            this.TB.TabIndex = 7;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(606, 259);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // NU
            // 
            this.NU.Location = new System.Drawing.Point(586, 221);
            this.NU.Name = "NU";
            this.NU.ReadOnly = true;
            this.NU.Size = new System.Drawing.Size(120, 20);
            this.NU.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select procentage";
            // 
            // Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NU);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.CLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AB);
            this.Controls.Add(this.C1);
            this.Name = "Switch";
            this.Text = "X";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox C1;
        private System.Windows.Forms.TextBox AB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CLB;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.NumericUpDown NU;
        private System.Windows.Forms.Label label2;
    }
}

