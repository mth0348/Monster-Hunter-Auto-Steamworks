namespace MonsterHunterAutoSteamworks
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.LabelRunning = new System.Windows.Forms.Label();
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.ProgramCheckBox = new System.Windows.Forms.CheckBox();
			this.TimerIntervalTextBox = new System.Windows.Forms.NumericUpDown();
			this.ProgramTitleTextBox = new System.Windows.Forms.TextBox();
			this.KeyTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.CheckboxText = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TimerIntervalTextBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Press F7 to start and stop...";
			// 
			// LabelRunning
			// 
			this.LabelRunning.AutoSize = true;
			this.LabelRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelRunning.Location = new System.Drawing.Point(96, 112);
			this.LabelRunning.Name = "LabelRunning";
			this.LabelRunning.Size = new System.Drawing.Size(114, 13);
			this.LabelRunning.TabIndex = 2;
			this.LabelRunning.Text = "currently running...";
			this.LabelRunning.Visible = false;
			// 
			// GroupBox
			// 
			this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox.Controls.Add(this.LabelRunning);
			this.GroupBox.Controls.Add(this.ProgramCheckBox);
			this.GroupBox.Controls.Add(this.TimerIntervalTextBox);
			this.GroupBox.Controls.Add(this.ProgramTitleTextBox);
			this.GroupBox.Controls.Add(this.KeyTextBox);
			this.GroupBox.Controls.Add(this.label4);
			this.GroupBox.Controls.Add(this.label3);
			this.GroupBox.Controls.Add(this.label5);
			this.GroupBox.Controls.Add(this.CheckboxText);
			this.GroupBox.Controls.Add(this.label2);
			this.GroupBox.Controls.Add(this.label1);
			this.GroupBox.Location = new System.Drawing.Point(12, 12);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(328, 150);
			this.GroupBox.TabIndex = 3;
			this.GroupBox.TabStop = false;
			this.GroupBox.Text = "Settings";
			// 
			// ProgramCheckBox
			// 
			this.ProgramCheckBox.AutoSize = true;
			this.ProgramCheckBox.Checked = true;
			this.ProgramCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ProgramCheckBox.Location = new System.Drawing.Point(9, 66);
			this.ProgramCheckBox.Name = "ProgramCheckBox";
			this.ProgramCheckBox.Size = new System.Drawing.Size(15, 14);
			this.ProgramCheckBox.TabIndex = 2;
			this.ProgramCheckBox.UseVisualStyleBackColor = true;
			this.ProgramCheckBox.CheckedChanged += new System.EventHandler(this.ProgramCheckBox_CheckedChanged);
			// 
			// TimerIntervalTextBox
			// 
			this.TimerIntervalTextBox.Location = new System.Drawing.Point(233, 17);
			this.TimerIntervalTextBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.TimerIntervalTextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.TimerIntervalTextBox.Name = "TimerIntervalTextBox";
			this.TimerIntervalTextBox.Size = new System.Drawing.Size(55, 20);
			this.TimerIntervalTextBox.TabIndex = 1;
			this.TimerIntervalTextBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// ProgramTitleTextBox
			// 
			this.ProgramTitleTextBox.Location = new System.Drawing.Point(204, 63);
			this.ProgramTitleTextBox.Name = "ProgramTitleTextBox";
			this.ProgramTitleTextBox.Size = new System.Drawing.Size(110, 20);
			this.ProgramTitleTextBox.TabIndex = 1;
			this.ProgramTitleTextBox.Text = "MONSTER HUNTER";
			// 
			// KeyTextBox
			// 
			this.KeyTextBox.Location = new System.Drawing.Point(130, 16);
			this.KeyTextBox.Name = "KeyTextBox";
			this.KeyTextBox.Size = new System.Drawing.Size(70, 20);
			this.KeyTextBox.TabIndex = 1;
			this.KeyTextBox.Text = "{SPACE}";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(291, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "ms.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "each";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(293, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "Use \'{\' and \'}\' for system keys like \'{space}\'. Use just \'A\' for the letter A.";
			// 
			// CheckboxText
			// 
			this.CheckboxText.AutoSize = true;
			this.CheckboxText.Location = new System.Drawing.Point(30, 66);
			this.CheckboxText.Name = "CheckboxText";
			this.CheckboxText.Size = new System.Drawing.Size(170, 13);
			this.CheckboxText.TabIndex = 0;
			this.CheckboxText.Text = "if the active window\'s title contains";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "This will repeatedly press ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(352, 174);
			this.Controls.Add(this.GroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Monster Hunter Auto-Steamworks";
			this.GroupBox.ResumeLayout(false);
			this.GroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TimerIntervalTextBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LabelRunning;
		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.TextBox KeyTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown TimerIntervalTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox ProgramCheckBox;
		private System.Windows.Forms.TextBox ProgramTitleTextBox;
		private System.Windows.Forms.Label CheckboxText;
		private System.Windows.Forms.Label label5;
	}
}

