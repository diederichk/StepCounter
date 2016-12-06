using EyeXFramework;
using System.Windows.Forms;
using WMPLib;
using System;

namespace GazeAwareForms
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();

            Program.EyeXHost.Connect(behaviorMap);
        }

        public void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var button3 = sender as Button;
            var button2 = sender as Button;

            if (button3 != null)
            {
                if (e.HasGaze == true)
                {
                    button3_Click(sender, e);
                }

            }

            if (button2 != null)
            {
                if (e.HasGaze == true)
                {
                    button2_Click(sender, e);
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GazeAwareForm form = new GazeAwareForm();
            this.Hide();
            form.Show();
        }
    }
}
