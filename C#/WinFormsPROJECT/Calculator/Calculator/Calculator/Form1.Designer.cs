namespace Calculator {
	 partial class Form1 {

		  public static Point Plus(Point lf, Point rg) {
				return new Point(lf.X + rg.X,lf.Y+rg.Y);
		  }
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
				this.buttonPlus = new System.Windows.Forms.Button();
				this.buttonMinus = new System.Windows.Forms.Button();
				this.buttonMult = new System.Windows.Forms.Button();
				this.buttonDiv = new System.Windows.Forms.Button();
				this.buttonPercent = new System.Windows.Forms.Button();
				this.buttonBackSpace = new System.Windows.Forms.Button();
				this.buttonClear = new System.Windows.Forms.Button();
				this.buttonDigit7 = new System.Windows.Forms.Button();
				this.buttonDigit8 = new System.Windows.Forms.Button();
				this.buttonDigit9 = new System.Windows.Forms.Button();
				this.buttonDigit6 = new System.Windows.Forms.Button();
				this.buttonDigit5 = new System.Windows.Forms.Button();
				this.buttonDigit4 = new System.Windows.Forms.Button();
				this.buttonDigit3 = new System.Windows.Forms.Button();
				this.buttonDigit2 = new System.Windows.Forms.Button();
				this.buttonDigit1 = new System.Windows.Forms.Button();
				this.buttonDigit0 = new System.Windows.Forms.Button();
				this.buttonComma = new System.Windows.Forms.Button();
				this.buttonEqual = new System.Windows.Forms.Button();
				this.buttonChangeMark = new System.Windows.Forms.Button();
				this.Result = new System.Windows.Forms.Label();
				this.LogicalMark = new System.Windows.Forms.Label();
				this.BCforResult = new System.Windows.Forms.Panel();
				this.PreviousName = new System.Windows.Forms.TextBox();
				this.SwitchType = new System.Windows.Forms.Button();
				this.button1 = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// buttonPlus
				// 
				this.buttonPlus.BackColor = System.Drawing.Color.Peru;
				this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
				this.buttonPlus.FlatAppearance.BorderSize = 4;
				this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonPlus.ForeColor = System.Drawing.Color.Bisque;
				this.buttonPlus.Location = Plus(new System.Drawing.Point(547, 600), firstCoord);
				this.buttonPlus.Name = "buttonPlus";
				this.buttonPlus.Size = TileSize;
				this.buttonPlus.TabIndex = 0;
				this.buttonPlus.Text = "+";
				this.buttonPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonPlus.UseVisualStyleBackColor = false;
				this.buttonPlus.Click += new System.EventHandler(this.buttonPlusClick);
				// 
				// buttonMinus
				// 
				this.buttonMinus.BackColor = System.Drawing.Color.Peru;
				this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
				this.buttonMinus.FlatAppearance.BorderSize = 4;
				this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonMinus.ForeColor = System.Drawing.Color.Bisque;
				this.buttonMinus.Location = Plus(new System.Drawing.Point(547, 485), firstCoord);
				this.buttonMinus.Name = "buttonMinus";
				this.buttonMinus.Size = TileSize;
				this.buttonMinus.TabIndex = 1;
				this.buttonMinus.Text = "-";
				this.buttonMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonMinus.UseVisualStyleBackColor = false;
				this.buttonMinus.Click += new System.EventHandler(this.buttonMinusClick);
				// 
				// buttonMult
				// 
				this.buttonMult.BackColor = System.Drawing.Color.Peru;
				this.buttonMult.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
				this.buttonMult.FlatAppearance.BorderSize = 4;
				this.buttonMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonMult.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonMult.ForeColor = System.Drawing.Color.Bisque;
				this.buttonMult.Location = Plus(new System.Drawing.Point(547, 370), firstCoord);
				this.buttonMult.Name = "buttonMult";
				this.buttonMult.Size = TileSize;
				this.buttonMult.TabIndex = 2;
				this.buttonMult.Text = "x";
				this.buttonMult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonMult.UseVisualStyleBackColor = false;
				this.buttonMult.Click += new System.EventHandler(this.buttonMultClick);
				// 
				// buttonDiv
				// 
				this.buttonDiv.BackColor = System.Drawing.Color.Peru;
				this.buttonDiv.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
				this.buttonDiv.FlatAppearance.BorderSize = 4;
				this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDiv.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDiv.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDiv.Location = Plus(new System.Drawing.Point(547, 255),firstCoord);
				this.buttonDiv.Name = "buttonDiv";
				this.buttonDiv.Size = TileSize;
				this.buttonDiv.TabIndex = 3;
				this.buttonDiv.Text = "÷";
				this.buttonDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDiv.UseVisualStyleBackColor = false;
				this.buttonDiv.Click += new System.EventHandler(this.buttonDivClick);
				// 
				// buttonPercent
				// 
				this.buttonPercent.BackColor = System.Drawing.Color.LightSeaGreen;
				this.buttonPercent.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
				this.buttonPercent.FlatAppearance.BorderSize = 4;
				this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonPercent.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonPercent.ForeColor = System.Drawing.Color.Bisque;
				this.buttonPercent.Location = Plus(new System.Drawing.Point(388, 255), firstCoord);
				this.buttonPercent.Name = "buttonPercent";
				this.buttonPercent.Size = TileSize;
				this.buttonPercent.TabIndex = 4;
				this.buttonPercent.Text = "%";
				this.buttonPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonPercent.UseVisualStyleBackColor = false;
				this.buttonPercent.Click += new System.EventHandler(this.buttonPercentClick);
				// 
				// buttonBackSpace
				// 
				this.buttonBackSpace.BackColor = System.Drawing.Color.LightSeaGreen;
				this.buttonBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
				this.buttonBackSpace.FlatAppearance.BorderSize = 4;
				this.buttonBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonBackSpace.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonBackSpace.ForeColor = System.Drawing.Color.BlanchedAlmond;
				this.buttonBackSpace.Location = Plus(new System.Drawing.Point(229, 255), firstCoord);
				this.buttonBackSpace.Name = "buttonBackSpace";
				this.buttonBackSpace.Size = TileSize;
				this.buttonBackSpace.TabIndex = 5;
				this.buttonBackSpace.Text = "←";
				this.buttonBackSpace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonBackSpace.UseVisualStyleBackColor = false;
				this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpaceClick);
				// 
				// buttonClear
				// 
				this.buttonClear.BackColor = System.Drawing.Color.Tomato;
				this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
				this.buttonClear.FlatAppearance.BorderSize = 4;
				this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonClear.ForeColor = System.Drawing.Color.Bisque;
				this.buttonClear.Location = Plus(new System.Drawing.Point(70, 255), firstCoord);
				this.buttonClear.Name = "buttonClear";
				this.buttonClear.Size = TileSize;
				this.buttonClear.TabIndex = 6;
				this.buttonClear.Text = "C";
				this.buttonClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonClear.UseVisualStyleBackColor = false;
				this.buttonClear.Click += new System.EventHandler(this.buttonClearClick);
				// 
				// buttonDigit7
				// 
				this.buttonDigit7.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit7.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit7.FlatAppearance.BorderSize = 4;
				this.buttonDigit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit7.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit7.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit7.Location = Plus(new System.Drawing.Point(70, 370), firstCoord);
				this.buttonDigit7.Name = "buttonDigit7";
				this.buttonDigit7.Size = TileSize;
				this.buttonDigit7.TabIndex = 7;
				this.buttonDigit7.Text = "7";
				this.buttonDigit7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit7.UseVisualStyleBackColor = false;
				this.buttonDigit7.Click += new System.EventHandler(this.button7Click);
				// 
				// buttonDigit8
				// 
				this.buttonDigit8.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit8.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit8.FlatAppearance.BorderSize = 4;
				this.buttonDigit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit8.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit8.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit8.Location = Plus(new System.Drawing.Point(229, 370), firstCoord);
				this.buttonDigit8.Name = "buttonDigit8";
				this.buttonDigit8.Size = TileSize;
				this.buttonDigit8.TabIndex = 8;
				this.buttonDigit8.Text = "8";
				this.buttonDigit8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit8.UseVisualStyleBackColor = false;
				this.buttonDigit8.Click += new System.EventHandler(this.button8Click);
				// 
				// buttonDigit9
				// 
				this.buttonDigit9.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit9.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit9.FlatAppearance.BorderSize = 4;
				this.buttonDigit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit9.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit9.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit9.Location = Plus(new System.Drawing.Point(388, 370), firstCoord);
				this.buttonDigit9.Name = "buttonDigit9";
				this.buttonDigit9.Size = TileSize;
				this.buttonDigit9.TabIndex = 9;
				this.buttonDigit9.Text = "9";
				this.buttonDigit9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit9.UseVisualStyleBackColor = false;
				this.buttonDigit9.Click += new System.EventHandler(this.button9Click);
				// 
				// buttonDigit6
				// 
				this.buttonDigit6.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit6.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit6.FlatAppearance.BorderSize = 4;
				this.buttonDigit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit6.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit6.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit6.Location = Plus(new System.Drawing.Point(388, 485), firstCoord);
				this.buttonDigit6.Name = "buttonDigit6";
				this.buttonDigit6.Size = TileSize;
				this.buttonDigit6.TabIndex = 10;
				this.buttonDigit6.Text = "6";
				this.buttonDigit6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit6.UseVisualStyleBackColor = false;
				this.buttonDigit6.Click += new System.EventHandler(this.button6Click);
				// 
				// buttonDigit5
				// 
				this.buttonDigit5.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit5.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit5.FlatAppearance.BorderSize = 4;
				this.buttonDigit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit5.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit5.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit5.Location = Plus(new System.Drawing.Point(229, 485), firstCoord);
				this.buttonDigit5.Name = "buttonDigit5";
				this.buttonDigit5.Size = TileSize;
				this.buttonDigit5.TabIndex = 11;
				this.buttonDigit5.Text = "5";
				this.buttonDigit5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit5.UseVisualStyleBackColor = false;
				this.buttonDigit5.Click += new System.EventHandler(this.button5Click);
				// 
				// buttonDigit4
				// 
				this.buttonDigit4.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit4.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit4.FlatAppearance.BorderSize = 4;
				this.buttonDigit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit4.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit4.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit4.Location = Plus(new System.Drawing.Point(70, 485), firstCoord);
				this.buttonDigit4.Name = "buttonDigit4";
				this.buttonDigit4.Size = TileSize;
				this.buttonDigit4.TabIndex = 12;
				this.buttonDigit4.Text = "4";
				this.buttonDigit4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit4.UseVisualStyleBackColor = false;
				this.buttonDigit4.Click += new System.EventHandler(this.button4Click);
				// 
				// buttonDigit3
				// 
				this.buttonDigit3.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit3.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit3.FlatAppearance.BorderSize = 4;
				this.buttonDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit3.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit3.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit3.Location = Plus(new System.Drawing.Point(388, 600), firstCoord);
				this.buttonDigit3.Name = "buttonDigit3";
				this.buttonDigit3.Size = TileSize;
				this.buttonDigit3.TabIndex = 13;
				this.buttonDigit3.Text = "3";
				this.buttonDigit3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit3.UseVisualStyleBackColor = false;
				this.buttonDigit3.Click += new System.EventHandler(this.button3Click);
				// 
				// buttonDigit2
				// 
				this.buttonDigit2.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit2.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit2.FlatAppearance.BorderSize = 4;
				this.buttonDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit2.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit2.Location = Plus(new System.Drawing.Point(229, 600), firstCoord);
				this.buttonDigit2.Name = "buttonDigit2";
				this.buttonDigit2.Size = TileSize;
				this.buttonDigit2.TabIndex = 14;
				this.buttonDigit2.Text = "2";
				this.buttonDigit2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit2.UseVisualStyleBackColor = false;
				this.buttonDigit2.Click += new System.EventHandler(this.button2Click);
				// 
				// buttonDigit1
				// 
				this.buttonDigit1.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit1.FlatAppearance.BorderSize = 4;
				this.buttonDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit1.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit1.Location = Plus(new System.Drawing.Point(70, 600), firstCoord);
				this.buttonDigit1.Name = "buttonDigit1";
				this.buttonDigit1.Size = TileSize;
				this.buttonDigit1.TabIndex = 15;
				this.buttonDigit1.Text = "1";
				this.buttonDigit1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit1.UseVisualStyleBackColor = false;
				this.buttonDigit1.Click += new System.EventHandler(this.button1Click);
				// 
				// buttonDigit0
				// 
				this.buttonDigit0.BackColor = System.Drawing.Color.BlueViolet;
				this.buttonDigit0.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
				this.buttonDigit0.FlatAppearance.BorderSize = 4;
				this.buttonDigit0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonDigit0.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonDigit0.ForeColor = System.Drawing.Color.Bisque;
				this.buttonDigit0.Location = Plus(new System.Drawing.Point(229, 715), firstCoord);
				this.buttonDigit0.Name = "buttonDigit0";
				this.buttonDigit0.Size = TileSize;
				this.buttonDigit0.TabIndex = 16;
				this.buttonDigit0.Text = "0";
				this.buttonDigit0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonDigit0.UseVisualStyleBackColor = false;
				this.buttonDigit0.Click += new System.EventHandler(this.button0Click);
				// 
				// buttonComma
				// 
				this.buttonComma.BackColor = System.Drawing.Color.MediumSlateBlue;
				this.buttonComma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(234)))));
				this.buttonComma.FlatAppearance.BorderSize = 4;
				this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonComma.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonComma.ForeColor = System.Drawing.Color.Bisque;
				this.buttonComma.Location = Plus(new System.Drawing.Point(388, 715), firstCoord);
				this.buttonComma.Name = "buttonComma";
				this.buttonComma.Size = TileSize;
				this.buttonComma.TabIndex = 17;
				this.buttonComma.Text = ",";
				this.buttonComma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonComma.UseVisualStyleBackColor = false;
				this.buttonComma.Click += new System.EventHandler(this.buttonCommaClick);
				// 
				// buttonEqual
				// 
				this.buttonEqual.BackColor = System.Drawing.Color.DarkOrange;
				this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
				this.buttonEqual.FlatAppearance.BorderSize = 4;
				this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonEqual.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonEqual.ForeColor = System.Drawing.Color.Bisque;
				this.buttonEqual.Location = Plus(new System.Drawing.Point(547, 715), firstCoord);
				this.buttonEqual.Name = "buttonEqual";
				this.buttonEqual.Size = TileSize;
				this.buttonEqual.TabIndex = 18;
				this.buttonEqual.Text = "=";
				this.buttonEqual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonEqual.UseVisualStyleBackColor = false;
				this.buttonEqual.Click += new System.EventHandler(this.buttonEqualClick);
				// 
				// buttonChangeMark
				// 
				this.buttonChangeMark.BackColor = System.Drawing.Color.MediumSlateBlue;
				this.buttonChangeMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(234)))));
				this.buttonChangeMark.FlatAppearance.BorderSize = 4;
				this.buttonChangeMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.buttonChangeMark.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.buttonChangeMark.ForeColor = System.Drawing.Color.Bisque;
				this.buttonChangeMark.Location = Plus(new System.Drawing.Point(70, 715), firstCoord);
				this.buttonChangeMark.Name = "buttonChangeMark";
				this.buttonChangeMark.Size = TileSize;
				this.buttonChangeMark.TabIndex = 19;
				this.buttonChangeMark.Text = "+/-";
				this.buttonChangeMark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.buttonChangeMark.UseVisualStyleBackColor = false;
				this.buttonChangeMark.Click += new System.EventHandler(this.buttonPlusMinusClick);
				// 
				// Result
				// 
				this.Result.BackColor = System.Drawing.Color.NavajoWhite;
				this.Result.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(117)))), ((int)(((byte)(70)))));
				this.Result.Location = Plus(new System.Drawing.Point(78, 150), firstCoord);
				this.Result.Name = "Result";
				this.Result.Size = new System.Drawing.Size(614, 80);
				this.Result.TabIndex = 20;
				this.Result.Text = "0";
				this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				this.Result.UseCompatibleTextRendering = true;
				// 
				// LogicalMark
				// 
				this.LogicalMark.BackColor = System.Drawing.Color.LightSteelBlue;
				this.LogicalMark.Font = new System.Drawing.Font("Segoe UI", 49F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.LogicalMark.ForeColor = System.Drawing.Color.LightSlateGray;
				this.LogicalMark.Location = Plus(new System.Drawing.Point(70, 19), firstCoord);
				this.LogicalMark.Name = "LogicalMark";
				this.LogicalMark.Size = new System.Drawing.Size(121, 109);
				this.LogicalMark.TabIndex = 23;
				this.LogicalMark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				// 
				// BCforResult
				// 
				this.BCforResult.BackColor = System.Drawing.Color.Tan;
				this.BCforResult.Location = Plus(new System.Drawing.Point(70, 141), firstCoord);
				this.BCforResult.Name = "BCforResult";
				this.BCforResult.Size = new System.Drawing.Size(630, 100);
				this.BCforResult.TabIndex = 24;
				// 
				// PreviousName
				// 
				this.PreviousName.BackColor = System.Drawing.Color.LightSlateGray;
				this.PreviousName.BorderStyle = System.Windows.Forms.BorderStyle.None;
				this.PreviousName.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.PreviousName.ForeColor = System.Drawing.Color.Transparent;
				this.PreviousName.Location = Plus(new System.Drawing.Point(191, 94), firstCoord);
				this.PreviousName.Name = "PreviousName";
				this.PreviousName.Size = new System.Drawing.Size(332, 34);
				this.PreviousName.TabIndex = 25;
				// 
				// SwitchType
				// 
				this.SwitchType.BackColor = System.Drawing.Color.Tomato;
				this.SwitchType.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
				this.SwitchType.FlatAppearance.BorderSize = 4;
				this.SwitchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.SwitchType.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.SwitchType.ForeColor = System.Drawing.Color.Bisque;
				this.SwitchType.Location = Plus(new System.Drawing.Point(547, 19), firstCoord);
				this.SwitchType.Name = "SwitchType";
				this.SwitchType.Size = TileSize;
				this.SwitchType.TabIndex = 26;
				this.SwitchType.Text = "⇄";
				this.SwitchType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.SwitchType.UseVisualStyleBackColor = false;
				// 
				// button1
				// 
				this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
				this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
				this.button1.FlatAppearance.BorderSize = 4;
				this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.button1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
				this.button1.ForeColor = System.Drawing.Color.BlanchedAlmond;
				this.button1.Location = Plus(new System.Drawing.Point(730, 84), firstCoord);
				this.button1.Name = "button1";
				this.button1.Size = new System.Drawing.Size(153, 109);
				this.button1.TabIndex = 27;
				this.button1.Text = "←";
				this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				this.button1.UseVisualStyleBackColor = false;
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
				this.ClientSize = new System.Drawing.Size(882, 875);
				this.Controls.Add(this.button1);
				this.Controls.Add(this.SwitchType);
				this.Controls.Add(this.PreviousName);
				this.Controls.Add(this.LogicalMark);
				this.Controls.Add(this.Result);
				this.Controls.Add(this.BCforResult);
				this.Controls.Add(this.buttonChangeMark);
				this.Controls.Add(this.buttonEqual);
				this.Controls.Add(this.buttonComma);
				this.Controls.Add(this.buttonDigit0);
				this.Controls.Add(this.buttonDigit1);
				this.Controls.Add(this.buttonDigit2);
				this.Controls.Add(this.buttonDigit3);
				this.Controls.Add(this.buttonDigit4);
				this.Controls.Add(this.buttonDigit5);
				this.Controls.Add(this.buttonDigit6);
				this.Controls.Add(this.buttonDigit9);
				this.Controls.Add(this.buttonDigit8);
				this.Controls.Add(this.buttonDigit7);
				this.Controls.Add(this.buttonClear);
				this.Controls.Add(this.buttonBackSpace);
				this.Controls.Add(this.buttonPercent);
				this.Controls.Add(this.buttonDiv);
				this.Controls.Add(this.buttonMult);
				this.Controls.Add(this.buttonMinus);
				this.Controls.Add(this.buttonPlus);
				this.Name = "Form1";
				this.Text = "Form1";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }
		  #endregion

		  private Button buttonPlus;
		  private Button buttonMinus;
		  private Button buttonMult;
		  private Button buttonDiv;
		  private Button buttonPercent;
		  private Button buttonBackSpace;
		  private Button buttonClear;
		  private Button buttonDigit7;
		  private Button buttonDigit8;
		  private Button buttonDigit9;
		  private Button buttonDigit6;
		  private Button buttonDigit5;
		  private Button buttonDigit4;
		  private Button buttonDigit3;
		  private Button buttonDigit2;
		  private Button buttonDigit1;
		  private Button buttonDigit0;
		  private Button buttonComma;
		  private Button buttonEqual;
		  private Button buttonChangeMark;
		  private Label Result;
		  private Label LogicalMark;
		  private Panel BCforResult;
		  private TextBox PreviousName;
		  private Button SwitchType;
		  private Button button1;
	 }
}