
namespace security_project
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EN = new System.Windows.Forms.RichTextBox();
            this.REN = new System.Windows.Forms.RichTextBox();
            this.ke = new System.Windows.Forms.TextBox();
            this.ENC = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "write text to Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(91, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "The Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(271, 58);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(327, 98);
            this.EN.TabIndex = 4;
            this.EN.Text = "";
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(271, 240);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(327, 109);
            this.REN.TabIndex = 5;
            this.REN.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(271, 162);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(327, 20);
            this.ke.TabIndex = 6;
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ENC.Location = new System.Drawing.Point(363, 188);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(155, 46);
            this.ENC.TabIndex = 7;
            this.ENC.Text = "Encryption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button3.Location = new System.Drawing.Point(8, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "<= Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CL.Location = new System.Drawing.Point(377, 355);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(141, 38);
            this.CL.TabIndex = 10;
            this.CL.Text = "Clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "caser ciper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CL;
    }
}