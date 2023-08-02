
namespace security_project
{
    partial class Form12
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
            this.EN = new System.Windows.Forms.RichTextBox();
            this.ke = new System.Windows.Forms.TextBox();
            this.ENC = new System.Windows.Forms.Button();
            this.REN = new System.Windows.Forms.RichTextBox();
            this.CL = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(285, 64);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(328, 104);
            this.EN.TabIndex = 1;
            this.EN.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(285, 195);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(328, 20);
            this.ke.TabIndex = 2;
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.ENC.Location = new System.Drawing.Point(372, 221);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(159, 51);
            this.ENC.TabIndex = 3;
            this.ENC.Text = "Encryption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(285, 278);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(328, 96);
            this.REN.TabIndex = 4;
            this.REN.Text = "";
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.CL.Location = new System.Drawing.Point(372, 380);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(159, 51);
            this.CL.TabIndex = 5;
            this.CL.Text = "clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(1, 398);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(159, 51);
            this.Back.TabIndex = 6;
            this.Back.Text = "<= Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "write text to Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(85, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "The Result";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.label1);
            this.Name = "Form12";
            this.Text = "poly alphatic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}