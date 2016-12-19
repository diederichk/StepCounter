using EyeXFramework;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WMPLib;
using System;

namespace GazeAwareForms
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            
            var pageDelay = 1200;
            // Add eye-gaze interaction behaviors to the panels on the form.
            // The panels should display a border when the user's gaze are on them.
            // Note that panel4 is nested inside panel2. This means that any time 
            // panel2 has the user's gaze, panel4 will too.
            Program.EyeXHost.Connect(behaviorMap);
            behaviorMap.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = pageDelay });
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var button1 = sender as Button;


            var audioURL = "C:\\Users\\Suhas\\Desktop\\Suhas - Main Project\\AudioFiles\\";
            //var audioURL = "Audio\\";
            WindowsMediaPlayer myplayer = new WMPLib.WindowsMediaPlayer();


            if (button1 != null)
            {
                if (e.HasGaze == true)
                {
                    button1_Click(sender, e);
                }

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            GazeAwareForm form = new GazeAwareForm();
            form.Show();
            this.Hide();
        }
    }
}
