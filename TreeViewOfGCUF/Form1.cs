using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewOfGCUF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode CurrentNode = e.Node;
            string fullpath = CurrentNode.FullPath;
            MessageBox.Show(fullpath);
        }

        private void btn_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("GCUF");

            treeView1.Nodes[0].Nodes.Add("Faculty of Physical Sciences");
            treeView1.Nodes[0].Nodes.Add("Faculty of life Sciences");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Computer Science");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Software Engineering");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Information Technology");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Data Science");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Chemistry");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Physics");


            treeView1.Nodes[0].Nodes[1].Nodes.Add("Botany");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Zoology");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Microbiology");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("BioChemistry");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Bioinformatics and Biotechnology");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Food Science");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_click(object sender, EventArgs e)
        {
          
        }
    }
}
