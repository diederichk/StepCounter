//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

using EyeXFramework;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WMPLib;
using System;



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
            Program.EyeXHost.Connect(behaviorMap);

            //  behaviorMap1.Add(panel3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 500 });

            behaviorMap.Add(once, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(upon, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });

            behaviorMap.Add(a, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(time, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(there, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(lived, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(a2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(lion, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(in1, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(a3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(forest, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(one, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(day, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(after, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(a4, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(heavy, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(meal, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(it, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(was, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(sleeping, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(under, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(a5, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 150 });
            behaviorMap.Add(tree, new GazeAwareBehavior(OnGaze));

            behaviorMap.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnGaze(object sender, GazeAwareEventArgs e)
        {
          
            var label = sender as Label;
            var button1 = sender as Button;

            // Variables required to play sound
            var audioURL = "C:\\Users\\diede\\Documents\\CS4630_MobileComputing\\StepCounter\\AudioFiles\\";
            WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();


            if (label != null)
            {   
                if (e.HasGaze == true)
                {
                    label.ForeColor  = System.Drawing.Color.Red;
                    label.BackColor = System.Drawing.Color.Yellow;

                    if (label.Text == "Once") 
                    {
                        myplayer.URL = audioURL + "once.mp3";
                        myplayer.controls.play();
                    }
                    if (label.Text == "upon")
                    {
                        myplayer.URL = audioURL + "upon.mp3";
                        myplayer.controls.play();
                    }
                    if (label.Text == "a")
                    {
                        myplayer.URL = audioURL + "ah.mp3";
                        myplayer.controls.play();
                    }
                    if (label.Text == "time")
                    {
                        myplayer.URL = audioURL + "time.mp3";
                        myplayer.controls.play();
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
           Page2 form = new Page2();
           form.Show();
           this.Hide();
            
        }
    }
}
