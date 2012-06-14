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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void onLoad(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实现对表格的查询，并且显示在listview中
            Accessor accessor = Accessor.Instance;
            IList<assetimformation> s = accessor.GetAssetByDepartmentname(this.comboBox1.Text);
            this.listView1.View = View.Details;

        }
    }
}
