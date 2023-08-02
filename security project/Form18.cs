using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_project
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENC_Click(object sender, EventArgs e)
        { 
          
                string input = EN.Text.ToUpper();
                string Result = "";
                Dictionary<char, int> dic = new Dictionary<char, int>(26);
                for (int i=0; i<alphates.Length;i++)
                {
                    dic.Add(alphates[i], i + 1);
                }
               
                for (int i=0; i<input.Length;i++)
                {
                    if(alphates.Contains(input[i]))
                    {
                        Result += dic[input[i]];
                    }
                    else
                    {
                        Result += input[i];
                    }
                Result += " ";
                }
                REN.Text = Result;
            
        }

        private void BA_Click(object sender, EventArgs e)
        {
            Form17 f1 = new Form17();
            f1.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           
            EN.Clear();
            REN.Text = "";
        }

        private void DEC_Click(object sender, EventArgs e)
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.Show();
            this.Hide();
        }
    }
}








    