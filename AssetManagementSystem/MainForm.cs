using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AssetManagementSystem;
using models;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private string p;

        public MainForm(string name)
        {
            InitializeComponent();
            p = name;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemForm Reg = new AddItemForm();
            this.Hide();
            Reg.Owner = this;
            //让新建的窗口不在任务栏显示并显示新窗口
            Reg.ShowDialog();
            //新建的窗口关闭后，再使原窗口可见
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectForm Reg = new SelectForm();
            this.Hide();
            Reg.Owner = this;
            //让新建的窗口不在任务栏显示并显示新窗口
            Reg.ShowDialog();
            //新建的窗口关闭后，再使原窗口可见
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageForm Reg = new ManageForm();
            this.Hide();
            Reg.Owner = this;
            //让新建的窗口不在任务栏显示并显示新窗口
            Reg.ShowDialog();
            //新建的窗口关闭后，再使原窗口可见
            this.Show();
        }

        private void onLoad(object sender, EventArgs e)
        {
            //连接数据库
            Accessor accessor = Accessor.Instance;
            //在数据库中查询输入用户名
            IList<Users> s = accessor.GetUsersByFirstname(this.p);
            if (s[0].role == "资产采购员")
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if (s[0].role == "部门经理")
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
           
        }

        public string username { get; set; }
    }
}
