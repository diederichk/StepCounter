using EyeXFramework;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Media;

namespace GazeAwareForms
{
    public partial class Page2 : GazeAwareForm
    {
        public Page2()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(behaviorMap2);

            behaviorMap2.Add(label1, new GazeAwareBehavior(OnGaze));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GazeAwareForm form = new GazeAwareForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page3 form = new Page3();
            form.Show();
        }




    }
}
