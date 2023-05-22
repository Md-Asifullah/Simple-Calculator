namespace Simple_Calculator
{
    partial class Calculator
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
            this.mainDisplay = new System.Windows.Forms.Label();
            this.secondaryDisplay = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDisplay.AutoSize = true;
            this.mainDisplay.CausesValidation = false;
            this.mainDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.mainDisplay.Location = new System.Drawing.Point(34, 37);
            this.mainDisplay.MaximumSize = new System.Drawing.Size(200, 0);
            this.mainDisplay.MinimumSize = new System.Drawing.Size(260, 0);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(260, 54);
            this.mainDisplay.TabIndex = 0;
            this.mainDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondaryDisplay
            // 
            this.secondaryDisplay.AutoSize = true;
            this.secondaryDisplay.CausesValidation = false;
            this.secondaryDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.secondaryDisplay.Location = new System.Drawing.Point(88, 12);
            this.secondaryDisplay.MinimumSize = new System.Drawing.Size(200, 0);
            this.secondaryDisplay.Name = "secondaryDisplay";
            this.secondaryDisplay.Size = new System.Drawing.Size(200, 20);
            this.secondaryDisplay.TabIndex = 1;
            this.secondaryDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.White;
            this.plus.CausesValidation = false;
            this.plus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.plus.Location = new System.Drawing.Point(16, 112);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(57, 50);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.White;
            this.minus.CausesValidation = false;
            this.minus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.minus.Location = new System.Drawing.Point(88, 112);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(57, 50);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.White;
            this.multiply.CausesValidation = false;
            this.multiply.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.multiply.Location = new System.Drawing.Point(160, 112);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(57, 50);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.White;
            this.divide.CausesValidation = false;
            this.divide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.divide.Location = new System.Drawing.Point(232, 112);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(57, 50);
            this.divide.TabIndex = 5;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.equal.CausesValidation = false;
            this.equal.ForeColor = System.Drawing.SystemColors.Control;
            this.equal.Location = new System.Drawing.Point(232, 250);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(57, 188);
            this.equal.TabIndex = 9;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.White;
            this.nine.CausesValidation = false;
            this.nine.Location = new System.Drawing.Point(160, 181);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(57, 50);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.White;
            this.eight.CausesValidation = false;
            this.eight.Location = new System.Drawing.Point(88, 181);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(57, 50);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.White;
            this.seven.CausesValidation = false;
            this.seven.Location = new System.Drawing.Point(16, 181);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(57, 50);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.White;
            this.six.CausesValidation = false;
            this.six.Location = new System.Drawing.Point(160, 250);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 50);
            this.six.TabIndex = 12;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.White;
            this.five.CausesValidation = false;
            this.five.Location = new System.Drawing.Point(88, 250);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(57, 50);
            this.five.TabIndex = 11;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.White;
            this.four.CausesValidation = false;
            this.four.Location = new System.Drawing.Point(16, 250);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(57, 50);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.White;
            this.three.CausesValidation = false;
            this.three.Location = new System.Drawing.Point(160, 319);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 50);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.White;
            this.two.CausesValidation = false;
            this.two.Location = new System.Drawing.Point(88, 319);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(57, 50);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.White;
            this.one.CausesValidation = false;
            this.one.Location = new System.Drawing.Point(16, 319);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(57, 50);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.IndianRed;
            this.ac.CausesValidation = false;
            this.ac.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ac.Location = new System.Drawing.Point(160, 388);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(57, 50);
            this.ac.TabIndex = 18;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.White;
            this.dot.CausesValidation = false;
            this.dot.Location = new System.Drawing.Point(88, 388);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(57, 50);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.White;
            this.zero.CausesValidation = false;
            this.zero.Location = new System.Drawing.Point(16, 388);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(57, 50);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.secondaryDisplay);
            this.panel1.Controls.Add(this.mainDisplay);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 100);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.CausesValidation = false;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(232, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "⌫";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainDisplay;
        private System.Windows.Forms.Label secondaryDisplay;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
