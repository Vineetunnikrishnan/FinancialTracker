using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInancialTrackerGUI
{
	public partial class MainUI : Form
	{
		private Panel titleBar;
		private TableLayoutPanel layout;
		private Label closeBtn;

		public MainUI()
		{
			InitializeComponent();
			InitializeCustomTitleBar();
			InitializeTableLayout();
		}

		private void InitializeCustomTitleBar()
		{
			RemoveDefaultTitleBar();
			CreateCustomTitleBar();
			CreateCloseButton();
			
			closeBtn.Click += (s, e) => this.Close();
			titleBar.Controls.Add(closeBtn);
		}

		private void InitializeTableLayout()
		{
			CreateDynamicTableLayout();
			SetLayoutStyle();
			AddPanelsToLayout();

			this.Controls.Add(layout);
		}

		private void RemoveDefaultTitleBar()
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.Text = string.Empty;
			this.ControlBox = false;
		}

		private void CreateCustomTitleBar()
		{
			// Title bar (spans both columns)
			titleBar = new Panel
			{
				Dock = DockStyle.Fill,
				BackColor = Color.FromArgb(30, 30, 30)
			};
		}

		private void CreateCloseButton()
		{
			closeBtn = new Label
			{
				Text = "X", // Resembles the close button symbol
				ForeColor = Color.White,
				Width = 40,
				Dock = DockStyle.Right,
				TextAlign = ContentAlignment.MiddleCenter
			};
		}

		private void CreateDynamicTableLayout()
		{
			// Root layout
			layout = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				RowCount = 2,
				ColumnCount = 2
			};

		}

		private void SetLayoutStyle()
		{
			layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Title bar
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // Content
			layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300)); // Left panel
			layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 150));  // Main panel
			layout.SetColumnSpan(titleBar, 2);
		}

		private void AddPanelsToLayout()
		{
			layout.Controls.Add(titleBar, 0, 0);
			layout.Controls.Add(SideBarPanel, 0, 1);
			layout.Controls.Add(DashboardMainPanel, 1, 1);
			layout.Controls.Add(titleBar);
			layout.Controls.Add(IncomePanel);
			layout.Controls.Add(ExpensesPanel);
			layout.Controls.Add(SavingsPanel);
		}

		protected override void WndProc(ref Message m)
		{
			const int WM_NCHITTEST = 0x84;
			const int HT_CAPTION = 0x2;

			base.WndProc(ref m);

			if (m.Msg == WM_NCHITTEST && titleBar.ClientRectangle.Contains(PointToClient(Cursor.Position)))
			{
				m.Result = (IntPtr)HT_CAPTION;
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void TotalIncomValueLabel_Click(object sender, EventArgs e)
		{

		}

		private void DashboardBtn_Click(object sender, EventArgs e)
		{
			DashboardMainPanel.Visible = true;
			IncomePanel.Visible = false;
			ExpensesPanel.Visible = false;
			SavingsPanel.Visible = false;
		}

		private void IncomeBtn_Click(object sender, EventArgs e)
		{
			DashboardMainPanel.Visible = false;
			IncomePanel.Visible = true;
			ExpensesPanel.Visible = false;
			SavingsPanel.Visible = false;
		}

		private void ExpensesBtn_Click(object sender, EventArgs e)
		{
			DashboardMainPanel.Visible = false;
			IncomePanel.Visible = false;
			ExpensesPanel.Visible = true;
			SavingsPanel.Visible = false;
		}

		private void SavingsBtn_Click(object sender, EventArgs e)
		{
			DashboardMainPanel.Visible = false;
			IncomePanel.Visible = false;
			ExpensesPanel.Visible = false;
			SavingsPanel.Visible = true;
		}
	}
}
	