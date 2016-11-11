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
    public partial class Page3 : Form
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page2 form = new Page2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page4 form = new Page4();
            form.Show();
        }
    }
}
