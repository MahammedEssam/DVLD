namespace DVLD
{
    partial class frmTest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlScheduleTest1 = new DVLD.Tests.ctrlScheduleTest();
            this.ctrlScheduleTest2 = new DVLD.Tests.ctrlScheduleTest();
            this.ctrlScheduleTest3 = new DVLD.Tests.ctrlScheduleTest();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.Enabled = false;
            this.ctrlScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(23, 12);
            this.ctrlScheduleTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(533, 722);
            this.ctrlScheduleTest1.TabIndex = 0;
            this.ctrlScheduleTest1.TestTypeID = DVLD_Buisness.clsTestType.enTestType.VisionTest;
            // 
            // ctrlScheduleTest2
            // 
            this.ctrlScheduleTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlScheduleTest2.Location = new System.Drawing.Point(598, 14);
            this.ctrlScheduleTest2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlScheduleTest2.Name = "ctrlScheduleTest2";
            this.ctrlScheduleTest2.Size = new System.Drawing.Size(533, 722);
            this.ctrlScheduleTest2.TabIndex = 1;
            this.ctrlScheduleTest2.TestTypeID = DVLD_Buisness.clsTestType.enTestType.WrittenTest;
            // 
            // ctrlScheduleTest3
            // 
            this.ctrlScheduleTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlScheduleTest3.Location = new System.Drawing.Point(1191, 12);
            this.ctrlScheduleTest3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlScheduleTest3.Name = "ctrlScheduleTest3";
            this.ctrlScheduleTest3.Size = new System.Drawing.Size(533, 722);
            this.ctrlScheduleTest3.TabIndex = 2;
            this.ctrlScheduleTest3.TestTypeID = DVLD_Buisness.clsTestType.enTestType.StreetTest;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 748);
            this.Controls.Add(this.ctrlScheduleTest3);
            this.Controls.Add(this.ctrlScheduleTest2);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Tests.ctrlScheduleTest ctrlScheduleTest1;
        private Tests.ctrlScheduleTest ctrlScheduleTest2;
        private Tests.ctrlScheduleTest ctrlScheduleTest3;
    }
}