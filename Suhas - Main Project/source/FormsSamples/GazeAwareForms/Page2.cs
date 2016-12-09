using EyeXFramework;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WMPLib;
using System;


namespace GazeAwareForms
{
   
    public partial class Page2 : Form 
    {
        public Page2()
        { 
         
            InitializeComponent();
            var wordDelay = 305;
            var pageDelay = 1200;
            DoubleBuffered = true;

            //button2.Hide();
            Program.EyeXHost.Connect(behaviorMap);

            behaviorMap.Add(label1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label3, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label4, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label5, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label6, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label7, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label8, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label9, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label10, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label11, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label12, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label13, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label14, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label15, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label16, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label17, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label18, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label19, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label20, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label21, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label22, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label23, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label24, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label25, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label26, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label27, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label28, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label29, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label30, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(label31, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = wordDelay });
            behaviorMap.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = pageDelay });
            behaviorMap.Add(button2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });

        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }


        public void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var label = sender as Label;
            var button = sender as Button;

        //            var button2 = sender as Button;

            var audioURL = "C:\\Users\\Suhas\\Desktop\\Suhas - Main Project\\AudioFiles\\";
            WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();

            if (label != null)
            {
                if (e.HasGaze == true)
                {
                    label.ForeColor = System.Drawing.Color.Red;
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
                if (button.Text == "Back")
                {
                    if (e.HasGaze == true)
                    {
                        button1_Click(sender, e);
                    }
                }
                else if (button.Text == "Next")
                {
                    if (e.HasGaze == true)
                    {
                        button2_Click(sender, e);
                    }
                }

            }

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            GazeAwareForm form = new GazeAwareForm();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page3 form = new Page3();
            this.Hide();
            form.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GazeAwareForm form = new GazeAwareForm();
            this.Hide();
            form.Show();
        }
    }
}
