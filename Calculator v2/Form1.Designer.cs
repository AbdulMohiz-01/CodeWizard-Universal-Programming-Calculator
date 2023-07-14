namespace Calculator_v2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backSpaceButton = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hexaLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.octLabel = new System.Windows.Forms.Label();
            this.binLabel = new System.Windows.Forms.Label();
            this.hexButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.octButton = new System.Windows.Forms.Button();
            this.binButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.equationLabel = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.xorButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.orButton = new System.Windows.Forms.Button();
            this.norButton = new System.Windows.Forms.Button();
            this.andButton = new System.Windows.Forms.Button();
            this.nandButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.memoryLabel);
            this.groupBox1.Controls.Add(this.Memory);
            this.groupBox1.Location = new System.Drawing.Point(539, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoryLabel.Location = new System.Drawing.Point(6, 38);
            this.memoryLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(155, 20);
            this.memoryLabel.TabIndex = 1;
            this.memoryLabel.Text = "There is no memory yet.";
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Memory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Memory.Location = new System.Drawing.Point(6, 10);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(70, 19);
            this.Memory.TabIndex = 0;
            this.Memory.Text = "Memory";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.Enabled = false;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(4, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "A";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.buttonClick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Azure;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(116, 20);
            this.clearButton.Margin = new System.Windows.Forms.Padding(1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(220, 40);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backSpaceButton
            // 
            this.backSpaceButton.BackColor = System.Drawing.Color.Azure;
            this.backSpaceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backSpaceButton.Location = new System.Drawing.Point(342, 20);
            this.backSpaceButton.Name = "backSpaceButton";
            this.backSpaceButton.Size = new System.Drawing.Size(175, 40);
            this.backSpaceButton.TabIndex = 4;
            this.backSpaceButton.Text = "←";
            this.backSpaceButton.UseVisualStyleBackColor = false;
            this.backSpaceButton.Click += new System.EventHandler(this.backSpaceButton_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.Enabled = false;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(4, 66);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 40);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "B";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.Enabled = false;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(4, 112);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(108, 40);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "C";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.buttonClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightGray;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(116, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "(";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.buttonClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightGray;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(228, 66);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 40);
            this.button12.TabIndex = 11;
            this.button12.Text = ")";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.buttonClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightGray;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(342, 66);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 40);
            this.button13.TabIndex = 12;
            this.button13.Text = "%";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.getOperation);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.Enabled = false;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(4, 158);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(108, 40);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "D";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn8
            // 
            this.btn8.Enabled = false;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(116, 158);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(108, 40);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "4";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn11
            // 
            this.btn11.Enabled = false;
            this.btn11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn11.Location = new System.Drawing.Point(228, 158);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(108, 40);
            this.btn11.TabIndex = 15;
            this.btn11.Text = "5";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn15
            // 
            this.btn15.Enabled = false;
            this.btn15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn15.Location = new System.Drawing.Point(342, 158);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(108, 40);
            this.btn15.TabIndex = 16;
            this.btn15.Text = "6";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.Enabled = false;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(4, 204);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(108, 40);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "E";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn9
            // 
            this.btn9.Enabled = false;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(116, 204);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(108, 40);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "1";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn12
            // 
            this.btn12.Enabled = false;
            this.btn12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn12.Location = new System.Drawing.Point(228, 204);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(108, 40);
            this.btn12.TabIndex = 19;
            this.btn12.Text = "2";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn16
            // 
            this.btn16.Enabled = false;
            this.btn16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn16.Location = new System.Drawing.Point(342, 204);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(108, 40);
            this.btn16.TabIndex = 20;
            this.btn16.Text = "3";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.Enabled = false;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(4, 245);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(108, 40);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "F";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.buttonClick);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.Location = new System.Drawing.Point(116, 250);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(108, 40);
            this.button23.TabIndex = 22;
            this.button23.Text = "+/_";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.unirayOperation);
            // 
            // btn13
            // 
            this.btn13.Enabled = false;
            this.btn13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn13.Location = new System.Drawing.Point(228, 250);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(108, 40);
            this.btn13.TabIndex = 23;
            this.btn13.Text = "0";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.buttonClick);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.Peru;
            this.equalButton.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalButton.Location = new System.Drawing.Point(342, 250);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(175, 40);
            this.equalButton.TabIndex = 24;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LightGray;
            this.button26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button26.Location = new System.Drawing.Point(456, 66);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(61, 40);
            this.button26.TabIndex = 25;
            this.button26.Text = "÷";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.getOperation);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.LightGray;
            this.button27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button27.Location = new System.Drawing.Point(456, 112);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(61, 40);
            this.button27.TabIndex = 26;
            this.button27.Text = "x";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.getOperation);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.LightGray;
            this.button28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button28.Location = new System.Drawing.Point(456, 158);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(61, 40);
            this.button28.TabIndex = 27;
            this.button28.Text = "-";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.getOperation);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.LightGray;
            this.button29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button29.Location = new System.Drawing.Point(456, 204);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(61, 40);
            this.button29.TabIndex = 28;
            this.button29.Text = "+";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.getOperation);
            // 
            // btn7
            // 
            this.btn7.Enabled = false;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(116, 112);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(108, 40);
            this.btn7.TabIndex = 29;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn10
            // 
            this.btn10.Enabled = false;
            this.btn10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn10.Location = new System.Drawing.Point(228, 112);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(108, 40);
            this.btn10.TabIndex = 30;
            this.btn10.Text = "8";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn14
            // 
            this.btn14.Enabled = false;
            this.btn14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn14.Location = new System.Drawing.Point(342, 112);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(108, 40);
            this.btn14.TabIndex = 31;
            this.btn14.Text = "9";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.buttonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn14);
            this.groupBox2.Controls.Add(this.btn10);
            this.groupBox2.Controls.Add(this.btn7);
            this.groupBox2.Controls.Add(this.button29);
            this.groupBox2.Controls.Add(this.button28);
            this.groupBox2.Controls.Add(this.button27);
            this.groupBox2.Controls.Add(this.button26);
            this.groupBox2.Controls.Add(this.equalButton);
            this.groupBox2.Controls.Add(this.btn13);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.btn6);
            this.groupBox2.Controls.Add(this.btn16);
            this.groupBox2.Controls.Add(this.btn12);
            this.groupBox2.Controls.Add(this.btn9);
            this.groupBox2.Controls.Add(this.btn5);
            this.groupBox2.Controls.Add(this.btn15);
            this.groupBox2.Controls.Add(this.btn11);
            this.groupBox2.Controls.Add(this.btn8);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.backSpaceButton);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(527, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // hexaLabel
            // 
            this.hexaLabel.AutoSize = true;
            this.hexaLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexaLabel.Location = new System.Drawing.Point(53, 164);
            this.hexaLabel.Name = "hexaLabel";
            this.hexaLabel.Size = new System.Drawing.Size(17, 19);
            this.hexaLabel.TabIndex = 4;
            this.hexaLabel.Text = "0";
            // 
            // decLabel
            // 
            this.decLabel.AutoSize = true;
            this.decLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decLabel.Location = new System.Drawing.Point(53, 185);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(17, 19);
            this.decLabel.TabIndex = 5;
            this.decLabel.Text = "0";
            // 
            // octLabel
            // 
            this.octLabel.AutoSize = true;
            this.octLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.octLabel.Location = new System.Drawing.Point(53, 206);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(17, 19);
            this.octLabel.TabIndex = 6;
            this.octLabel.Text = "0";
            // 
            // binLabel
            // 
            this.binLabel.AutoSize = true;
            this.binLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binLabel.Location = new System.Drawing.Point(53, 227);
            this.binLabel.Name = "binLabel";
            this.binLabel.Size = new System.Drawing.Size(17, 19);
            this.binLabel.TabIndex = 7;
            this.binLabel.Text = "0";
            // 
            // hexButton
            // 
            this.hexButton.Location = new System.Drawing.Point(6, 164);
            this.hexButton.Name = "hexButton";
            this.hexButton.Size = new System.Drawing.Size(41, 23);
            this.hexButton.TabIndex = 10;
            this.hexButton.Text = "HEX";
            this.hexButton.UseVisualStyleBackColor = true;
            this.hexButton.Click += new System.EventHandler(this.conversionButtonClick);
            // 
            // decButton
            // 
            this.decButton.BackColor = System.Drawing.Color.SkyBlue;
            this.decButton.Location = new System.Drawing.Point(6, 185);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(41, 23);
            this.decButton.TabIndex = 11;
            this.decButton.Text = "DEC";
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.conversionButtonClick);
            // 
            // octButton
            // 
            this.octButton.Location = new System.Drawing.Point(6, 206);
            this.octButton.Name = "octButton";
            this.octButton.Size = new System.Drawing.Size(41, 23);
            this.octButton.TabIndex = 12;
            this.octButton.Text = "OCT";
            this.octButton.UseVisualStyleBackColor = true;
            this.octButton.Click += new System.EventHandler(this.conversionButtonClick);
            // 
            // binButton
            // 
            this.binButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.binButton.Location = new System.Drawing.Point(6, 227);
            this.binButton.Name = "binButton";
            this.binButton.Size = new System.Drawing.Size(41, 23);
            this.binButton.TabIndex = 13;
            this.binButton.Text = "BIN";
            this.binButton.UseVisualStyleBackColor = true;
            this.binButton.Click += new System.EventHandler(this.conversionButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.equationLabel);
            this.groupBox3.Controls.Add(this.textBox);
            this.groupBox3.Controls.Add(this.xorButton);
            this.groupBox3.Controls.Add(this.notButton);
            this.groupBox3.Controls.Add(this.orButton);
            this.groupBox3.Controls.Add(this.norButton);
            this.groupBox3.Controls.Add(this.andButton);
            this.groupBox3.Controls.Add(this.nandButton);
            this.groupBox3.Controls.Add(this.binButton);
            this.groupBox3.Controls.Add(this.octButton);
            this.groupBox3.Controls.Add(this.decButton);
            this.groupBox3.Controls.Add(this.hexButton);
            this.groupBox3.Controls.Add(this.binLabel);
            this.groupBox3.Controls.Add(this.octLabel);
            this.groupBox3.Controls.Add(this.decLabel);
            this.groupBox3.Controls.Add(this.hexaLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 324);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // equationLabel
            // 
            this.equationLabel.BackColor = System.Drawing.Color.White;
            this.equationLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationLabel.ForeColor = System.Drawing.Color.Gray;
            this.equationLabel.Location = new System.Drawing.Point(60, 66);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.ReadOnly = true;
            this.equationLabel.Size = new System.Drawing.Size(457, 22);
            this.equationLabel.TabIndex = 21;
            this.equationLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox.Location = new System.Drawing.Point(53, 85);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(464, 71);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(116, 292);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(52, 26);
            this.xorButton.TabIndex = 19;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.getOperation);
            // 
            // notButton
            // 
            this.notButton.Location = new System.Drawing.Point(116, 260);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(52, 26);
            this.notButton.TabIndex = 18;
            this.notButton.Text = "NOT";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.getOperation);
            // 
            // orButton
            // 
            this.orButton.Location = new System.Drawing.Point(60, 260);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(52, 26);
            this.orButton.TabIndex = 17;
            this.orButton.Text = "OR";
            this.orButton.UseVisualStyleBackColor = true;
            this.orButton.Click += new System.EventHandler(this.getOperation);
            // 
            // norButton
            // 
            this.norButton.Location = new System.Drawing.Point(60, 292);
            this.norButton.Name = "norButton";
            this.norButton.Size = new System.Drawing.Size(52, 26);
            this.norButton.TabIndex = 16;
            this.norButton.Text = "NOR";
            this.norButton.UseVisualStyleBackColor = true;
            this.norButton.Click += new System.EventHandler(this.getOperation);
            // 
            // andButton
            // 
            this.andButton.Location = new System.Drawing.Point(6, 260);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(52, 26);
            this.andButton.TabIndex = 15;
            this.andButton.Text = "AND";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.Click += new System.EventHandler(this.getOperation);
            // 
            // nandButton
            // 
            this.nandButton.Location = new System.Drawing.Point(6, 292);
            this.nandButton.Name = "nandButton";
            this.nandButton.Size = new System.Drawing.Size(52, 26);
            this.nandButton.TabIndex = 14;
            this.nandButton.Text = "NAND";
            this.nandButton.UseVisualStyleBackColor = true;
            this.nandButton.Click += new System.EventHandler(this.getOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 619);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programmer Calculator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label Memory;
        private Label memoryLabel;
        private Button btn1;
        private Button clearButton;
        private Button backSpaceButton;
        private Button btn2;
        private Button btn3;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button btn4;
        private Button btn8;
        private Button btn11;
        private Button btn15;
        private Button btn5;
        private Button btn9;
        private Button btn12;
        private Button btn16;
        private Button btn6;
        private Button button23;
        private Button btn13;
        private Button equalButton;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button btn7;
        private Button btn10;
        private Button btn14;
        private GroupBox groupBox2;
        private Label hexaLabel;
        private Label decLabel;
        private Label octLabel;
        private Label binLabel;
        private Button hexButton;
        private Button decButton;
        private Button octButton;
        private Button binButton;
        private GroupBox groupBox3;
        private Button xorButton;
        private Button notButton;
        private Button orButton;
        private Button norButton;
        private Button andButton;
        private Button nandButton;
        public TextBox textBox;
        public TextBox equationLabel;
    }
}