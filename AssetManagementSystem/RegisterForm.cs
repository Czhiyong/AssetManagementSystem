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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accessor accessor = Accessor.Instance;
            Users user = new Users
            {
                name = this.textBox1.Text,
                role = comboBox1.Text,
                password = Convert.ToInt32(textBox3.Text),
                email = textBox4.Text
            };
            accessor.CreateUser(user);
            this.Close();
        }
    }
}

