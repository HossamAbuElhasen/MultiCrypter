
namespace security_project
{
    partial class Form4
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
            this.DE = new System.Windows.Forms.RichTextBox();
            this.ke = new System.Windows.Forms.TextBox();
            this.DEC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RDE = new System.Windows.Forms.RichTextBox();
            this.back = new System.Windows.Forms.Button();
            this.CL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decryption";
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(261, 54);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(312, 104);
            this.DE.TabIndex = 1;
            this.DE.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(261, 181);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(312, 20);
            this.ke.TabIndex = 2;
            // 
            // DEC
            // 
            this.DEC.Font = new System.Drawing.Font("Tahoma", 16F);
            this.DEC.Location = new System.Drawing.Point(359, 207);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(141, 46);
            this.DEC.TabIndex = 3;
            this.DEC.Text = "Decryption";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "write text to Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "The key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "The Result";
            // 
            // RDE
            // 
            this.RDE.Location = new System.Drawing.Point(261, 259);
            this.RDE.Name = "RDE";
            this.RDE.Size = new System.Drawing.Size(312, 102);
            this.RDE.TabIndex = 7;
            this.RDE.Text = "";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Tahoma", 16F);
            this.back.Location = new System.Drawing.Point(7, 411);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(141, 36);
            this.back.TabIndex = 8;
            this.back.Text = "<= Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CL.Location = new System.Drawing.Point(343, 367);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(141, 36);
            this.CL.TabIndex = 9;
            this.CL.Text = "Clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.back);
            this.Controls.Add(this.RDE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "caser ciper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DE;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RDE;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button CL;
    }
}