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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 f1 = new Form19();
            f1.Show();
            this.Hide();
        }

        private void DEC_Click(object sender, EventArgs e)
        {
           

            string input = DE.Text;
            string Result = "";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("word5", "word1");
            dic.Add("word6", "word2");
            dic.Add("word7", "word3");
            dic.Add("word8", "word4");

            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length ; i++)
            {
                Result += dic[words[i]] + " ";

            }
            RDE.Text = Result;
        }

        private void CL_Click(object sender, EventArgs e)
        {
            RDE.Text = "";
            DE.Text = "";
        }
    }
}
