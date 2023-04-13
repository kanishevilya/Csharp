namespace Calculator {
	 public partial class Form1 : Form {
		  private const int maxLength = 22;
		  //private char logicalSymbol;
		  //private bool isAbleTo;

		  private string firstString;
		  private string secondString;

		  private bool isChangedType;

		  public Form1() {
				isChangedType = false;
				//isAbleTo = true;
				InitializeComponent();
		  }
		  private bool isCanToAddDigit() {
				return this.Result.Text.Length <= maxLength;
		  }
		  private void isOneSimbole(char ch) {
				if (!isCanToAddDigit()) return;
				if (this.Result.Text.Length == 1 && ch == '0' && this.Result.Text == "0") { return; } else if (this.Result.Text == "0" && ch != '0') { Result.Text = String.Empty; }
				this.Result.Text += ch;
		  }

		  private void buttonsClick(char ch) {
				this.LogicalMark.Text = ch.ToString();
				firstString = this.Result.Text;
				this.FirstNumber.Text = firstString;
				this.Result.Text = "0";
		  }

		  private void buttonPlusClick(object sender, EventArgs e) {
				buttonsClick('+');
		  }
		  private void buttonMinusClick(object sender, EventArgs e) {
				buttonsClick('-');
		  }
		  private void buttonMultClick(object sender, EventArgs e) {
				buttonsClick('*');
		  }
		  private void buttonDivClick(object sender, EventArgs e) {
				buttonsClick('/');
		  }

		  private string calc() {
				double tempNum = 0.0;
				double frst = double.Parse(firstString);
				double sec = double.Parse(secondString);
				switch (this.LogicalMark.Text) {
					 case "+":
					 tempNum = frst + sec;
					 break;
					 case "-":
					 tempNum = frst - sec;

					 break;
					 case "*":
					 tempNum = frst * sec;

					 break;
					 case "/":
					 if (sec != 0) {
						  tempNum = frst / sec;
					 } else {
						  return "UnCertainty";
					 }
					 break;
				}
				return tempNum.ToString();
		  }


		  private void buttonEqualClick(object sender, EventArgs e) {
				if (this.LogicalMark.Text != String.Empty) {
					 secondString = this.Result.Text;
					 firstString = calc();
					 secondString = "0";
					 this.LogicalMark.Text = String.Empty;
					 this.FirstNumber.Text = "";
					 this.Result.Text = firstString;
				}
		  }

		  private void button0Click(object sender, EventArgs e) {
				isOneSimbole('0');
		  }
		  private void button1Click(object sender, EventArgs e) {
				isOneSimbole('1');
		  }
		  private void button2Click(object sender, EventArgs e) {
				isOneSimbole('2');
		  }
		  private void button3Click(object sender, EventArgs e) {
				isOneSimbole('3');
		  }
		  private void button4Click(object sender, EventArgs e) {
				isOneSimbole('4');
		  }
		  private void button5Click(object sender, EventArgs e) {
				isOneSimbole('5');
		  }
		  private void button6Click(object sender, EventArgs e) {
				isOneSimbole('6');
		  }
		  private void button7Click(object sender, EventArgs e) {
				isOneSimbole('7');
		  }
		  private void button8Click(object sender, EventArgs e) {
				isOneSimbole('8');
		  }
		  private void button9Click(object sender, EventArgs e) {
				isOneSimbole('9');
		  }

		  private void buttonClearClick(object sender, EventArgs e) {
				this.Result.Text = "0";
				this.LogicalMark.Text = "";
				this.FirstNumber.Text = "";

		  }

		  private void buttonBackSpaceClick(object sender, EventArgs e) {
				if (this.Result.Text.Length == 1) { this.Result.Text = "0"; } else {
					 int idx = Result.Text.Length - 1;
					 if (this.Result.Text.Contains('E')) {
						  idx = this.Result.Text.IndexOf('E');
					 }
					 if (this.Result.Text.ToUpper()[0] >= 'A' && this.Result.Text.ToUpper()[0] <= 'Z') { idx = 0; }
					 this.Result.Text = this.Result.Text.Substring(0, idx);
					 if (idx == 0) { this.Result.Text = "0"; }
				}
		  }
		  private void buttonPercentClick(object sender, EventArgs e) {
				this.Result.Text = (double.Parse(this.Result.Text) / 100).ToString();
		  }
		  private void buttonbuttonCommaClick(object sender, EventArgs e) {
				if (!this.Result.Text.Contains(',')) {
					 this.Result.Text += ',';
				}
		  }
		  private void buttonPlusMinusClick(object sender, EventArgs e) {
				if (this.Result.Text == "0") return;
				this.Result.Text = (double.Parse(this.Result.Text) * -1).ToString();
		  }

	 }
}