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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string alphates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void ENC_Click(object sender, EventArgs e)
        {

            if (EN.Text == "" || ke.Text == "") 
                MessageBox.Show("the field is empty");
            else
            {
                string chUpper = EN.Text.ToUpper(); 
                char[] plan = chUpper.ToCharArray(); 
                for (int i = 0; i < plan.Length; i++) 
                {
                    if (alphates.Contains(plan[i])) 
                    {
                        int planNUM = alphates.IndexOf(plan[i]); 
                       

                        REN.Text += alphates[(planNUM + Convert.ToInt32(ke.Text)) % 26];
                        
                    }
                    else
                    {
                        ENC.Text += plan[i]; 
                    }
                }
                ENC.Enabled = true;

            }

        }

        private void CL_Click(object sender, EventArgs e)
        {
            REN.Text = "";
            ke.Clear();
            EN.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
