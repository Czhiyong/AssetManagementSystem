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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //对登陆进行判断，如果用户和密码正确，进入主界面，若其中一个错误，则弹出相应错误提示
        private void button1_Click(object sender, EventArgs e)
        { 
             Accessor accessor = Accessor.Instance;
            //在数据库中查询输入用户名
             IList<Users> s = accessor.GetUsersByFirstname(textBox1.Text);
            //判断数据库中用户名是否存在
             if (s.Count != 0)    
                 //如果用户名存在，则判断密码是否正确
                 if (s[1].password.ToString() == textBox2.Text)
                 {                
                     //密码正确，将原窗口隐藏，显示新的窗口
                     MainForm Reg = new MainForm();
                     this.Hide();
                     Reg.Owner = this;
                     //让新建的窗口不在任务栏显示并显示新窗口
                     Reg.ShowDialog();
                     //新建的窗口关闭后，再使原窗口可见
                     this.Show();
                 }
                 else
                 {
                     this.errorProvider1.SetError(textBox2, "输入密码错误");

                 }
             else {
                 this.errorProvider1.SetError(textBox1, "输入用户名不存在");
             }
                 

               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rform = new RegisterForm();
            this.Hide();
            rform.Owner = this;
            //让新建的窗口不在任务栏显示并显示新窗口
            rform.ShowDialog();
            //新建的窗口关闭后，再使原窗口可见
            this.Show();
        }
    }
}
