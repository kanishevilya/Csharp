namespace DriversInfo {
	 partial class Form1 {
		  /// <summary>
		  ///  Required designer variable.
		  /// </summary>
		  private System.ComponentModel.IContainer components = null;

		  /// <summary>
		  ///  Clean up any resources being used.
		  /// </summary>
		  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		  protected override void Dispose(bool disposing) {
				if (disposing && (components != null)) {
					 components.Dispose();
				}
				base.Dispose(disposing);
		  }

		  #region Windows Form Designer generated code

		  /// <summary>
		  ///  Required method for Designer support - do not modify
		  ///  the contents of this method with the code editor.
		  /// </summary>
		  private void InitializeComponent() {
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
				this.progressBar1 = new System.Windows.Forms.ProgressBar();
				this.pictureBox1 = new System.Windows.Forms.PictureBox();
				this.label1 = new System.Windows.Forms.Label();
				this.AllSize = new System.Windows.Forms.Label();
				this.Free = new System.Windows.Forms.Label();
				this.Full = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.listBox1 = new System.Windows.Forms.ListBox();
				((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
				this.SuspendLayout();
				// 
				// progressBar1
				// 
				this.progressBar1.Location = new System.Drawing.Point(12, 204);
				this.progressBar1.MarqueeAnimationSpeed = 10000;
				this.progressBar1.Name = "progressBar1";
				this.progressBar1.Size = new System.Drawing.Size(200, 14);
				this.progressBar1.Step = 1;
				this.progressBar1.TabIndex = 0;
				// 
				// pictureBox1
				// 
				this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
				this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
				this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
				this.pictureBox1.Location = new System.Drawing.Point(12, 12);
				this.pictureBox1.Name = "pictureBox1";
				this.pictureBox1.Size = new System.Drawing.Size(200, 162);
				this.pictureBox1.TabIndex = 1;
				this.pictureBox1.TabStop = false;
				this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.label1.Location = new System.Drawing.Point(12, 231);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(36, 28);
				this.label1.TabIndex = 2;
				this.label1.Text = "C:\\";
				this.label1.Click += new System.EventHandler(this.label1_Click);
				// 
				// AllSize
				// 
				this.AllSize.AutoSize = true;
				this.AllSize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.AllSize.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.AllSize.Location = new System.Drawing.Point(185, 270);
				this.AllSize.Name = "AllSize";
				this.AllSize.Size = new System.Drawing.Size(0, 28);
				this.AllSize.TabIndex = 3;
				// 
				// Free
				// 
				this.Free.AutoSize = true;
				this.Free.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.Free.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.Free.Location = new System.Drawing.Point(132, 298);
				this.Free.Name = "Free";
				this.Free.Size = new System.Drawing.Size(0, 28);
				this.Free.TabIndex = 4;
				// 
				// Full
				// 
				this.Full.AutoSize = true;
				this.Full.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.Full.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.Full.Location = new System.Drawing.Point(111, 325);
				this.Full.Name = "Full";
				this.Full.Size = new System.Drawing.Size(0, 28);
				this.Full.TabIndex = 5;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.label2.Location = new System.Drawing.Point(12, 269);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(177, 28);
				this.label2.TabIndex = 6;
				this.label2.Text = "Полный размер - ";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.label3.Location = new System.Drawing.Point(12, 297);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(124, 28);
				this.label3.TabIndex = 7;
				this.label3.Text = "Свободно - ";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
				this.label4.Location = new System.Drawing.Point(12, 325);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(93, 28);
				this.label4.TabIndex = 8;
				this.label4.Text = "Занято - ";
				// 
				// listBox1
				// 
				this.listBox1.FormattingEnabled = true;
				this.listBox1.ItemHeight = 15;
				this.listBox1.Location = new System.Drawing.Point(284, 12);
				this.listBox1.Name = "listBox1";
				this.listBox1.Size = new System.Drawing.Size(514, 439);
				this.listBox1.TabIndex = 9;
				this.listBox1.DoubleClick += new System.EventHandler(this.openDirectory);
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.listBox1);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.Full);
				this.Controls.Add(this.Free);
				this.Controls.Add(this.AllSize);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.pictureBox1);
				this.Controls.Add(this.progressBar1);
				this.Name = "Form1";
				this.Text = "Form1";
				((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private ProgressBar progressBar1;
		  private PictureBox pictureBox1;
		  private Label label1;
		  private Label A;
		  private Label Free;
		  private Label Full;
		  private Label AllSize;
		  private Label label2;
		  private Label label3;
		  private Label label4;
		  private ListBox listBox1;
	 }
}