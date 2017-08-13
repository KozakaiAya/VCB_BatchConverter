using System;
using System.Threading;
using System.Windows.Forms;

namespace WebP_Converter
{
    public partial class EncoderProgressForm : Form
    {
        public EncoderProgressForm()
        {
            InitializeComponent();
        }

        public int encoderProgressBarValue
        {
            get => encoderProgressBar.Value;
            set
            {
                encoderProgressBar.Value = value;
                encoderProgressLabel.Text = $"{encoderProgressBar.Value:D3} / {encoderProgressBar.Maximum:D3}";
                if (encoderProgressBar.Value >= encoderProgressBar.Maximum)
                    cancelEncodeButton.Enabled = false;
            }
        }

        public int encoderProgressBarMaximum
        {
            get => encoderProgressBar.Maximum;
            set => encoderProgressBar.Maximum = value;
        }

        public CancellationTokenSource cts = new CancellationTokenSource();

        private void cancelEncodeButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
