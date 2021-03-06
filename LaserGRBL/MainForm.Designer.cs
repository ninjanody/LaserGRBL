﻿namespace LaserGRBL
{
	partial class MainForm
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Liberare le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ConnectionForm = new LaserGRBL.ConnectLogForm();
			this.JogForm = new LaserGRBL.JogForm();
			this.PreviewForm = new LaserGRBL.PreviewForm();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.TTLLines = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTTLines = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTLEstimated = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTTEstimated = new System.Windows.Forms.ToolStripStatusLabel();
			this.spring = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTOvG0 = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTOvG1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTOvS = new System.Windows.Forms.ToolStripStatusLabel();
			this.spacer = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTLStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.TTTStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.MMn = new System.Windows.Forms.MenuStrip();
			this.grblToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MnConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.MnDisconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.MnGrblReset = new System.Windows.Forms.ToolStripMenuItem();
			this.MnGoHome = new System.Windows.Forms.ToolStripMenuItem();
			this.MnUnlock = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MnExportConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.MnImportConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.MnExit = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.MnSaveProgram = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.MnFileSend = new System.Windows.Forms.ToolStripMenuItem();
			this.linguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MNEnglish = new System.Windows.Forms.ToolStripMenuItem();
			this.MNItalian = new System.Windows.Forms.ToolStripMenuItem();
			this.MNSpanish = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpOnLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSessionLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.MMn.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ConnectionForm);
			this.splitContainer1.Panel1.Controls.Add(this.JogForm);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.PreviewForm);
			this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
			// 
			// ConnectionForm
			// 
			resources.ApplyResources(this.ConnectionForm, "ConnectionForm");
			this.ConnectionForm.Name = "ConnectionForm";
			// 
			// JogForm
			// 
			resources.ApplyResources(this.JogForm, "JogForm");
			this.JogForm.Name = "JogForm";
			// 
			// PreviewForm
			// 
			resources.ApplyResources(this.PreviewForm, "PreviewForm");
			this.PreviewForm.Name = "PreviewForm";
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTLLines,
            this.TTTLines,
            this.TTLEstimated,
            this.TTTEstimated,
            this.spring,
            this.TTOvG0,
            this.TTOvG1,
            this.TTOvS,
            this.spacer,
            this.TTLStatus,
            this.TTTStatus});
			resources.ApplyResources(this.StatusBar, "StatusBar");
			this.StatusBar.Name = "StatusBar";
			// 
			// TTLLines
			// 
			this.TTLLines.Name = "TTLLines";
			resources.ApplyResources(this.TTLLines, "TTLLines");
			// 
			// TTTLines
			// 
			this.TTTLines.Name = "TTTLines";
			resources.ApplyResources(this.TTTLines, "TTTLines");
			// 
			// TTLEstimated
			// 
			this.TTLEstimated.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.TTLEstimated.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.TTLEstimated.Name = "TTLEstimated";
			resources.ApplyResources(this.TTLEstimated, "TTLEstimated");
			// 
			// TTTEstimated
			// 
			this.TTTEstimated.Name = "TTTEstimated";
			resources.ApplyResources(this.TTTEstimated, "TTTEstimated");
			// 
			// spring
			// 
			this.spring.Name = "spring";
			resources.ApplyResources(this.spring, "spring");
			this.spring.Spring = true;
			// 
			// TTOvG0
			// 
			resources.ApplyResources(this.TTOvG0, "TTOvG0");
			this.TTOvG0.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.TTOvG0.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.TTOvG0.Name = "TTOvG0";
			this.TTOvG0.Click += new System.EventHandler(this.TTOvClick);
			// 
			// TTOvG1
			// 
			resources.ApplyResources(this.TTOvG1, "TTOvG1");
			this.TTOvG1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.TTOvG1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.TTOvG1.Name = "TTOvG1";
			this.TTOvG1.Click += new System.EventHandler(this.TTOvClick);
			// 
			// TTOvS
			// 
			resources.ApplyResources(this.TTOvS, "TTOvS");
			this.TTOvS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.TTOvS.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.TTOvS.Name = "TTOvS";
			this.TTOvS.Click += new System.EventHandler(this.TTOvClick);
			// 
			// spacer
			// 
			resources.ApplyResources(this.spacer, "spacer");
			this.spacer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.spacer.Name = "spacer";
			// 
			// TTLStatus
			// 
			this.TTLStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.TTLStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.TTLStatus.Name = "TTLStatus";
			resources.ApplyResources(this.TTLStatus, "TTLStatus");
			// 
			// TTTStatus
			// 
			this.TTTStatus.Name = "TTTStatus";
			resources.ApplyResources(this.TTTStatus, "TTTStatus");
			// 
			// UpdateTimer
			// 
			this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
			// 
			// MMn
			// 
			this.MMn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grblToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.linguaToolStripMenuItem,
            this.toolStripMenuItem4});
			resources.ApplyResources(this.MMn, "MMn");
			this.MMn.Name = "MMn";
			// 
			// grblToolStripMenuItem
			// 
			this.grblToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnConnect,
            this.MnDisconnect,
            this.toolStripMenuItem2,
            this.MnGrblReset,
            this.MnGoHome,
            this.MnUnlock,
            this.toolStripSeparator1,
            this.MnExportConfig,
            this.MnImportConfig,
            this.toolStripMenuItem3,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem6,
            this.MnExit});
			this.grblToolStripMenuItem.Name = "grblToolStripMenuItem";
			resources.ApplyResources(this.grblToolStripMenuItem, "grblToolStripMenuItem");
			// 
			// MnConnect
			// 
			resources.ApplyResources(this.MnConnect, "MnConnect");
			this.MnConnect.Name = "MnConnect";
			this.MnConnect.Click += new System.EventHandler(this.MnConnect_Click);
			// 
			// MnDisconnect
			// 
			resources.ApplyResources(this.MnDisconnect, "MnDisconnect");
			this.MnDisconnect.Name = "MnDisconnect";
			this.MnDisconnect.Click += new System.EventHandler(this.MnDisconnect_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			// 
			// MnGrblReset
			// 
			resources.ApplyResources(this.MnGrblReset, "MnGrblReset");
			this.MnGrblReset.Name = "MnGrblReset";
			this.MnGrblReset.Click += new System.EventHandler(this.MnGrblReset_Click);
			// 
			// MnGoHome
			// 
			resources.ApplyResources(this.MnGoHome, "MnGoHome");
			this.MnGoHome.Name = "MnGoHome";
			this.MnGoHome.Click += new System.EventHandler(this.MnGoHome_Click);
			// 
			// MnUnlock
			// 
			resources.ApplyResources(this.MnUnlock, "MnUnlock");
			this.MnUnlock.Name = "MnUnlock";
			this.MnUnlock.Click += new System.EventHandler(this.MnUnlock_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// MnExportConfig
			// 
			resources.ApplyResources(this.MnExportConfig, "MnExportConfig");
			this.MnExportConfig.Name = "MnExportConfig";
			this.MnExportConfig.Click += new System.EventHandler(this.MnExportConfigClick);
			// 
			// MnImportConfig
			// 
			resources.ApplyResources(this.MnImportConfig, "MnImportConfig");
			this.MnImportConfig.Name = "MnImportConfig";
			this.MnImportConfig.Click += new System.EventHandler(this.MnImportConfigClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
			// 
			// settingsToolStripMenuItem
			// 
			resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
			// 
			// MnExit
			// 
			resources.ApplyResources(this.MnExit, "MnExit");
			this.MnExit.Name = "MnExit";
			this.MnExit.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnFileOpen,
            this.MnSaveProgram,
            this.toolStripMenuItem1,
            this.MnFileSend});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// MnFileOpen
			// 
			resources.ApplyResources(this.MnFileOpen, "MnFileOpen");
			this.MnFileOpen.Name = "MnFileOpen";
			this.MnFileOpen.Click += new System.EventHandler(this.MnFileOpen_Click);
			// 
			// MnSaveProgram
			// 
			resources.ApplyResources(this.MnSaveProgram, "MnSaveProgram");
			this.MnSaveProgram.Name = "MnSaveProgram";
			this.MnSaveProgram.Click += new System.EventHandler(this.MnSaveProgramClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// MnFileSend
			// 
			resources.ApplyResources(this.MnFileSend, "MnFileSend");
			this.MnFileSend.Name = "MnFileSend";
			this.MnFileSend.Click += new System.EventHandler(this.MnFileSend_Click);
			// 
			// linguaToolStripMenuItem
			// 
			this.linguaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNEnglish,
            this.MNItalian,
            this.MNSpanish});
			this.linguaToolStripMenuItem.Name = "linguaToolStripMenuItem";
			resources.ApplyResources(this.linguaToolStripMenuItem, "linguaToolStripMenuItem");
			// 
			// MNEnglish
			// 
			resources.ApplyResources(this.MNEnglish, "MNEnglish");
			this.MNEnglish.Name = "MNEnglish";
			this.MNEnglish.Click += new System.EventHandler(this.MNEnglish_Click);
			// 
			// MNItalian
			// 
			resources.ApplyResources(this.MNItalian, "MNItalian");
			this.MNItalian.Name = "MNItalian";
			this.MNItalian.Click += new System.EventHandler(this.MNItalian_Click);
			// 
			// MNSpanish
			// 
			resources.ApplyResources(this.MNSpanish, "MNSpanish");
			this.MNSpanish.Name = "MNSpanish";
			this.MNSpanish.Click += new System.EventHandler(this.MNSpanish_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpOnLineToolStripMenuItem,
            this.autoUpdateToolStripMenuItem,
            this.toolStripMenuItem5,
            this.openSessionLogToolStripMenuItem,
            this.toolStripMenuItem7,
            this.aboutToolStripMenuItem});
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
			this.toolStripMenuItem4.DropDownOpening += new System.EventHandler(this.toolStripMenuItem4_DropDownOpening);
			// 
			// helpOnLineToolStripMenuItem
			// 
			this.helpOnLineToolStripMenuItem.Name = "helpOnLineToolStripMenuItem";
			resources.ApplyResources(this.helpOnLineToolStripMenuItem, "helpOnLineToolStripMenuItem");
			this.helpOnLineToolStripMenuItem.Click += new System.EventHandler(this.helpOnLineToolStripMenuItem_Click);
			// 
			// autoUpdateToolStripMenuItem
			// 
			this.autoUpdateToolStripMenuItem.Checked = true;
			this.autoUpdateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoUpdateToolStripMenuItem.Name = "autoUpdateToolStripMenuItem";
			resources.ApplyResources(this.autoUpdateToolStripMenuItem, "autoUpdateToolStripMenuItem");
			this.autoUpdateToolStripMenuItem.Click += new System.EventHandler(this.autoUpdateToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// openSessionLogToolStripMenuItem
			// 
			this.openSessionLogToolStripMenuItem.Name = "openSessionLogToolStripMenuItem";
			resources.ApplyResources(this.openSessionLogToolStripMenuItem, "openSessionLogToolStripMenuItem");
			this.openSessionLogToolStripMenuItem.Click += new System.EventHandler(this.openSessionLogToolStripMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.MMn);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.MMn.ResumeLayout(false);
			this.MMn.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel TTLLines;
		private System.Windows.Forms.ToolStripStatusLabel TTLEstimated;
		private System.Windows.Forms.ToolStripStatusLabel TTTEstimated;
		private System.Windows.Forms.MenuStrip MMn;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MnFileOpen;
		private System.Windows.Forms.ToolStripMenuItem MnFileSend;
		private System.Windows.Forms.ToolStripMenuItem grblToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MnGrblReset;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MnExportConfig;
		private System.Windows.Forms.ToolStripMenuItem MnImportConfig;
		private System.Windows.Forms.Timer UpdateTimer;
		private System.Windows.Forms.ToolStripStatusLabel spring;
		private System.Windows.Forms.ToolStripStatusLabel TTLStatus;
		private System.Windows.Forms.ToolStripStatusLabel TTOvG0;
		private System.Windows.Forms.ToolStripStatusLabel TTOvG1;
		private System.Windows.Forms.ToolStripStatusLabel TTOvS;
		private System.Windows.Forms.ToolStripStatusLabel spacer;

		#endregion
		private System.Windows.Forms.ToolStripMenuItem MnConnect;
		private System.Windows.Forms.ToolStripMenuItem MnDisconnect;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem MnGoHome;
		private System.Windows.Forms.ToolStripMenuItem MnUnlock;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem MnExit;
		private System.Windows.Forms.ToolStripMenuItem MnSaveProgram;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripStatusLabel TTTLines;
		private System.Windows.Forms.ToolStripStatusLabel TTTStatus;
		private System.Windows.Forms.ToolStripMenuItem linguaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MNEnglish;
		private System.Windows.Forms.ToolStripMenuItem MNItalian;
		private System.Windows.Forms.ToolStripMenuItem MNSpanish;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem helpOnLineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoUpdateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private PreviewForm PreviewForm;
		private JogForm JogForm;
		private ConnectLogForm ConnectionForm;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem openSessionLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
	}
}

