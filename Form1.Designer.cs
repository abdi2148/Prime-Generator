namespace Prime_Generator
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
            this.primesOutput_list = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rangeStart_lbl = new System.Windows.Forms.Label();
            this.rangeStart_input = new System.Windows.Forms.TextBox();
            this.rangeEnd_lbl = new System.Windows.Forms.Label();
            this.rangeEnd_input = new System.Windows.Forms.TextBox();
            this.generatePrimesSequential_btn = new System.Windows.Forms.Button();
            this.resultSyncronous_lbl = new System.Windows.Forms.Label();
            this.generatePrimesParallel_btn = new System.Windows.Forms.Button();
            this.resultParallel_lbl = new System.Windows.Forms.Label();
            this.resultSyncronousOutput_lbl = new System.Windows.Forms.Label();
            this.resultParallelOutput_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // primesOutput_list
            // 
            this.primesOutput_list.FormattingEnabled = true;
            this.primesOutput_list.Location = new System.Drawing.Point(462, 96);
            this.primesOutput_list.Name = "primesOutput_list";
            this.primesOutput_list.Size = new System.Drawing.Size(306, 420);
            this.primesOutput_list.TabIndex = 8;
            this.primesOutput_list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(571, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Output List";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "PRIME GENERATOR USING BOTH SEQUENTIAL AND PARRALEL METHODS";
            // 
            // rangeStart_lbl
            // 
            this.rangeStart_lbl.AutoSize = true;
            this.rangeStart_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.rangeStart_lbl.Location = new System.Drawing.Point(76, 153);
            this.rangeStart_lbl.Name = "rangeStart_lbl";
            this.rangeStart_lbl.Size = new System.Drawing.Size(94, 13);
            this.rangeStart_lbl.TabIndex = 17;
            this.rangeStart_lbl.Text = "Input Start Range:";
            this.rangeStart_lbl.Click += new System.EventHandler(this.rangeStart_lbl_Click);
            // 
            // rangeStart_input
            // 
            this.rangeStart_input.Location = new System.Drawing.Point(192, 150);
            this.rangeStart_input.Name = "rangeStart_input";
            this.rangeStart_input.Size = new System.Drawing.Size(100, 20);
            this.rangeStart_input.TabIndex = 18;
            this.rangeStart_input.TextChanged += new System.EventHandler(this.rangeStart_input_TextChanged);
            // 
            // rangeEnd_lbl
            // 
            this.rangeEnd_lbl.AutoSize = true;
            this.rangeEnd_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.rangeEnd_lbl.Location = new System.Drawing.Point(76, 183);
            this.rangeEnd_lbl.Name = "rangeEnd_lbl";
            this.rangeEnd_lbl.Size = new System.Drawing.Size(91, 13);
            this.rangeEnd_lbl.TabIndex = 19;
            this.rangeEnd_lbl.Text = "Input End Range:";
            // 
            // rangeEnd_input
            // 
            this.rangeEnd_input.Location = new System.Drawing.Point(192, 176);
            this.rangeEnd_input.Name = "rangeEnd_input";
            this.rangeEnd_input.Size = new System.Drawing.Size(100, 20);
            this.rangeEnd_input.TabIndex = 20;
            // 
            // generatePrimesSequential_btn
            // 
            this.generatePrimesSequential_btn.Location = new System.Drawing.Point(79, 272);
            this.generatePrimesSequential_btn.Name = "generatePrimesSequential_btn";
            this.generatePrimesSequential_btn.Size = new System.Drawing.Size(207, 23);
            this.generatePrimesSequential_btn.TabIndex = 21;
            this.generatePrimesSequential_btn.Text = "Generate Prime Numbers (Sequential)";
            this.generatePrimesSequential_btn.UseVisualStyleBackColor = true;
            this.generatePrimesSequential_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resultSyncronous_lbl
            // 
            this.resultSyncronous_lbl.AutoSize = true;
            this.resultSyncronous_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resultSyncronous_lbl.Location = new System.Drawing.Point(73, 318);
            this.resultSyncronous_lbl.Name = "resultSyncronous_lbl";
            this.resultSyncronous_lbl.Size = new System.Drawing.Size(81, 13);
            this.resultSyncronous_lbl.TabIndex = 22;
            this.resultSyncronous_lbl.Text = "Time Executed:";
            // 
            // generatePrimesParallel_btn
            // 
            this.generatePrimesParallel_btn.Location = new System.Drawing.Point(79, 382);
            this.generatePrimesParallel_btn.Name = "generatePrimesParallel_btn";
            this.generatePrimesParallel_btn.Size = new System.Drawing.Size(207, 23);
            this.generatePrimesParallel_btn.TabIndex = 23;
            this.generatePrimesParallel_btn.Text = "Generate Prime Numbers (Parralel)";
            this.generatePrimesParallel_btn.UseVisualStyleBackColor = true;
            this.generatePrimesParallel_btn.Click += new System.EventHandler(this.button1_Click);

            // 
            // resultParallel_lbl
            // 
            this.resultParallel_lbl.AutoSize = true;
            this.resultParallel_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resultParallel_lbl.Location = new System.Drawing.Point(76, 422);
            this.resultParallel_lbl.Name = "resultParallel_lbl";
            this.resultParallel_lbl.Size = new System.Drawing.Size(81, 13);
            this.resultParallel_lbl.TabIndex = 24;
            this.resultParallel_lbl.Text = "Time Executed:";
            // 
            // resultSyncronousOutput_lbl
            // 
            this.resultSyncronousOutput_lbl.AutoSize = true;
            this.resultSyncronousOutput_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultSyncronousOutput_lbl.Location = new System.Drawing.Point(160, 318);
            this.resultSyncronousOutput_lbl.Name = "resultSyncronousOutput_lbl";
            this.resultSyncronousOutput_lbl.Size = new System.Drawing.Size(16, 13);
            this.resultSyncronousOutput_lbl.TabIndex = 25;
            this.resultSyncronousOutput_lbl.Text = "...";
            // 
            // resultParallelOutput_lbl
            // 
            this.resultParallelOutput_lbl.AutoSize = true;
            this.resultParallelOutput_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultParallelOutput_lbl.Location = new System.Drawing.Point(160, 422);
            this.resultParallelOutput_lbl.Name = "resultParallelOutput_lbl";
            this.resultParallelOutput_lbl.Size = new System.Drawing.Size(16, 13);
            this.resultParallelOutput_lbl.TabIndex = 26;
            this.resultParallelOutput_lbl.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(820, 591);
            this.Controls.Add(this.resultParallelOutput_lbl);
            this.Controls.Add(this.resultSyncronousOutput_lbl);
            this.Controls.Add(this.resultParallel_lbl);
            this.Controls.Add(this.generatePrimesParallel_btn);
            this.Controls.Add(this.resultSyncronous_lbl);
            this.Controls.Add(this.generatePrimesSequential_btn);
            this.Controls.Add(this.rangeEnd_input);
            this.Controls.Add(this.rangeEnd_lbl);
            this.Controls.Add(this.rangeStart_input);
            this.Controls.Add(this.rangeStart_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.primesOutput_list);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox primesOutput_list;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rangeStart_lbl;
        private System.Windows.Forms.TextBox rangeStart_input;
        private System.Windows.Forms.Label rangeEnd_lbl;
        private System.Windows.Forms.TextBox rangeEnd_input;
        private System.Windows.Forms.Button generatePrimesSequential_btn;
        private System.Windows.Forms.Label resultSyncronous_lbl;
        private System.Windows.Forms.Button generatePrimesParallel_btn;
        private System.Windows.Forms.Label resultParallel_lbl;
        private System.Windows.Forms.Label resultSyncronousOutput_lbl;
        private System.Windows.Forms.Label resultParallelOutput_lbl;
    }
}

