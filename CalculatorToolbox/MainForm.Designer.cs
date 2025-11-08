namespace CalculatorToolbox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuPanel = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCalculator = new Button();
            btnCurrencyConverter = new Button();
            btnUnitConverter = new Button();
            btnMenu = new Button();
            menuPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.AutoScroll = true;
            menuPanel.BackColor = Color.WhiteSmoke;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(tableLayoutPanel3);
            menuPanel.Dock = DockStyle.Left;
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
            btnUnitConverter.Text = "單位換算";
            btnUnitConverter.TextAlign = ContentAlignment.MiddleLeft;
            btnUnitConverter.UseVisualStyleBackColor = true;
            btnUnitConverter.Click += BtnUnitConverter_Click;
            // 
            // btnMenu
            // 
            btnMenu.AutoSize = true;
            btnMenu.BackColor = Color.WhiteSmoke;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(10, 10);
            btnMenu.Margin = new Padding(10);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(59, 55);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += BtnMenu_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 704);
            Controls.Add(btnMenu);
            Controls.Add(menuPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 760);
            Name = "MainForm";
            Text = "計算機";
            menuPanel.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel menuPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnMenu;
        private Button btnCalculator;
        private Button btnCurrencyConverter;
        private Button btnUnitConverter;
    }
}
