//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

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
    public partial class GazeAwareForm : Form
    {
        
        public GazeAwareForm()
        {
            InitializeComponent();

            // Add eye-gaze interaction behaviors to the panels on the form.
            // The panels should display a border when the user's gaze are on them.
            // Note that panel4 is nested inside panel2. This means that any time 
            // panel2 has the user's gaze, panel4 will too.
            Program.EyeXHost.Connect(behaviorMap1);
         
          //  behaviorMap1.Add(panel3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 500 });
           
            behaviorMap1.Add(once, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(upon, new GazeAwareBehavior(OnGaze));

            behaviorMap1.Add(a, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(time, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(there, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(lived, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(a2, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(lion, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(in1, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(a3, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(forest, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(one, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(day, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(after, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(a4, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(heavy, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(meal, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(it, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(was, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(sleeping, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(under, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(a5, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(tree, new GazeAwareBehavior(OnGaze));

            behaviorMap1.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var panel = sender as Panel;
            var label = sender as Label;
            var button1 = sender as Button;
            if (panel != null )
            {
                panel.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;
               
            }

            if (label != null)
            {   
                if (e.HasGaze == true)
                {
                    label.ForeColor  = System.Drawing.Color.Red;
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
                    button1_Click(sender,e);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Close();


            Page2 form = new Page2();
            form.Show();
        }

    }
}
