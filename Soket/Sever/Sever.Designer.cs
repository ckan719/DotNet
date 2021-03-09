
namespace Sever
{
    partial class Sever
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btReceive
            // 
            this.btReceive.Location = new System.Drawing.Point(714, 400);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(75, 38);
            this.btReceive.TabIndex = 6;
            this.btReceive.Text = "Send";
            this.btReceive.UseVisualStyleBackColor = true;
            this.btReceive.Click += new System.EventHandler(this.btReceive_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 400);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(686, 38);
            this.rtbInput.TabIndex = 5;
            this.rtbInput.Text = "";
            // 
            // lvShow
            // 
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(10, 12);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(688, 376);
            this.lvShow.TabIndex = 7;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "DS Client";
            // 
            // cbbClient
            // 
            this.cbbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClient.FormattingEnabled = true;
            this.cbbClient.Location = new System.Drawing.Point(711, 40);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(77, 24);
            this.cbbClient.TabIndex = 10;
            this.cbbClient.SelectedIndexChanged += new System.EventHandler(this.cbbClient_SelectedIndexChanged);
            // 
            // Sever
            // 
            this.AcceptButton = this.btReceive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.btReceive);
            this.Controls.Add(this.rtbInput);
            this.Name = "Sever";
            this.Text = "Sever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClient;
    }
}

