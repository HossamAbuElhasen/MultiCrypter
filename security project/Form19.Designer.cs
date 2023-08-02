
namespace security_project
{
    partial class Form19
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
            this.ENC = new System.Windows.Forms.Button();
            this.REN = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BA = new System.Windows.Forms.Button();
            this.CL = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictonary Type two";
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(271, 73);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(350, 74);
            this.EN.TabIndex = 1;
            this.EN.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "wirte Text to Encryption";
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ENC.Location = new System.Drawing.Point(377, 168);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(158, 50);
            this.ENC.TabIndex = 3;
            this.ENC.Text = "Encryption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(271, 238);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(350, 78);
            this.REN.TabIndex = 4;
            this.REN.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Result of Encryption";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BA
            // 
            this.BA.Font = new System.Drawing.Font("Tahoma", 15F);
            this.BA.Location = new System.Drawing.Point(1, 413);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(139, 37);
            this.BA.TabIndex = 9;
            this.BA.Text = "<= Back";
            this.BA.UseVisualStyleBackColor = true;
            this.BA.Click += new System.EventHandler(this.BA_Click);
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 15F);
            this.CL.Location = new System.Drawing.Point(377, 332);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(149, 37);
            this.CL.TabIndex = 10;
            this.CL.Text = "clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Tahoma", 15F);
            this.go.Location = new System.Drawing.Point(581, 401);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(207, 49);
            this.go.TabIndex = 11;
            this.go.Text = "Go to Decryption =>";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.label1);
            this.Name = "Form19";
            this.Text = "Dictonary Type two";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button go;
    }
}