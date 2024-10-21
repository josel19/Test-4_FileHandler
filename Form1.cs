using System.Linq.Expressions;

namespace Test_4_FileHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }
        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cboSystemDriver.Items.Add(drive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSystemDriver.SelectedItem.ToString();
                DriveInfo diskInfo = new DriveInfo(disk);
                var driverDetail = $@" 
                    Drive: {disk} drive:

                    Total size: {diskInfo.TotalSize}
                    Free space available: {diskInfo.AvailableFreeSpace}
                    Format: {diskInfo.DriveFormat}
                    Type: {diskInfo.DriveType}";

                txtSystemDetails.Text = driverDetail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
