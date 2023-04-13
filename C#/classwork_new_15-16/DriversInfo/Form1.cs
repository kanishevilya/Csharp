namespace DriversInfo {
	 public partial class Form1 : Form {
		  public Form1() {
				InitializeComponent();
		  }


		  private void pictureBox1_Click(object sender, EventArgs e) {

				DriveInfo drive = new(@"D:\");
				label1.Text= drive.Name;
				if (drive.IsReady) {
					 this.progressBar1.Value = (int)((drive.TotalSize - (float)drive.TotalFreeSpace) / drive.TotalSize * 100);
					 this.AllSize.Text = (drive.TotalSize).ToString();
					 this.Full.Text = (drive.TotalSize - (float)drive.TotalFreeSpace).ToString();
					 this.Free.Text = drive.TotalFreeSpace.ToString();
				}
				string path = drive.Name;
				if (Directory.Exists(path)) {
					 listBox1.Items.Clear();
					 string[] subdirs = Directory.GetDirectories(path);
					 foreach (var item in subdirs) {
						  listBox1.Items.Add(item);
					 }

				}
				
		  }

		  private void debug(object sender, EventArgs e) {
				MessageBox.Show("рш цемхи!");
		  }
		  private void openDirectory(object sender, EventArgs e) {
				if (listBox1.SelectedItem == null) { return; }
				string path = listBox1.SelectedItem.ToString();
				if (Directory.Exists(path)) {
					 listBox1.Items.Clear();
					 string[] subdirs = Directory.GetDirectories(path);
					 foreach (var item in subdirs) {
						  listBox1.Items.Add(item);
					 }
					 string[] subfiles = Directory.GetFiles(path);
					 foreach (string i in subfiles) {
						  listBox1.Items.Add(i);
					 }

				}
		  }

		  private void label1_Click(object sender, EventArgs e) {
			  
		  }
	 }
}