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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BA_Click(object sender, EventArgs e)
        {
            Form17 f1 = new Form17();
            f1.Show();
            this.Hide();
        }

        private void CL_Click(object sender, EventArgs e)
        {
            
            EN.Clear();
            REN.Text = "";
        }

        private void ENC_Click(object sender, EventArgs e)
        {
           
          
                string input = EN.Text;
                string Result = "";
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("word1", "word5");
                dic.Add("word2", "word6");
                dic.Add("word3", "word7");
                dic.Add("word4", "word8");
                
                string[] words = input.Split(' '); 
                for (int i=0; i<words.Length;i++)
                {
                    Result += dic[words[i]] ;
                }
                REN.Text = Result;
            
        }

        private void DEC_Click(object sender, EventArgs e)
        { 
            

        }

        private void go_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
            this.Hide();
        }
    }





}


















