namespace _21_Pool_Club_Project
{
    partial class ctrlPoolTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpTable = new GroupBox();
            pictureBox1 = new PictureBox();
            lblTime = new Label();
            lblName = new Label();
            btnEnd = new Button();
            btnStartStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpTable
            // 
            grpTable.Controls.Add(pictureBox1);
            grpTable.Controls.Add(lblTime);
            grpTable.Controls.Add(lblName);
            grpTable.Controls.Add(btnEnd);
            grpTable.Controls.Add(btnStartStop);
            grpTable.Location = new Point(3, 3);
            grpTable.Name = "grpTable";
            grpTable.Size = new Size(454, 316);
            grpTable.TabIndex = 0;
            grpTable.TabStop = false;
            grpTable.Text = "Table";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.billiard;
            pictureBox1.Location = new Point(29, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(29, 267);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(227, 33);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(29, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(227, 33);
            lblName.TabIndex = 1;
            lblName.Text = "Player1";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(308, 169);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 42);
            btnEnd.TabIndex = 0;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(308, 107);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(98, 42);
            btnStartStop.TabIndex = 0;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ctrlPoolTable
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            Controls.Add(grpTable);
            Name = "ctrlPoolTable";
            Size = new Size(465, 331);
            grpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTable;
        private PictureBox pictureBox1;
        private Label lblName;
        private Button btnEnd;
        private Button btnStartStop;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
