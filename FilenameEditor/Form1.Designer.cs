namespace FilenameEditor {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cblFiles = new System.Windows.Forms.CheckedListBox();
            this.tbFiles = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bRenameFiles = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCurrentFolderInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFullFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cblFiles
            // 
            this.cblFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblFiles.CheckOnClick = true;
            this.cblFiles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cblFiles.FormattingEnabled = true;
            this.cblFiles.IntegralHeight = false;
            this.cblFiles.Location = new System.Drawing.Point(0, 3);
            this.cblFiles.Margin = new System.Windows.Forms.Padding(0);
            this.cblFiles.Name = "cblFiles";
            this.cblFiles.Size = new System.Drawing.Size(412, 393);
            this.cblFiles.TabIndex = 0;
            this.cblFiles.SelectedValueChanged += new System.EventHandler(this.cblFiles_SelectedValueChanged);
            // 
            // tbFiles
            // 
            this.tbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFiles.Location = new System.Drawing.Point(3, 3);
            this.tbFiles.Multiline = true;
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(435, 393);
            this.tbFiles.TabIndex = 1;
            this.tbFiles.TextChanged += new System.EventHandler(this.tbFiles_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cblFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbFiles);
            this.splitContainer1.Size = new System.Drawing.Size(864, 404);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.TabIndex = 2;
            // 
            // bRenameFiles
            // 
            this.bRenameFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRenameFiles.Location = new System.Drawing.Point(729, 437);
            this.bRenameFiles.Name = "bRenameFiles";
            this.bRenameFiles.Size = new System.Drawing.Size(147, 39);
            this.bRenameFiles.TabIndex = 3;
            this.bRenameFiles.Text = "Rename Files";
            this.bRenameFiles.UseVisualStyleBackColor = true;
            this.bRenameFiles.Click += new System.EventHandler(this.bRenameFiles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openCurrentFolderInEditorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openCurrentFolderInEditorToolStripMenuItem
            // 
            this.openCurrentFolderInEditorToolStripMenuItem.Name = "openCurrentFolderInEditorToolStripMenuItem";
            this.openCurrentFolderInEditorToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openCurrentFolderInEditorToolStripMenuItem.Text = "Open Current folder In Editor";
            this.openCurrentFolderInEditorToolStripMenuItem.Click += new System.EventHandler(this.openCurrentFolderInEditorToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.copyFilesToolStripMenuItem,
            this.copyFullFilePathsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // copyFilesToolStripMenuItem
            // 
            this.copyFilesToolStripMenuItem.Name = "copyFilesToolStripMenuItem";
            this.copyFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyFilesToolStripMenuItem.Text = "Copy Files";
            this.copyFilesToolStripMenuItem.Click += new System.EventHandler(this.copyFilesToolStripMenuItem_Click);
            // 
            // copyFullFilePathsToolStripMenuItem
            // 
            this.copyFullFilePathsToolStripMenuItem.Name = "copyFullFilePathsToolStripMenuItem";
            this.copyFullFilePathsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyFullFilePathsToolStripMenuItem.Text = "Copy Full File Paths";
            this.copyFullFilePathsToolStripMenuItem.Click += new System.EventHandler(this.copyFullFilePathsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.bRenameFiles);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(355, 228);
            this.Name = "Form1";
            this.Text = "Filename Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox cblFiles;
        private TextBox tbFiles;
        private SplitContainer splitContainer1;
        private Button bRenameFiles;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem openCurrentFolderInEditorToolStripMenuItem;
        private ToolStripMenuItem copyFullFilePathsToolStripMenuItem;
        private ToolStripMenuItem copyFilesToolStripMenuItem;
    }
}