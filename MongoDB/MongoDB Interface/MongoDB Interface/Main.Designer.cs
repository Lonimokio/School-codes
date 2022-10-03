namespace MongoDB_Interface
{
    partial class Main
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
            this.View = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sorting = new System.Windows.Forms.ComboBox();
            this.MainSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Direction = new System.Windows.Forms.ComboBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.View2 = new System.Windows.Forms.ListBox();
            this.View3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TestID = new System.Windows.Forms.ListBox();
            this.Update = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.SeriesT = new System.Windows.Forms.TextBox();
            this.NameT = new System.Windows.Forms.TextBox();
            this.IDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Update2 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.FormattingEnabled = true;
            this.View.HorizontalScrollbar = true;
            this.View.Location = new System.Drawing.Point(12, 107);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(592, 134);
            this.View.TabIndex = 0;
            this.View.SelectedIndexChanged += new System.EventHandler(this.View_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contents";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(654, 570);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(149, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(677, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "What to show?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 617);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1569, 99);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Sorting
            // 
            this.Sorting.FormattingEnabled = true;
            this.Sorting.Items.AddRange(new object[] {
            "Name",
            "ID",
            "Series"});
            this.Sorting.Location = new System.Drawing.Point(654, 515);
            this.Sorting.Name = "Sorting";
            this.Sorting.Size = new System.Drawing.Size(75, 21);
            this.Sorting.TabIndex = 11;
            // 
            // MainSort
            // 
            this.MainSort.FormattingEnabled = true;
            this.MainSort.Items.AddRange(new object[] {
            "Sort",
            "Dont sort"});
            this.MainSort.Location = new System.Drawing.Point(654, 476);
            this.MainSort.Name = "MainSort";
            this.MainSort.Size = new System.Drawing.Size(149, 21);
            this.MainSort.TabIndex = 14;
            this.MainSort.Text = "Dont sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(696, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "How to sort?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(687, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Amount of results";
            // 
            // Direction
            // 
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.Direction.Location = new System.Drawing.Point(728, 515);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(75, 21);
            this.Direction.TabIndex = 25;
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(654, 552);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(149, 20);
            this.Length.TabIndex = 28;
            this.Length.Text = "1";
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // View2
            // 
            this.View2.FormattingEnabled = true;
            this.View2.HorizontalScrollbar = true;
            this.View2.Location = new System.Drawing.Point(12, 282);
            this.View2.Name = "View2";
            this.View2.Size = new System.Drawing.Size(592, 134);
            this.View2.TabIndex = 30;
            this.View2.SelectedIndexChanged += new System.EventHandler(this.View2_SelectedIndexChanged);
            // 
            // View3
            // 
            this.View3.FormattingEnabled = true;
            this.View3.HorizontalScrollbar = true;
            this.View3.Location = new System.Drawing.Point(12, 459);
            this.View3.Name = "View3";
            this.View3.Size = new System.Drawing.Size(592, 134);
            this.View3.TabIndex = 31;
            this.View3.SelectedIndexChanged += new System.EventHandler(this.View3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "Series";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TestID
            // 
            this.TestID.FormattingEnabled = true;
            this.TestID.Location = new System.Drawing.Point(708, 633);
            this.TestID.Name = "TestID";
            this.TestID.Size = new System.Drawing.Size(120, 56);
            this.TestID.TabIndex = 35;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(654, 393);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(149, 23);
            this.Update.TabIndex = 36;
            this.Update.Text = "Update Selected";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(832, 529);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(149, 23);
            this.Copy.TabIndex = 37;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // SeriesT
            // 
            this.SeriesT.Location = new System.Drawing.Point(832, 509);
            this.SeriesT.Name = "SeriesT";
            this.SeriesT.Size = new System.Drawing.Size(149, 20);
            this.SeriesT.TabIndex = 38;
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(832, 472);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(149, 20);
            this.NameT.TabIndex = 39;
            // 
            // IDT
            // 
            this.IDT.Location = new System.Drawing.Point(832, 435);
            this.IDT.Name = "IDT";
            this.IDT.Size = new System.Drawing.Size(149, 20);
            this.IDT.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(832, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(832, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Name";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(832, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Series";
            // 
            // Update2
            // 
            this.Update2.Location = new System.Drawing.Point(832, 548);
            this.Update2.Name = "Update2";
            this.Update2.Size = new System.Drawing.Size(149, 23);
            this.Update2.TabIndex = 44;
            this.Update2.Text = "Update";
            this.Update2.UseVisualStyleBackColor = true;
            this.Update2.Click += new System.EventHandler(this.Update2_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(832, 570);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(149, 23);
            this.Remove.TabIndex = 45;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1063, 701);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Update2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IDT);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.SeriesT);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.View3);
            this.Controls.Add(this.View2);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainSort);
            this.Controls.Add(this.Sorting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.TestID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Sorting;
        private System.Windows.Forms.ComboBox MainSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Direction;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.ListBox View2;
        private System.Windows.Forms.ListBox View3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ListBox TestID;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.TextBox SeriesT;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.TextBox IDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Update2;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}