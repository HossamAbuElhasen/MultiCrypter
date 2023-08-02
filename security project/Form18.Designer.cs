
namespace security_project
{
    partial class Form18
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ENC = new System.Windows.Forms.Button();
            this.REN = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.BA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictonary type one";
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(284, 71);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(366, 74);
            this.EN.TabIndex = 1;
            this.EN.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "write text to encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(48, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "The Result ";
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ENC.Location = new System.Drawing.Point(385, 179);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(165, 39);
            this.ENC.TabIndex = 4;
            this.ENC.Text = "Encryption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(284, 239);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(374, 80);
            this.REN.TabIndex = 5;
            this.REN.Text = "";
            this.REN.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Tahoma", 16F);
            this.Clear.Location = new System.Drawing.Point(399, 325);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(151, 37);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BA
            // 
            this.BA.Font = new System.Drawing.Font("Tahoma", 16F);
            this.BA.Location = new System.Drawing.Point(1, 411);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(136, 40);
            this.BA.TabIndex = 10;
            this.BA.Text = "<= Back";
            this.BA.UseVisualStyleBackColor = true;
            this.BA.Click += new System.EventHandler(this.BA_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button1.Location = new System.Drawing.Point(549, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "go to Decryption =>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.label1);
            this.Name = "Form18";
            this.Text = "Dictonary Type one";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.Button button1;
    }
}