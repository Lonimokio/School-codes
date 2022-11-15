namespace Vs_Harjoitukset_1_2
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
            this.Test1 = new System.Windows.Forms.TextBox();
            this.Test2 = new System.Windows.Forms.TextBox();
            this.Test3 = new System.Windows.Forms.TextBox();
            this.TestB1 = new System.Windows.Forms.Button();
            this.TestL1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Test1
            // 
            this.Test1.Location = new System.Drawing.Point(203, 197);
            this.Test1.Name = "Test1";
            this.Test1.Size = new System.Drawing.Size(100, 20);
            this.Test1.TabIndex = 0;
            this.Test1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Test2
            // 
            this.Test2.Location = new System.Drawing.Point(328, 197);
            this.Test2.Name = "Test2";
            this.Test2.Size = new System.Drawing.Size(100, 20);
            this.Test2.TabIndex = 1;
            this.Test2.TextChanged += new System.EventHandler(this.Test2_TextChanged);
            // 
            // Test3
            // 
            this.Test3.Location = new System.Drawing.Point(454, 197);
            this.Test3.Name = "Test3";
            this.Test3.Size = new System.Drawing.Size(100, 20);
            this.Test3.TabIndex = 2;
            this.Test3.TextChanged += new System.EventHandler(this.Test3_TextChanged);
            // 
            // TestB1
            // 
            this.TestB1.Location = new System.Drawing.Point(340, 233);
            this.TestB1.Name = "TestB1";
            this.TestB1.Size = new System.Drawing.Size(75, 23);
            this.TestB1.TabIndex = 3;
            this.TestB1.Text = "Calculate";
            this.TestB1.UseVisualStyleBackColor = true;
            this.TestB1.Click += new System.EventHandler(this.TestB1_Click);
            // 
            // TestL1
            // 
            this.TestL1.AutoSize = true;
            this.TestL1.Location = new System.Drawing.Point(309, 200);
            this.TestL1.Name = "TestL1";
            this.TestL1.Size = new System.Drawing.Size(13, 13);
            this.TestL1.TabIndex = 4;
            this.TestL1.Text = "+";
            this.TestL1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestL1);
            this.Controls.Add(this.TestB1);
            this.Controls.Add(this.Test3);
            this.Controls.Add(this.Test2);
            this.Controls.Add(this.Test1);
            this.Name = "Form1";
            this.Text = "Testing in progress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Test1;
        private System.Windows.Forms.TextBox Test2;
        private System.Windows.Forms.TextBox Test3;
        private System.Windows.Forms.Button TestB1;
        private System.Windows.Forms.Label TestL1;
        private System.Windows.Forms.Label label2;
    }
}

