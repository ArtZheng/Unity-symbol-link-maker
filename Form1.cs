using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitySymLinkMaker
{
    public partial class Form1 : Form
    {
        string sourceFilePath ="", sourceFolderPath = "";
        string targetFilePath ="", targetFolderPath = "";
        string[] pathSplit;
        string symlName;
        string linkFolderPath;
        string newSymlFilePath;
        string finalSymlFilePath;
        string datestamp =string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
        bool isFile = false;
        bool isFolder = false;
        bool isStandard = false;

        private void CreateSymbolicLink(string targetFolderPath, string smylName, string sourcFolderPath, bool isFile)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = targetFolderPath;
            startInfo.FileName = "cmd.exe";//call cmd 
            startInfo.RedirectStandardInput = true;// allow cmd input
            startInfo.RedirectStandardOutput = true;//get cmd output
            startInfo.UseShellExecute = false;// do not use shell

            if (isFile)
            {
                startInfo.Arguments = "/C mklink \"" + smylName + "\" \"" + sourcFolderPath + "\"";//input command with /C for files
            }
            else
            {
                startInfo.Arguments = "/C mklink /d \"" + smylName + "\" \"" + sourcFolderPath + "\"";//input command with /C /d for directories
            }
            
            startInfo.Verb = "runas";//run as admin if allowed
            process.StartInfo = startInfo;
            process.Start();

            // Synchronously read the standard output of the spawned process. 
            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            //send out put to process logs
            Process_log.Text += output;

        }
            

        public Form1()
        {
            InitializeComponent();

        }

        //browsing for source project folder
        private void Proj_loca_brws_button_Click(object sender, EventArgs e)
        { 
            FolderBrowserDialog projOpenFolderDialog = new FolderBrowserDialog();

            if(projOpenFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(projOpenFolderDialog.SelectedPath))
            {
                datestamp = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
                //get file path and assign to input
                string projFolderPath = projOpenFolderDialog.SelectedPath;
                sourceFolderPath = proj_loca_input_txt.Text = projFolderPath;
                //assume user want syml folder to be in same path
                targetFolderPath = syml_loca_input_txt.Text = projFolderPath + "_SymLink_"+datestamp;
            }
        }

        //allow user to choose destination path for folder symlink
        private void Syml_loca_brws_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog symlOpenFolderDialog = new FolderBrowserDialog();

            if (symlOpenFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(symlOpenFolderDialog.SelectedPath))
            {
                //get file path and assign to input
                string symlFolderPath = symlOpenFolderDialog.SelectedPath;
                targetFolderPath =syml_loca_input_txt.Text = symlFolderPath;

            }
        }

        //browse for source file
        private void File_loca_brws_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.FileName))
            {
                datestamp = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
                //get file path and assign to input
                string projFilepath = fileDialog.FileName;
                //get directory path
                string directoryPath = Path.GetDirectoryName(projFilepath);
                //assume new file will be generated in the same folder fo sourcefile
                targetFilePath = symlFileFolder_loca_txt_input.Text = directoryPath;
                sourceFilePath = projFile_loca_txt_input.Text = projFilepath;
                //assume user want syml file to be in same folder
                string[] splitExtensionFilePath = sourceFilePath.Split('.');
                //get name of file and add symlink timestamp
                string symlFileName = splitExtensionFilePath[splitExtensionFilePath.Length - 2] + "_SymLink_" + datestamp;
                splitExtensionFilePath[splitExtensionFilePath.Length - 2] = splitExtensionFilePath[splitExtensionFilePath.Length - 2] + "_SymLink_" + datestamp;
                string symlTimeStamp = string.Join(".", splitExtensionFilePath);
                //process file path to get syml file name with time stamp and extension
                string[] splitSourceFilepath = symlTimeStamp.Split('\\');
                // get file name and add to target file path
                newSymlFilePath = splitSourceFilepath[splitSourceFilepath.Length - 1];
                finalSymlFilePath = targetFilePath + "\\" + newSymlFilePath;
                Process_log.Text += "Symlink file loaction is: " + finalSymlFilePath+ Environment.NewLine;
            }

        }

        //browse to select location for new single syml file 
        private void File_syml_loca_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog symlOpenFolderDialog = new FolderBrowserDialog();

            if (symlOpenFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(symlOpenFolderDialog.SelectedPath))
            {
                //get file path and assign to input
                targetFilePath = symlFileFolder_loca_txt_input.Text = symlOpenFolderDialog.SelectedPath;
                finalSymlFilePath = targetFilePath + "\\" + newSymlFilePath;
                Process_log.Text += "File location switch to: " + finalSymlFilePath + Environment.NewLine;
            }

        }

        //create symlink for selected folder
        private void Create_syml_button_Click(object sender, EventArgs e)
        {
            isFile = false;
                        
            //get sub folders from project folder specified
            string[] sourceFoldersPath = Directory.GetDirectories(sourceFolderPath);
            
            //single level directory
            if(sourceFoldersPath.Length == 0)
            { 
                pathSplit = sourceFolderPath.Split('\\');
                symlName = pathSplit[pathSplit.Length - 1];
                string parentPath = System.IO.Directory.GetParent(targetFolderPath).FullName;
                CreateSymbolicLink(parentPath, targetFolderPath, sourceFolderPath, isFile);
            }
            else if(sourceFoldersPath.Length > 0)//multi level directory
            {
                //create symlink folder in same folder as project
                Process_log.Text += "Creating symlink folder... " + Environment.NewLine;
                string symlinkFolder = targetFolderPath;
                System.IO.Directory.CreateDirectory(symlinkFolder);

                Process_log.Text += "Symlink Folder created at: " + targetFolderPath + Environment.NewLine;

                foreach (string folderPath in sourceFoldersPath)
                {
                    if (isStandard)
                    {
                        //only Assets, ProjectSettings and Packages are valid
                        if (folderPath.Contains("\\Assets") || folderPath.Contains("\\Packages") || folderPath.Contains("\\ProjectSettings"))
                        {
                            Process_log.Text += "Standard folder found: " + folderPath + Environment.NewLine;
                            pathSplit = folderPath.Split('\\');
                            symlName = pathSplit[pathSplit.Length - 1];
                            /*linkFolderPath = targetFolderPath + "\\" + symlName;
                            //copy folder to target symlink folder
                            var dirSource = new DirectoryInfo(folderPath);
                            var dirTarget = new DirectoryInfo(linkFolderPath);
                            Process_log.Text += "Link folder created: " + linkFolderPath + Environment.NewLine;
                            //CopyAll(dirSource, dirTarget);*/
                            CreateSymbolicLink(targetFolderPath, symlName, folderPath, isFile);

                        }
                    }
                    else // if not standard create the symlink for the selected folder
                    {
                        pathSplit = folderPath.Split('\\');

                        symlName = pathSplit[pathSplit.Length - 1];
                        //Create all subdirectories as required
                        Process_log.Text += "Source folder found: " + folderPath + Environment.NewLine;
                        linkFolderPath = targetFolderPath + "\\" + symlName;
                        CreateSymbolicLink(targetFolderPath, symlName, folderPath, isFile);


                    }
                }

            }
            
        }

        //create symlink for selected file path
        private void Create_syml_file_button_Click(object sender, EventArgs e)
        {
            isFile = true;
            string sourceFile = sourceFilePath;
            symlName = finalSymlFilePath;//get chosen file
            //create symlink folder in same folder as project
            Process_log.Text += "Creating symlink file... " + Environment.NewLine;
            CreateSymbolicLink(targetFilePath, symlName, sourceFile, isFile);
            Process_log.Text += "Symlink File created at: " + targetFilePath + Environment.NewLine;

        }

        private void proj_loca_input_txt_TextChanged(object sender, EventArgs e)
        {
            sourceFolderPath = proj_loca_input_txt.Text;
            Process_log.Text += "Source Folder Path set to: " + sourceFolderPath + Environment.NewLine;
        }

        private void syml_loca_input_txt_TextChanged(object sender, EventArgs e)
        {
            targetFolderPath = syml_loca_input_txt.Text;
            Process_log.Text += "Target Folder Path set to: " + targetFolderPath + Environment.NewLine;
        }

        private void projFile_loca_txt_input_TextChanged(object sender, EventArgs e)
        {
            sourceFilePath = projFile_loca_txt_input.Text;
            Process_log.Text += "Source File Path set to: " + sourceFilePath + Environment.NewLine;
        }

        private void symlFileFolder_loca_txt_input_TextChanged(object sender, EventArgs e)
        {
            targetFilePath = symlFileFolder_loca_txt_input.Text;
            Process_log.Text += "Target File Path set to: " + targetFilePath + Environment.NewLine;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCCtgfN-1fqMKgbSEFD8j9OA");
        }

      

        private void checkBoxStandardFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStandardFolders.Checked)
            {
                isStandard = true;
            }
            else
            {
                isStandard = false;
            }
        }


        /* public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
         {
             Directory.CreateDirectory(target.FullName);

             // Copy each file into the new directory. Overwrites existing
             foreach (FileInfo fi in source.GetFiles())
             {
                 Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                 fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
             }


             // Copy each subdirectory using recursion.
             foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
             {
                 DirectoryInfo nextTargetSubDir =
                 target.CreateSubdirectory(diSourceSubDir.Name);
                 CopyAll(diSourceSubDir, nextTargetSubDir);
             }
         }*/


    }

}
