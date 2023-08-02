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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ba_Click(object sender, EventArgs e)
        {
            Form11 f1 = new Form11();
            f1.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            RDE.Text = "";
            ke.Clear();
            DE.Text = "";
        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

      

        private void DEC_Click(object sender, EventArgs e)
        {


            string chUpper = DE.Text.ToUpper();
            char[] plan = chUpper.ToCharArray();
            string key = ke.Text.ToUpper();
            char chKey;
            if (DE.Text == "" || ke.Text == "")  
                MessageBox.Show("the field is empty");
            else
            {

                for (int i = 0; i < DE.Text.Length; i++)
                {
                    if (alphates.Contains(plan[i])) 
                    {
                        chKey = key[i % key.Length];

                        int indexPlane = alphates.IndexOf(plan[i]); 
                        int indexKey = alphates.IndexOf(chKey);
                        int Result = (indexPlane - indexKey) % 26;
                        if (Result < 0)
                        {
                            Result += 26;
                        }
                        RDE.Text += alphates[Result];         

                    }
                    else
                    {

                        RDE.Text += plan[i];  
                    }
                }
                DEC.Enabled = true;
            }

        }
    }
}
