namespace WebP_Converter
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.filesTabPage = new System.Windows.Forms.TabPage();
            this.encodeStartButton = new System.Windows.Forms.Button();
            this.useSourceAsDestCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteOriginalCheckBox = new System.Windows.Forms.CheckBox();
            this.destPathGroupBox = new System.Windows.Forms.GroupBox();
            this.destPathBrowseButton = new System.Windows.Forms.Button();
            this.destPathTextBox = new System.Windows.Forms.TextBox();
            this.sourcePathGroupBox = new System.Windows.Forms.GroupBox();
            this.sourcePathBrowseButton = new System.Windows.Forms.Button();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.optionTabPage = new System.Windows.Forms.TabPage();
            this.presetGroupBox = new System.Windows.Forms.GroupBox();
            this.presetComboBox = new System.Windows.Forms.ComboBox();
            this.encoderOptionsGroupBox3 = new System.Windows.Forms.GroupBox();
            this.encoderOptionsTextBox = new System.Windows.Forms.RichTextBox();
            this.encoderTabPage = new System.Windows.Forms.TabPage();
            this.encoderPathGroupBox = new System.Windows.Forms.GroupBox();
            this.encoderPathButton = new System.Windows.Forms.Button();
            this.encoderPathTextBox = new System.Windows.Forms.TextBox();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl.SuspendLayout();
            this.filesTabPage.SuspendLayout();
            this.destPathGroupBox.SuspendLayout();
            this.sourcePathGroupBox.SuspendLayout();
            this.optionTabPage.SuspendLayout();
            this.presetGroupBox.SuspendLayout();
            this.encoderOptionsGroupBox3.SuspendLayout();
            this.encoderTabPage.SuspendLayout();
            this.encoderPathGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.filesTabPage);
            this.mainTabControl.Controls.Add(this.optionTabPage);
            this.mainTabControl.Controls.Add(this.encoderTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(13, 13);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(503, 235);
            this.mainTabControl.TabIndex = 0;
            // 
            // filesTabPage
            // 
            this.filesTabPage.Controls.Add(this.encodeStartButton);
            this.filesTabPage.Controls.Add(this.useSourceAsDestCheckBox);
            this.filesTabPage.Controls.Add(this.deleteOriginalCheckBox);
            this.filesTabPage.Controls.Add(this.destPathGroupBox);
            this.filesTabPage.Controls.Add(this.sourcePathGroupBox);
            this.filesTabPage.Location = new System.Drawing.Point(4, 22);
            this.filesTabPage.Name = "filesTabPage";
            this.filesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filesTabPage.Size = new System.Drawing.Size(495, 209);
            this.filesTabPage.TabIndex = 0;
            this.filesTabPage.Text = "Files";
            this.filesTabPage.UseVisualStyleBackColor = true;
            // 
            // encodeStartButton
            // 
            this.encodeStartButton.Location = new System.Drawing.Point(408, 180);
            this.encodeStartButton.Name = "encodeStartButton";
            this.encodeStartButton.Size = new System.Drawing.Size(75, 23);
            this.encodeStartButton.TabIndex = 4;
            this.encodeStartButton.Text = "Start";
            this.encodeStartButton.UseVisualStyleBackColor = true;
            this.encodeStartButton.Click += new System.EventHandler(this.encodeStartButton_Click);
            // 
            // useSourceAsDestCheckBox
            // 
            this.useSourceAsDestCheckBox.AutoSize = true;
            this.useSourceAsDestCheckBox.Location = new System.Drawing.Point(7, 151);
            this.useSourceAsDestCheckBox.Name = "useSourceAsDestCheckBox";
            this.useSourceAsDestCheckBox.Size = new System.Drawing.Size(204, 16);
            this.useSourceAsDestCheckBox.TabIndex = 3;
            this.useSourceAsDestCheckBox.Text = "Use Source Path as Destination";
            this.useSourceAsDestCheckBox.UseVisualStyleBackColor = true;
            this.useSourceAsDestCheckBox.CheckedChanged += new System.EventHandler(this.useSourceAsDestCheckBox_CheckedChanged);
            // 
            // deleteOriginalCheckBox
            // 
            this.deleteOriginalCheckBox.AutoSize = true;
            this.deleteOriginalCheckBox.Location = new System.Drawing.Point(7, 128);
            this.deleteOriginalCheckBox.Name = "deleteOriginalCheckBox";
            this.deleteOriginalCheckBox.Size = new System.Drawing.Size(144, 16);
            this.deleteOriginalCheckBox.TabIndex = 2;
            this.deleteOriginalCheckBox.Text = "Delete Original File";
            this.deleteOriginalCheckBox.UseVisualStyleBackColor = true;
            this.deleteOriginalCheckBox.CheckedChanged += new System.EventHandler(this.deleteOriginalCheckBox_CheckedChanged);
            // 
            // destPathGroupBox
            // 
            this.destPathGroupBox.Controls.Add(this.destPathBrowseButton);
            this.destPathGroupBox.Controls.Add(this.destPathTextBox);
            this.destPathGroupBox.Location = new System.Drawing.Point(7, 66);
            this.destPathGroupBox.Name = "destPathGroupBox";
            this.destPathGroupBox.Size = new System.Drawing.Size(482, 55);
            this.destPathGroupBox.TabIndex = 1;
            this.destPathGroupBox.TabStop = false;
            this.destPathGroupBox.Text = "Destination";
            // 
            // destPathBrowseButton
            // 
            this.destPathBrowseButton.Location = new System.Drawing.Point(401, 19);
            this.destPathBrowseButton.Name = "destPathBrowseButton";
            this.destPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.destPathBrowseButton.TabIndex = 1;
            this.destPathBrowseButton.Text = "Browse";
            this.destPathBrowseButton.UseVisualStyleBackColor = true;
            this.destPathBrowseButton.Click += new System.EventHandler(this.destPathBrowseButton_Click);
            // 
            // destPathTextBox
            // 
            this.destPathTextBox.AllowDrop = true;
            this.destPathTextBox.Location = new System.Drawing.Point(7, 21);
            this.destPathTextBox.Name = "destPathTextBox";
            this.destPathTextBox.Size = new System.Drawing.Size(387, 21);
            this.destPathTextBox.TabIndex = 0;
            this.destPathTextBox.TextChanged += new System.EventHandler(this.destPathTextBox_TextChanged);
            this.destPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.destPathTextBox_DragDrop);
            this.destPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.destPathTextBox_DragEnter);
            // 
            // sourcePathGroupBox
            // 
            this.sourcePathGroupBox.Controls.Add(this.sourcePathBrowseButton);
            this.sourcePathGroupBox.Controls.Add(this.sourcePathTextBox);
            this.sourcePathGroupBox.Location = new System.Drawing.Point(7, 7);
            this.sourcePathGroupBox.Name = "sourcePathGroupBox";
            this.sourcePathGroupBox.Size = new System.Drawing.Size(482, 52);
            this.sourcePathGroupBox.TabIndex = 0;
            this.sourcePathGroupBox.TabStop = false;
            this.sourcePathGroupBox.Text = "Source";
            // 
            // sourcePathBrowseButton
            // 
            this.sourcePathBrowseButton.Location = new System.Drawing.Point(401, 19);
            this.sourcePathBrowseButton.Name = "sourcePathBrowseButton";
            this.sourcePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sourcePathBrowseButton.TabIndex = 1;
            this.sourcePathBrowseButton.Text = "Browse";
            this.sourcePathBrowseButton.UseVisualStyleBackColor = true;
            this.sourcePathBrowseButton.Click += new System.EventHandler(this.sourcePathBrowseButton_Click);
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.AllowDrop = true;
            this.sourcePathTextBox.Location = new System.Drawing.Point(7, 21);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(388, 21);
            this.sourcePathTextBox.TabIndex = 0;
            this.sourcePathTextBox.TextChanged += new System.EventHandler(this.sourcePathTextBox_TextChanged);
            this.sourcePathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.sourcePathTextBox_DragDrop);
            this.sourcePathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.sourcePathTextBox_DragEnter);
            // 
            // optionTabPage
            // 
            this.optionTabPage.Controls.Add(this.presetGroupBox);
            this.optionTabPage.Controls.Add(this.encoderOptionsGroupBox3);
            this.optionTabPage.Location = new System.Drawing.Point(4, 22);
            this.optionTabPage.Name = "optionTabPage";
            this.optionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionTabPage.Size = new System.Drawing.Size(495, 209);
            this.optionTabPage.TabIndex = 1;
            this.optionTabPage.Text = "Options";
            this.optionTabPage.UseVisualStyleBackColor = true;
            // 
            // presetGroupBox
            // 
            this.presetGroupBox.Controls.Add(this.presetComboBox);
            this.presetGroupBox.Location = new System.Drawing.Point(7, 103);
            this.presetGroupBox.Name = "presetGroupBox";
            this.presetGroupBox.Size = new System.Drawing.Size(482, 51);
            this.presetGroupBox.TabIndex = 1;
            this.presetGroupBox.TabStop = false;
            this.presetGroupBox.Text = "Preset";
            // 
            // presetComboBox
            // 
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Location = new System.Drawing.Point(7, 21);
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size(469, 20);
            this.presetComboBox.TabIndex = 0;
            this.presetComboBox.SelectedIndexChanged += new System.EventHandler(this.presetComboBox_SelectedIndexChanged);
            // 
            // encoderOptionsGroupBox3
            // 
            this.encoderOptionsGroupBox3.Controls.Add(this.encoderOptionsTextBox);
            this.encoderOptionsGroupBox3.Location = new System.Drawing.Point(7, 7);
            this.encoderOptionsGroupBox3.Name = "encoderOptionsGroupBox3";
            this.encoderOptionsGroupBox3.Size = new System.Drawing.Size(482, 89);
            this.encoderOptionsGroupBox3.TabIndex = 0;
            this.encoderOptionsGroupBox3.TabStop = false;
            this.encoderOptionsGroupBox3.Text = "Encoder Options";
            // 
            // encoderOptionsTextBox
            // 
            this.encoderOptionsTextBox.Location = new System.Drawing.Point(7, 21);
            this.encoderOptionsTextBox.Name = "encoderOptionsTextBox";
            this.encoderOptionsTextBox.Size = new System.Drawing.Size(469, 62);
            this.encoderOptionsTextBox.TabIndex = 0;
            this.encoderOptionsTextBox.Text = "";
            this.encoderOptionsTextBox.TextChanged += new System.EventHandler(this.encoderOptionsTextBox_TextChanged);
            // 
            // encoderTabPage
            // 
            this.encoderTabPage.Controls.Add(this.encoderPathGroupBox);
            this.encoderTabPage.Location = new System.Drawing.Point(4, 22);
            this.encoderTabPage.Name = "encoderTabPage";
            this.encoderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encoderTabPage.Size = new System.Drawing.Size(495, 209);
            this.encoderTabPage.TabIndex = 2;
            this.encoderTabPage.Text = "Encoder";
            this.encoderTabPage.UseVisualStyleBackColor = true;
            // 
            // encoderPathGroupBox
            // 
            this.encoderPathGroupBox.Controls.Add(this.encoderPathButton);
            this.encoderPathGroupBox.Controls.Add(this.encoderPathTextBox);
            this.encoderPathGroupBox.Location = new System.Drawing.Point(7, 7);
            this.encoderPathGroupBox.Name = "encoderPathGroupBox";
            this.encoderPathGroupBox.Size = new System.Drawing.Size(482, 52);
            this.encoderPathGroupBox.TabIndex = 0;
            this.encoderPathGroupBox.TabStop = false;
            this.encoderPathGroupBox.Text = "Encoder Path";
            // 
            // encoderPathButton
            // 
            this.encoderPathButton.Location = new System.Drawing.Point(401, 19);
            this.encoderPathButton.Name = "encoderPathButton";
            this.encoderPathButton.Size = new System.Drawing.Size(75, 23);
            this.encoderPathButton.TabIndex = 1;
            this.encoderPathButton.Text = "Browse";
            this.encoderPathButton.UseVisualStyleBackColor = true;
            this.encoderPathButton.Click += new System.EventHandler(this.encoderPathButton_Click);
            // 
            // encoderPathTextBox
            // 
            this.encoderPathTextBox.Location = new System.Drawing.Point(7, 21);
            this.encoderPathTextBox.Name = "encoderPathTextBox";
            this.encoderPathTextBox.Size = new System.Drawing.Size(388, 21);
            this.encoderPathTextBox.TabIndex = 0;
            this.encoderPathTextBox.TextChanged += new System.EventHandler(this.encoderPathTextBox_TextChanged);
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(495, 209);
            this.aboutTabPage.TabIndex = 3;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 260);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "WebP Batch Converter";
            this.mainTabControl.ResumeLayout(false);
            this.filesTabPage.ResumeLayout(false);
            this.filesTabPage.PerformLayout();
            this.destPathGroupBox.ResumeLayout(false);
            this.destPathGroupBox.PerformLayout();
            this.sourcePathGroupBox.ResumeLayout(false);
            this.sourcePathGroupBox.PerformLayout();
            this.optionTabPage.ResumeLayout(false);
            this.presetGroupBox.ResumeLayout(false);
            this.encoderOptionsGroupBox3.ResumeLayout(false);
            this.encoderTabPage.ResumeLayout(false);
            this.encoderPathGroupBox.ResumeLayout(false);
            this.encoderPathGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage filesTabPage;
        private System.Windows.Forms.TabPage optionTabPage;
        private System.Windows.Forms.TabPage encoderTabPage;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.GroupBox sourcePathGroupBox;
        private System.Windows.Forms.GroupBox destPathGroupBox;
        private System.Windows.Forms.Button destPathBrowseButton;
        private System.Windows.Forms.TextBox destPathTextBox;
        private System.Windows.Forms.Button sourcePathBrowseButton;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.CheckBox useSourceAsDestCheckBox;
        private System.Windows.Forms.CheckBox deleteOriginalCheckBox;
        private System.Windows.Forms.GroupBox encoderOptionsGroupBox3;
        private System.Windows.Forms.RichTextBox encoderOptionsTextBox;
        private System.Windows.Forms.GroupBox presetGroupBox;
        private System.Windows.Forms.ComboBox presetComboBox;
        private System.Windows.Forms.GroupBox encoderPathGroupBox;
        private System.Windows.Forms.Button encoderPathButton;
        private System.Windows.Forms.TextBox encoderPathTextBox;
        private System.Windows.Forms.Button encodeStartButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

