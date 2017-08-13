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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            GlobalVariables.workingDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //Check Encoder
            string encoderFolderPath = GlobalVariables.workingDir + "\\encoder";
            if (System.IO.Directory.Exists(encoderFolderPath))
            {
                GlobalVariables.encoderPath = encoderFolderPath + "\\cwebp.exe";
                if (System.IO.File.Exists(GlobalVariables.encoderPath))
                {
                    this.encoderPathTextBox.Text = GlobalVariables.encoderPath;
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
            string encoderOptFolderPath = GlobalVariables.workingDir + "\\presets";
            if (System.IO.Directory.Exists(encoderOptFolderPath))
            {
                string[] presets = System.IO.Directory.GetFiles(encoderOptFolderPath, "*.cfg");
                if (presets.Length > 0)
                {
                    for (int i = 0; i < presets.Length; i++)
                    {
                        presets[i] = System.IO.Path.GetFileNameWithoutExtension(presets[i]);
                    }
                    this.presetComboBox.Items.AddRange(presets);
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
                if (System.IO.Directory.Exists(files[0]))
                {
                    this.sourcePathTextBox.Text = files[0];
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
            GlobalVariables.sourcePath = this.sourcePathTextBox.Text;
        }

        private void sourcePathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.sourcePathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void destPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (System.IO.Directory.Exists(files[0]))
                {
                    this.destPathTextBox.Text = files[0];
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
            GlobalVariables.destPath = this.destPathTextBox.Text;
        }

        private void destPathBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.destPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void deleteOriginalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteOriginalCheckBox.Checked)
            {
                GlobalVariables.deleteOrigial = true;
            }
            else
            {
                GlobalVariables.deleteOrigial = false;
            }
        }

        private void useSourceAsDestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useSourceAsDestCheckBox.Checked)
            {
                GlobalVariables.useSourceAsDest = true;
                this.destPathTextBox.Text = this.sourcePathTextBox.Text;
                this.destPathGroupBox.Enabled = false;
            }
            else
            {
                GlobalVariables.useSourceAsDest = false;
                this.destPathGroupBox.Enabled = true;
            }
        }

        private void presetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string presetName = presetComboBox.SelectedItem.ToString();
            string presetFilePath = GlobalVariables.workingDir + "\\presets\\" + presetName + ".cfg";

            this.encoderOptionsTextBox.Text = System.IO.File.ReadAllText(presetFilePath);

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
                this.encoderPathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private async void encodeStartButton_Click(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(GlobalVariables.sourcePath, "*.*", System.IO.SearchOption.AllDirectories);
            var execFileList = new List<Tuple<string, string>>();//First: source, Second: dest
            foreach (string item in files)
            {
                var fileExt = System.IO.Path.GetExtension(item).TrimStart('.');
                if (Constants.losslessImgType.Contains(fileExt))
                {
                    var dest = System.IO.Path.GetDirectoryName(item) + "\\" + System.IO.Path.GetFileNameWithoutExtension(item) + ".webp";
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
            var encoderTask = Task.Factory.StartNew(() =>
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
                        encoderProgress.Hide();
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
            });

            await Task.WhenAll(encoderTask);
            encoderProgress.Close();
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
