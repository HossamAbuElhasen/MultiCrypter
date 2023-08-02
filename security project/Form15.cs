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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }


      
        private void ENC_Click(object sender, EventArgs e)
        {
            
       
            int key;
           
            if (!int.TryParse(ke.Text, out key))   
            {

                MessageBox.Show("the key should contian number");

            }

            string keyString = ke.Text.ToUpper();     
            string planText = EN.Text.ToUpper();
            Random r = new Random(); 

            while (planText.Length % keyString.Length !=0)  

            {
                planText += r.Next(0, 9); 
            }

          
        

           
            List<string> myList = new List<string>();
            for (int i = 0; i < keyString.Length; i++) 
            {

                myList.Add(""); 
            }

            int number = 0;
            foreach (char c in planText) 
            {
                if (number == keyString.Length)
                
                    number = 0; 

                    myList[number] += c;
                    number += 1; 
                
            }

            string Result = "";
     
            for (int i=0;i<keyString.Length;i++ )
            {


                Result += myList[Convert.ToInt32(keyString[i].ToString())];
          

            }
            REN.Text = Result;
        }

  
        private void ba_Click(object sender, EventArgs e)
        {
            Form14 f1 = new Form14();
            f1.Show();
            this.Hide();
        }
    }
}

/*
 
  

  if (keyString.Length <= 1 || keyString.Length >= planText.Length)
            // لو المفتاح بيساوى واحد او اكبر من عدد الكلمات
            {
                MessageBox.Show("key not vailded");
                return;
            }

 
 */