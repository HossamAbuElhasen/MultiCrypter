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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void DEC_Click(object sender, EventArgs e)
        {
            if (DE.Text == "" || ke.Text == "")
                MessageBox.Show("the field is empty");
            else
            {
                string chUpper = DE.Text.ToUpper(); 
                char[] ciper = chUpper.ToCharArray(); 
                for (int i = 0; i < ciper.Length; i++)  
                {
                    if (alphates.Contains(ciper[i]))  
                    {

                        int ciperNUM = alphates.IndexOf(ciper[i]); 
                      
                        ciperNUM = (ciperNUM - Convert.ToInt32(ke.Text))%26 ;
                      
                        if (ciperNUM < 0) 
                        {
                            ciperNUM = 26 + ciperNUM; 
                        }

                        RDE.Text += alphates[ciperNUM];  
                    }

                    else
                    {
                        RDE.Text += ciper[i];  
                    }
                }


            }
        }

        private void CL_Click(object sender, EventArgs e)
        {
            DE.Text = "";
            ke.Clear();
            RDE.Text = "";
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
