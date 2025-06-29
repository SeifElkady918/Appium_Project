namespace PMAG.CU.Appium.Tool
{
    partial class Form1
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.comboBoxDesiredDevices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(392, 12);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.DoTest);
            // 
            // comboBoxDesiredDevices
            // 
            this.comboBoxDesiredDevices.FormattingEnabled = true;
            this.comboBoxDesiredDevices.Items.AddRange(new object[] {
            "CUO 4B2A",
            "BT-S2",
            "BLA"});
            this.comboBoxDesiredDevices.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDesiredDevices.Name = "comboBoxDesiredDevices";
            this.comboBoxDesiredDevices.Size = new System.Drawing.Size(374, 24);
            this.comboBoxDesiredDevices.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 312);
            this.Controls.Add(this.comboBoxDesiredDevices);
            this.Controls.Add(this.buttonTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ComboBox comboBoxDesiredDevices;
    }
}

