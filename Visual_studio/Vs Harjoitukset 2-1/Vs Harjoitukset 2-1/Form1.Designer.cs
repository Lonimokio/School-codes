namespace Vs_Harjoitukset_2_1
{
    partial class Form1
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
            this.TestB1 = new System.Windows.Forms.Button();
            this.TestBox1 = new System.Windows.Forms.TextBox();
            this.TestBox2 = new System.Windows.Forms.TextBox();
            this.TestL1 = new System.Windows.Forms.Label();
            this.TestL2 = new System.Windows.Forms.Label();
            this.TestB2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestB1
            // 
            this.TestB1.Location = new System.Drawing.Point(331, 280);
            this.TestB1.Name = "TestB1";
            this.TestB1.Size = new System.Drawing.Size(75, 23);
            this.TestB1.TabIndex = 0;
            this.TestB1.Text = "Submit";
            this.TestB1.UseVisualStyleBackColor = true;
            this.TestB1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestBox1
            // 
            this.TestBox1.Location = new System.Drawing.Point(322, 254);
            this.TestBox1.Name = "TestBox1";
            this.TestBox1.Size = new System.Drawing.Size(100, 20);
            this.TestBox1.TabIndex = 1;
            this.TestBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TestBox2
            // 
            this.TestBox2.Location = new System.Drawing.Point(322, 214);
            this.TestBox2.Name = "TestBox2";
            this.TestBox2.Size = new System.Drawing.Size(100, 20);
            this.TestBox2.TabIndex = 2;
            this.TestBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TestL1
            // 
            this.TestL1.AutoSize = true;
            this.TestL1.Location = new System.Drawing.Point(319, 198);
            this.TestL1.Name = "TestL1";
            this.TestL1.Size = new System.Drawing.Size(101, 13);
            this.TestL1.TabIndex = 3;
            this.TestL1.Text = "What is your name?";
            this.TestL1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TestL2
            // 
            this.TestL2.AutoSize = true;
            this.TestL2.Location = new System.Drawing.Point(303, 238);
            this.TestL2.Name = "TestL2";
            this.TestL2.Size = new System.Drawing.Size(132, 13);
            this.TestL2.TabIndex = 4;
            this.TestL2.Text = "What year were you born?";
            this.TestL2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TestB2
            // 
            this.TestB2.Location = new System.Drawing.Point(677, 415);
            this.TestB2.Name = "TestB2";
            this.TestB2.Size = new System.Drawing.Size(75, 23);
            this.TestB2.TabIndex = 5;
            this.TestB2.Text = "Close program";
            this.TestB2.UseVisualStyleBackColor = true;
            this.TestB2.Click += new System.EventHandler(this.TestB2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestL1);
            this.Controls.Add(this.TestB1);
            this.Controls.Add(this.TestBox2);
            this.Controls.Add(this.TestB2);
            this.Controls.Add(this.TestL2);
            this.Controls.Add(this.TestBox1);
            this.Name = "Form1";
            this.Text = "Testing in progress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestB1;
        private System.Windows.Forms.TextBox TestBox1;
        private System.Windows.Forms.TextBox TestBox2;
        private System.Windows.Forms.Label TestL1;
        private System.Windows.Forms.Label TestL2;
        private System.Windows.Forms.Button TestB2;
    }
}

