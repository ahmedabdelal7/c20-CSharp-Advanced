namespace _21_Pool_Club_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }



        private void OnPoolTableEnded(object sender, ctrlPoolTable.TableCompletedEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\n" +
               $"Total Seconds: {e.TimeInSeconds}\n" +
               $"Hourly Rate: {e.RatePerHour}\n" +
               $"Total Fees: {e.TotalFees}");
        }
    }
}
