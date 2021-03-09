
namespace Client
{
    partial class Client
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
            this.btReceive = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.lvShow = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btReceive
            // 
            this.btReceive.Location = new System.Drawing.Point(714, 400);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(75, 38);
            this.btReceive.TabIndex = 9;
            this.btReceive.Text = "Send";
            this.btReceive.UseVisualStyleBackColor = true;
            this.btReceive.Click += new System.EventHandler(this.btReceive_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 400);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(686, 38);
            this.rtbInput.TabIndex = 8;
            this.rtbInput.Text = "";
            // 
            // lvShow
            // 
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(10, 7);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(778, 372);
            this.lvShow.TabIndex = 10;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.List;
            // 
            // Client
            // 
            this.AcceptButton = this.btReceive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.btReceive);
            this.Controls.Add(this.rtbInput);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.ListView lvShow;
    }
}

