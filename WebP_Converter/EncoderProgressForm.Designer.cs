namespace WebP_Converter
{
    partial class EncoderProgressForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.encoderProgressLabel = new System.Windows.Forms.Label();
            this.encoderProgressBar = new System.Windows.Forms.ProgressBar();
            this.cancelEncodeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.encoderProgressLabel);
            this.groupBox1.Controls.Add(this.encoderProgressBar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // encoderProgressLabel
            // 
            this.encoderProgressLabel.AutoSize = true;
            this.encoderProgressLabel.Location = new System.Drawing.Point(7, 51);
            this.encoderProgressLabel.Name = "encoderProgressLabel";
            this.encoderProgressLabel.Size = new System.Drawing.Size(89, 12);
            this.encoderProgressLabel.TabIndex = 1;
            this.encoderProgressLabel.Text = "Progress Label";
            // 
            // encoderProgressBar
            // 
            this.encoderProgressBar.Location = new System.Drawing.Point(7, 21);
            this.encoderProgressBar.Name = "encoderProgressBar";
            this.encoderProgressBar.Size = new System.Drawing.Size(555, 23);
            this.encoderProgressBar.TabIndex = 0;
            // 
            // cancelEncodeButton
            // 
            this.cancelEncodeButton.Location = new System.Drawing.Point(506, 96);
            this.cancelEncodeButton.Name = "cancelEncodeButton";
            this.cancelEncodeButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEncodeButton.TabIndex = 1;
            this.cancelEncodeButton.Text = "Cancel";
            this.cancelEncodeButton.UseVisualStyleBackColor = true;
            this.cancelEncodeButton.Click += new System.EventHandler(this.cancelEncodeButton_Click);
            // 
            // EncoderProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 131);
            this.Controls.Add(this.cancelEncodeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "EncoderProgressForm";
            this.Text = "Encoding Progress";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label encoderProgressLabel;
        private System.Windows.Forms.ProgressBar encoderProgressBar;
        private System.Windows.Forms.Button cancelEncodeButton;
    }
}