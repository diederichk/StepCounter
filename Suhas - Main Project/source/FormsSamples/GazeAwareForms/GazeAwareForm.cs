//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

using EyeXFramework;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WMPLib;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GazeAwareForms
{
    public partial class GazeAwareForm : Form
    {

        public override Size MaximumSize { get; set; }

        public GazeAwareForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1932, 1092);
            var wordDelay = 305;
            var pageDelay = 1200;
            DoubleBuffered = true;

            // Add eye-gaze interaction behaviors to the panels on the form.
            // The panels should display a border when the user's gaze are on them.
            // Note that panel4 is nested inside panel2. This means that any time 
            // panel2 has the user's gaze, panel4 will too.
            Program.EyeXHost.Connect(behaviorMap);

            //  behaviorMap1.Add(panel3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 500 });

            behaviorMap.Add(once, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(upon, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });

            behaviorMap.Add(a, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(time, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(there, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(lived, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(a2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(lion, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(in1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(a3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(forest, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(one, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(day, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(after, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(a4, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(heavy, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(meal, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(it, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(was, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(sleeping, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(under, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(a5, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(tree, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });

            behaviorMap.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = pageDelay });
            behaviorMap.Add(button3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = pageDelay });

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnGaze(object sender, GazeAwareEventArgs e)
        {
          
            var label = sender as Label;
            var button = sender as Button;
    

        // Variables required to play sound
       // var audioURL = "C:\\Users\\diede\\Documents\\CS4630_MobileComputing\\StepCounter\\AudioFiles\\";
            var audioURL = "C:\\Users\\Suhas\\Desktop\\Suhas - Main Project\\AudioFiles\\";
            //var audioURL = "Audio\\";
            WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();


            if (label != null)
            {   
                if (e.HasGaze == true)
                {
                    label.ForeColor  = System.Drawing.Color.Red;
                    label.BackColor = System.Drawing.Color.Yellow;

                    myplayer.URL = audioURL + label.Text.ToLower() + ".mp3";
                    myplayer.controls.play();
                }
                else
                {
                    label.ForeColor = System.Drawing.Color.Black;
                    label.BackColor = System.Drawing.Color.White;
                    this.BackColor = System.Drawing.Color.White;
                }

            }

            if (button != null)
            {
                if (button.Text == "Next")
                {
                    if (e.HasGaze == true)
                    {
                        button1_Click(sender, e);
                    }
                }
                else if (button.Text == "Back")
                {
                    if (e.HasGaze == true)
                    {
                        button3_Click(sender, e);
                    }
                }

            }



        }

        private void button1_Click(object sender, EventArgs e)

        {
            //next button
            
           Page2 form = new Page2();
           form.Show();
           this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            form.Show();
            this.Hide();
        }
    }
}
