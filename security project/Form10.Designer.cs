
namespace security_project
{
    partial class Form10
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
            this.CL = new System.Windows.Forms.Button();
            this.BA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.daTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decryption";
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(649, 88);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(281, 82);
            this.DE.TabIndex = 1;
            this.DE.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(93, 110);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(433, 20);
            this.ke.TabIndex = 2;
            this.ke.TextChanged += new System.EventHandler(this.ke_TextChanged);
            // 
            // DEC
            // 
            this.DEC.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.DEC.Location = new System.Drawing.Point(693, 186);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(198, 40);
            this.DEC.TabIndex = 3;
            this.DEC.Text = "Decryption";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // RDE
            // 
            this.RDE.Location = new System.Drawing.Point(649, 281);
            this.RDE.Name = "RDE";
            this.RDE.Size = new System.Drawing.Size(281, 83);
            this.RDE.TabIndex = 4;
            this.RDE.Text = "";
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.CL.Location = new System.Drawing.Point(722, 385);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(158, 36);
            this.CL.TabIndex = 5;
            this.CL.Text = "Clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // BA
            // 
            this.BA.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.BA.Location = new System.Drawing.Point(2, 448);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(158, 51);
            this.BA.TabIndex = 6;
            this.BA.Text = "<= Back";
            this.BA.UseVisualStyleBackColor = true;
            this.BA.Click += new System.EventHandler(this.BA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "The Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(733, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(651, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "write text to Decryption";
            // 
            // daTable
            // 
            this.daTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daTable.Location = new System.Drawing.Point(2, 145);
            this.daTable.Name = "daTable";
            this.daTable.Size = new System.Drawing.Size(524, 229);
            this.daTable.TabIndex = 10;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(958, 501);
            this.Controls.Add(this.daTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.RDE);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "playFire Decryption";
            ((System.ComponentModel.ISupportInitialize)(this.daTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DE;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.RichTextBox RDE;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView daTable;
    }
}