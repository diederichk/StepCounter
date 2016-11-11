using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeAwareForms
{
    public partial class Page4 : Form
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page3 form = new Page3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            End form = new End();
            form.Show();
        }
    }
}
