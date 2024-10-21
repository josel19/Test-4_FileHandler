namespace Test_4_FileHandler
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
            cboSystemDriver = new ComboBox();
            txtSystemDetails = new TextBox();
            SuspendLayout();
            // 
            // cboSystemDriver
            // 
            cboSystemDriver.FormattingEnabled = true;
            cboSystemDriver.Location = new Point(44, 45);
            cboSystemDriver.Name = "cboSystemDriver";
            cboSystemDriver.Size = new Size(690, 33);
            cboSystemDriver.TabIndex = 0;
            cboSystemDriver.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtSystemDetails
            // 
            txtSystemDetails.Location = new Point(44, 117);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(690, 294);
            txtSystemDetails.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSystemDetails);
            Controls.Add(cboSystemDriver);
            Name = "Form1";
            Text = "File Handler";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSystemDriver;
        private TextBox txtSystemDetails;
    }
}
