using _20_Traffic_Light_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Traffic_Light_Project
{
    public partial class ctrlTrafficLight : UserControl
    {
        public ctrlTrafficLight()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        public class LightEventArgs : EventArgs
        {
            public string CurrentLight { set; get; }
            public int LightDuration { set; get; }
            public LightEventArgs(string currentLight, int lightDuration)
            {
                CurrentLight = currentLight;
                LightDuration = lightDuration;
            }
        }


        public event EventHandler<LightEventArgs> LightChanged;
        public void RaiseOnLightChanged()
        {
            RaiseOnLightChanged(new LightEventArgs(CurrentLight.ToString(), GetCurrentTime()));
        }

        protected virtual void RaiseOnLightChanged(LightEventArgs e)
        {
            LightChanged?.Invoke(this, e);
        }

        public enum enLight { Red = 1, Yellow = 2, Green = 3 };
        private enLight _CurrentLight = enLight.Red;

        public enLight CurrentLight
        {
            get { return _CurrentLight; }
            set
            {
                _CurrentLight = value;

                switch (_CurrentLight)
                {
                    case enLight.Red:
                        pictureBox1.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;
                    case enLight.Yellow:
                        pictureBox1.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        break;
                    case enLight.Green:
                        pictureBox1.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        break;
                }

            }
        }

        int _RedTime = 10;
        int _YellowTime = 5;
        int _GreenTime = 5;


        public int RedTime
        {
            get { return _RedTime; }
            set
            {
                _RedTime = value;
            }
        }

        public int GreenTime
        {
            get { return _GreenTime; }
            set
            {
                _GreenTime = value;
                
            }
        }

        public int YellowTime
        {
            get { return _YellowTime; }
            set
            {
                _YellowTime = value;
            }
        }

        private int GetCurrentTime()
        {
            switch (CurrentLight)
            {
                case enLight.Red:
                    return _RedTime;
                case enLight.Yellow:
                    return _YellowTime;
                case enLight.Green:
                    return _GreenTime;
                default:
                    return _RedTime;
            }
        }

        int CountDown;
        bool _IsFirstRun = true;
        public void StartTrafficLight()
        {
            CountDown = GetCurrentTime();

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountDown == 0)
            {
                SetNextColor();
            }

            if (CountDown > 0)
            {
                lblCountDown.Text = CountDown.ToString();
                CountDown--;

            }
        }



        private void SetNextColor()
        {
            
            switch (_CurrentLight)
            {
                case enLight.Red:
                    CurrentLight = enLight.Yellow;
                    CountDown = _YellowTime;
                    //raise event
                    break;
                case enLight.Yellow:
                    CurrentLight = enLight.Green;
                    CountDown = _GreenTime;
                    break;
                case enLight.Green:
                    CurrentLight = enLight.Red;
                    CountDown = _RedTime;
                    break;

            }
            //LightEventArgs e = new LightEventArgs(_CurrentLight.ToString());
            //LightChanged?.Invoke(this, e);

            RaiseOnLightChanged();
        }
    }
}
