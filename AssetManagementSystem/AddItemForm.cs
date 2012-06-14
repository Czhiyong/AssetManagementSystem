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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accessor accessor = Accessor.Instance;
            assetimformation ainformation = new assetimformation
            {
               
                name = this.textBox1.Text,
                buydate = this.textBox2.Text,
                sort = this.comboBox1.Text,
                amount = Convert.ToInt32(this.textBox3.Text),
                price = Convert.ToInt32(this.textBox4.Text),
                safedepartment = this.textBox5.Text,
                safeplace = this.textBox6.Text,
                usedepatment = this.textBox7.Text ,
                depreciation = this.textBox8.Text
            };
            accessor.Createassetimformation(ainformation);
            this.label10.Text = "资产信息已经成功保存";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.textBox1.Clear();
            this.textBox2.Clear();
            this.comboBox1.Text = "";
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.label10.Text = "";
        }
    }
}
