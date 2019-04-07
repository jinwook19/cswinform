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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 result = Convert.ToInt32(textKorean.Text) + Convert.ToInt32(textEnglish.Text) + Convert.ToInt32(textMath.Text);
                MessageBox.Show(Convert.ToString(result));
                textAverage.Text = Convert.ToString(result / 3);
            }
            catch (Exception exception)
            {
                if (exception.Message == "입력 문자열의 형식이 잘못되었습니다.")
                {
                    MessageBox.Show("숫자값을 입력하세요");
                    Console.WriteLine();

                }
                else
                {
                    MessageBox.Show(exception.Message);

                }

            }

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
