
namespace security_project
{
    partial class Form16
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
            this.DEC = new System.Windows.Forms.Button();
            this.DE = new System.Windows.Forms.RichTextBox();
            this.ke = new System.Windows.Forms.TextBox();
            this.RDE = new System.Windows.Forms.RichTextBox();
            this.CL = new System.Windows.Forms.Button();
            this.BA = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decryption";
            // 
            // DEC
            // 
            this.DEC.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.DEC.Location = new System.Drawing.Point(373, 209);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(157, 53);
            this.DEC.TabIndex = 1;
            this.DEC.Text = "Decryption";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(291, 60);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(309, 108);
            this.DE.TabIndex = 2;
            this.DE.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(291, 183);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(309, 20);
            this.ke.TabIndex = 3;
            // 
            // RDE
            // 
            this.RDE.Location = new System.Drawing.Point(291, 268);
            this.RDE.Name = "RDE";
            this.RDE.Size = new System.Drawing.Size(309, 115);
            this.RDE.TabIndex = 4;
            this.RDE.Text = "";
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.CL.Location = new System.Drawing.Point(373, 389);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(157, 39);
            this.CL.TabIndex = 5;
            this.CL.Text = "clear";
            this.CL.UseVisualStyleBackColor = true;
            // 
            // BA
            // 
            this.BA.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.BA.Location = new System.Drawing.Point(2, 398);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(157, 53);
            this.BA.TabIndex = 6;
            this.BA.Text = "<= Back";
            this.BA.UseVisualStyleBackColor = true;
            this.BA.Click += new System.EventHandler(this.BA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "write text to Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(81, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "The Result";
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.RDE);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.label1);
            this.Name = "Form16";
            this.Text = "Rail fence decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.RichTextBox DE;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.RichTextBox RDE;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}