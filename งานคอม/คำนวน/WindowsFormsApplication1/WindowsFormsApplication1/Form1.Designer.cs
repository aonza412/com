namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.pl = new System.Windows.Forms.Button();
            this.mu = new System.Windows.Forms.Button();
            this.de = new System.Windows.Forms.Button();
            this.di = new System.Windows.Forms.Button();
            this.txt_sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตัวเลขที่1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ตัวเลขที่2";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(77, 8);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(114, 20);
            this.txt_num1.TabIndex = 2;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(77, 63);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(114, 20);
            this.txt_num2.TabIndex = 3;
            // 
            // pl
            // 
            this.pl.Location = new System.Drawing.Point(77, 34);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(24, 23);
            this.pl.TabIndex = 4;
            this.pl.Text = "+";
            this.pl.UseVisualStyleBackColor = true;
            this.pl.Click += new System.EventHandler(this.button1_Click);
            // 
            // mu
            // 
            this.mu.Location = new System.Drawing.Point(137, 34);
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(24, 23);
            this.mu.TabIndex = 5;
            this.mu.Text = "x";
            this.mu.UseVisualStyleBackColor = true;
            this.mu.Click += new System.EventHandler(this.mu_Click);
            // 
            // de
            // 
            this.de.Location = new System.Drawing.Point(107, 34);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(24, 23);
            this.de.TabIndex = 6;
            this.de.Text = "-";
            this.de.UseVisualStyleBackColor = true;
            this.de.Click += new System.EventHandler(this.de_Click);
            // 
            // di
            // 
            this.di.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("di.BackgroundImage")));
            this.di.Location = new System.Drawing.Point(167, 34);
            this.di.Name = "di";
            this.di.Size = new System.Drawing.Size(24, 23);
            this.di.TabIndex = 7;
            this.di.Text = "/";
            this.di.UseVisualStyleBackColor = true;
            this.di.Click += new System.EventHandler(this.di_Click);
            // 
            // txt_sum
            // 
            this.txt_sum.AutoSize = true;
            this.txt_sum.Location = new System.Drawing.Point(104, 104);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(37, 13);
            this.txt_sum.TabIndex = 8;
            this.txt_sum.Text = "          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(241, 124);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.di);
            this.Controls.Add(this.de);
            this.Controls.Add(this.mu);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button pl;
        private System.Windows.Forms.Button mu;
        private System.Windows.Forms.Button de;
        private System.Windows.Forms.Button di;
        private System.Windows.Forms.Label txt_sum;
    }
}

