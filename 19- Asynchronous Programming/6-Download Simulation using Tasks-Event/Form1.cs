using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Simulation_using_Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 101;
            lblProgress.Text = "0%";

            DownloadCompleted += OnDownloadCompleted;

            btnEnd.Enabled = false;
        }

        //Cancellation Token
        private CancellationTokenSource _Cts;
        //Action Event.
        public event Action DownloadCompleted;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnEnd.Enabled = true;

            lblStatus.Text = "In Progress";
            lblProgress.Text = "0%";
            progressBar1.Value = 0;

            _Cts = new CancellationTokenSource();

            try
            {
                await SimulateDownloadAsync(_Cts.Token);

                lblStatus.Text = "Download Completed Successfully.";
            }
            catch (OperationCanceledException )
            {

                lblStatus.Text = "Download Cancelled";
            }
            finally
            {
                btnStart.Enabled = true;
                btnEnd.Enabled = false;

                _Cts.Dispose();
                _Cts=null;
            }
        }

        private async Task SimulateDownloadAsync(CancellationToken token)
        {
            for (int p = 0; p <= 100; p++)
            {
                token.ThrowIfCancellationRequested();

                await Task.Delay(10);

                progressBar1.Value++;

                lblProgress.Text = p.ToString()+"%";
            }
            DownloadCompleted?.Invoke();
        }


        private void OnDownloadCompleted()
        {
            notifyIcon1.Icon = SystemIcons.Information;
            //notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(
                10000,
                "Download Status",
                "Download Completed!",
                ToolTipIcon.Info
            );
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            _Cts.Cancel();
        }

    }
}
