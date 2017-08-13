using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WebP_Converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            GlobalVariables.workingDir = Path.GetDirectoryName(Application.ExecutablePath);
            //Check Encoder
            string encoderFolderPath = GlobalVariables.workingDir + "\\encoder";
            if (Directory.Exists(encoderFolderPath))
            {
                GlobalVariables.encoderPath = encoderFolderPath + "\\cwebp.exe";
                if (File.Exists(GlobalVariables.encoderPath))
                {
                    encoderPathTextBox.Text = GlobalVariables.encoderPath;
                }
                else
                {
                    MessageBox.Show("Cannot Find WebP Encoder!", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Cannot Find WebP Encoder!", "Warning", MessageBoxButtons.OK);
            }

            //Check Presets
            string encoderOptFolderPath = Path.Combine(GlobalVariables.workingDir ?? "", "presets");
            if (Directory.Exists(encoderOptFolderPath))
            {
                string[] presets = Directory.GetFiles(encoderOptFolderPath, "*.cfg");
                if (presets.Length > 0)
                {
                    for (int i = 0; i < presets.Length; i++)
                    {
                        presets[i] = Path.GetFileNameWithoutExtension(presets[i]);
                    }
                    presetComboBox.Items.AddRange(presets);
                    presetComboBox.SelectedIndex = 0;// select the first cfg as default
                }
                else
                {
                    MessageBox.Show("No WebP Presets Available!", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No WebP Presets Available!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void sourcePathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Directory.Exists(files[0]))
                {
                    sourcePathTextBox.Text = files[0];
                }
                else
                {
                    MessageBox.Show("Only Folders Can be Dropped Here!", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void sourcePathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void sourcePathTextBox_TextChanged(object sender, EventArgs e)
        {
            GlobalVariables.sourcePath = sourcePathTextBox.Text;
        }

        private void sourcePathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sourcePathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void destPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Directory.Exists(files[0]))
                {
                    destPathTextBox.Text = files[0];
                }
                else
                {
                    MessageBox.Show("Only Folders Can be Dropped Here!", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void destPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void destPathTextBox_TextChanged(object sender, EventArgs e)
        {
            GlobalVariables.destPath = destPathTextBox.Text;
        }

        private void destPathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void deleteOriginalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.deleteOrigial = deleteOriginalCheckBox.Checked;
        }

        private void useSourceAsDestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useSourceAsDestCheckBox.Checked)
            {
                GlobalVariables.useSourceAsDest = true;
                destPathTextBox.Text = sourcePathTextBox.Text;
                destPathGroupBox.Enabled = false;
            }
            else
            {
                GlobalVariables.useSourceAsDest = false;
                destPathGroupBox.Enabled = true;
            }
        }

        private void presetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string presetName = presetComboBox.SelectedItem.ToString();
            string presetFilePath = Path.Combine(GlobalVariables.workingDir, "presets", presetName + ".cfg");

            encoderOptionsTextBox.Text = File.ReadAllText(presetFilePath);

        }

        private void encoderOptionsTextBox_TextChanged(object sender, EventArgs e)
        {
            GlobalVariables.encoderOpt = encoderOptionsTextBox.Text;
        }

        private void encoderPathTextBox_TextChanged(object sender, EventArgs e)
        {
            GlobalVariables.encoderPath = encoderPathTextBox.Text;
        }

        private void encoderPathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                encoderPathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private async void encodeStartButton_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(GlobalVariables.sourcePath, "*.*", SearchOption.AllDirectories);
            var execFileList = new List<Tuple<string, string>>();//First: source, Second: dest
            foreach (string item in files)
            {
                var fileExt = (Path.GetExtension(item)?? "").TrimStart('.');
                if (Constants.losslessImgType.Contains(fileExt))
                {
                    var dest = Path.Combine(Path.GetDirectoryName(item)??"", Path.GetFileNameWithoutExtension(item) + ".webp");
                    var tupleT = Tuple.Create(item, dest);
                    execFileList.Add(tupleT);
                }
            }

            //CancellationTokenSource cts = new CancellationTokenSource();

            EncoderProgressForm encoderProgress = new EncoderProgressForm();
            encoderProgress.Show();
            encoderProgress.encoderProgressBarMaximum = execFileList.Count;
            encoderProgress.encoderProgressBarValue = 0;

            var po = new ParallelOptions
            {
                MaxDegreeOfParallelism = Environment.ProcessorCount - 1,
                CancellationToken = encoderProgress.cts.Token
            };

            int current = 0;
            var errList = new List<string>();
            OperationCanceledException canceled = null;
            var encoderTask = Task.Factory.StartNew(() =>
            {
                try
                {
                    Parallel.ForEach(execFileList, po, item =>
                    {
                        try
                        {
                            Utility.runWebpEncoder(item.Item1, item.Item2);
                            po.CancellationToken.ThrowIfCancellationRequested();
                        }
                        catch (OperationCanceledException ex)
                        {
                            canceled = ex;
                            Invoke(new Action(() => encoderProgress.Close()));
                        }
                        catch (ArgumentException ex)
                        {
                            lock (this)
                            {
                                errList.Add(ex.Message);
                            }
                        }
                        finally
                        {
                            Interlocked.Increment(ref current);
                            Invoke(new Action(() =>
                            {
                                lock (encoderProgress)
                                    encoderProgress.encoderProgressBarValue = current;
                            }));
                        }
                    });
                }
                catch (OperationCanceledException)
                {
                }
            });

            await Task.WhenAll(encoderTask);
            encoderProgress.Close();
            if (canceled != null)
            {
                MessageBox.Show(canceled.Message, "Warning", MessageBoxButtons.OK);
                return;
            }
            if (GlobalVariables.deleteOrigial)
            {
                foreach (var item in execFileList.Select(item => item.Item1).Except(errList))
                {
                    File.Delete(item);
                }
            }
            if (errList.Count!=0)
            {
                string allErrors = errList.Aggregate((i, j) => i + '\n' + j);
                MessageBox.Show(allErrors, "Some of the Files Are Not Converted Successfully", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Successfully Completed!","Finished!",MessageBoxButtons.OK);
            }
        }
    }
}
