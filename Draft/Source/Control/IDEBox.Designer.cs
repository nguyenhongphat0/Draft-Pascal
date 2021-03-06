﻿namespace DraftPascal
{
    partial class IDEBox
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // IDEBox
            // 
            this.AutoCompleteBrackets = true;
            this.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(37, 33);
            this.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.CaretBlinking = false;
            this.CaretColor = System.Drawing.Color.Teal;
            this.CharHeight = 23;
            this.CurrentLineColor = System.Drawing.Color.Gray;
            this.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.IndentBackColor = System.Drawing.Color.White;
            this.Language = FastColoredTextBoxNS.Language.CSharp;
            this.LeftBracket = '(';
            this.LeftBracket2 = '{';
            this.LineInterval = 10;
            this.LineNumberColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IDEBox";
            this.Paddings = new System.Windows.Forms.Padding(5);
            this.RightBracket = ')';
            this.RightBracket2 = '}';
            this.ServiceLinesColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(539, 346);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
