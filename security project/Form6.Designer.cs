
namespace security_project
{
    partial class Form6
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
            this.cl = new System.Windows.Forms.Button();
            this.ba = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(300, 54);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(314, 96);
            this.EN.TabIndex = 2;
            this.EN.Text = "";
            this.EN.TextChanged += new System.EventHandler(this.EN_TextChanged);
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(300, 176);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(314, 20);
            this.ke.TabIndex = 3;
            this.ke.Text = "vwxyzabcdefghijklmnopqrstu";
            this.ke.TextChanged += new System.EventHandler(this.ke_TextChanged);
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 18F);
            this.ENC.Location = new System.Drawing.Point(359, 213);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(208, 46);
            this.ENC.TabIndex = 4;
            this.ENC.Text = "Encryption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(300, 265);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(314, 96);
            this.REN.TabIndex = 5;
            this.REN.Text = "";
            this.REN.TextChanged += new System.EventHandler(this.REN_TextChanged);
            // 
            // cl
            // 
            this.cl.Font = new System.Drawing.Font("Tahoma", 18F);
            this.cl.Location = new System.Drawing.Point(348, 367);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(219, 41);
            this.cl.TabIndex = 6;
            this.cl.Text = "clear";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // ba
            // 
            this.ba.Font = new System.Drawing.Font("Tahoma", 18F);
            this.ba.Location = new System.Drawing.Point(3, 404);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(187, 44);
            this.ba.TabIndex = 7;
            this.ba.Text = "<= Back";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "The Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "write text to Encryption";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(64, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "The Key";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "mono alphabetical";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}