using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BloccoNote_Mortara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getFolderPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + File.ReadAllText;
        }
        /*private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + File.ReadAllText;
        }*/
    }
}
