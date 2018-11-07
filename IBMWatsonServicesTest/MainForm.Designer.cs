namespace IBMWatsonServicesTest
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.AutoScrollCB = new System.Windows.Forms.CheckBox();
            this.ClearDebugButton = new System.Windows.Forms.Button();
            this.LogBottomControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.DebugTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.OptionsTabControl = new System.Windows.Forms.TabControl();
            this.SynthesizeTabPage = new System.Windows.Forms.TabPage();
            this.SynthesizeButton = new System.Windows.Forms.Button();
            this.TextToSynthesizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogBottomControlsGroupBox.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.DebugTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.OptionsTabControl.SuspendLayout();
            this.SynthesizeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoScrollCB
            // 
            this.AutoScrollCB.AutoSize = true;
            this.AutoScrollCB.Checked = true;
            this.AutoScrollCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoScrollCB.Location = new System.Drawing.Point(84, 14);
            this.AutoScrollCB.Name = "AutoScrollCB";
            this.AutoScrollCB.Size = new System.Drawing.Size(77, 17);
            this.AutoScrollCB.TabIndex = 9;
            this.AutoScrollCB.Text = "Auto Scroll";
            this.AutoScrollCB.UseVisualStyleBackColor = true;
            // 
            // ClearDebugButton
            // 
            this.ClearDebugButton.Location = new System.Drawing.Point(3, 10);
            this.ClearDebugButton.Name = "ClearDebugButton";
            this.ClearDebugButton.Size = new System.Drawing.Size(75, 23);
            this.ClearDebugButton.TabIndex = 8;
            this.ClearDebugButton.Text = "Clear";
            this.ClearDebugButton.UseVisualStyleBackColor = true;
            // 
            // LogBottomControlsGroupBox
            // 
            this.LogBottomControlsGroupBox.Controls.Add(this.AutoScrollCB);
            this.LogBottomControlsGroupBox.Controls.Add(this.ClearDebugButton);
            this.LogBottomControlsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBottomControlsGroupBox.Location = new System.Drawing.Point(3, 254);
            this.LogBottomControlsGroupBox.Name = "LogBottomControlsGroupBox";
            this.LogBottomControlsGroupBox.Size = new System.Drawing.Size(786, 41);
            this.LogBottomControlsGroupBox.TabIndex = 5;
            this.LogBottomControlsGroupBox.TabStop = false;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.Black;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(3, 16);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(780, 232);
            this.LogTextBox.TabIndex = 6;
            this.LogTextBox.WordWrap = false;
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.LogTextBox);
            this.LogGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogGroupBox.Location = new System.Drawing.Point(3, 3);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(786, 251);
            this.LogGroupBox.TabIndex = 5;
            this.LogGroupBox.TabStop = false;
            // 
            // DebugTabPage
            // 
            this.DebugTabPage.Controls.Add(this.LogGroupBox);
            this.DebugTabPage.Controls.Add(this.LogBottomControlsGroupBox);
            this.DebugTabPage.Location = new System.Drawing.Point(4, 22);
            this.DebugTabPage.Name = "DebugTabPage";
            this.DebugTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DebugTabPage.Size = new System.Drawing.Size(792, 298);
            this.DebugTabPage.TabIndex = 1;
            this.DebugTabPage.Text = "Debug";
            this.DebugTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.DebugTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 126);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 324);
            this.MainTabControl.TabIndex = 6;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.OptionsTabControl);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 126);
            this.TopPanel.TabIndex = 5;
            // 
            // OptionsTabControl
            // 
            this.OptionsTabControl.Controls.Add(this.SynthesizeTabPage);
            this.OptionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.OptionsTabControl.Name = "OptionsTabControl";
            this.OptionsTabControl.SelectedIndex = 0;
            this.OptionsTabControl.Size = new System.Drawing.Size(800, 126);
            this.OptionsTabControl.TabIndex = 0;
            // 
            // SynthesizeTabPage
            // 
            this.SynthesizeTabPage.Controls.Add(this.SynthesizeButton);
            this.SynthesizeTabPage.Controls.Add(this.TextToSynthesizeTextBox);
            this.SynthesizeTabPage.Controls.Add(this.label2);
            this.SynthesizeTabPage.Controls.Add(this.OutputFileTextBox);
            this.SynthesizeTabPage.Controls.Add(this.label1);
            this.SynthesizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.SynthesizeTabPage.Name = "SynthesizeTabPage";
            this.SynthesizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SynthesizeTabPage.Size = new System.Drawing.Size(792, 100);
            this.SynthesizeTabPage.TabIndex = 0;
            this.SynthesizeTabPage.Text = "Synthesize";
            this.SynthesizeTabPage.UseVisualStyleBackColor = true;
            // 
            // SynthesizeButton
            // 
            this.SynthesizeButton.Location = new System.Drawing.Point(450, 32);
            this.SynthesizeButton.Name = "SynthesizeButton";
            this.SynthesizeButton.Size = new System.Drawing.Size(75, 23);
            this.SynthesizeButton.TabIndex = 12;
            this.SynthesizeButton.Text = "Synthesize";
            this.SynthesizeButton.UseVisualStyleBackColor = true;
            this.SynthesizeButton.Click += new System.EventHandler(this.SynthesizeButton_Click);
            // 
            // TextToSynthesizeTextBox
            // 
            this.TextToSynthesizeTextBox.Location = new System.Drawing.Point(75, 6);
            this.TextToSynthesizeTextBox.Name = "TextToSynthesizeTextBox";
            this.TextToSynthesizeTextBox.Size = new System.Drawing.Size(650, 20);
            this.TextToSynthesizeTextBox.TabIndex = 9;
            this.TextToSynthesizeTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Text:";
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(75, 34);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(369, 20);
            this.OutputFileTextBox.TabIndex = 7;
            this.OutputFileTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output File:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainForm";
            this.Text = "IBM Watson Services Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LogBottomControlsGroupBox.ResumeLayout(false);
            this.LogBottomControlsGroupBox.PerformLayout();
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.DebugTabPage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.OptionsTabControl.ResumeLayout(false);
            this.SynthesizeTabPage.ResumeLayout(false);
            this.SynthesizeTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox AutoScrollCB;
        private System.Windows.Forms.Button ClearDebugButton;
        private System.Windows.Forms.GroupBox LogBottomControlsGroupBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.TabPage DebugTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TabControl OptionsTabControl;
        private System.Windows.Forms.TabPage SynthesizeTabPage;
        private System.Windows.Forms.Button SynthesizeButton;
        private System.Windows.Forms.TextBox TextToSynthesizeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputFileTextBox;
        private System.Windows.Forms.Label label1;
    }
}