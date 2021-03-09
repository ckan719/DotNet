namespace XepHinh
{
    partial class form
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
            this.getNum = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getNum)).BeginInit();
            this.SuspendLayout();
            // 
            // getNum
            // 
            this.getNum.Location = new System.Drawing.Point(12, 12);
            this.getNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.getNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.getNum.Name = "getNum";
            this.getNum.Size = new System.Drawing.Size(97, 22);
            this.getNum.TabIndex = 0;
            this.getNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.getNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 2;
            // 
            // btRand
            // 
            this.btRand.Location = new System.Drawing.Point(12, 40);
            this.btRand.Name = "btRand";
            this.btRand.Size = new System.Drawing.Size(97, 24);
            this.btRand.TabIndex = 3;
            this.btRand.Text = "random";
            this.btRand.UseVisualStyleBackColor = true;
            this.btRand.Visible = false;
            this.btRand.Click += new System.EventHandler(this.button1_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 213);
            this.Controls.Add(this.btRand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.getNum);
            this.Name = "form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.getNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown getNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRand;
    }
}

