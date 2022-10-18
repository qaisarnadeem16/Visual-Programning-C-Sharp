using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_click(object sender, EventArgs e)
        {
            MessageBox.Show("this is first message","message",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
            
        }
    }
}
