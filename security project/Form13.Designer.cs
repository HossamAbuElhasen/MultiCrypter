
namespace security_project
{
    partial class Form13
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
            this.RDE = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decryption";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(293, 57);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(298, 104);
            this.DE.TabIndex = 1;
            this.DE.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(293, 180);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(298, 20);
            this.ke.TabIndex = 2;
            // 
            // DEC
            // 
            this.DEC.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.DEC.Location = new System.Drawing.Point(368, 206);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(151, 45);
            this.DEC.TabIndex = 3;
            this.DEC.Text = "Decyrption";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // RDE
            // 
            this.RDE.Location = new System.Drawing.Point(293, 257);
            this.RDE.Name = "RDE";
            this.RDE.Size = new System.Drawing.Size(298, 101);
            this.RDE.TabIndex = 4;
            this.RDE.Text = "";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.Clear.Location = new System.Drawing.Point(368, 374);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(151, 45);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ba
            // 
            this.ba.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ba.Location = new System.Drawing.Point(1, 404);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(151, 45);
            this.ba.TabIndex = 6;
            this.ba.Text = "<= Back";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(68, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "The Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(87, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "write text to Decryption";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.RDE);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.label1);
            this.Name = "Form13";
            this.Text = "poly alphatic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DE;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.RichTextBox RDE;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}