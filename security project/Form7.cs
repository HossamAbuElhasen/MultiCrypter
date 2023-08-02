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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void ba_Click(object sender, EventArgs e)
        {
            Form5 ba = new Form5();
            ba.Show();
            this.Hide();
        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // Mono alphates Decryption xnyahpogzqwbtsflrcvmuekjdi
        private void DEC_Click(object sender, EventArgs e)
        {
            string ciperText = DE.Text.ToUpper(); 
            string key = ke.Text.ToUpper();
            if(DE.Text == "" || ke.Text == "")
            {
                MessageBox.Show("the field is empty");
            }
            else
            {
                for (int i=0; i<ciperText.Length;i++) 
                {
                    if (alphates.Contains(ciperText[i]))
                    {
                        int indexCiper = key.IndexOf(ciperText[i]); 
                        RDE.Text += alphates[indexCiper]; 
                    }
                    else
                        RDE.Text += ciperText[i]; 
                    
                }
            }
        }
        private void CL_Click(object sender, EventArgs e)  
        {
            DE.Text = "";  
            ke.Clear();
            RDE.Text = "";
        }
        private void ke_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
