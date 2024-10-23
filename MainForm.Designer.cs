
namespace ArkaneSystems.MouseJiggler
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			jiggleTimer = new System.Windows.Forms.Timer(components);
			flpLayout = new System.Windows.Forms.FlowLayoutPanel();
			panelBase = new System.Windows.Forms.Panel();
			cmdTrayify = new System.Windows.Forms.Button();
			cbSettings = new System.Windows.Forms.CheckBox();
			cbJiggling = new System.Windows.Forms.CheckBox();
			panelSettings = new System.Windows.Forms.Panel();
			cbKeys = new System.Windows.Forms.CheckBox();
			cbScroll = new System.Windows.Forms.CheckBox();
			lbPeriod = new System.Windows.Forms.Label();
			tbPeriod = new System.Windows.Forms.TrackBar();
			cbMinimize = new System.Windows.Forms.CheckBox();
			cbZen = new System.Windows.Forms.CheckBox();
			labelResponse = new System.Windows.Forms.Label();
			niTray = new System.Windows.Forms.NotifyIcon(components);
			timerMouseIdle = new System.Windows.Forms.Timer(components);
			flpLayout.SuspendLayout();
			panelBase.SuspendLayout();
			panelSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbPeriod).BeginInit();
			SuspendLayout();
			// 
			// jiggleTimer
			// 
			jiggleTimer.Interval = 1000;
			jiggleTimer.Tick += jiggleTimer_Tick;
			// 
			// flpLayout
			// 
			flpLayout.AutoSize = true;
			flpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flpLayout.Controls.Add(panelBase);
			flpLayout.Controls.Add(panelSettings);
			flpLayout.Controls.Add(labelResponse);
			flpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			flpLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			flpLayout.Location = new System.Drawing.Point(0, 0);
			flpLayout.Name = "flpLayout";
			flpLayout.Padding = new System.Windows.Forms.Padding(5);
			flpLayout.Size = new System.Drawing.Size(304, 180);
			flpLayout.TabIndex = 2;
			// 
			// panelBase
			// 
			panelBase.Controls.Add(cmdTrayify);
			panelBase.Controls.Add(cbSettings);
			panelBase.Controls.Add(cbJiggling);
			panelBase.Location = new System.Drawing.Point(8, 8);
			panelBase.Name = "panelBase";
			panelBase.Size = new System.Drawing.Size(289, 28);
			panelBase.TabIndex = 3;
			// 
			// cmdTrayify
			// 
			cmdTrayify.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			cmdTrayify.Location = new System.Drawing.Point(244, 2);
			cmdTrayify.Name = "cmdTrayify";
			cmdTrayify.Size = new System.Drawing.Size(40, 23);
			cmdTrayify.TabIndex = 3;
			cmdTrayify.Text = "-";
			cmdTrayify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			cmdTrayify.UseVisualStyleBackColor = true;
			cmdTrayify.Click += cmdTrayify_Click;
			// 
			// cbSettings
			// 
			cbSettings.Checked = true;
			cbSettings.CheckState = System.Windows.Forms.CheckState.Checked;
			cbSettings.Location = new System.Drawing.Point(88, 5);
			cbSettings.Name = "cbSettings";
			cbSettings.Size = new System.Drawing.Size(77, 19);
			cbSettings.TabIndex = 1;
			cbSettings.Text = "Settings...";
			cbSettings.UseVisualStyleBackColor = true;
			cbSettings.Visible = false;
			cbSettings.CheckedChanged += cbSettings_CheckedChanged;
			// 
			// cbJiggling
			// 
			cbJiggling.AutoSize = true;
			cbJiggling.Location = new System.Drawing.Point(10, 5);
			cbJiggling.Name = "cbJiggling";
			cbJiggling.Size = new System.Drawing.Size(72, 19);
			cbJiggling.TabIndex = 0;
			cbJiggling.Text = "Jiggling?";
			cbJiggling.UseVisualStyleBackColor = true;
			cbJiggling.CheckedChanged += cbJiggling_CheckedChanged;
			// 
			// panelSettings
			// 
			panelSettings.AutoSize = true;
			panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panelSettings.Controls.Add(cbKeys);
			panelSettings.Controls.Add(cbScroll);
			panelSettings.Controls.Add(lbPeriod);
			panelSettings.Controls.Add(tbPeriod);
			panelSettings.Controls.Add(cbMinimize);
			panelSettings.Controls.Add(cbZen);
			panelSettings.Location = new System.Drawing.Point(8, 42);
			panelSettings.Name = "panelSettings";
			panelSettings.Size = new System.Drawing.Size(290, 110);
			panelSettings.TabIndex = 2;
			panelSettings.Visible = false;
			// 
			// cbKeys
			// 
			cbKeys.AutoSize = true;
			cbKeys.Location = new System.Drawing.Point(184, 11);
			cbKeys.Name = "cbKeys";
			cbKeys.Size = new System.Drawing.Size(103, 19);
			cbKeys.TabIndex = 8;
			cbKeys.Text = "Random Keys?";
			cbKeys.UseVisualStyleBackColor = true;
			// 
			// cbScroll
			// 
			cbScroll.AutoSize = true;
			cbScroll.Location = new System.Drawing.Point(87, 11);
			cbScroll.Name = "cbScroll";
			cbScroll.Size = new System.Drawing.Size(99, 19);
			cbScroll.TabIndex = 7;
			cbScroll.Text = "Mouse Scroll?";
			cbScroll.UseVisualStyleBackColor = true;
			// 
			// lbPeriod
			// 
			lbPeriod.AutoSize = true;
			lbPeriod.Location = new System.Drawing.Point(253, 41);
			lbPeriod.Name = "lbPeriod";
			lbPeriod.Size = new System.Drawing.Size(21, 15);
			lbPeriod.TabIndex = 3;
			lbPeriod.Text = "1 s";
			// 
			// tbPeriod
			// 
			tbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			tbPeriod.Location = new System.Drawing.Point(2, 62);
			tbPeriod.Maximum = 60;
			tbPeriod.Minimum = 1;
			tbPeriod.Name = "tbPeriod";
			tbPeriod.Size = new System.Drawing.Size(282, 45);
			tbPeriod.TabIndex = 6;
			tbPeriod.TickFrequency = 2;
			tbPeriod.Value = 1;
			tbPeriod.ValueChanged += tbPeriod_ValueChanged;
			// 
			// cbMinimize
			// 
			cbMinimize.AutoSize = true;
			cbMinimize.Location = new System.Drawing.Point(7, 37);
			cbMinimize.Name = "cbMinimize";
			cbMinimize.Size = new System.Drawing.Size(123, 19);
			cbMinimize.TabIndex = 5;
			cbMinimize.Text = "Minimize on start?";
			cbMinimize.UseVisualStyleBackColor = true;
			cbMinimize.CheckedChanged += cbMinimize_CheckedChanged;
			// 
			// cbZen
			// 
			cbZen.AutoSize = true;
			cbZen.Location = new System.Drawing.Point(7, 11);
			cbZen.Name = "cbZen";
			cbZen.Size = new System.Drawing.Size(83, 19);
			cbZen.TabIndex = 4;
			cbZen.Text = "Zen jiggle?";
			cbZen.UseVisualStyleBackColor = true;
			cbZen.CheckedChanged += cbZen_CheckedChanged;
			// 
			// labelResponse
			// 
			labelResponse.AutoSize = true;
			labelResponse.Location = new System.Drawing.Point(8, 155);
			labelResponse.Name = "labelResponse";
			labelResponse.Size = new System.Drawing.Size(0, 15);
			labelResponse.TabIndex = 4;
			// 
			// niTray
			// 
			niTray.Icon = (System.Drawing.Icon)resources.GetObject("niTray.Icon");
			niTray.Text = "KJ Mouse";
			niTray.DoubleClick += niTray_DoubleClick;
			// 
			// timerMouseIdle
			// 
			timerMouseIdle.Interval = 1000;
			timerMouseIdle.Tick += timerMouseIdle_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			ClientSize = new System.Drawing.Size(304, 180);
			Controls.Add(flpLayout);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "MainForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Jiggler";
			Load += MainForm_Load;
			Shown += MainForm_Shown;
			flpLayout.ResumeLayout(false);
			flpLayout.PerformLayout();
			panelBase.ResumeLayout(false);
			panelBase.PerformLayout();
			panelSettings.ResumeLayout(false);
			panelSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tbPeriod).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.FlowLayoutPanel flpLayout;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TrackBar tbPeriod;
        private System.Windows.Forms.CheckBox cbMinimize;
        private System.Windows.Forms.CheckBox cbZen;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.CheckBox cbSettings;
        private System.Windows.Forms.CheckBox cbJiggling;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Button cmdTrayify;
        private System.Windows.Forms.CheckBox cbKeys;
        private System.Windows.Forms.CheckBox cbScroll;
		private System.Windows.Forms.Timer timerMouseIdle;
		private System.Windows.Forms.Label labelResponse;
	}
}

