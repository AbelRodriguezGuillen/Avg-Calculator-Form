namespace WinFormsApp1
{
    partial class AvgCalcForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFirstInput = new System.Windows.Forms.TextBox();
            this.tbSecondInput = new System.Windows.Forms.TextBox();
            this.tbThirdInput = new System.Windows.Forms.TextBox();
            this.tbFourthInput = new System.Windows.Forms.TextBox();
            this.tbFifthInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstInput
            // 
            this.tbFirstInput.AcceptsTab = true;
            this.tbFirstInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbFirstInput.Location = new System.Drawing.Point(119, 163);
            this.tbFirstInput.Name = "tbFirstInput";
            this.tbFirstInput.Size = new System.Drawing.Size(125, 27);
            this.tbFirstInput.TabIndex = 1;
            this.tbFirstInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstInput_KeyPress);

            // 
            // tbSecondInput
            // 
            this.tbSecondInput.AcceptsTab = true;
            this.tbSecondInput.Location = new System.Drawing.Point(119, 210);
            this.tbSecondInput.Name = "tbSecondInput";
            this.tbSecondInput.Size = new System.Drawing.Size(125, 27);
            this.tbSecondInput.TabIndex = 2;
            this.tbSecondInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSecondInput_KeyPress);
            // 
            // tbThirdInput
            // 
            this.tbThirdInput.AcceptsTab = true;
            this.tbThirdInput.Location = new System.Drawing.Point(119, 261);
            this.tbThirdInput.Name = "tbThirdInput";
            this.tbThirdInput.Size = new System.Drawing.Size(125, 27);
            this.tbThirdInput.TabIndex = 3;
            this.tbThirdInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThirdInput_KeyPress);
            // 
            // tbFourthInput
            // 
            this.tbFourthInput.AcceptsTab = true;
            this.tbFourthInput.Location = new System.Drawing.Point(119, 313);
            this.tbFourthInput.Name = "tbFourthInput";
            this.tbFourthInput.Size = new System.Drawing.Size(125, 27);
            this.tbFourthInput.TabIndex = 4;
            this.tbFourthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFourthInput_KeyPress);
            // 
            // tbFifthInput
            // 
            this.tbFifthInput.AcceptsTab = true;
            this.tbFifthInput.Location = new System.Drawing.Point(119, 364);
            this.tbFifthInput.Name = "tbFifthInput";
            this.tbFifthInput.Size = new System.Drawing.Size(125, 27);
            this.tbFifthInput.TabIndex = 5;
            this.tbFifthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFifthInput_KeyPress);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(119, 436);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(125, 29);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            this.submit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.submit_KeyPress);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(119, 489);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(125, 29);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(356, 166);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(374, 225);
            this.output.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Input #3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Input #4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input #5";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Average";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(404, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Please input 5 numbers and press submit to get the average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(289, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 55);
            this.label8.TabIndex = 16;
            this.label8.Text = "AVERAGE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 545);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tbFifthInput);
            this.Controls.Add(this.tbFourthInput);
            this.Controls.Add(this.tbThirdInput);
            this.Controls.Add(this.tbSecondInput);
            this.Controls.Add(this.tbFirstInput);
            this.MinimumSize = new System.Drawing.Size(915, 592);
            this.Name = "AvgCalcForm";
            this.Text = "Average Calculator";
            this.Load += new System.EventHandler(this.AvgCalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbFirstInput;
        private TextBox tbSecondInput;
        private TextBox tbThirdInput;
        private TextBox tbFourthInput;
        private TextBox tbFifthInput;
        private Button submit;
        private Button clear;
        private TextBox output;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}