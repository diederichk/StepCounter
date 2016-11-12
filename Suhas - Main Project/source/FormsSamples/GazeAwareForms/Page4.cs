using EyeXFramework;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using GazeAwareForms;

namespace GazeAwareForms
{
    public partial class Page4 : Form
    {
        public Page4()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(behaviorMap3);

            //  behaviorMap1.Add(panel3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 500 });

            behaviorMap3.Add(label1, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label2, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label3, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label4, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label5, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label6, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label7, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label8, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label9, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label10, new GazeAwareBehavior(OnGaze));
            behaviorMap3.Add(label11, new GazeAwareBehavior(OnGaze));


            behaviorMap3.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });
            behaviorMap3.Add(button2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnGaze(object sender, GazeAwareEventArgs e)
        {

            var label = sender as Label;
            var button1 = sender as Button;
            var button2 = sender as Button;


            if (label != null)
            {
                if (e.HasGaze == true)
                {
                    label.ForeColor = System.Drawing.Color.Red;
                    label.BackColor = System.Drawing.Color.Yellow;

                    if (label.Text == "hello") //@"G:\Music\akon -Smack That.mp3"
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\chimes.wav");
                        player.Play();
                    }
                }
                else
                {
                    label.ForeColor = System.Drawing.Color.Black;
                    label.BackColor = System.Drawing.Color.White;
                    this.BackColor = System.Drawing.Color.White;
                }

            }

            if (button1 != null)
            {
                if (e.HasGaze == true)
                {
                    button1_Click(sender, e);
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
