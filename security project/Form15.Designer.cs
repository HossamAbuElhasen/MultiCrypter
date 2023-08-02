
namespace security_project
{
    partial class Form15
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
            this.ENC = new System.Windows.Forms.Button();
            this.EN = new System.Windows.Forms.RichTextBox();
            this.ke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.REN = new System.Windows.Forms.RichTextBox();
            this.CL = new System.Windows.Forms.Button();
            this.ba = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.ENC.Location = new System.Drawing.Point(362, 207);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(168, 52);
            this.ENC.TabIndex = 1;
            this.ENC.Text = "Encryption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(289, 52);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(309, 102);
            this.EN.TabIndex = 2;
            this.EN.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(289, 169);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(309, 20);
            this.ke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "write Text to encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(80, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Key";
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(289, 265);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(309, 102);
            this.REN.TabIndex = 7;
            this.REN.Text = "";
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.CL.Location = new System.Drawing.Point(362, 373);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(168, 52);
            this.CL.TabIndex = 8;
            this.CL.Text = "Clear";
            this.CL.UseVisualStyleBackColor = true;
            // 
            // ba
            // 
            this.ba.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.ba.Location = new System.Drawing.Point(3, 396);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(168, 52);
            this.ba.TabIndex = 9;
            this.ba.Text = "<= Back";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(63, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "The Ruslt";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.label1);
            this.Name = "Form15";
            this.Text = "Rail fence Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Label label4;
    }
}