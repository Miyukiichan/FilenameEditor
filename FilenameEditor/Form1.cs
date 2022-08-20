using System.Diagnostics;
namespace FilenameEditor {
    public partial class Form1 : Form {
        private bool _namesChanged;
        private string _folder;
        public Form1() {
            InitializeComponent();
            _namesChanged = false;
            bRenameFiles.Enabled = false;
            _folder = "";
            var args = Environment.GetCommandLineArgs();
            if (args == null || args.Length > 2) {
                Error("Can't process more than one folder");
                Close();
                return;
            }
            if (args.Length > 1)
                OpenFolder(args[1]);
        }
        void Error(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void OpenFolder(string path = "") {
            if (path == "") {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                path = dlg.SelectedPath;
            }
            else if (!Directory.Exists(path))
                Error($"{path} does not exist");
            _folder = path;
            cblFiles.Items.Clear();
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles();
            foreach (var file in files) {
                cblFiles.Items.Add(file.Name);
            }
            for (var i = 0; i < cblFiles.Items.Count; i++) {
                cblFiles.SetItemChecked(i, true);
            }
            FillFileEditor();
        }
        void FillFileEditor() {
            tbFiles.Text = "";
            for (var i = 0; i < cblFiles.Items.Count; i++) {
                if (cblFiles.GetItemChecked(i)) {
                    var text = cblFiles.GetItemText(cblFiles.Items[i]);
                    if (i > 0)
                        text = Environment.NewLine + text;
                    tbFiles.AppendText(text);
                }
            }
            _namesChanged = false;
            bRenameFiles.Enabled = false;
        }

        private void cblFiles_SelectedValueChanged(object sender, EventArgs e) {
            if (_namesChanged) {
                if (MessageBox.Show("Changing file selection will clear your work. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                    cblFiles.SetItemChecked(cblFiles.SelectedIndex, !cblFiles.GetItemChecked(cblFiles.SelectedIndex));
                    return;
                }
            }
            FillFileEditor();
        }

        private void bRenameFiles_Click(object sender, EventArgs e) {
            tbFiles.Lines = tbFiles.Lines.Where(l => !String.IsNullOrWhiteSpace(l)).ToArray();
            if (cblFiles.CheckedItems.Count != tbFiles.Lines.Count()) {
                Error("File lines doesn't match the amount of selected files");
                return;
            }
            var map = new Dictionary<string, string>();
            int j = 0;
            for (var i = 0; i < cblFiles.Items.Count; i++) {
                if (!cblFiles.GetItemChecked(i)) continue;
                var orig = cblFiles.Items[i].ToString();
                map.Add(orig, tbFiles.Lines[j]);
                j++;
            }
            foreach (var pair in map) {
                var orig = pair.Key;
                var newName = pair.Value;
                var isValid = !string.IsNullOrEmpty(newName) && newName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
                if (!isValid) {
                    Error($"{newName} is not a valid file name");
                    return;
                }
                if (File.Exists(Path.Combine(_folder, newName)) && orig != newName) {
                    Error($"{newName} alrady exists in folder {_folder}");
                    return;
                }
            }
            var renamed = 0;
            foreach (var pair in map) {
                var orig = pair.Key;
                var newName = pair.Value;
                if (newName == orig) continue;
                orig = Path.Combine(_folder, orig);
                newName = Path.Combine(_folder, newName);
                File.Move(orig, newName);
                renamed++;
            }
            if (renamed > 0) {
                MessageBox.Show($"Successfully renamed {renamed} files", "Success");
                OpenFolder(_folder);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFolder();
        }

        private void tbFiles_TextChanged(object sender, EventArgs e) {
            _namesChanged = true;
            bRenameFiles.Enabled = true;
            tbFiles.Lines = tbFiles.Lines.Where(l => !String.IsNullOrWhiteSpace(l)).ToArray();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            FillFileEditor();
        }

        private void openCurrentFolderInEditorToolStripMenuItem_Click(object sender, EventArgs e) {
            var fileName = Path.ChangeExtension(Path.GetTempFileName(), ".txt");
            File.WriteAllLines(fileName, tbFiles.Lines);
            try {
                var proc = new Process {
                    StartInfo = new ProcessStartInfo(fileName) {
                        UseShellExecute = true
                    }
                };
                proc.Start();
                proc.WaitForExit();
                tbFiles.Lines = File.ReadAllLines(fileName);
            }
            finally {
                File.Delete(fileName);
            }
        }

        private void copyFullFilePathsToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.SetText(tbFiles.Lines.Select(l => Path.Combine(_folder, l)).Aggregate((a, b) => a + Environment.NewLine + b));
        }

        private void copyFilesToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.SetText(tbFiles.Text);
        }
    }
}