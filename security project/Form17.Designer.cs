﻿
namespace security_project
{
    partial class Form17
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button1.Location = new System.Drawing.Point(127, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Type one";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dictonary Two Type";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button2.Location = new System.Drawing.Point(437, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Type Two";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button3.Location = new System.Drawing.Point(1, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "<= Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form17";
            this.Text = "Dictonary";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}