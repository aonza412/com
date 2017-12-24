namespace WindowsFormsApplication1
{
    partial class calculator
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
            this.tex = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.persent = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eigth = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.mutiply = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.Equal_to = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // tex
            // 
            this.tex.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tex.Location = new System.Drawing.Point(22, 27);
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(250, 40);
            this.tex.TabIndex = 0;
            this.tex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(22, 83);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(58, 35);
            this.clear.TabIndex = 1;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.Location = new System.Drawing.Point(86, 83);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(58, 35);
            this.plus_minus.TabIndex = 2;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.button2_Click);
            // 
            // persent
            // 
            this.persent.Location = new System.Drawing.Point(150, 83);
            this.persent.Name = "persent";
            this.persent.Size = new System.Drawing.Size(58, 35);
            this.persent.TabIndex = 3;
            this.persent.Text = "%";
            this.persent.UseVisualStyleBackColor = true;
            this.persent.Click += new System.EventHandler(this.button3_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.divide.Location = new System.Drawing.Point(214, 83);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 35);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.button4_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(22, 124);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(58, 35);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button5_Click);
            // 
            // eigth
            // 
            this.eigth.Location = new System.Drawing.Point(86, 124);
            this.eigth.Name = "eigth";
            this.eigth.Size = new System.Drawing.Size(58, 35);
            this.eigth.TabIndex = 6;
            this.eigth.Text = "8";
            this.eigth.UseVisualStyleBackColor = true;
            this.eigth.Click += new System.EventHandler(this.button6_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(150, 124);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(58, 35);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button7_Click);
            // 
            // mutiply
            // 
            this.mutiply.Location = new System.Drawing.Point(214, 124);
            this.mutiply.Name = "mutiply";
            this.mutiply.Size = new System.Drawing.Size(58, 35);
            this.mutiply.TabIndex = 8;
            this.mutiply.Text = "x";
            this.mutiply.UseVisualStyleBackColor = true;
            this.mutiply.Click += new System.EventHandler(this.button8_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(22, 165);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(58, 35);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button9_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(86, 165);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(58, 35);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button10_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(150, 165);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(58, 35);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button11_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(214, 165);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 35);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button12_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(22, 247);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(58, 35);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button13_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dot.Location = new System.Drawing.Point(86, 247);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(58, 35);
            this.dot.TabIndex = 14;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // Equal_to
            // 
            this.Equal_to.Location = new System.Drawing.Point(150, 247);
            this.Equal_to.Name = "Equal_to";
            this.Equal_to.Size = new System.Drawing.Size(122, 35);
            this.Equal_to.TabIndex = 15;
            this.Equal_to.Text = "=";
            this.Equal_to.UseVisualStyleBackColor = true;
            this.Equal_to.Click += new System.EventHandler(this.button15_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(214, 206);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 35);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button16_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(150, 206);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(58, 35);
            this.three.TabIndex = 18;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button17_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(86, 206);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(58, 35);
            this.two.TabIndex = 17;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button18_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(22, 206);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(58, 35);
            this.one.TabIndex = 16;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button19_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 307);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Equal_to);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.mutiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eigth);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.persent);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tex);
            this.MaximizeBox = false;
            this.Name = "calculator";
            this.Text = "เครื่องคิดเลข";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button persent;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eigth;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button mutiply;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button Equal_to;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

