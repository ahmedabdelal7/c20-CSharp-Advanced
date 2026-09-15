using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Pool_Club_Project
{
    public partial class ctrlPoolTable : UserControl
    {
        public ctrlPoolTable()
        {
            InitializeComponent();
        }

        public class TableCompletedEventArgs : EventArgs
        {
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }

            public TableCompletedEventArgs(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
            {
                this.TimeText = TimeText;
                this.TimeInSeconds = TimeInSeconds;
                this.RatePerHour = RatePerHour;
                this.TotalFees = TotalFees;
            }
        }

        public event EventHandler<TableCompletedEventArgs> OnTableComplete;

        public void RaiseOnTableComplete(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
        {
            RaiseOnTableComplete(new TableCompletedEventArgs(TimeText, TimeInSeconds, RatePerHour, TotalFees));
        }

        protected virtual void RaiseOnTableComplete(TableCompletedEventArgs e)
        {
            OnTableComplete?.Invoke(this, e);
        }


        int _Seconds;

        // Private data member that backs the EndColor property.  
        private string _TableTitle = "Table";


        // The Category attribute tells the designer to display  
        // it in the Flash grouping.
        // The Description attribute provides a description of  
        // the property.
        [
        Category("Pool Config"),
        Description("The table Name.")
        ]
        // The public property EndColor accesses endColor.  
        public string TableTitle
        {
            get
            {
                return _TableTitle;
            }
            set
            {
                _TableTitle = value;

                grpTable.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        private string _TablePlayer = "Player";
        [
        Category("Pool Config"),
        Description("The Player Name.")
        ]

        public string TablePlayer
        {
            get
            {
                return _TablePlayer;
            }
            set
            {
                _TablePlayer = value;

                lblName.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        private float _HourlyRate = 10.00F;

        [
        Category("Pool Config"),
        Description("Rate Per Hour.")
        ]
        public float HourlyRate
        {
            get
            {
                return _HourlyRate;
            }
            set
            {
                _HourlyRate = value;

            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;

            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lblTime.Text = str;
            lblTime.Refresh();
        }

        private void PoolTable_Load(object sender, EventArgs e)
        {
            grpTable.Text = _TableTitle;
            lblName.Text = _TablePlayer;

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            float TotalFees = ((float)_Seconds / 60 / 60) * _HourlyRate;
            RaiseOnTableComplete(lblTime.Text, _Seconds, _HourlyRate, TotalFees);
            grpTable.Text = "Table";
            lblName.Text = "Player";
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _Seconds = 0;


        }

    }
}

//My Solution:
/*
 
    int SecondsCounter = 0;
    double _HourlyRate = 10;
    double _TotalFees = 0.0;

    [Category("Pool Config"), Description("Hourly Rate")]
    public double HourlyRate
    {
        get { return _HourlyRate; }
        set
        {
            _HourlyRate = value;

        }
    }

    [Category("Pool Config"), Description("Player Name")]
    public string TablePlayer
    {
        get
        {
            return lblName.Text;
        }
        set
        {
            lblName.Text = value;
        }
    }

    [Category("Pool Config"), Description("Table Title")]
    public string TableTitle
    {
        get
        {
            return grpTable.Text;
        }
        set
        {
            grpTable.Text = value;
        }
    }

    public class PoolTableEventArgs : EventArgs
    {
        public string TimeConsumed { get; set; }
        public int TotalSeconds { get; set; }
        public double HourlyRate { get; set; }
        public double TotalFees { get; set; }

        public PoolTableEventArgs(string timeConsumed, int totalSeconds, double hourlyRate, double totalFees)
        {
            TimeConsumed = timeConsumed;
            TotalSeconds = totalSeconds;
            HourlyRate = hourlyRate;
            TotalFees = totalFees;
        }
    }


    public event EventHandler<PoolTableEventArgs> PoolTableEnd;

    public void OnPoolTableEnd(string timeConsumed, int totalSeconds, double hourlyRate, double totalFees)
    {
        OnPoolTableEnd(new PoolTableEventArgs(timeConsumed, totalSeconds, hourlyRate, totalFees));
    }

    protected virtual void OnPoolTableEnd(PoolTableEventArgs e)
    {
        PoolTableEnd?.Invoke(this, e);
    }


    enum enTableStatus { Start, Stop };
    enTableStatus _TableStatus = enTableStatus.Start;

    private enTableStatus TableStatus
    {
        set
        {
            _TableStatus = value;
            btnStartStop.Text = _TableStatus.ToString();
        }
        get
        {
            return _TableStatus;
        }
    }

    private void btnStartStop_Click(object sender, EventArgs e)
    {

        if (TableStatus == enTableStatus.Start)
        {
            TableStatus = enTableStatus.Stop;
            //Stop The Timer
            timer1.Start();
        }
        else
        {
            TableStatus = enTableStatus.Start;
            btnStartStop.Text = TableStatus.ToString();

            //Stop The Timer
            timer1.Stop();
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        //lblElapsedTime.Text = 
        SecondsCounter++;
        lblTime.Text = TimeToText(SecondsCounter);

    }

    private string TimeToText(int TotalSeconds)
    {
        int seconds = TotalSeconds % 60;
        int minutes = (TotalSeconds / 60) % 60;
        int hours = (TotalSeconds / 60 / 60) % 60;

        return $"{(hours < 10 ? "0" : "")}{hours}" +
            $":{(minutes < 10 ? "0" : "")}{minutes}" +
            $":{(seconds < 10 ? "0" : "")}{seconds}";
    }

    private void btnEnd_Click(object sender, EventArgs e)
    {
        timer1.Stop();

        _TotalFees = (SecondsCounter / 60.0 / 60.0) * HourlyRate;

        //TimeToText(SecondsCounter), SecondsCounter, HourlyRate, _TotalFees)
        OnPoolTableEnd(TimeToText(SecondsCounter),SecondsCounter,HourlyRate,_TotalFees);

        ResetTable();
    }

    private void ResetTable()
    {
        lblTime.Text = "00:00:00";
        SecondsCounter = 0;
        _TotalFees = 0;
        TableStatus = enTableStatus.Start;
    }

*/