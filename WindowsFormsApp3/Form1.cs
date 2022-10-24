using System;
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

        }
    }
}
