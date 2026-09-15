using System.Diagnostics.Metrics;

namespace _20_Traffic_Light_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.ctrlTrafficLight1.StartTrafficLight();
            //ctrlTrafficLight1.LightChanged += OnLightChanged;

        }

        //private void OnLightChanged(object sender, ctrlTrafficLight.LightEventArgs e)
        //{
        //    MessageBox.Show(e.CurrentLight);
        //}

        private void ctrlTrafficLight1_LightChanged(object sender, ctrlTrafficLight.LightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight);
        }
    }
}
