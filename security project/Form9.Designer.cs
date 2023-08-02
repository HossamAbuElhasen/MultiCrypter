
namespace security_project
{
    partial class Form9
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
            this.ke = new System.Windows.Forms.TextBox();
            this.EN = new System.Windows.Forms.RichTextBox();
            this.REN = new System.Windows.Forms.RichTextBox();
            this.CL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            // 
            // ENC
            // 
            this.ENC.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.ENC.Location = new System.Drawing.Point(708, 192);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(179, 40);
            this.ENC.TabIndex = 1;
            this.ENC.Text = "Encyption";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.button1_Click);
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(93, 92);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(437, 20);
            this.ke.TabIndex = 2;
            this.ke.TextChanged += new System.EventHandler(this.ke_TextChanged);
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(649, 92);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(276, 79);
            this.EN.TabIndex = 3;
            this.EN.Text = "";
            // 
            // REN
            // 
            this.REN.Location = new System.Drawing.Point(649, 302);
            this.REN.Name = "REN";
            this.REN.Size = new System.Drawing.Size(284, 71);
            this.REN.TabIndex = 4;
            this.REN.Text = "";
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.CL.Location = new System.Drawing.Point(725, 379);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(148, 33);
            this.CL.TabIndex = 5;
            this.CL.Text = "Clear";
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.CL_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(2, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "<= Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(644, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "write text to Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(727, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "The Result";
            // 
            // daTable
            // 
            this.daTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daTable.Location = new System.Drawing.Point(2, 127);
            this.daTable.Name = "daTable";
            this.daTable.Size = new System.Drawing.Size(528, 285);
            this.daTable.TabIndex = 10;
            this.daTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daTable_CellContentClick);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(971, 501);
            this.Controls.Add(this.daTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.REN);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "playFire Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.daTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.RichTextBox EN;
        private System.Windows.Forms.RichTextBox REN;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView daTable;
    }
}