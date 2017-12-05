namespace Draft
{
    partial class ConsoleBox
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
            this.placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textField
            // 
            this.textField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textField.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.textField.ForeColor = System.Drawing.Color.White;
            this.textField.Location = new System.Drawing.Point(5, 5);
            this.textField.Multiline = true;
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(331, 179);
            this.textField.TabIndex = 4;
            this.textField.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.textField.Enter += new System.EventHandler(this.textField_Enter);
            this.textField.Leave += new System.EventHandler(this.textField_Leave);
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.placeholder.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.placeholder.ForeColor = System.Drawing.Color.Gray;
            this.placeholder.Location = new System.Drawing.Point(114, 77);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(135, 30);
            this.placeholder.TabIndex = 5;
            this.placeholder.Text = "Placeholder";
            this.placeholder.Click += new System.EventHandler(this.placeholder_Click);
            // 
            // ConsoleBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.textField);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ConsoleBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(341, 189);
            this.Resize += new System.EventHandler(this.ConsoleBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textField;
        private System.Windows.Forms.Label placeholder;
    }
}
