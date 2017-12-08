using FastColoredTextBoxNS;

namespace Draft
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
            this.components = new System.ComponentModel.Container();
            this.loadBtn_file = new System.Windows.Forms.OpenFileDialog();
            this.mainTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loadBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.idePanel = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.Panel();
            this.statusTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.runBtn = new System.Windows.Forms.PictureBox();
            this.stopBtn = new System.Windows.Forms.PictureBox();
            this.buildBtn = new System.Windows.Forms.PictureBox();
            this.saveAsBtn = new System.Windows.Forms.PictureBox();
            this.undoBtn = new System.Windows.Forms.PictureBox();
            this.redoBtn = new System.Windows.Forms.PictureBox();
            this.findBtn = new System.Windows.Forms.PictureBox();
            this.replaceBtn = new System.Windows.Forms.PictureBox();
            this.settingBtn = new System.Windows.Forms.PictureBox();
            this.helpBtn = new System.Windows.Forms.PictureBox();
            this.feedbackBtn = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toggleDebugBtn = new System.Windows.Forms.PictureBox();
            this.toggleEasyModeBtn = new System.Windows.Forms.PictureBox();
            this.toggleInternalModeBtn = new System.Windows.Forms.PictureBox();
            this.saveBtn_file = new System.Windows.Forms.SaveFileDialog();
            this.title = new System.Windows.Forms.Label();
            this.buttonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTblLayout.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightTableLayoutPanel.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.statusTableLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBtn)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDebugBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleEasyModeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleInternalModeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn_file
            // 
            this.loadBtn_file.Filter = "C files|*.c|Pascal files|*.pas|Text files|*.txt|All files|*.*";
            // 
            // mainTblLayout
            // 
            this.mainTblLayout.ColumnCount = 2;
            this.mainTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.mainTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTblLayout.Controls.Add(this.leftPanel, 0, 0);
            this.mainTblLayout.Controls.Add(this.rightTableLayoutPanel, 1, 0);
            this.mainTblLayout.Controls.Add(this.statusBar, 0, 1);
            this.mainTblLayout.Location = new System.Drawing.Point(1, 64);
            this.mainTblLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTblLayout.Name = "mainTblLayout";
            this.mainTblLayout.RowCount = 2;
            this.mainTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTblLayout.Size = new System.Drawing.Size(1239, 566);
            this.mainTblLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.newBtn);
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(294, 540);
            this.leftPanel.TabIndex = 4;
            // 
            // newBtn
            // 
            this.newBtn.Depth = 0;
            this.newBtn.Location = new System.Drawing.Point(3, 3);
            this.newBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.newBtn.Name = "newBtn";
            this.newBtn.Primary = true;
            this.newBtn.Size = new System.Drawing.Size(96, 43);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Depth = 0;
            this.saveBtn.Location = new System.Drawing.Point(105, 3);
            this.saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Primary = true;
            this.saveBtn.Size = new System.Drawing.Size(81, 43);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Depth = 0;
            this.loadBtn.Location = new System.Drawing.Point(192, 3);
            this.loadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Primary = true;
            this.loadBtn.Size = new System.Drawing.Size(91, 43);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // rightTableLayoutPanel
            // 
            this.rightTableLayoutPanel.ColumnCount = 2;
            this.rightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.rightTableLayoutPanel.Controls.Add(this.idePanel, 0, 0);
            this.rightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTableLayoutPanel.Location = new System.Drawing.Point(300, 0);
            this.rightTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightTableLayoutPanel.Name = "rightTableLayoutPanel";
            this.rightTableLayoutPanel.RowCount = 2;
            this.rightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightTableLayoutPanel.Size = new System.Drawing.Size(939, 546);
            this.rightTableLayoutPanel.TabIndex = 6;
            // 
            // idePanel
            // 
            this.idePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idePanel.Location = new System.Drawing.Point(0, 0);
            this.idePanel.Margin = new System.Windows.Forms.Padding(0);
            this.idePanel.Name = "idePanel";
            this.rightTableLayoutPanel.SetRowSpan(this.idePanel, 2);
            this.idePanel.Size = new System.Drawing.Size(939, 546);
            this.idePanel.TabIndex = 7;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainTblLayout.SetColumnSpan(this.statusBar, 2);
            this.statusBar.Controls.Add(this.statusTableLayout);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBar.Location = new System.Drawing.Point(0, 546);
            this.statusBar.Margin = new System.Windows.Forms.Padding(0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statusBar.Size = new System.Drawing.Size(1239, 20);
            this.statusBar.TabIndex = 7;
            // 
            // statusTableLayout
            // 
            this.statusTableLayout.ColumnCount = 2;
            this.statusTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusTableLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.statusTableLayout.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.statusTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusTableLayout.Location = new System.Drawing.Point(5, 0);
            this.statusTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.statusTableLayout.Name = "statusTableLayout";
            this.statusTableLayout.RowCount = 1;
            this.statusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statusTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statusTableLayout.Size = new System.Drawing.Size(1229, 20);
            this.statusTableLayout.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.runBtn);
            this.flowLayoutPanel1.Controls.Add(this.stopBtn);
            this.flowLayoutPanel1.Controls.Add(this.buildBtn);
            this.flowLayoutPanel1.Controls.Add(this.saveAsBtn);
            this.flowLayoutPanel1.Controls.Add(this.undoBtn);
            this.flowLayoutPanel1.Controls.Add(this.redoBtn);
            this.flowLayoutPanel1.Controls.Add(this.findBtn);
            this.flowLayoutPanel1.Controls.Add(this.replaceBtn);
            this.flowLayoutPanel1.Controls.Add(this.settingBtn);
            this.flowLayoutPanel1.Controls.Add(this.helpBtn);
            this.flowLayoutPanel1.Controls.Add(this.feedbackBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(614, 20);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // runBtn
            // 
            this.runBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runBtn.Image = global::Draft.Properties.Resources.run;
            this.runBtn.Location = new System.Drawing.Point(2, 2);
            this.runBtn.Margin = new System.Windows.Forms.Padding(0);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(25, 16);
            this.runBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.runBtn.TabIndex = 1;
            this.runBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.runBtn, "Run code (shortcut: Ctrl+F9, command: \"go\")");
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.Image = global::Draft.Properties.Resources.stop;
            this.stopBtn.Location = new System.Drawing.Point(27, 2);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(25, 16);
            this.stopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.stopBtn.TabIndex = 2;
            this.stopBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.stopBtn, "Stop executing (shortcut: Ctrl+F8, command: \"stop\")");
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // buildBtn
            // 
            this.buildBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildBtn.Image = global::Draft.Properties.Resources.compile;
            this.buildBtn.Location = new System.Drawing.Point(52, 2);
            this.buildBtn.Margin = new System.Windows.Forms.Padding(0);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(25, 16);
            this.buildBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buildBtn.TabIndex = 4;
            this.buildBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.buildBtn, "Build to exe (command: \"build\")");
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAsBtn.Image = global::Draft.Properties.Resources.saveas;
            this.saveAsBtn.Location = new System.Drawing.Point(77, 2);
            this.saveAsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(25, 16);
            this.saveAsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveAsBtn.TabIndex = 5;
            this.saveAsBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.saveAsBtn, "Save as (command: \"saveas\")");
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoBtn.Image = global::Draft.Properties.Resources.undo;
            this.undoBtn.Location = new System.Drawing.Point(102, 2);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(25, 16);
            this.undoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.undoBtn.TabIndex = 6;
            this.undoBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.undoBtn, "Undo (shortcut: Ctrl+Z)");
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redoBtn.Image = global::Draft.Properties.Resources.redo;
            this.redoBtn.Location = new System.Drawing.Point(127, 2);
            this.redoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(25, 16);
            this.redoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redoBtn.TabIndex = 7;
            this.redoBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.redoBtn, "Redo (shortcut: Ctrl+R)");
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findBtn.Image = global::Draft.Properties.Resources.find;
            this.findBtn.Location = new System.Drawing.Point(152, 2);
            this.findBtn.Margin = new System.Windows.Forms.Padding(0);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(25, 16);
            this.findBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.findBtn.TabIndex = 8;
            this.findBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.findBtn, "Find (shortcut: Ctrl+F)");
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replaceBtn.Image = global::Draft.Properties.Resources.replace;
            this.replaceBtn.Location = new System.Drawing.Point(177, 2);
            this.replaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(25, 16);
            this.replaceBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.replaceBtn.TabIndex = 9;
            this.replaceBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.replaceBtn, "Replace (shortcut: Ctrl+H)");
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.Image = global::Draft.Properties.Resources.setting;
            this.settingBtn.Location = new System.Drawing.Point(202, 2);
            this.settingBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(25, 16);
            this.settingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingBtn.TabIndex = 10;
            this.settingBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.settingBtn, "Setting (command: \"setting\")");
            this.settingBtn.Visible = false;
            // 
            // helpBtn
            // 
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.Image = global::Draft.Properties.Resources.help;
            this.helpBtn.Location = new System.Drawing.Point(227, 2);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(25, 16);
            this.helpBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpBtn.TabIndex = 11;
            this.helpBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.helpBtn, "Help (command: \"help\")");
            this.helpBtn.Visible = false;
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackBtn.Image = global::Draft.Properties.Resources.feedback;
            this.feedbackBtn.Location = new System.Drawing.Point(252, 2);
            this.feedbackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(25, 16);
            this.feedbackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedbackBtn.TabIndex = 12;
            this.feedbackBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.feedbackBtn, "Feedback (command: \"fb\")");
            this.feedbackBtn.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.toggleDebugBtn);
            this.flowLayoutPanel2.Controls.Add(this.toggleEasyModeBtn);
            this.flowLayoutPanel2.Controls.Add(this.toggleInternalModeBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(614, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(615, 20);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // toggleDebugBtn
            // 
            this.toggleDebugBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleDebugBtn.Image = global::Draft.Properties.Resources.debug;
            this.toggleDebugBtn.Location = new System.Drawing.Point(583, 0);
            this.toggleDebugBtn.Margin = new System.Windows.Forms.Padding(0);
            this.toggleDebugBtn.Name = "toggleDebugBtn";
            this.toggleDebugBtn.Padding = new System.Windows.Forms.Padding(2);
            this.toggleDebugBtn.Size = new System.Drawing.Size(28, 20);
            this.toggleDebugBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggleDebugBtn.TabIndex = 3;
            this.toggleDebugBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.toggleDebugBtn, "Toggle input, output boxes (shortcut: Ctrl+`, command: \"std\")");
            this.toggleDebugBtn.Click += new System.EventHandler(this.toggleDebugBtn_Click);
            // 
            // toggleEasyModeBtn
            // 
            this.toggleEasyModeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleEasyModeBtn.Image = global::Draft.Properties.Resources.braces;
            this.toggleEasyModeBtn.Location = new System.Drawing.Point(555, 0);
            this.toggleEasyModeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.toggleEasyModeBtn.Name = "toggleEasyModeBtn";
            this.toggleEasyModeBtn.Padding = new System.Windows.Forms.Padding(2);
            this.toggleEasyModeBtn.Size = new System.Drawing.Size(28, 20);
            this.toggleEasyModeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggleEasyModeBtn.TabIndex = 3;
            this.toggleEasyModeBtn.TabStop = false;
            this.toggleEasyModeBtn.Visible = false;
            // 
            // toggleInternalModeBtn
            // 
            this.toggleInternalModeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleInternalModeBtn.Image = global::Draft.Properties.Resources.windows;
            this.toggleInternalModeBtn.Location = new System.Drawing.Point(527, 0);
            this.toggleInternalModeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.toggleInternalModeBtn.Name = "toggleInternalModeBtn";
            this.toggleInternalModeBtn.Padding = new System.Windows.Forms.Padding(2);
            this.toggleInternalModeBtn.Size = new System.Drawing.Size(28, 20);
            this.toggleInternalModeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggleInternalModeBtn.TabIndex = 3;
            this.toggleInternalModeBtn.TabStop = false;
            this.buttonToolTip.SetToolTip(this.toggleInternalModeBtn, "Toggle pre-input mode (shortcut: Ctrl+P, command: \"spoj\")");
            this.toggleInternalModeBtn.Click += new System.EventHandler(this.toggleInternalModeBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(73, 24);
            this.title.TabIndex = 1;
            this.title.Text = "DRAFT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 632);
            this.Controls.Add(this.title);
            this.Controls.Add(this.mainTblLayout);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.mainTblLayout.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightTableLayoutPanel.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusTableLayout.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBtn)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleDebugBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleEasyModeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleInternalModeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog loadBtn_file;
        private System.Windows.Forms.TableLayoutPanel mainTblLayout;
        private MaterialSkin.Controls.MaterialRaisedButton loadBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saveBtn;
        private MaterialSkin.Controls.MaterialRaisedButton newBtn;
        private System.Windows.Forms.SaveFileDialog saveBtn_file;
        public System.Windows.Forms.FlowLayoutPanel leftPanel;
        public System.Windows.Forms.Label title;
        private System.Windows.Forms.TableLayoutPanel rightTableLayoutPanel;
        public System.Windows.Forms.Panel idePanel;
        private System.Windows.Forms.Panel statusBar;
        private System.Windows.Forms.TableLayoutPanel statusTableLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox runBtn;
        private System.Windows.Forms.PictureBox stopBtn;
        private System.Windows.Forms.PictureBox toggleDebugBtn;
        private System.Windows.Forms.PictureBox buildBtn;
        private System.Windows.Forms.PictureBox saveAsBtn;
        private System.Windows.Forms.PictureBox undoBtn;
        private System.Windows.Forms.PictureBox redoBtn;
        private System.Windows.Forms.PictureBox findBtn;
        private System.Windows.Forms.PictureBox replaceBtn;
        private System.Windows.Forms.PictureBox settingBtn;
        private System.Windows.Forms.PictureBox helpBtn;
        private System.Windows.Forms.PictureBox feedbackBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox toggleEasyModeBtn;
        private System.Windows.Forms.PictureBox toggleInternalModeBtn;
        private System.Windows.Forms.ToolTip buttonToolTip;
    }
}

