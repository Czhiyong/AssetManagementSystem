using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using models;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
             Accessor accessor = Accessor.Instance;
             IList<Users> s = accessor.GetUsersByFirstname(textBox1.Text);
             if (s[1].password.ToString() == textBox2.Text)
             {
                 //判断角色进入主页
             }

               
        }
    }
}
