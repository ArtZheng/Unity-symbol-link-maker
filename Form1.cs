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
        string sourcePath ="";
        string targetPath = "";
        string datestamp = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
        private void CreateSymbolicLink(string targetPath, string linkfolderName, string SourcefolderPath)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = targetPath;
            startInfo.FileName = "cmd.exe";//call cmd 
            startInfo.RedirectStandardInput = true;// allow cmd input
            startInfo.RedirectStandardOutput = true;//get cmd output
            startInfo.UseShellExecute = false;// do not use shell
            startInfo.Arguments = "/C mklink /d \"" +  linkfolderName + "\" \"" + SourcefolderPath+"\"";//input command with /C close cmd when complete
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

        //browsing for project folder
        private void Proj_loca_brws_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog projOpenFolderDialog = new FolderBrowserDialog();

            if(projOpenFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(projOpenFolderDialog.SelectedPath))
            {
                //get file path and assign to input
                string projFilepath = projOpenFolderDialog.SelectedPath;
                sourcePath = proj_loca_input_txt.Text = projFilepath;
                //assume user want syml folder to be in same path
                targetPath = syml_loca_input_txt.Text = projFilepath+"_SymLink_"+datestamp;
            }
        }

        //allow user to choose destination path for symlink
        private void Syml_loca_brws_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog symlOpenFolderDialog = new FolderBrowserDialog();

            if (symlOpenFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(symlOpenFolderDialog.SelectedPath))
            {
                //get file path and assign to input
                string symlFilepath = symlOpenFolderDialog.SelectedPath;
                targetPath =syml_loca_input_txt.Text = symlFilepath;

            }
        }

        private void Create_syml_button_Click(object sender, EventArgs e)
        {
            //create symlink folder in same folder as project
            Process_log.Text += "Creating symlink folder... " + Environment.NewLine;
            string symlinkFolder = targetPath;
            System.IO.Directory.CreateDirectory(symlinkFolder);

            Process_log.Text += "Symlink folder created at: " + targetPath + Environment.NewLine;

            //get sub folders from project folder specified
            string[] sourceFoldersPath = Directory.GetDirectories(sourcePath);
            string[] folderSplit;

            foreach (string folderPath in sourceFoldersPath)
            {
                 //only Assets, ProjectSettings and Packages are valid
                if (folderPath.Contains("\\Assets") || folderPath.Contains("\\Packages") || folderPath.Contains("\\ProjectSettings"))
                {
                    Process_log.Text += "Source folder found: " + folderPath + Environment.NewLine;
                    folderSplit = folderPath.Split('\\');
                    string folderName = folderSplit[folderSplit.Length - 1];
                    string linkFolderPath = targetPath + "\\" + folderName;
                    //copy folder to target symlink folder
                    var dirSource = new DirectoryInfo(folderPath);
                    var dirTarget = new DirectoryInfo(linkFolderPath);
                    Process_log.Text += "Link folder created: " + linkFolderPath + Environment.NewLine;
                    //CopyAll(dirSource, dirTarget);
                    
                    CreateSymbolicLink(targetPath, folderName, folderPath);

                }
            }
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCCtgfN-1fqMKgbSEFD8j9OA");
        }
    }

}
