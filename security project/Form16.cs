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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void DEC_Click(object sender, EventArgs e)
        {
          
            int key;
            
            if (!int.TryParse(ke.Text, out key)) 
            {
                MessageBox.Show("no vailded number");
                return;
            }

            string keyString = ke.Text.ToUpper();
            string ciperText = DE.Text.ToUpper();

           

            int cipherLength = ciperText.Length;
            List<List<int>> myList = new List<List<int>>();
            
            for(int i=0; i<keyString.Length;i++)
            {
                myList.Add(new List<int>()); 
            }

            int number = 0;
            for(int i=0;i<cipherLength;i++) 
            {
                if (number == keyString.Length)
                    number = 0;  

                myList[number].Add(i);
                number += 1;  


            }

            
            int counter = 0;
                char[] buffer = new char[cipherLength]; 
            
            for (int i =0; i<keyString.Length;i++) 
            {
                for(int j =0; j< myList[i].Count;j++) 
                {
                    
                    buffer[myList[Convert.ToInt32(keyString[i].ToString())][j]] = ciperText[counter];
                    counter+=1;
                

                }
            }
            RDE.Text = new string(buffer);
        }

        private void BA_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }
    }
 }


/*
 

 if (keyString.Length <= 1 || keyString.Length >= ciperText.Length)
                // لو المفتاح بيساوى واحد او اكبر من عدد الكلمات
            {
                MessageBox.Show("key not vailded");
                return;
            }
 
 */