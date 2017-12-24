namespace เกรด
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_point = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ใส่คะแนน";
            // 
            // txt_point
            // 
            this.txt_point.Location = new System.Drawing.Point(112, 40);
            this.txt_point.Name = "txt_point";
            this.txt_point.Size = new System.Drawing.Size(100, 20);
            this.txt_point.TabIndex = 1;
            this.txt_point.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(109, 96);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(32, 13);
            this.grade.TabIndex = 2;
            this.grade.Text = "เกรด";
            this.grade.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 137);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_point;
        private System.Windows.Forms.Label grade;
    }
}

