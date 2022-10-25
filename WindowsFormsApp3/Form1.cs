using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
            //sender.GetType();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
            tNode= treeView1.Nodes.Add("GCUF");

            treeView1.Nodes[0].Nodes.Add("Departments");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Computer Science");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Software Engineering");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Information Technology");

            ListBox mylist = new ListBox();
            mylist.Location = new Point(12, 12);
            mylist.Size = new Size(245, 200);

            ArrayList lst = new ArrayList();
            lst.Add("firstitem");
            lst.Add("seconditem");
            lst.Add("thirditem");
            //mylist.Items.Add("item1");
            //mylist.Items.Add("item2");
            mylist.DataSource = lst;
            this.Controls.Add(mylist);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.FullPath.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox2.Items.Add(listBox1.SelectedItem.ToString());
            StringBuilder sb = new StringBuilder();
            foreach(object item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item.ToString());
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            MessageBox.Show(sb.ToString());
            
            
        }
    }
}
