using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            get { return encoderProgressBar.Value; }
            set { encoderProgressBar.Value = value; }
        }

        public int encoderProgressBarMaximum
        {
            get { return encoderProgressBar.Maximum; }
            set { encoderProgressBar.Maximum = value; }
        }

        public CancellationTokenSource cts = new CancellationTokenSource();

        private void cancelEncodeButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
