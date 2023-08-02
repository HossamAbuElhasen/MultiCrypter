
namespace security_project
{
    partial class Form21
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
            this.DEC = new System.Windows.Forms.Button();
            this.RDE = new System.Windows.Forms.RichTextBox();
            this.CL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decryption";
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(279, 68);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(331, 97);
            this.DE.TabIndex = 1;
            this.DE.Text = "";
            // 
            // DEC
            // 
            this.DEC.Font = new System.Drawing.Font("Tahoma", 16F);
            this.DEC.Location = new System.Drawing.Point(337, 190);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(217, 45);
            this.DEC.TabIndex = 2;
            this.DEC.Text = "Decryption";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // RDE
            // 
            this.RDE.Location = new System.Drawing.Point(279, 259);
            this.RDE.Name = "RDE";
            this.RDE.Size = new System.Drawing.Size(331, 97);
            this.RDE.TabIndex = 3;
            this.RDE.Text = "";
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CL.Location = new System.Drawing.Point(350, 362);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(191, 40);
            this.CL.TabIndex = 4;
            this.CL.Text = "clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button2.Location = new System.Drawing.Point(2, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "<= Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "write text toDecryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Result";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.RDE);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.label1);
            this.Name = "Form21";
            this.Text = "Dictionary type two Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DE;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.RichTextBox RDE;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}