using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Task.Run
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelChanged += OnLabelChanged;
        }

        public class CustomEventArgs : EventArgs
        {
            public string Text { get; }
            public int ThreadID { get; }

            public CustomEventArgs(string text, int threadID)
            {
                Text = text;
                ThreadID = threadID;
            }
        }

        public event EventHandler<CustomEventArgs> LabelChanged;

        private async void btn1_Click(object sender, EventArgs e)
        {

            await ChangeLabel("Hello From UI Thread: ", Thread.CurrentThread.ManagedThreadId);

            MessageBox.Show("Done!");
        }

        private async Task ChangeLabel(string Text, int ThreadID)
        {
            await Task.Delay(5000);
            
            lblText.Text = Text+ThreadID;

            CustomEventArgs e = new CustomEventArgs(Text, ThreadID);

            LabelChanged?.Invoke(this,e);// raise event
        }

        private void OnLabelChanged(object sender, CustomEventArgs e)
        {
            MessageBox.Show($"Label Changed To:\n[{e.Text}{e.ThreadID}]");

            BackColor = Color.Yellow;
        }
    }
}
