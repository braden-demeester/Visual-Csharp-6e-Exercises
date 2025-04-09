using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace FileExplorer
{
    public partial class FileExplorerForm : Form
    {
        public FileExplorerForm()
        {
            InitializeComponent();
        }
        
        // Store the current main directory; default to C:\Users
        private string currentDirectory = @"C:\Users";

        // Store a constant ListViewItem for going up one directory
        private readonly ListViewItem upOneDirectoryListViewItem =
            new ListViewItem("..") { ImageIndex = 2 };

        /// <summary>
        /// Recursive method that fills a TreeNode with nodes for each subdirectory associated with the given node
        /// </summary>
        /// <param name="mainDirectory">The directory with whose contents the parentNode will be populated</param>
        /// <param name="parentNode">The TreeNode to be populated</param>
        private void PopulateTreeView(string mainDirectory, TreeNode parentNode)
        {
            try
            {
                // Get all the subdirectories for the given directory
                string[] directories = Directory.GetDirectories(mainDirectory);

                // Check that there are any subdirectories
                if(directories.Length > 0)
                {
                    // Loop through the array of directories
                    foreach (string directory in directories)
                    {
                        // Get the name of the directory (without preceding absolute path)
                        string filename = Path.GetFileNameWithoutExtension(directory);

                        // Create a new TreeNode with the file name as its text
                        TreeNode childNode = new TreeNode(filename);
                        // Add the new node to the parentNode
                        parentNode.Nodes.Add(childNode);

                        // Recursively populate the new child node
                        PopulateTreeView(directory, childNode);
                    }
                }
            }
            // Catch exceptions from lack of permission
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied!");
            }
            // Catch exceptions from unfound directories
            catch(DirectoryNotFoundException)
            {
                parentNode.Nodes.Add("Directory not found!");
            }
        }

        /// <summary>
        /// Populates directoryContentsListView with all the directories and files within the given directory
        /// </summary>
        /// <param name="mainDirectory">The directory with whose contents directoryContentsListView will be populated</param>
        private void PopulateListView(string mainDirectory)
        {
            try
            {
                // Create a DirectoryInfo object for the given directory
                DirectoryInfo directoryInfo = new DirectoryInfo(mainDirectory);

                // Get all the directories and files within the given directory
                DirectoryInfo[] contentsDirectories = directoryInfo.GetDirectories();
                FileInfo[] contentsFiles = directoryInfo.GetFiles();

                // Loop through the directories and add them to the ListView
                foreach(DirectoryInfo dir in contentsDirectories)
                {
                    ListViewItem item = new ListViewItem(dir.Name);
                    item.ImageIndex = 0; // Sets the icon to a folder image
                    directoryContentsListView.Items.Add(item);
                }

                // Loop through the files and add them to the ListView
                foreach(FileInfo file in contentsFiles)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.ImageIndex = 1; // Sets the icon to a file image
                    directoryContentsListView.Items.Add(item);
                }
            }
            // Catch exceptions from lack of permission
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("Some files or directories may be invisible due to lack of access.",
                    "Unauthorized Access Exception", 0, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Method to populate directoriesTreeView and directoryContentsListView based on the given directory
        /// </summary>
        /// <param name="mainDirectory">The directory with whose contents the views will be populated</param>
        private void PopulateExplorer(string mainDirectory)
        {
            if (Directory.Exists(mainDirectory))
            {
                // Empty the tree view
                directoriesTreeView.Nodes.Clear();
                // Add the main directory as the main node
                directoriesTreeView.Nodes.Add(new TreeNode(mainDirectory));
                // Populate the main tree node
                PopulateTreeView(mainDirectory, directoriesTreeView.Nodes[0]);

                // Empty the list view
                directoryContentsListView.Items.Clear();
                // Add the "go up one directory" option
                directoryContentsListView.Items.Add(upOneDirectoryListViewItem);
                // Populate the list view
                PopulateListView(mainDirectory);
            }
        }

        /// <summary>
        /// Initialize the image list for the ListView, and populate both views
        /// Called when the form first loads
        /// </summary>
        private void FileExplorerForm_Load(object sender, EventArgs e)
        {
            // Empty the image list
            fileExplorerImageList.Images.Clear();
            
            // Add images for folders, files, and the "go up one directory" option
            fileExplorerImageList.Images.Add(Properties.Resources.folder);
            fileExplorerImageList.Images.Add(Properties.Resources.file);
            fileExplorerImageList.Images.Add(Properties.Resources.up);

            // Set the list view's SmallImageList to this list
            directoryContentsListView.SmallImageList = fileExplorerImageList;


            // Populate the views with the current directory 
            PopulateExplorer(currentDirectory);

        }

        /// <summary>
        /// Handles double-click events on directoriesTreeView and directoryContentsListView
        /// </summary>
        private void DoubleClickHandler(object sender, EventArgs e)
        {
            // If the event is from directoryContentsListView and the selected item is the "go up one directory" item
            if (sender == directoryContentsListView && 
                directoryContentsListView.Items[0].Selected)
            {
                // Create a DirectoryInfo object for the current directory
                DirectoryInfo dir = new DirectoryInfo(currentDirectory);

                // Make sure the directory has a parent directory
                if (dir.Parent != null) 
                {
                    // Set currentDirectory to the parent directory and populate both views
                    currentDirectory = dir.Parent.FullName;
                    PopulateExplorer(currentDirectory);
                }

                return; // Exit the method
            }

            // Store the path selected in the view
            string selectedPath =
                // If in the tree view
                sender == directoriesTreeView ?
                    // Get the text of the selected node
                    directoriesTreeView.SelectedNode.Text
                // Otherwise (if in the list view), if there's something selected in the list view
                : directoryContentsListView.SelectedItems.Count > 0 ? 
                    // Get the text of the first selected item
                    directoryContentsListView.SelectedItems[0].Text
                // Otherwise (if in the list view with nothing selected)
                // Use an empty string
                : "";

            // Exit the method if nothing was selected (no need to repopulate the views with the same directory)
            if (selectedPath == "") return;
                
            // Get the path for the new selected directory
            string newPath = Path.Combine(currentDirectory, selectedPath);

            // If the path destination is a file
            if (File.Exists(newPath))
            {
                try
                {
                    // Open the file
                    Process.Start(newPath);
                }
                // If the file can't be opened
                catch (Win32Exception)
                {
                    // Inform the user
                    MessageBox.Show("This file can't be opened.");
                }
            }
            // If the path destination is a directory
            else if(Directory.Exists(newPath))
            {
                // Set currentDirectory to the new path and populate the views with it
                currentDirectory = newPath;
                PopulateExplorer(currentDirectory);
            }
        }

    }
}
