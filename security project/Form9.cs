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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        string alphates = "ABCDEFGHIKLMNOPQRSTUVWXYZ";

       
        private void button1_Click(object sender, EventArgs e)
        {

            if (EN.Text == "" || ke.Text == "")
                MessageBox.Show("the field is empty");
            else
            {

                string chupper = EN.Text.ToUpper() + " "; 
                chupper = chupper.Replace("J", "I");   
             
                for (int i = 0; i < chupper.Length; i += 2)
                {
                    if (alphates.Contains(chupper[i]))
                    {
                        if (!alphates.Contains(chupper[i + 1]))  
                        {
                            chupper = chupper.Insert(i + 1, "X");
                        }

                        if (chupper[i] == chupper[i + 1]) 
                        {
                            chupper = chupper.Insert(i + 1, "X");
                        }

                        int RowChar1 = 0;
                        int columChar1 = 0;
                        int Rowchar2 = 0;
                        int columChar2 = 0; ;

                        for (int R = 0; R < 5; R++) 
                        {

                            for (int c = 0; c < 5; c++) 
                            {
                                if (daTable.Rows[R].Cells[c].Value.ToString() == Convert.ToString(chupper[i]))
                      
                                {
                                    RowChar1 = R;  
                                    columChar1 = c; 
                                }
                                if (daTable.Rows[R].Cells[c].Value.ToString() == Convert.ToString(chupper[i + 1]))
                                {
                                
                                    Rowchar2 = R;
                                    columChar2 = c;
                                }
                            }
                        }

                        if (RowChar1 == Rowchar2)
                           
                        {
                            REN.Text += daTable.Rows[RowChar1].Cells[(columChar1 + 1)%5].Value.ToString();
                            REN.Text += daTable.Rows[Rowchar2].Cells[(columChar2 + 1)%5].Value.ToString();
                            
                           

                        }
                        else if (columChar1 == columChar2)
                        {
                           
                            REN.Text += daTable.Rows[(RowChar1 + 1)%5].Cells[columChar1].Value.ToString();
                            REN.Text += daTable.Rows[(Rowchar2 + 1)%5].Cells[columChar1].Value.ToString();


                        }

                        else
                        {
                            REN.Text += daTable.Rows[RowChar1].Cells[columChar2].Value.ToString();
                            REN.Text += daTable.Rows[Rowchar2].Cells[columChar1].Value.ToString();
                           
                        }

                    }
                    else
                    {
                        REN.Text += chupper[i]; 
                        i--;
                    }
                }

            }

        }



       

            private void button2_Click(object sender, EventArgs e)
            {
            Form8 f1 = new Form8();
            f1.Show();
            this.Hide();
            }



       
        private void ke_TextChanged(object sender, EventArgs e)
        { // جدول التشفير التلقائى عشان لما نكتب كلمه يكون جدول البلايفير
            if (ke.Text == "")
            {
                daTable.DataSource = null;  // لو مفيش مفتاح ميعرضش حاجه فى الجدول
            }
            else
            {
                string key = ke.Text.ToUpper();  
                key = key.Replace('J', 'I');    
             
                for(int i=0; i < key.Count() ; i++)
                {
                    for(int j=i+1; j<key.Count();j++) 
                    {
                        if (key[i]==key[j]) 
                        {
                            key = key.Remove(j, 1); 
                            j--; 
                        }

                    }
                }
               
               
                for (int i=0; i<25; i++)
                {
                    if (key.Contains(alphates[i]))
                        continue; 
                    else
                    {
                        key = key + alphates[i];
                   
                    }

                }
                List <string[] > list= new List<string[]>(); 
                for (int i=0; i<25; i+=5)   
                {
                    list.Add( new string[] { Convert.ToString(key[i]), Convert.ToString(key[i + 1]), Convert.ToString(key[i + 2]), Convert.ToString(key[i + 3]), Convert.ToString(key[i + 4]) });

                }

                DataTable table = ConvertToDataTable(list); 
                daTable.DataSource = table; 


            }
            
        }

        
        static DataTable ConvertToDataTable(List<string[]> list) 
        {

            DataTable table = new DataTable(); 
            int columns = 0;
            foreach(var array in  list) 
            {
                if(array.Length > columns)
                {
                    columns = array.Length;

                }

            }
            for(int i=0; i< columns; i++)
            {
                table.Columns.Add();

            }

            foreach(var array in list)
            {
                table.Rows.Add(array);
            }
            return table;
        }
       
        private void daTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CL_Click(object sender, EventArgs e)
        {
            REN.Text = "";
            ke.Clear();
            EN.Text = "";
        }
    }
}






/*
 
  public static int mod(int x, int y)
        {
            return x - (int)Math.Floor((double)x / y) * y;
            
        }

 */













