using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        int sayi;
        int s;
        int x;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Form f4 = new Form4();
            f4.Show();
            this.Hide();
            
            
        

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi++;
            label5.Text = sayi.ToString(); 


        }

        private void button4_Click(object sender, EventArgs e)
        {
            s++;
            label9.Text = s.ToString(); 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            x++;
            label10.Text = x.ToString(); 

        }
    }
}
