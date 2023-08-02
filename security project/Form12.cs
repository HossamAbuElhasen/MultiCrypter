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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void CL_Click(object sender, EventArgs e)
        {
            REN.Text = "";
            ke.Clear();
            EN.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form11 f1 = new Form11();
            f1.Show();
            this.Hide();
        }

      
        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void ENC_Click(object sender, EventArgs e) 
        {
            string chUpper = EN.Text.ToUpper();
            char[] plan = chUpper.ToCharArray();
            string key = ke.Text.ToUpper();
            char chKey ;
            if (EN.Text == "" || ke.Text == "")  
                MessageBox.Show("the field is empty");
            else
            {

                for (int i = 0; i < EN.Text.Length; i++)
                {
                    if (alphates.Contains(plan[i]))  
                    {
                        chKey = key[i % key.Length];
              
                        int indexPlane = alphates.IndexOf(plan[i]); 
                        int indexKey = alphates.IndexOf(chKey);
                        int Result = (indexPlane + indexKey) % 26; 
                        REN.Text += alphates[Result];          

                    }
                    else

                        REN.Text += plan[i];  
                }
                ENC.Enabled = true;
            }
        }
    }
}
