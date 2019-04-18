using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("새로설치");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Int32 result = Convert.ToInt32(textKorean.Text) + Convert.ToInt32(textEnglish.Text) + Convert.ToInt32(textMath.Text);
            MessageBox.Show(Convert.ToString(result));
            textAverage.Text = Convert.ToString(result / 3);


        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("합계");
            tbsum.Text = textKorean.Text;

        }
    }
}
