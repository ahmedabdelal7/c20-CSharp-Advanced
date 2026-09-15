namespace _21_Pool_Club_Project
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
            ctrlPoolTable1 = new ctrlPoolTable();
            ctrlPoolTable2 = new ctrlPoolTable();
            ctrlPoolTable3 = new ctrlPoolTable();
            ctrlPoolTable4 = new ctrlPoolTable();
            SuspendLayout();
            // 
            // ctrlPoolTable1
            // 
            ctrlPoolTable1.BackColor = Color.MintCream;
            ctrlPoolTable1.HourlyRate = 10F;
            ctrlPoolTable1.Location = new Point(12, 17);
            ctrlPoolTable1.Name = "ctrlPoolTable1";
            ctrlPoolTable1.Size = new Size(465, 331);
            ctrlPoolTable1.TabIndex = 0;
            ctrlPoolTable1.TablePlayer = "Player1";
            ctrlPoolTable1.TableTitle = "Table1";
            ctrlPoolTable1.OnTableComplete += OnPoolTableEnded;
            // 
            // ctrlPoolTable2
            // 
            ctrlPoolTable2.BackColor = Color.MintCream;
            ctrlPoolTable2.HourlyRate = 10F;
            ctrlPoolTable2.Location = new Point(504, 17);
            ctrlPoolTable2.Name = "ctrlPoolTable2";
            ctrlPoolTable2.Size = new Size(465, 331);
            ctrlPoolTable2.TabIndex = 0;
            ctrlPoolTable2.TablePlayer = "Player2";
            ctrlPoolTable2.TableTitle = "Table2";
            ctrlPoolTable2.OnTableComplete += OnPoolTableEnded;
            // 
            // ctrlPoolTable3
            // 
            ctrlPoolTable3.BackColor = Color.MintCream;
            ctrlPoolTable3.HourlyRate = 10F;
            ctrlPoolTable3.Location = new Point(12, 363);
            ctrlPoolTable3.Name = "ctrlPoolTable3";
            ctrlPoolTable3.Size = new Size(465, 331);
            ctrlPoolTable3.TabIndex = 0;
            ctrlPoolTable3.TablePlayer = "Player3";
            ctrlPoolTable3.TableTitle = "Table3";
            ctrlPoolTable3.OnTableComplete += OnPoolTableEnded;
            // 
            // ctrlPoolTable4
            // 
            ctrlPoolTable4.BackColor = Color.MintCream;
            ctrlPoolTable4.HourlyRate = 5F;
            ctrlPoolTable4.Location = new Point(504, 363);
            ctrlPoolTable4.Name = "ctrlPoolTable4";
            ctrlPoolTable4.Size = new Size(465, 331);
            ctrlPoolTable4.TabIndex = 0;
            ctrlPoolTable4.TablePlayer = "Player4";
            ctrlPoolTable4.TableTitle = "Table4";
            ctrlPoolTable4.OnTableComplete += OnPoolTableEnded;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(981, 710);
            Controls.Add(ctrlPoolTable4);
            Controls.Add(ctrlPoolTable3);
            Controls.Add(ctrlPoolTable2);
            Controls.Add(ctrlPoolTable1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ctrlPoolTable ctrlPoolTable1;
        private ctrlPoolTable ctrlPoolTable2;
        private ctrlPoolTable ctrlPoolTable3;
        private ctrlPoolTable ctrlPoolTable4;
    }
}
