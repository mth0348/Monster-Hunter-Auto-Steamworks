using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonsterHunterAutoSteamworks
{
	public partial class MainForm : Form
	{
		private readonly Timer _timer;
		private bool _isRunning;

		public MainForm()
		{
			InitializeComponent();

			_globalKeyHandler = new KeyHandler(Keys.F7, this);
			_globalKeyHandler.Register();

			_timer = new Timer();
			_timer.Tick += SendKey;
		}

		private void ProgramCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckboxText.Enabled = ProgramCheckBox.Checked;
			ProgramTitleTextBox.Enabled = ProgramCheckBox.Checked;
		}

		private void SendKey(object sender, EventArgs e)
		{
			string activeWindowTitle = ActiveWindow.GetTitle();

			if (!ProgramCheckBox.Checked || activeWindowTitle.Contains(ProgramTitleTextBox.Text))
			{
				AutoIt.AutoItX.Send(KeyTextBox.Text, mode: 0);
			}
		}

		protected override void WndProc(ref Message message)
		{
			if (message.Msg == Constants.WM_HOTKEY_MSG_ID)
			{
				HandleKeyPress();
			}
			base.WndProc(ref message);
		}

		private void HandleKeyPress()
		{
			_isRunning = !_isRunning;
			LabelRunning.Visible = _isRunning;
			GroupBox.Enabled = !_isRunning;

			if (_isRunning)
			{
				this.BackColor = Color.IndianRed;
				_timer.Interval = (int)TimerIntervalTextBox.Value;
				_timer.Start();
			}
			else
			{
				this.BackColor = SystemColors.Control;
				_timer.Stop();
			}
		}
	}
}
