namespace DraftPascal
{
	partial class CommandBar
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textField
            // 
            this.textField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textField.ForeColor = System.Drawing.Color.White;
            this.textField.Location = new System.Drawing.Point(20, 10);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(264, 18);
            this.textField.TabIndex = 4;
            this.textField.Text = "command here (Ctrl+Enter) ...";
            this.textField.Enter += new System.EventHandler(this.textField_Enter);
            this.textField.Leave += new System.EventHandler(this.textField_Leave);
            // 
            // CommandBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.textField);
            this.Name = "CommandBar";
            this.Size = new System.Drawing.Size(300, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textField;
	}
}
