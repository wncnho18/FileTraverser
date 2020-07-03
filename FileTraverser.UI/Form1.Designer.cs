namespace FileTraverser.UI
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
            this.SelectDirectoryBtn = new System.Windows.Forms.Button();
            this.displayDirectoryTxt = new System.Windows.Forms.TextBox();
            this.FileListView = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Directory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.extentionLbl = new System.Windows.Forms.Label();
            this.displayExtentionTxt = new System.Windows.Forms.TextBox();
            this.dayCountTxt = new System.Windows.Forms.TextBox();
            this.dayCountlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectDirectoryBtn
            // 
            this.SelectDirectoryBtn.Location = new System.Drawing.Point(23, 22);
            this.SelectDirectoryBtn.Name = "SelectDirectoryBtn";
            this.SelectDirectoryBtn.Size = new System.Drawing.Size(85, 43);
            this.SelectDirectoryBtn.TabIndex = 0;
            this.SelectDirectoryBtn.Text = "Select Directory";
            this.SelectDirectoryBtn.UseVisualStyleBackColor = true;
            this.SelectDirectoryBtn.Click += new System.EventHandler(this.SelectDirectoryBtn_Click);
            // 
            // displayDirectoryTxt
            // 
            this.displayDirectoryTxt.Location = new System.Drawing.Point(139, 34);
            this.displayDirectoryTxt.Name = "displayDirectoryTxt";
            this.displayDirectoryTxt.Size = new System.Drawing.Size(150, 20);
            this.displayDirectoryTxt.TabIndex = 1;
            this.displayDirectoryTxt.WordWrap = false;
            // 
            // FileListView
            // 
            this.FileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Directory,
            this.LastModified});
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(61, 107);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(334, 125);
            this.FileListView.TabIndex = 2;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "FileName";
            this.FileName.Width = 56;
            // 
            // LastModified
            // 
            this.LastModified.DisplayIndex = 1;
            this.LastModified.Text = "LastModified";
            this.LastModified.Width = 72;
            // 
            // Directory
            // 
            this.Directory.DisplayIndex = 2;
            this.Directory.Text = "Directory";
            this.Directory.Width = 177;
            // 
            // extentionLbl
            // 
            this.extentionLbl.AutoSize = true;
            this.extentionLbl.Location = new System.Drawing.Point(313, 37);
            this.extentionLbl.Name = "extentionLbl";
            this.extentionLbl.Size = new System.Drawing.Size(51, 13);
            this.extentionLbl.TabIndex = 4;
            this.extentionLbl.Text = "Extention";
            // 
            // displayExtentionTxt
            // 
            this.displayExtentionTxt.Location = new System.Drawing.Point(370, 34);
            this.displayExtentionTxt.Name = "displayExtentionTxt";
            this.displayExtentionTxt.Size = new System.Drawing.Size(65, 20);
            this.displayExtentionTxt.TabIndex = 5;
            this.displayExtentionTxt.WordWrap = false;
            // 
            // dayCountTxt
            // 
            this.dayCountTxt.Location = new System.Drawing.Point(370, 62);
            this.dayCountTxt.Name = "dayCountTxt";
            this.dayCountTxt.Size = new System.Drawing.Size(65, 20);
            this.dayCountTxt.TabIndex = 7;
            this.dayCountTxt.WordWrap = false;
            // 
            // dayCountlbl
            // 
            this.dayCountlbl.AutoSize = true;
            this.dayCountlbl.Location = new System.Drawing.Point(323, 69);
            this.dayCountlbl.Name = "dayCountlbl";
            this.dayCountlbl.Size = new System.Drawing.Size(31, 13);
            this.dayCountlbl.TabIndex = 6;
            this.dayCountlbl.Text = "Days";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 260);
            this.Controls.Add(this.dayCountTxt);
            this.Controls.Add(this.dayCountlbl);
            this.Controls.Add(this.displayExtentionTxt);
            this.Controls.Add(this.extentionLbl);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.displayDirectoryTxt);
            this.Controls.Add(this.SelectDirectoryBtn);
            this.Name = "MainForm";
            this.Text = "File Traverser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectDirectoryBtn;
        private System.Windows.Forms.TextBox displayDirectoryTxt;
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader LastModified;
        private System.Windows.Forms.ColumnHeader Directory;
        private System.Windows.Forms.FolderBrowserDialog selectFolderDialog;
        private System.Windows.Forms.Label extentionLbl;
        private System.Windows.Forms.TextBox displayExtentionTxt;
        private System.Windows.Forms.TextBox dayCountTxt;
        private System.Windows.Forms.Label dayCountlbl;
    }
}

