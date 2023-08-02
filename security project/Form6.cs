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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ba_Click(object sender, EventArgs e)
        {
            Form5 ba = new Form5();
            ba.Show();
            this.Hide();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            REN.Text = "";
            ke.Clear();
            EN.Text = "";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // Mono Alphates Encryption
        private void ENC_Click(object sender, EventArgs e)
        {

            string chUpper = EN.Text.ToUpper();  
             char[] plan = chUpper.ToCharArray();
            string key = ke.Text.ToUpper();
            

            if (EN.Text == "" || ke.Text == "") 
                MessageBox.Show("the field is empty");
            else
            {
               
                    for (int i = 0; i < EN.Text.Length; i++)
                    {
                        if (alphates.Contains(plan[i]))  
                        {
                            int indexPlane = alphates.IndexOf(plan[i]); 
                            REN.Text += key[indexPlane];         

                        }
                        else
                        
                            REN.Text += plan[i];  
                    }
                    ENC.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void REN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ke_TextChanged(object sender, EventArgs e)
        {

        }

        private void EN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
