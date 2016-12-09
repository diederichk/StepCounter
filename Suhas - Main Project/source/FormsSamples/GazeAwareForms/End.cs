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
            var button = sender as Button;
          
            if (button != null)
            {
                if (button.Text == "PlayAgain")
                {
                    if (e.HasGaze == true)
                    {
                        button3_Click(sender, e);
                    }
                }
                else if (button.Text == "Exit")
                {
                    if (e.HasGaze == true)
                    {
                        button2_Click(sender, e);
                    }
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            this.Hide();
            form.Show();
        }
    }
}
