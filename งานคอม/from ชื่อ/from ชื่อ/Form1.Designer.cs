namespace from_ชื่อ
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
            this.label2 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ-นามสกุล";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(43, 141);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(91, 13);
            this.lb_result.TabIndex = 2;
            this.lb_result.Text = "                            ";
            this.lb_result.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(80, 18);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(152, 20);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(74, 81);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(96, 37);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "ตกลง";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_name2
            // 
            this.txt_name2.Location = new System.Drawing.Point(80, 44);
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(152, 20);
            this.txt_name2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "รหัสนักศึกษา";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name2);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.Label label1;
    }
}

