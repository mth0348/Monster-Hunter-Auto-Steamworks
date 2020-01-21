using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MonsterHunterAutoSteamworks
{
	public partial class MainForm : Form
	{
		private KeyHandler globalKeyHandler;
		private bool _isRunning;
		private Timer _timer;

		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		public MainForm()
		{
			InitializeComponent();

			globalKeyHandler = new KeyHandler(Keys.F7, this);
			globalKeyHandler.Register();

			_timer = new Timer();
			_timer.Interval = 100;
			_timer.Tick += (sender, args) =>
			{
				SendKey();
			};
		}

		private void SendKey()
		{
			var programTitle = GetActiveWindowTitle();
			Console.WriteLine(programTitle);
			if (!ProgramCheckBox.Checked || programTitle.Contains(ProgramTitleTextBox.Text))
			{
				AutoIt.AutoItX.Send(KeyTextBox.Text, mode: 0);
			}
		}

		private string GetActiveWindowTitle()
		{
			const int nChars = 256;
			StringBuilder Buff = new StringBuilder(nChars);
			IntPtr handle = GetForegroundWindow();

			if (GetWindowText(handle, Buff, nChars) > 0)
			{
				return Buff.ToString();
			}
			return null;
		}

		private void HandleHotkey()
		{
			_timer.Interval = (int)TimerIntervalTextBox.Value;

			_isRunning = !_isRunning;
			LabelRunning.Visible = _isRunning;
			GroupBox.Enabled = !_isRunning;

			if (_isRunning)
			{
				this.BackColor = Color.IndianRed;
				_timer.Start();
			}
			else
			{
				this.BackColor = SystemColors.Control;
				_timer.Stop();
			}
		}

		protected override void WndProc(ref Message message)
		{
			if (message.Msg == Constants.WM_HOTKEY_MSG_ID)
				HandleHotkey();
			base.WndProc(ref message);
		}

		private void ProgramCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckboxText.Enabled = ProgramCheckBox.Checked;
			ProgramTitleTextBox.Enabled = ProgramCheckBox.Checked;
		}
	}
}
