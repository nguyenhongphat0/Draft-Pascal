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
            this.loadBtn_file = new System.Windows.Forms.OpenFileDialog();
            this.mainTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loadBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusBar = new System.Windows.Forms.FlowLayoutPanel();
            this.idePanel = new System.Windows.Forms.Panel();
            this.saveBtn_file = new System.Windows.Forms.SaveFileDialog();
            this.title = new System.Windows.Forms.Label();
            this.mainTblLayout.SuspendLayout();
            this.leftPanel.SuspendLayout();
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
            this.mainTblLayout.Controls.Add(this.statusBar, 0, 1);
            this.mainTblLayout.Controls.Add(this.idePanel, 1, 0);
            this.mainTblLayout.Location = new System.Drawing.Point(1, 64);
            this.mainTblLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTblLayout.Name = "mainTblLayout";
            this.mainTblLayout.RowCount = 2;
            this.mainTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTblLayout.Size = new System.Drawing.Size(690, 396);
            this.mainTblLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.newBtn);
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 376);
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
            this.loadBtn.Size = new System.Drawing.Size(96, 43);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Open";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // statusBar
            // 
            this.mainTblLayout.SetColumnSpan(this.statusBar, 2);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBar.Location = new System.Drawing.Point(0, 376);
            this.statusBar.Margin = new System.Windows.Forms.Padding(0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(690, 20);
            this.statusBar.TabIndex = 5;
            // 
            // idePanel
            // 
            this.idePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idePanel.Location = new System.Drawing.Point(300, 0);
            this.idePanel.Margin = new System.Windows.Forms.Padding(0);
            this.idePanel.Name = "idePanel";
            this.idePanel.Size = new System.Drawing.Size(390, 376);
            this.idePanel.TabIndex = 6;
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
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.title);
            this.Controls.Add(this.mainTblLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.mainTblLayout.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog loadBtn_file;
        private System.Windows.Forms.TableLayoutPanel mainTblLayout;
        private System.Windows.Forms.FlowLayoutPanel statusBar;
        private MaterialSkin.Controls.MaterialRaisedButton loadBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saveBtn;
        private MaterialSkin.Controls.MaterialRaisedButton newBtn;
        private System.Windows.Forms.SaveFileDialog saveBtn_file;
        public System.Windows.Forms.FlowLayoutPanel leftPanel;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Panel idePanel;
    }
}

