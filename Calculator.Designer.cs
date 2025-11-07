namespace CalculatorToolbox
{
    partial class Calculator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDisplay = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnPercent = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnReciprocal = new Button();
            btnPower = new Button();
            btnSquareRoot = new Button();
            btnDivide = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMultiply = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSubtract = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnAdd = new Button();
            btnToggleSign = new Button();
            btnZero = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            txtExpression = new Label();
            btnOpenMenu = new Button();
            menuPanel = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCloseMenu = new Button();
            btnCalculator = new Button();
            btnCurrencyConverter = new Button();
            btnUnitConverter = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtDisplay, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(txtExpression, 0, 1);
            tableLayoutPanel1.Controls.Add(btnOpenMenu, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Size = new Size(478, 704);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Control;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Font = new Font("Segoe UI Symbol", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(3, 140);
            txtDisplay.Margin = new Padding(3, 0, 20, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(455, 75);
            txtDisplay.TabIndex = 2;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnPercent, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClearEntry, 1, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel2.Controls.Add(btnBackspace, 3, 0);
            tableLayoutPanel2.Controls.Add(btnReciprocal, 0, 1);
            tableLayoutPanel2.Controls.Add(btnPower, 1, 1);
            tableLayoutPanel2.Controls.Add(btnSquareRoot, 2, 1);
            tableLayoutPanel2.Controls.Add(btnDivide, 3, 1);
            tableLayoutPanel2.Controls.Add(btnSeven, 0, 2);
            tableLayoutPanel2.Controls.Add(btnEight, 1, 2);
            tableLayoutPanel2.Controls.Add(btnNine, 2, 2);
            tableLayoutPanel2.Controls.Add(btnMultiply, 3, 2);
            tableLayoutPanel2.Controls.Add(btnFour, 0, 3);
            tableLayoutPanel2.Controls.Add(btnFive, 1, 3);
            tableLayoutPanel2.Controls.Add(btnSix, 2, 3);
            tableLayoutPanel2.Controls.Add(btnSubtract, 3, 3);
            tableLayoutPanel2.Controls.Add(btnOne, 0, 4);
            tableLayoutPanel2.Controls.Add(btnTwo, 1, 4);
            tableLayoutPanel2.Controls.Add(btnThree, 2, 4);
            tableLayoutPanel2.Controls.Add(btnAdd, 3, 4);
            tableLayoutPanel2.Controls.Add(btnToggleSign, 0, 5);
            tableLayoutPanel2.Controls.Add(btnZero, 1, 5);
            tableLayoutPanel2.Controls.Add(btnDecimal, 2, 5);
            tableLayoutPanel2.Controls.Add(btnEquals, 3, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("微軟正黑體", 12F);
            tableLayoutPanel2.Location = new Point(3, 248);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(472, 453);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI Symbol", 14F);
            btnPercent.Location = new Point(3, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(112, 69);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += BtnPercent_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.Font = new Font("Segoe UI Symbol", 14F);
            btnClearEntry.Location = new Point(121, 3);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(112, 69);
            btnClearEntry.TabIndex = 1;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += BtnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI Symbol", 14F);
            btnClear.Location = new Point(239, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 69);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Segoe UI Symbol", 14F);
            btnBackspace.Location = new Point(357, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(112, 69);
            btnBackspace.TabIndex = 3;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += BtnBackspace_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Dock = DockStyle.Fill;
            btnReciprocal.Font = new Font("Segoe UI Symbol", 14F);
            btnReciprocal.Location = new Point(3, 78);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(112, 69);
            btnReciprocal.TabIndex = 4;
            btnReciprocal.Text = "¹/𝑥";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += BtnReciprocal_Click;
            // 
            // btnPower
            // 
            btnPower.Dock = DockStyle.Fill;
            btnPower.Font = new Font("Segoe UI Symbol", 14F);
            btnPower.Location = new Point(121, 78);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(112, 69);
            btnPower.TabIndex = 5;
            btnPower.Text = "𝑥ʸ";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += BtnPower_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Dock = DockStyle.Fill;
            btnSquareRoot.Font = new Font("Segoe UI Symbol", 14F);
            btnSquareRoot.Location = new Point(239, 78);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(112, 69);
            btnSquareRoot.TabIndex = 6;
            btnSquareRoot.Text = "√𝑥";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += BtnSquareRoot_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI Symbol", 14F);
            btnDivide.Location = new Point(357, 78);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(112, 69);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnDivide_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Font = new Font("Segoe UI Symbol", 14F);
            btnSeven.Location = new Point(3, 153);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(112, 69);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += BtnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Font = new Font("Segoe UI Symbol", 14F);
            btnEight.Location = new Point(121, 153);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(112, 69);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += BtnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Font = new Font("Segoe UI Symbol", 14F);
            btnNine.Location = new Point(239, 153);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(112, 69);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += BtnNine_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI Symbol", 14F);
            btnMultiply.Location = new Point(357, 153);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(112, 69);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnMultiply_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Font = new Font("Segoe UI Symbol", 14F);
            btnFour.Location = new Point(3, 228);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(112, 69);
            btnFour.TabIndex = 12;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += BtnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Font = new Font("Segoe UI Symbol", 14F);
            btnFive.Location = new Point(121, 228);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(112, 69);
            btnFive.TabIndex = 13;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += BtnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Font = new Font("Segoe UI Symbol", 14F);
            btnSix.Location = new Point(239, 228);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(112, 69);
            btnSix.TabIndex = 14;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += BtnSix_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Font = new Font("Segoe UI Symbol", 14F);
            btnSubtract.Location = new Point(357, 228);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(112, 69);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BtnSubtract_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Font = new Font("Segoe UI Symbol", 14F);
            btnOne.Location = new Point(3, 303);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(112, 69);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += BtnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Font = new Font("Segoe UI Symbol", 14F);
            btnTwo.Location = new Point(121, 303);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(112, 69);
            btnTwo.TabIndex = 17;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += BtnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Font = new Font("Segoe UI Symbol", 14F);
            btnThree.Location = new Point(239, 303);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(112, 69);
            btnThree.TabIndex = 18;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += BtnThree_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI Symbol", 14F);
            btnAdd.Location = new Point(357, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 69);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnToggleSign
            // 
            btnToggleSign.Dock = DockStyle.Fill;
            btnToggleSign.Font = new Font("Segoe UI Symbol", 14F);
            btnToggleSign.Location = new Point(3, 378);
            btnToggleSign.Name = "btnToggleSign";
            btnToggleSign.Size = new Size(112, 72);
            btnToggleSign.TabIndex = 20;
            btnToggleSign.Text = "⁺/₋";
            btnToggleSign.UseVisualStyleBackColor = true;
            btnToggleSign.Click += BtnToggleSign_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Font = new Font("Segoe UI Symbol", 14F);
            btnZero.Location = new Point(121, 378);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(112, 72);
            btnZero.TabIndex = 21;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += BtnZero_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Font = new Font("Segoe UI Symbol", 14F);
            btnDecimal.Location = new Point(239, 378);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(112, 72);
            btnDecimal.TabIndex = 22;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += BtnDecimal_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.Highlight;
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Font = new Font("Segoe UI Symbol", 14F);
            btnEquals.ForeColor = SystemColors.ControlLightLight;
            btnEquals.Location = new Point(357, 378);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(112, 72);
            btnEquals.TabIndex = 23;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += BtnEquals_Click;
            // 
            // txtExpression
            // 
            txtExpression.AutoSize = true;
            txtExpression.Dock = DockStyle.Fill;
            txtExpression.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpression.ForeColor = SystemColors.ControlDarkDark;
            txtExpression.Location = new Point(3, 70);
            txtExpression.Margin = new Padding(3, 0, 20, 0);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(455, 70);
            txtExpression.TabIndex = 3;
            txtExpression.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnOpenMenu
            // 
            btnOpenMenu.AutoSize = true;
            btnOpenMenu.BackColor = SystemColors.Control;
            btnOpenMenu.BackgroundImageLayout = ImageLayout.None;
            btnOpenMenu.FlatAppearance.BorderSize = 0;
            btnOpenMenu.FlatStyle = FlatStyle.Flat;
            btnOpenMenu.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenMenu.Location = new Point(10, 10);
            btnOpenMenu.Margin = new Padding(10);
            btnOpenMenu.Name = "btnOpenMenu";
            btnOpenMenu.Size = new Size(59, 50);
            btnOpenMenu.TabIndex = 4;
            btnOpenMenu.Text = "☰";
            btnOpenMenu.UseVisualStyleBackColor = false;
            btnOpenMenu.Click += BtnOpenMenu_Click;
            // 
            // menuPanel
            // 
            menuPanel.AutoScroll = true;
            menuPanel.BackColor = Color.WhiteSmoke;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(tableLayoutPanel3);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(349, 704);
            menuPanel.TabIndex = 2;
            menuPanel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnCloseMenu, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCalculator, 0, 1);
            tableLayoutPanel3.Controls.Add(btnCurrencyConverter, 0, 2);
            tableLayoutPanel3.Controls.Add(btnUnitConverter, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(347, 702);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnCloseMenu
            // 
            btnCloseMenu.AutoSize = true;
            btnCloseMenu.BackColor = Color.WhiteSmoke;
            btnCloseMenu.FlatAppearance.BorderSize = 0;
            btnCloseMenu.FlatStyle = FlatStyle.Flat;
            btnCloseMenu.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseMenu.Location = new Point(10, 10);
            btnCloseMenu.Margin = new Padding(10);
            btnCloseMenu.Name = "btnCloseMenu";
            btnCloseMenu.Size = new Size(59, 50);
            btnCloseMenu.TabIndex = 0;
            btnCloseMenu.Text = "☰";
            btnCloseMenu.UseVisualStyleBackColor = false;
            btnCloseMenu.Click += BtnCloseMenu_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.BackColor = SystemColors.ControlLight;
            btnCalculator.Dock = DockStyle.Fill;
            btnCalculator.FlatAppearance.BorderSize = 0;
            btnCalculator.FlatStyle = FlatStyle.Flat;
            btnCalculator.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculator.Location = new Point(0, 73);
            btnCalculator.Margin = new Padding(0, 3, 0, 3);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Padding = new Padding(20, 0, 0, 0);
            btnCalculator.Size = new Size(347, 64);
            btnCalculator.TabIndex = 1;
            btnCalculator.Text = "計算機";
            btnCalculator.TextAlign = ContentAlignment.MiddleLeft;
            btnCalculator.UseVisualStyleBackColor = false;
            btnCalculator.Click += BtnCalculator_Click;
            // 
            // btnCurrencyConverter
            // 
            btnCurrencyConverter.Dock = DockStyle.Fill;
            btnCurrencyConverter.Enabled = false;
            btnCurrencyConverter.FlatAppearance.BorderSize = 0;
            btnCurrencyConverter.FlatStyle = FlatStyle.Flat;
            btnCurrencyConverter.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCurrencyConverter.Location = new Point(0, 143);
            btnCurrencyConverter.Margin = new Padding(0, 3, 0, 3);
            btnCurrencyConverter.Name = "btnCurrencyConverter";
            btnCurrencyConverter.Padding = new Padding(20, 0, 0, 0);
            btnCurrencyConverter.Size = new Size(347, 64);
            btnCurrencyConverter.TabIndex = 2;
            btnCurrencyConverter.Text = "匯率轉換";
            btnCurrencyConverter.TextAlign = ContentAlignment.MiddleLeft;
            btnCurrencyConverter.UseVisualStyleBackColor = true;
            btnCurrencyConverter.Click += BtnCurrencyConverter_Click;
            // 
            // btnUnitConverter
            // 
            btnUnitConverter.Dock = DockStyle.Fill;
            btnUnitConverter.Enabled = false;
            btnUnitConverter.FlatAppearance.BorderSize = 0;
            btnUnitConverter.FlatStyle = FlatStyle.Flat;
            btnUnitConverter.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnitConverter.Location = new Point(0, 213);
            btnUnitConverter.Margin = new Padding(0, 3, 0, 3);
            btnUnitConverter.Name = "btnUnitConverter";
            btnUnitConverter.Padding = new Padding(20, 0, 0, 0);
            btnUnitConverter.Size = new Size(347, 64);
            btnUnitConverter.TabIndex = 3;
            btnUnitConverter.Text = "單位轉換";
            btnUnitConverter.TextAlign = ContentAlignment.MiddleLeft;
            btnUnitConverter.UseVisualStyleBackColor = true;
            btnUnitConverter.Click += BtnUnitConverter_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 704);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuPanel);
            MinimumSize = new Size(500, 760);
            Name = "Calculator";
            Text = "計算機";
            Resize += Calculator_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnPercent;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnReciprocal;
        private Button btnPower;
        private Button btnSquareRoot;
        private Button btnDivide;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiply;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSubtract;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnAdd;
        private Button btnToggleSign;
        private Button btnZero;
        private Button btnDecimal;
        private Button btnEquals;
        private TextBox txtDisplay;
        private Label txtExpression;
        private Button btnOpenMenu;
        private Panel menuPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCloseMenu;
        private Button btnCalculator;
        private Button btnCurrencyConverter;
        private Button btnUnitConverter;
    }
}
