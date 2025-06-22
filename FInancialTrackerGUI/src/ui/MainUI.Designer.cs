namespace FInancialTrackerGUI
{
	partial class MainUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			SideBarPanel = new Panel();
			SavingsBtn = new Button();
			ExpensesBtn = new Button();
			IncomeBtn = new Button();
			DashboardBtn = new Button();
			ExpensesPanel = new Panel();
			ExpenseClearButton = new Button();
			ExpenseSubmitButton = new Button();
			ExpenseTextBox = new TextBox();
			ExpenseLabel = new Label();
			ExpenseMonthComboBox = new ComboBox();
			ExpenseMonthLabel = new Label();
			DashboardMainPanel = new Panel();
			DashboardTopPanel = new Panel();
			TotalBalanceValueLabel = new Label();
			TotalExpensesValueLabel = new Label();
			NetWorthValueLabel = new Label();
			TotalBalanceLabel = new Label();
			TotalExpensesLabel = new Label();
			NetWorthLabel = new Label();
			DashboardBottomPanel = new Panel();
			NetWorthGrowthPlot = new ScottPlot.WinForms.FormsPlot();
			SavingsPanel = new Panel();
			SavingsTypeComboBox = new ComboBox();
			SavingsMonthComboBox = new ComboBox();
			SavingsAmountLabel = new Label();
			SavingsAmountTextBox = new TextBox();
			SavingsClearButton = new Button();
			SavingsSubmitButton = new Button();
			SavingsTypeLabel = new Label();
			SavingsMonthLabel = new Label();
			IncomePanel = new Panel();
			ClearButton = new Button();
			SubmitButton = new Button();
			MonthComboBox = new ComboBox();
			IncomeMonthLabel = new Label();
			IncomeFromOthersLabel = new Label();
			IncomeFromOthersTextBox = new TextBox();
			IncomeFromSalaryTextBox = new TextBox();
			SalariedIncomeLabel = new Label();
			SideBarPanel.SuspendLayout();
			ExpensesPanel.SuspendLayout();
			DashboardMainPanel.SuspendLayout();
			DashboardTopPanel.SuspendLayout();
			DashboardBottomPanel.SuspendLayout();
			SavingsPanel.SuspendLayout();
			IncomePanel.SuspendLayout();
			SuspendLayout();
			// 
			// SideBarPanel
			// 
			SideBarPanel.Controls.Add(SavingsBtn);
			SideBarPanel.Controls.Add(ExpensesBtn);
			SideBarPanel.Controls.Add(IncomeBtn);
			SideBarPanel.Controls.Add(DashboardBtn);
			SideBarPanel.Dock = DockStyle.Left;
			SideBarPanel.Location = new Point(0, 0);
			SideBarPanel.Name = "SideBarPanel";
			SideBarPanel.Size = new Size(300, 698);
			SideBarPanel.TabIndex = 0;
			// 
			// SavingsBtn
			// 
			SavingsBtn.BackColor = Color.FromArgb(29, 36, 44);
			SavingsBtn.ForeColor = Color.White;
			SavingsBtn.Location = new Point(23, 244);
			SavingsBtn.Name = "SavingsBtn";
			SavingsBtn.Size = new Size(255, 47);
			SavingsBtn.TabIndex = 3;
			SavingsBtn.Text = "Savings";
			SavingsBtn.UseVisualStyleBackColor = false;
			SavingsBtn.Click += SavingsBtn_Click;
			// 
			// ExpensesBtn
			// 
			ExpensesBtn.BackColor = Color.FromArgb(29, 36, 44);
			ExpensesBtn.ForeColor = Color.White;
			ExpensesBtn.Location = new Point(23, 172);
			ExpensesBtn.Name = "ExpensesBtn";
			ExpensesBtn.Size = new Size(255, 47);
			ExpensesBtn.TabIndex = 2;
			ExpensesBtn.Text = "Expenses";
			ExpensesBtn.UseVisualStyleBackColor = false;
			ExpensesBtn.Click += ExpensesBtn_Click;
			// 
			// IncomeBtn
			// 
			IncomeBtn.BackColor = Color.FromArgb(29, 36, 44);
			IncomeBtn.ForeColor = Color.White;
			IncomeBtn.Location = new Point(23, 104);
			IncomeBtn.Name = "IncomeBtn";
			IncomeBtn.Size = new Size(255, 46);
			IncomeBtn.TabIndex = 1;
			IncomeBtn.Text = "Income";
			IncomeBtn.UseVisualStyleBackColor = false;
			IncomeBtn.Click += IncomeBtn_Click;
			// 
			// DashboardBtn
			// 
			DashboardBtn.ForeColor = Color.White;
			DashboardBtn.Location = new Point(23, 34);
			DashboardBtn.Name = "DashboardBtn";
			DashboardBtn.Size = new Size(255, 45);
			DashboardBtn.TabIndex = 0;
			DashboardBtn.Text = "Dashboard";
			DashboardBtn.UseVisualStyleBackColor = false;
			DashboardBtn.Click += DashboardBtn_Click;
			// 
			// ExpensesPanel
			// 
			ExpensesPanel.BackColor = Color.FromArgb(64, 64, 64);
			ExpensesPanel.Controls.Add(ExpenseClearButton);
			ExpensesPanel.Controls.Add(ExpenseSubmitButton);
			ExpensesPanel.Controls.Add(ExpenseTextBox);
			ExpensesPanel.Controls.Add(ExpenseLabel);
			ExpensesPanel.Controls.Add(ExpenseMonthComboBox);
			ExpensesPanel.Controls.Add(ExpenseMonthLabel);
			ExpensesPanel.Dock = DockStyle.Fill;
			ExpensesPanel.Location = new Point(300, 0);
			ExpensesPanel.Name = "ExpensesPanel";
			ExpensesPanel.Size = new Size(36, 698);
			ExpensesPanel.TabIndex = 8;
			ExpensesPanel.Visible = false;
			// 
			// ExpenseClearButton
			// 
			ExpenseClearButton.Location = new Point(376, 235);
			ExpenseClearButton.Name = "ExpenseClearButton";
			ExpenseClearButton.Size = new Size(146, 34);
			ExpenseClearButton.TabIndex = 5;
			ExpenseClearButton.Text = "Clear";
			ExpenseClearButton.UseVisualStyleBackColor = true;
			// 
			// ExpenseSubmitButton
			// 
			ExpenseSubmitButton.Location = new Point(180, 235);
			ExpenseSubmitButton.Name = "ExpenseSubmitButton";
			ExpenseSubmitButton.Size = new Size(146, 34);
			ExpenseSubmitButton.TabIndex = 4;
			ExpenseSubmitButton.Text = "Submit";
			ExpenseSubmitButton.UseVisualStyleBackColor = true;
			// 
			// ExpenseTextBox
			// 
			ExpenseTextBox.Location = new Point(396, 138);
			ExpenseTextBox.Name = "ExpenseTextBox";
			ExpenseTextBox.Size = new Size(199, 31);
			ExpenseTextBox.TabIndex = 3;
			// 
			// ExpenseLabel
			// 
			ExpenseLabel.AutoSize = true;
			ExpenseLabel.ForeColor = Color.White;
			ExpenseLabel.Location = new Point(109, 144);
			ExpenseLabel.Name = "ExpenseLabel";
			ExpenseLabel.Size = new Size(76, 25);
			ExpenseLabel.TabIndex = 2;
			ExpenseLabel.Text = "Expense";
			// 
			// ExpenseMonthComboBox
			// 
			ExpenseMonthComboBox.FormattingEnabled = true;
			ExpenseMonthComboBox.Location = new Point(396, 54);
			ExpenseMonthComboBox.Name = "ExpenseMonthComboBox";
			ExpenseMonthComboBox.Size = new Size(199, 33);
			ExpenseMonthComboBox.TabIndex = 1;
			// 
			// ExpenseMonthLabel
			// 
			ExpenseMonthLabel.AutoSize = true;
			ExpenseMonthLabel.ForeColor = Color.White;
			ExpenseMonthLabel.Location = new Point(109, 62);
			ExpenseMonthLabel.Name = "ExpenseMonthLabel";
			ExpenseMonthLabel.Size = new Size(65, 25);
			ExpenseMonthLabel.TabIndex = 0;
			ExpenseMonthLabel.Text = "Month";
			// 
			// DashboardMainPanel
			// 
			DashboardMainPanel.Controls.Add(DashboardTopPanel);
			DashboardMainPanel.Controls.Add(DashboardBottomPanel);
			DashboardMainPanel.Dock = DockStyle.Fill;
			DashboardMainPanel.Location = new Point(300, 0);
			DashboardMainPanel.Name = "DashboardMainPanel";
			DashboardMainPanel.Size = new Size(745, 698);
			DashboardMainPanel.TabIndex = 0;
			DashboardMainPanel.Paint += panel1_Paint;
			// 
			// DashboardTopPanel
			// 
			DashboardTopPanel.BackColor = Color.FromArgb(64, 64, 64);
			DashboardTopPanel.Controls.Add(TotalBalanceValueLabel);
			DashboardTopPanel.Controls.Add(TotalExpensesValueLabel);
			DashboardTopPanel.Controls.Add(NetWorthValueLabel);
			DashboardTopPanel.Controls.Add(TotalBalanceLabel);
			DashboardTopPanel.Controls.Add(TotalExpensesLabel);
			DashboardTopPanel.Controls.Add(NetWorthLabel);
			DashboardTopPanel.Location = new Point(15, 12);
			DashboardTopPanel.Name = "DashboardTopPanel";
			DashboardTopPanel.Size = new Size(712, 126);
			DashboardTopPanel.TabIndex = 1;
			// 
			// TotalBalanceValueLabel
			// 
			TotalBalanceValueLabel.AutoSize = true;
			TotalBalanceValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			TotalBalanceValueLabel.ForeColor = Color.White;
			TotalBalanceValueLabel.Location = new Point(493, 72);
			TotalBalanceValueLabel.Name = "TotalBalanceValueLabel";
			TotalBalanceValueLabel.Size = new Size(82, 45);
			TotalBalanceValueLabel.TabIndex = 5;
			TotalBalanceValueLabel.Text = "Rs 0";
			// 
			// TotalExpensesValueLabel
			// 
			TotalExpensesValueLabel.AutoSize = true;
			TotalExpensesValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			TotalExpensesValueLabel.ForeColor = Color.White;
			TotalExpensesValueLabel.Location = new Point(247, 72);
			TotalExpensesValueLabel.Name = "TotalExpensesValueLabel";
			TotalExpensesValueLabel.Size = new Size(82, 45);
			TotalExpensesValueLabel.TabIndex = 4;
			TotalExpensesValueLabel.Text = "Rs 0";
			// 
			// NetWorthValueLabel
			// 
			NetWorthValueLabel.AutoSize = true;
			NetWorthValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			NetWorthValueLabel.ForeColor = Color.White;
			NetWorthValueLabel.Location = new Point(19, 72);
			NetWorthValueLabel.Name = "NetWorthValueLabel";
			NetWorthValueLabel.Size = new Size(82, 45);
			NetWorthValueLabel.TabIndex = 3;
			NetWorthValueLabel.Text = "Rs 0";
			// 
			// TotalBalanceLabel
			// 
			TotalBalanceLabel.AutoSize = true;
			TotalBalanceLabel.Font = new Font("Segoe UI", 14F);
			TotalBalanceLabel.ForeColor = Color.White;
			TotalBalanceLabel.Location = new Point(493, 18);
			TotalBalanceLabel.Name = "TotalBalanceLabel";
			TotalBalanceLabel.Size = new Size(178, 38);
			TotalBalanceLabel.TabIndex = 2;
			TotalBalanceLabel.Text = "Total Balance";
			// 
			// TotalExpensesLabel
			// 
			TotalExpensesLabel.AutoSize = true;
			TotalExpensesLabel.Font = new Font("Segoe UI", 14F);
			TotalExpensesLabel.ForeColor = Color.White;
			TotalExpensesLabel.Location = new Point(247, 18);
			TotalExpensesLabel.Name = "TotalExpensesLabel";
			TotalExpensesLabel.Size = new Size(196, 38);
			TotalExpensesLabel.TabIndex = 1;
			TotalExpensesLabel.Text = "Total Expenses";
			// 
			// NetWorthLabel
			// 
			NetWorthLabel.AutoSize = true;
			NetWorthLabel.Font = new Font("Segoe UI", 14F);
			NetWorthLabel.ForeColor = Color.White;
			NetWorthLabel.Location = new Point(19, 18);
			NetWorthLabel.Name = "NetWorthLabel";
			NetWorthLabel.Size = new Size(146, 38);
			NetWorthLabel.TabIndex = 0;
			NetWorthLabel.Text = "Net Worth";
			// 
			// DashboardBottomPanel
			// 
			DashboardBottomPanel.BackColor = Color.FromArgb(64, 64, 64);
			DashboardBottomPanel.Controls.Add(NetWorthGrowthPlot);
			DashboardBottomPanel.Location = new Point(15, 159);
			DashboardBottomPanel.Name = "DashboardBottomPanel";
			DashboardBottomPanel.Size = new Size(712, 514);
			DashboardBottomPanel.TabIndex = 2;
			// 
			// NetWorthGrowthPlot
			// 
			NetWorthGrowthPlot.BackColor = Color.DimGray;
			NetWorthGrowthPlot.DisplayScale = 1.5F;
			NetWorthGrowthPlot.ForeColor = Color.Black;
			NetWorthGrowthPlot.Location = new Point(19, 23);
			NetWorthGrowthPlot.Name = "NetWorthGrowthPlot";
			NetWorthGrowthPlot.Size = new Size(672, 405);
			NetWorthGrowthPlot.TabIndex = 0;
			// 
			// SavingsPanel
			// 
			SavingsPanel.BackColor = Color.FromArgb(64, 64, 64);
			SavingsPanel.Controls.Add(SavingsTypeComboBox);
			SavingsPanel.Controls.Add(SavingsMonthComboBox);
			SavingsPanel.Controls.Add(SavingsAmountLabel);
			SavingsPanel.Controls.Add(SavingsAmountTextBox);
			SavingsPanel.Controls.Add(SavingsClearButton);
			SavingsPanel.Controls.Add(SavingsSubmitButton);
			SavingsPanel.Controls.Add(SavingsTypeLabel);
			SavingsPanel.Controls.Add(SavingsMonthLabel);
			SavingsPanel.Dock = DockStyle.Right;
			SavingsPanel.Location = new Point(336, 0);
			SavingsPanel.Name = "SavingsPanel";
			SavingsPanel.Size = new Size(709, 698);
			SavingsPanel.TabIndex = 6;
			SavingsPanel.Visible = false;
			// 
			// SavingsTypeComboBox
			// 
			SavingsTypeComboBox.FormattingEnabled = true;
			SavingsTypeComboBox.Location = new Point(396, 103);
			SavingsTypeComboBox.Name = "SavingsTypeComboBox";
			SavingsTypeComboBox.Size = new Size(205, 33);
			SavingsTypeComboBox.TabIndex = 8;
			// 
			// SavingsMonthComboBox
			// 
			SavingsMonthComboBox.FormattingEnabled = true;
			SavingsMonthComboBox.Location = new Point(396, 48);
			SavingsMonthComboBox.Name = "SavingsMonthComboBox";
			SavingsMonthComboBox.Size = new Size(205, 33);
			SavingsMonthComboBox.TabIndex = 7;
			// 
			// SavingsAmountLabel
			// 
			SavingsAmountLabel.AutoSize = true;
			SavingsAmountLabel.ForeColor = Color.White;
			SavingsAmountLabel.Location = new Point(92, 166);
			SavingsAmountLabel.Name = "SavingsAmountLabel";
			SavingsAmountLabel.Size = new Size(77, 25);
			SavingsAmountLabel.TabIndex = 6;
			SavingsAmountLabel.Text = "Amount";
			// 
			// SavingsAmountTextBox
			// 
			SavingsAmountTextBox.Location = new Point(396, 160);
			SavingsAmountTextBox.Name = "SavingsAmountTextBox";
			SavingsAmountTextBox.Size = new Size(205, 31);
			SavingsAmountTextBox.TabIndex = 5;
			// 
			// SavingsClearButton
			// 
			SavingsClearButton.Location = new Point(376, 271);
			SavingsClearButton.Name = "SavingsClearButton";
			SavingsClearButton.Size = new Size(144, 34);
			SavingsClearButton.TabIndex = 3;
			SavingsClearButton.Text = "Clear";
			SavingsClearButton.UseVisualStyleBackColor = true;
			// 
			// SavingsSubmitButton
			// 
			SavingsSubmitButton.Location = new Point(178, 271);
			SavingsSubmitButton.Name = "SavingsSubmitButton";
			SavingsSubmitButton.Size = new Size(146, 34);
			SavingsSubmitButton.TabIndex = 2;
			SavingsSubmitButton.Text = "Submit";
			SavingsSubmitButton.UseVisualStyleBackColor = true;
			// 
			// SavingsTypeLabel
			// 
			SavingsTypeLabel.AutoSize = true;
			SavingsTypeLabel.ForeColor = Color.White;
			SavingsTypeLabel.Location = new Point(92, 111);
			SavingsTypeLabel.Name = "SavingsTypeLabel";
			SavingsTypeLabel.Size = new Size(115, 25);
			SavingsTypeLabel.TabIndex = 1;
			SavingsTypeLabel.Text = "Savings Type";
			// 
			// SavingsMonthLabel
			// 
			SavingsMonthLabel.AutoSize = true;
			SavingsMonthLabel.ForeColor = Color.White;
			SavingsMonthLabel.Location = new Point(92, 56);
			SavingsMonthLabel.Name = "SavingsMonthLabel";
			SavingsMonthLabel.Size = new Size(65, 25);
			SavingsMonthLabel.TabIndex = 0;
			SavingsMonthLabel.Text = "Month";
			// 
			// IncomePanel
			// 
			IncomePanel.BackColor = Color.FromArgb(64, 64, 64);
			IncomePanel.Controls.Add(ClearButton);
			IncomePanel.Controls.Add(SubmitButton);
			IncomePanel.Controls.Add(MonthComboBox);
			IncomePanel.Controls.Add(IncomeMonthLabel);
			IncomePanel.Controls.Add(IncomeFromOthersLabel);
			IncomePanel.Controls.Add(IncomeFromOthersTextBox);
			IncomePanel.Controls.Add(IncomeFromSalaryTextBox);
			IncomePanel.Controls.Add(SalariedIncomeLabel);
			IncomePanel.Dock = DockStyle.Fill;
			IncomePanel.Location = new Point(300, 0);
			IncomePanel.Name = "IncomePanel";
			IncomePanel.Size = new Size(36, 698);
			IncomePanel.TabIndex = 1;
			IncomePanel.Visible = false;
			// 
			// ClearButton
			// 
			ClearButton.Location = new Point(349, 275);
			ClearButton.Name = "ClearButton";
			ClearButton.Size = new Size(151, 34);
			ClearButton.TabIndex = 7;
			ClearButton.Text = "Clear";
			ClearButton.UseVisualStyleBackColor = true;
			// 
			// SubmitButton
			// 
			SubmitButton.Location = new Point(163, 275);
			SubmitButton.Name = "SubmitButton";
			SubmitButton.Size = new Size(151, 34);
			SubmitButton.TabIndex = 6;
			SubmitButton.Text = "Submit";
			SubmitButton.UseVisualStyleBackColor = true;
			// 
			// MonthComboBox
			// 
			MonthComboBox.FormattingEnabled = true;
			MonthComboBox.Location = new Point(400, 50);
			MonthComboBox.Name = "MonthComboBox";
			MonthComboBox.Size = new Size(201, 33);
			MonthComboBox.TabIndex = 5;
			// 
			// IncomeMonthLabel
			// 
			IncomeMonthLabel.AutoSize = true;
			IncomeMonthLabel.ForeColor = Color.White;
			IncomeMonthLabel.Location = new Point(34, 53);
			IncomeMonthLabel.Name = "IncomeMonthLabel";
			IncomeMonthLabel.Size = new Size(65, 25);
			IncomeMonthLabel.TabIndex = 4;
			IncomeMonthLabel.Text = "Month";
			// 
			// IncomeFromOthersLabel
			// 
			IncomeFromOthersLabel.AutoSize = true;
			IncomeFromOthersLabel.ForeColor = Color.White;
			IncomeFromOthersLabel.Location = new Point(34, 179);
			IncomeFromOthersLabel.Name = "IncomeFromOthersLabel";
			IncomeFromOthersLabel.Size = new Size(235, 25);
			IncomeFromOthersLabel.TabIndex = 3;
			IncomeFromOthersLabel.Text = "Income From Other Sources";
			// 
			// IncomeFromOthersTextBox
			// 
			IncomeFromOthersTextBox.Location = new Point(399, 173);
			IncomeFromOthersTextBox.Name = "IncomeFromOthersTextBox";
			IncomeFromOthersTextBox.Size = new Size(202, 31);
			IncomeFromOthersTextBox.TabIndex = 2;
			// 
			// IncomeFromSalaryTextBox
			// 
			IncomeFromSalaryTextBox.Location = new Point(399, 111);
			IncomeFromSalaryTextBox.Name = "IncomeFromSalaryTextBox";
			IncomeFromSalaryTextBox.Size = new Size(202, 31);
			IncomeFromSalaryTextBox.TabIndex = 1;
			// 
			// SalariedIncomeLabel
			// 
			SalariedIncomeLabel.AutoSize = true;
			SalariedIncomeLabel.ForeColor = Color.White;
			SalariedIncomeLabel.Location = new Point(34, 117);
			SalariedIncomeLabel.Name = "SalariedIncomeLabel";
			SalariedIncomeLabel.Size = new Size(138, 25);
			SalariedIncomeLabel.TabIndex = 0;
			SalariedIncomeLabel.Text = "Salaried Income";
			// 
			// MainUI
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(29, 36, 44);
			ClientSize = new Size(1045, 698);
			Controls.Add(ExpensesPanel);
			Controls.Add(IncomePanel);
			Controls.Add(SavingsPanel);
			Controls.Add(DashboardMainPanel);
			Controls.Add(SideBarPanel);
			Name = "MainUI";
			Text = "Financial Tracker";
			SideBarPanel.ResumeLayout(false);
			ExpensesPanel.ResumeLayout(false);
			ExpensesPanel.PerformLayout();
			DashboardMainPanel.ResumeLayout(false);
			DashboardTopPanel.ResumeLayout(false);
			DashboardTopPanel.PerformLayout();
			DashboardBottomPanel.ResumeLayout(false);
			SavingsPanel.ResumeLayout(false);
			SavingsPanel.PerformLayout();
			IncomePanel.ResumeLayout(false);
			IncomePanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel SideBarPanel;
		private Panel DashboardTopPanel;
		private Panel DashboardMainPanel;
		private Panel DashboardBottomPanel;
		private Label TotalBalanceLabel;
		private Label TotalExpensesLabel;
		private Label NetWorthLabel;
		private Label TotalBalanceValueLabel;
		private Label TotalExpensesValueLabel;
		private Label NetWorthValueLabel;
		private Button ExpensesBtn;
		private Button IncomeBtn;
		private Button DashboardBtn;
		private Button SavingsBtn;
		private ScottPlot.WinForms.FormsPlot NetWorthGrowthPlot;
		private Panel IncomePanel;
		private Label IncomeFromOthersLabel;
		private TextBox IncomeFromOthersTextBox;
		private TextBox IncomeFromSalaryTextBox;
		private Label SalariedIncomeLabel;
		private ComboBox MonthComboBox;
		private Label IncomeMonthLabel;
		private Panel ExpensesPanel;
		private TextBox ExpenseTextBox;
		private Label ExpenseLabel;
		private ComboBox ExpenseMonthComboBox;
		private Label ExpenseMonthLabel;
		private Button ClearButton;
		private Button SubmitButton;
		private Panel SavingsPanel;
		private Button ExpenseClearButton;
		private Button ExpenseSubmitButton;
		private TextBox SavingsAmountTextBox;
		private Button SavingsClearButton;
		private Button SavingsSubmitButton;
		private Label SavingsTypeLabel;
		private Label SavingsMonthLabel;
		private ComboBox SavingsTypeComboBox;
		private ComboBox SavingsMonthComboBox;
		private Label SavingsAmountLabel;
	}
}