using EyeXFramework;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WMPLib;
using System;
using System.Drawing;

namespace GazeAwareForms
{
    public partial class End : Form
    {
        public override Size MaximumSize { get; set; }
        public End()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1932, 1092);
            var pageDelay = 1200;
            DoubleBuffered = true;
            Program.EyeXHost.Connect(behaviorMap);
            behaviorMap.Add(button2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = pageDelay });
            behaviorMap.Add(button3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = pageDelay });

        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
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
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GazeAwareForm form = new GazeAwareForm();
            this.Hide();
            form.Show();
        }
    }
}
