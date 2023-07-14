namespace Calculator_v2
{
    public partial class Form1 : Form
    {
        public string currentOperation = "";
        public string previousNumber = "";
        public string currentNumber = "";
        private string result = "";
        private bool operationPerformed = false;
        public bool isEqualPressed = false;
        public bool isOperationPressed = false;
        private string currentSelectedConversion = "DEC";
        private readonly string[] decButtons = { "btn7", "btn8", "btn9", "btn10", "btn11", "btn12", "btn13", "btn14", "btn15", "btn16" };
        private readonly string[] octButtons = { "btn7", "btn8", "btn9", "btn11", "btn12", "btn13", "btn15", "btn16" };
        private readonly string[] binButtons = { "btn9", "btn13" };
        private readonly string[] hexButtons = { "btn1", "btn2", "btn3", "btn4", "btn5", "btn6", "btn7", "btn8", "btn9", "btn10", "btn11", "btn12", "btn13", "btn14", "btn15", "btn16" };

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox.Text == "0" || operationPerformed)
            {
                textBox.Text = btn.Text;
                operationPerformed = false;
            }
            else
            {
                textBox.Text += btn.Text;
            }
            isOperationPressed = false;
            textBox.Text = textBox.Text.DoFormatting(currentSelectedConversion);
            UpdateConversions();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            previousNumber = "";
            currentOperation = "";
            operationPerformed = false;
            isEqualPressed = false;
            isOperationPressed = false;
            result = "";
            equationLabel.Text = "";
            UpdateConversions();
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
            UpdateConversions();
        }
        private void getOperation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == currentOperation)
            {
                equationLabel.Text += textBox.Text + " " + btn.Text + " ";
                equalButton_Click(sender, e);
                isEqualPressed = false;
            }
            else if (isOperationPressed)
            {
                currentOperation = btn.Text;
                if (equationLabel.Text.Length > 0)
                {
                    equationLabel.Text = equationLabel.Text[..^3];
                }
                equationLabel.Text += " " + currentOperation + " ";
            }
            else
            {
                currentOperation = btn.Text;
                previousNumber = textBox.Text.UndoFormatting(currentSelectedConversion);
                equationLabel.Text += previousNumber + " " + currentOperation + " ";
                textBox.Text = "0";
            }
            isOperationPressed = true;
            isEqualPressed = false;
            UpdateConversions();
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            if (Checks.InvalidEqualPressed(this)) return;
            string memoryString;
            if (isEqualPressed)
            {
                equationLabel.Text = $"{result} {currentOperation} {currentNumber} = ";
            }
            else
            {
                currentNumber = textBox.Text.UndoFormatting(currentSelectedConversion);
            }

            if (Checks.DivisbleByZero(this))
            {
                switch (currentSelectedConversion)
                {
                    case "DEC":
                        HandleOperations.Decimal(currentOperation, previousNumber, currentNumber, ref result);
                        break;
                    case "OCT":
                        HandleOperations.Octal(currentOperation, previousNumber, currentNumber, ref result);
                        break;
                    case "BIN":
                        HandleOperations.Binary(currentOperation, previousNumber, currentNumber, ref result);
                        break;
                    case "HEX":
                        HandleOperations.Hexadecimal(currentOperation, previousNumber, currentNumber, ref result);
                        break;
                }
                textBox.Text = result.DoFormatting(currentSelectedConversion);
                previousNumber = result;


                if ((Button)sender == equalButton)
                {
                    if (!isEqualPressed)
                    {
                        equationLabel.Text += currentNumber + " = ";
                    }
                    memoryString = equationLabel.Text + " " + result + "\n";

                    if (memoryLabel.Text == "There is no memory yet.")
                    {
                        memoryLabel.Text = memoryString;
                    }
                    else
                    {
                        memoryLabel.Text += memoryString;
                    }
                    isEqualPressed = true;
                }

                operationPerformed = true;
                UpdateConversions();
            }
        }

        private void unirayOperation(object sender, EventArgs e)
        {
            textBox.Text = (int.Parse(textBox.Text) * -1).ToString();
            UpdateConversions();
        }

        private void UpdateConversions()
        {
            string text = textBox.Text.UndoFormatting(currentSelectedConversion);
            string hex, dec, oct, bin;
            if (currentSelectedConversion == "DEC")
            {
                (hex, dec, oct, bin) = Utils.DecimalConversions(Convert.ToInt64(text));
            }
            else if (currentSelectedConversion == "HEX")
            {
                (hex, dec, oct, bin) = Utils.HexConversions(text);

            }
            else if (currentSelectedConversion == "OCT")
            {
                (hex, dec, oct, bin) = Utils.OctalConversions(text);
            }
            else
            {
                (hex, dec, oct, bin) = Utils.BinaryConversions(text);
            }
            (hex, dec, oct, bin) = Utils.FormatConversions(hex, dec, oct, bin);
            hexaLabel.Text = hex;
            decLabel.Text = dec;
            octLabel.Text = oct;
            binLabel.Text = bin;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (string btn in decButtons)
            {
                this.Controls.Find(btn, true)[0].Enabled = true;
            }
        }
        private void ResetStateOfButtons()
        {
            for (int i = 1; i <= 16; i++)
            {
                string btn = "btn" + i;
                this.Controls.Find(btn, true)[0].Enabled = false;
            }
        }
        private void conversionButtonClick(object sender, EventArgs e)
        {
            ResetStateOfButtons();
            string btnText = currentSelectedConversion.ToLower() + "Button";
            this.Controls.Find(btnText, true)[0].BackColor = Color.Gainsboro;
            currentSelectedConversion = ((Button)sender).Text;
            ((Button)sender).BackColor = Color.SkyBlue;

            if (currentSelectedConversion == "DEC")
            {
                textBox.Text = decLabel.Text;
                foreach (string btn in decButtons)
                {
                    this.Controls.Find(btn, true)[0].Enabled = true;
                }
            }
            else if (currentSelectedConversion == "HEX")
            {
                textBox.Text = hexaLabel.Text;
                foreach (string btn in hexButtons)
                {
                    this.Controls.Find(btn, true)[0].Enabled = true;
                }
            }
            else if (currentSelectedConversion == "OCT")
            {
                textBox.Text = octLabel.Text;
                foreach (string btn in octButtons)
                {
                    this.Controls.Find(btn, true)[0].Enabled = true;
                }
            }
            else
            {
                textBox.Text = binLabel.Text;
                foreach (string btn in binButtons)
                {
                    this.Controls.Find(btn, true)[0].Enabled = true;
                }
            }

        }
    }
}