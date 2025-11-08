namespace CalculatorToolbox
{
    partial class Calculator
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
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
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtDisplay, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(txtExpression, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Size = new Size(500, 760);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Control;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Font = new Font("Segoe UI Symbol", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(3, 152);
            txtDisplay.Margin = new Padding(3, 0, 20, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(477, 75);
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
            tableLayoutPanel2.Location = new Point(3, 269);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(494, 488);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI Symbol", 14F);
            btnPercent.Location = new Point(3, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(117, 75);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += BtnPercent_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.Font = new Font("Segoe UI Symbol", 14F);
            btnClearEntry.Location = new Point(126, 3);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(117, 75);
            btnClearEntry.TabIndex = 1;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += BtnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI Symbol", 14F);
            btnClear.Location = new Point(249, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 75);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Segoe UI Symbol", 14F);
            btnBackspace.Location = new Point(372, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(119, 75);
            btnBackspace.TabIndex = 3;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += BtnBackspace_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Dock = DockStyle.Fill;
            btnReciprocal.Font = new Font("Segoe UI Symbol", 14F);
            btnReciprocal.Location = new Point(3, 84);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(117, 75);
            btnReciprocal.TabIndex = 4;
            btnReciprocal.Text = "¹/𝑥";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += BtnReciprocal_Click;
            // 
            // btnPower
            // 
            btnPower.Dock = DockStyle.Fill;
            btnPower.Font = new Font("Segoe UI Symbol", 14F);
            btnPower.Location = new Point(126, 84);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(117, 75);
            btnPower.TabIndex = 5;
            btnPower.Text = "𝑥ʸ";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += BtnPower_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Dock = DockStyle.Fill;
            btnSquareRoot.Font = new Font("Segoe UI Symbol", 14F);
            btnSquareRoot.Location = new Point(249, 84);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(117, 75);
            btnSquareRoot.TabIndex = 6;
            btnSquareRoot.Text = "√𝑥";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += BtnSquareRoot_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI Symbol", 14F);
            btnDivide.Location = new Point(372, 84);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(119, 75);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnDivide_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Font = new Font("Segoe UI Symbol", 14F);
            btnSeven.Location = new Point(3, 165);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(117, 75);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += BtnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Font = new Font("Segoe UI Symbol", 14F);
            btnEight.Location = new Point(126, 165);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(117, 75);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += BtnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Font = new Font("Segoe UI Symbol", 14F);
            btnNine.Location = new Point(249, 165);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(117, 75);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += BtnNine_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI Symbol", 14F);
            btnMultiply.Location = new Point(372, 165);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(119, 75);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnMultiply_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Font = new Font("Segoe UI Symbol", 14F);
            btnFour.Location = new Point(3, 246);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(117, 75);
            btnFour.TabIndex = 12;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += BtnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Font = new Font("Segoe UI Symbol", 14F);
            btnFive.Location = new Point(126, 246);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(117, 75);
            btnFive.TabIndex = 13;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += BtnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Font = new Font("Segoe UI Symbol", 14F);
            btnSix.Location = new Point(249, 246);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(117, 75);
            btnSix.TabIndex = 14;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += BtnSix_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Font = new Font("Segoe UI Symbol", 14F);
            btnSubtract.Location = new Point(372, 246);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(119, 75);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BtnSubtract_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Font = new Font("Segoe UI Symbol", 14F);
            btnOne.Location = new Point(3, 327);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(117, 75);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += BtnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Font = new Font("Segoe UI Symbol", 14F);
            btnTwo.Location = new Point(126, 327);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(117, 75);
            btnTwo.TabIndex = 17;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += BtnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Font = new Font("Segoe UI Symbol", 14F);
            btnThree.Location = new Point(249, 327);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(117, 75);
            btnThree.TabIndex = 18;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += BtnThree_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI Symbol", 14F);
            btnAdd.Location = new Point(372, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 75);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnToggleSign
            // 
            btnToggleSign.Dock = DockStyle.Fill;
            btnToggleSign.Font = new Font("Segoe UI Symbol", 14F);
            btnToggleSign.Location = new Point(3, 408);
            btnToggleSign.Name = "btnToggleSign";
            btnToggleSign.Size = new Size(117, 77);
            btnToggleSign.TabIndex = 20;
            btnToggleSign.Text = "⁺/₋";
            btnToggleSign.UseVisualStyleBackColor = true;
            btnToggleSign.Click += BtnToggleSign_Click;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Font = new Font("Segoe UI Symbol", 14F);
            btnZero.Location = new Point(126, 408);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(117, 77);
            btnZero.TabIndex = 21;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += BtnZero_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Font = new Font("Segoe UI Symbol", 14F);
            btnDecimal.Location = new Point(249, 408);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(117, 77);
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
            btnEquals.Location = new Point(372, 408);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(119, 77);
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
            txtExpression.Location = new Point(3, 76);
            txtExpression.Margin = new Padding(3, 0, 20, 0);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(477, 76);
            txtExpression.TabIndex = 3;
            txtExpression.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "Calculator";
            Size = new Size(500, 760);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDisplay;
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
        private Label txtExpression;
    }
}
