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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 f1 = new Form18();
            f1.Show();
            this.Hide();
        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void DEC_Click(object sender, EventArgs e)
        {
       

            string input = DE.Text;
            Dictionary<int, char> dic = new Dictionary<int, char>(26);
            for (int i = 0; i < alphates.Length; i++)
            {
                dic.Add(i + 1, alphates[i]);
            }

            string[] ciperTxt = input.Split(' ');
            string Result = "";
            for (int i = 0; i < ciperTxt.Length-1 ; i++)
            {
                Result += dic[int.Parse(ciperTxt[i])];
                Result += " ";
            }
            RDE.Text = Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RDE.Text = "";
            DE.Text = "";
        }
    }
}
