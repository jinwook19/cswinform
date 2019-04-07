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
    public partial class NameChange : Form
    {
        public NameChange()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            afterText.Text = "안녕하세요" + beforeText.Text;
        }
    }
}
