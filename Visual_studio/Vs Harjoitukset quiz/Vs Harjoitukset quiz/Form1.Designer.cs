namespace Vs_Harjoitukset_quiz
{
    partial class Quiz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.QBox = new System.Windows.Forms.TextBox();
            this.QL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QB = new System.Windows.Forms.Button();
            this.TM = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(257, 104);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(86, 31);
            this.Time.TabIndex = 1;
            this.Time.Text = "label1";
            // 
            // QBox
            // 
            this.QBox.Location = new System.Drawing.Point(325, 207);
            this.QBox.Name = "QBox";
            this.QBox.Size = new System.Drawing.Size(100, 20);
            this.QBox.TabIndex = 2;
            // 
            // QL
            // 
            this.QL.AutoSize = true;
            this.QL.Location = new System.Drawing.Point(257, 191);
            this.QL.Name = "QL";
            this.QL.Size = new System.Drawing.Size(243, 13);
            this.QL.TabIndex = 3;
            this.QL.Text = "What is the max stack for enderpearls in Minecraft";
            this.QL.Click += new System.EventHandler(this.QL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quiz";
            // 
            // QB
            // 
            this.QB.Location = new System.Drawing.Point(337, 225);
            this.QB.Name = "QB";
            this.QB.Size = new System.Drawing.Size(75, 23);
            this.QB.TabIndex = 5;
            this.QB.Text = "Submit";
            this.QB.UseVisualStyleBackColor = true;
            this.QB.Click += new System.EventHandler(this.QB_Click);
            // 
            // TM
            // 
            this.TM.Interval = 1000;
            this.TM.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QL);
            this.Controls.Add(this.QBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox QBox;
        private System.Windows.Forms.Label QL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QB;
        private System.Windows.Forms.Timer TM;
    }
}

