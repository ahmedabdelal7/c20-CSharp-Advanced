namespace _20_Traffic_Light_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlTrafficLight1 = new ctrlTrafficLight();
            SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            ctrlTrafficLight1.CurrentLight = ctrlTrafficLight.enLight.Yellow;
            ctrlTrafficLight1.GreenTime = 5;
            ctrlTrafficLight1.Location = new Point(334, 128);
            ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            ctrlTrafficLight1.RedTime = 10;
            ctrlTrafficLight1.Size = new Size(93, 186);
            ctrlTrafficLight1.TabIndex = 0;
            ctrlTrafficLight1.YellowTime = 5;
            ctrlTrafficLight1.LightChanged += ctrlTrafficLight1_LightChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ctrlTrafficLight1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
    }
}
