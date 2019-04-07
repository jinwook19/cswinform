using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FormTemp
{

    public partial class Aif : Form
    {
        int result = 0; //전역

        public Aif()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int result = 1; //지역
            result = result + 1;
            MessageBox.Show(result.ToString());
            textBox1.Text = "진욱";
            textBox2.Text = "오성";
            textBox3.Text = "상현";
            textBox4.Text = "준범";
            textBox5.Text = "태섭";

            if(result == 3)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "상현";
                textBox4.Text = "";
                textBox5.Text = "";
                        
            }
            if (result == 4)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "준범";
                textBox5.Text = "";

            }
            if (result == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "태섭";

            }
            if (result == 1)
            {
                textBox1.Text = "진욱";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            if (result == 2)
            {
                textBox1.Text = "";
                textBox2.Text = "오성";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }


























        }       
    }
}