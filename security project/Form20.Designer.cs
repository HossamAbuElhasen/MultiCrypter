
namespace security_project
{
    partial class Form20
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
            this.DE = new System.Windows.Forms.RichTextBox();
            this.DEC = new System.Windows.Forms.Button();
            this.RDE = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(267, 55);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(347, 115);
            this.DE.TabIndex = 0;
            this.DE.Text = "";
            // 
            // DEC
            // 
            this.DEC.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.DEC.Location = new System.Drawing.Point(351, 191);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(197, 49);
            this.DEC.TabIndex = 1;
            this.DEC.Text = "Decryption";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // RDE
            // 
            this.RDE.Location = new System.Drawing.Point(267, 246);
            this.RDE.Name = "RDE";
            this.RDE.Size = new System.Drawing.Size(347, 115);
            this.RDE.TabIndex = 2;
            this.RDE.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(2, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "<= Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.c.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.c.Location = new System.Drawing.Point(381, 9);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(144, 29);
            this.c.TabIndex = 4;
            this.c.Text = "Decryption";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(351, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "write text to Decryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "The Result";
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.c);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RDE);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.DE);
            this.Name = "Form20";
            this.Text = "Dictionary type one Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DE;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.RichTextBox RDE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}