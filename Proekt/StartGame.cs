using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    public partial class StartGame : Form
    {
        Form1 form1;
        public StartGame()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

    }
           
}
