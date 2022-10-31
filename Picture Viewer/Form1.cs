using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void oFD1_FileOk(object sender, CancelEventArgs e)
        {
            imageList1.Images.Clear();
            listView1.Clear();
            oFD1.InitialDirectory = "C:\\Users\\hp\\OneDrive\\Pictures\\Screenshots";
            oFD1.Title = "Open an Image File";
            oFD1.Filter = "JPEGS|*.jpg|GIFS|*.gif";
            var ofdResults = oFD1.ShowDialog();
            if (ofdResults == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            try
            {
                int num_of_files = oFD1.FileNames.Length;
                string[] aryFilePaths = new string[num_of_files];
                int counter = 0;
                foreach (string single_file in oFD1.FileNames)
                {
                    aryFilePaths[counter] = single_file;
                    counter++;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

        }
    }
}
