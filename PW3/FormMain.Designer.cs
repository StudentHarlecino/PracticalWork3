﻿namespace PW3
{
    partial class FormMain
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            labelOut = new Label();
            SuspendLayout();
            // 
            // labelOut
            // 
            labelOut.Location = new Point(52, 52);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(631, 314);
            labelOut.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOut);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelOut;
    }
}
