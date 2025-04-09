namespace FileExplorer
{
    partial class FileExplorerForm
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
            this.components = new System.ComponentModel.Container();
            this.directoriesTreeView = new System.Windows.Forms.TreeView();
            this.directoryContentsListView = new System.Windows.Forms.ListView();
            this.fileExplorerImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // directoriesTreeView
            // 
            this.directoriesTreeView.Location = new System.Drawing.Point(13, 12);
            this.directoriesTreeView.Name = "directoriesTreeView";
            this.directoriesTreeView.Size = new System.Drawing.Size(192, 426);
            this.directoriesTreeView.TabIndex = 0;
            this.directoriesTreeView.DoubleClick += new System.EventHandler(this.DoubleClickHandler);
            // 
            // directoryContentsListView
            // 
            this.directoryContentsListView.HideSelection = false;
            this.directoryContentsListView.LabelWrap = false;
            this.directoryContentsListView.Location = new System.Drawing.Point(245, 12);
            this.directoryContentsListView.Name = "directoryContentsListView";
            this.directoryContentsListView.Size = new System.Drawing.Size(642, 425);
            this.directoryContentsListView.SmallImageList = this.fileExplorerImageList;
            this.directoryContentsListView.TabIndex = 1;
            this.directoryContentsListView.UseCompatibleStateImageBehavior = false;
            this.directoryContentsListView.View = System.Windows.Forms.View.List;
            this.directoryContentsListView.DoubleClick += new System.EventHandler(this.DoubleClickHandler);
            // 
            // fileExplorerImageList
            // 
            this.fileExplorerImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.fileExplorerImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.fileExplorerImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FileExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.directoryContentsListView);
            this.Controls.Add(this.directoriesTreeView);
            this.Name = "FileExplorerForm";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.FileExplorerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView directoriesTreeView;
        private System.Windows.Forms.ListView directoryContentsListView;
        private System.Windows.Forms.ImageList fileExplorerImageList;
    }
}

