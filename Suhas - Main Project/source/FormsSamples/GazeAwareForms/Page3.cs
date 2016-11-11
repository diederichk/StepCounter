using EyeXFramework;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System;


namespace GazeAwareForms
{
    public partial class Page3 : Form
    {
        public Page3()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(behaviorMap);

            behaviorMap.Add(label1, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label2, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label3, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label4, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label5, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label6, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label7, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label8, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label9, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label10, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label11, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label12, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label13, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label14, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label15, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label16, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label17, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label18, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label19, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label20, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label21, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label22, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label23, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label24, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label25, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label26, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label27, new GazeAwareBehavior(OnGaze));
            behaviorMap.Add(label28, new GazeAwareBehavior(OnGaze));


            behaviorMap.Add(button1, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });
            behaviorMap.Add(button2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 1200 });

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
            Page2 form = new Page2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page4 form1 = new Page4();
            form1.Show();
        }
    }
}
