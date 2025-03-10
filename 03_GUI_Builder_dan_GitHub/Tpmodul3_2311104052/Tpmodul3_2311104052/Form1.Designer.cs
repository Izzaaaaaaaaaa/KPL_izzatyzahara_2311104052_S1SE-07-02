namespace Tpmodul3_2311104052
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labeloutp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtinput.Location = new System.Drawing.Point(104, 76);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(348, 30);
            this.txtinput.TabIndex = 1;
            this.txtinput.Text = "masukkan inputan";
            this.txtinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtinput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(572, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // labeloutp
            // 
            this.labeloutp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labeloutp.Location = new System.Drawing.Point(101, 122);
            this.labeloutp.Name = "labeloutp";
            this.labeloutp.Size = new System.Drawing.Size(644, 152);
            this.labeloutp.TabIndex = 4;
            this.labeloutp.Text = "Output";
            this.labeloutp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labeloutp.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeloutp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeloutp;
    }
}

