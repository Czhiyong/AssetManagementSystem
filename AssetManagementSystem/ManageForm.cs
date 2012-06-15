using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using models;

namespace AssetManagementSystem
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //实现对表格的查询，并且显示在listview中
            Accessor accessor = Accessor.Instance;
            IList<assetimformation> s = accessor.GetAssetByDepartmentname(this.comboBox1.Text);
            //      this.listView1.View = View.Details;


            listView1.Columns.Clear();
            listView1.Items.Clear();
            this.listView1.GridLines = true;
            this.listView1.View = View.Details;
            this.listView1.Scrollable = true;
            listView1.Columns.Add("资产名称");
            listView1.Columns.Add("单价");
            listView1.Columns.Add("保管部门");

            //assetimformation product = accessor.GetAssetByDepartmentname(this.listBox1.SelectedItem.ToString());
            foreach (assetimformation ss in s)
            {
                ListViewItem li = new ListViewItem();
                li.SubItems[0].Text = ss.name;
                li.SubItems.Add(ss.price.ToString());
                li.SubItems.Add(ss.safedepartment);
                listView1.Items.Add(li);
            }
        }
    }
}
