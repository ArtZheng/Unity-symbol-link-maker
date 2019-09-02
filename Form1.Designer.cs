namespace UnitySymLinkMaker
{
    partial class Form1
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
            if (disposing && ( components != null ))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Create_syml_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Process_log = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proj_loca_input_txt = new System.Windows.Forms.TextBox();
            this.syml_loca_input_txt = new System.Windows.Forms.TextBox();
            this.Proj_loca_brws_button = new System.Windows.Forms.Button();
            this.Syml_loca_brws_button = new System.Windows.Forms.Button();
            this.folderDetailsBox = new System.Windows.Forms.GroupBox();
            this.checkBoxStandardFolders = new System.Windows.Forms.CheckBox();
            this.fileDetailsBox = new System.Windows.Forms.GroupBox();
            this.Create_syml_file_button = new System.Windows.Forms.Button();
            this.File_syml_loca_button = new System.Windows.Forms.Button();
            this.File_loca_brws_button = new System.Windows.Forms.Button();
            this.symlFileFolder_loca_txt_input = new System.Windows.Forms.TextBox();
            this.projFile_loca_txt_input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.folderDetailsBox.SuspendLayout();
            this.fileDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Create_syml_button
            // 
            this.Create_syml_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Create_syml_button.Location = new System.Drawing.Point(20, 154);
            this.Create_syml_button.Name = "Create_syml_button";
            this.Create_syml_button.Size = new System.Drawing.Size(158, 26);
            this.Create_syml_button.TabIndex = 2;
            this.Create_syml_button.Text = "Create Symlink Folder";
            this.Create_syml_button.UseVisualStyleBackColor = true;
            this.Create_syml_button.Click += new System.EventHandler(this.Create_syml_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Process Log:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // Process_log
            // 
            this.Process_log.Location = new System.Drawing.Point(255, 550);
            this.Process_log.Multiline = true;
            this.Process_log.Name = "Process_log";
            this.Process_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Process_log.Size = new System.Drawing.Size(456, 101);
            this.Process_log.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(105, 638);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Alex Hicks YouTube";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "By: Arthur Zheng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Special thanks to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Symlink Location:";
            // 
            // proj_loca_input_txt
            // 
            this.proj_loca_input_txt.Location = new System.Drawing.Point(20, 47);
            this.proj_loca_input_txt.Name = "proj_loca_input_txt";
            this.proj_loca_input_txt.Size = new System.Drawing.Size(567, 20);
            this.proj_loca_input_txt.TabIndex = 2;
            this.proj_loca_input_txt.TextChanged += new System.EventHandler(this.proj_loca_input_txt_TextChanged);
            // 
            // syml_loca_input_txt
            // 
            this.syml_loca_input_txt.Location = new System.Drawing.Point(20, 115);
            this.syml_loca_input_txt.Name = "syml_loca_input_txt";
            this.syml_loca_input_txt.Size = new System.Drawing.Size(567, 20);
            this.syml_loca_input_txt.TabIndex = 3;
            this.syml_loca_input_txt.TextChanged += new System.EventHandler(this.syml_loca_input_txt_TextChanged);
            // 
            // Proj_loca_brws_button
            // 
            this.Proj_loca_brws_button.Location = new System.Drawing.Point(600, 47);
            this.Proj_loca_brws_button.Name = "Proj_loca_brws_button";
            this.Proj_loca_brws_button.Size = new System.Drawing.Size(75, 23);
            this.Proj_loca_brws_button.TabIndex = 4;
            this.Proj_loca_brws_button.Text = "Browse";
            this.Proj_loca_brws_button.UseVisualStyleBackColor = true;
            this.Proj_loca_brws_button.Click += new System.EventHandler(this.Proj_loca_brws_button_Click);
            // 
            // Syml_loca_brws_button
            // 
            this.Syml_loca_brws_button.Location = new System.Drawing.Point(600, 115);
            this.Syml_loca_brws_button.Name = "Syml_loca_brws_button";
            this.Syml_loca_brws_button.Size = new System.Drawing.Size(75, 23);
            this.Syml_loca_brws_button.TabIndex = 5;
            this.Syml_loca_brws_button.Text = "Browse";
            this.Syml_loca_brws_button.UseVisualStyleBackColor = true;
            this.Syml_loca_brws_button.Click += new System.EventHandler(this.Syml_loca_brws_button_Click);
            // 
            // folderDetailsBox
            // 
            this.folderDetailsBox.Controls.Add(this.checkBoxStandardFolders);
            this.folderDetailsBox.Controls.Add(this.Syml_loca_brws_button);
            this.folderDetailsBox.Controls.Add(this.Proj_loca_brws_button);
            this.folderDetailsBox.Controls.Add(this.syml_loca_input_txt);
            this.folderDetailsBox.Controls.Add(this.proj_loca_input_txt);
            this.folderDetailsBox.Controls.Add(this.label3);
            this.folderDetailsBox.Controls.Add(this.label2);
            this.folderDetailsBox.Controls.Add(this.Create_syml_button);
            this.folderDetailsBox.Location = new System.Drawing.Point(15, 120);
            this.folderDetailsBox.Name = "folderDetailsBox";
            this.folderDetailsBox.Size = new System.Drawing.Size(696, 192);
            this.folderDetailsBox.TabIndex = 1;
            this.folderDetailsBox.TabStop = false;
            this.folderDetailsBox.Text = "Folder Details";
            // 
            // checkBoxStandardFolders
            // 
            this.checkBoxStandardFolders.AutoSize = true;
            this.checkBoxStandardFolders.Location = new System.Drawing.Point(20, 72);
            this.checkBoxStandardFolders.Name = "checkBoxStandardFolders";
            this.checkBoxStandardFolders.Size = new System.Drawing.Size(577, 17);
            this.checkBoxStandardFolders.TabIndex = 6;
            this.checkBoxStandardFolders.Text = "Standard Folders: Maker will copy and link the \'Assets\', \'Project Settings\' and \'" +
    "Packages\' folders from Project location.";
            this.checkBoxStandardFolders.UseVisualStyleBackColor = true;
            this.checkBoxStandardFolders.CheckedChanged += new System.EventHandler(this.checkBoxStandardFolders_CheckedChanged);
            // 
            // fileDetailsBox
            // 
            this.fileDetailsBox.Controls.Add(this.Create_syml_file_button);
            this.fileDetailsBox.Controls.Add(this.File_syml_loca_button);
            this.fileDetailsBox.Controls.Add(this.File_loca_brws_button);
            this.fileDetailsBox.Controls.Add(this.symlFileFolder_loca_txt_input);
            this.fileDetailsBox.Controls.Add(this.projFile_loca_txt_input);
            this.fileDetailsBox.Controls.Add(this.label8);
            this.fileDetailsBox.Controls.Add(this.label9);
            this.fileDetailsBox.Location = new System.Drawing.Point(15, 328);
            this.fileDetailsBox.Name = "fileDetailsBox";
            this.fileDetailsBox.Size = new System.Drawing.Size(696, 191);
            this.fileDetailsBox.TabIndex = 6;
            this.fileDetailsBox.TabStop = false;
            this.fileDetailsBox.Text = "File Details";
            // 
            // Create_syml_file_button
            // 
            this.Create_syml_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Create_syml_file_button.Location = new System.Drawing.Point(20, 148);
            this.Create_syml_file_button.Name = "Create_syml_file_button";
            this.Create_syml_file_button.Size = new System.Drawing.Size(145, 26);
            this.Create_syml_file_button.TabIndex = 7;
            this.Create_syml_file_button.Text = "Create Symlink File";
            this.Create_syml_file_button.UseVisualStyleBackColor = true;
            this.Create_syml_file_button.Click += new System.EventHandler(this.Create_syml_file_button_Click);
            // 
            // File_syml_loca_button
            // 
            this.File_syml_loca_button.Location = new System.Drawing.Point(600, 109);
            this.File_syml_loca_button.Name = "File_syml_loca_button";
            this.File_syml_loca_button.Size = new System.Drawing.Size(75, 23);
            this.File_syml_loca_button.TabIndex = 5;
            this.File_syml_loca_button.Text = "Browse";
            this.File_syml_loca_button.UseVisualStyleBackColor = true;
            this.File_syml_loca_button.Click += new System.EventHandler(this.File_syml_loca_button_Click);
            // 
            // File_loca_brws_button
            // 
            this.File_loca_brws_button.Location = new System.Drawing.Point(600, 47);
            this.File_loca_brws_button.Name = "File_loca_brws_button";
            this.File_loca_brws_button.Size = new System.Drawing.Size(75, 23);
            this.File_loca_brws_button.TabIndex = 4;
            this.File_loca_brws_button.Text = "Browse";
            this.File_loca_brws_button.UseVisualStyleBackColor = true;
            this.File_loca_brws_button.Click += new System.EventHandler(this.File_loca_brws_button_Click);
            // 
            // symlFileFolder_loca_txt_input
            // 
            this.symlFileFolder_loca_txt_input.Location = new System.Drawing.Point(20, 109);
            this.symlFileFolder_loca_txt_input.Name = "symlFileFolder_loca_txt_input";
            this.symlFileFolder_loca_txt_input.Size = new System.Drawing.Size(567, 20);
            this.symlFileFolder_loca_txt_input.TabIndex = 3;
            this.symlFileFolder_loca_txt_input.TextChanged += new System.EventHandler(this.symlFileFolder_loca_txt_input_TextChanged);
            // 
            // projFile_loca_txt_input
            // 
            this.projFile_loca_txt_input.Location = new System.Drawing.Point(20, 47);
            this.projFile_loca_txt_input.Name = "projFile_loca_txt_input";
            this.projFile_loca_txt_input.Size = new System.Drawing.Size(567, 20);
            this.projFile_loca_txt_input.TabIndex = 2;
            this.projFile_loca_txt_input.TextChanged += new System.EventHandler(this.projFile_loca_txt_input_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Symlink File\'s Folder Location:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "File Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 665);
            this.Controls.Add(this.fileDetailsBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Process_log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.folderDetailsBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Unity Symlink Maker";
            this.folderDetailsBox.ResumeLayout(false);
            this.folderDetailsBox.PerformLayout();
            this.fileDetailsBox.ResumeLayout(false);
            this.fileDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create_syml_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Process_log;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proj_loca_input_txt;
        private System.Windows.Forms.TextBox syml_loca_input_txt;
        private System.Windows.Forms.Button Proj_loca_brws_button;
        private System.Windows.Forms.Button Syml_loca_brws_button;
        private System.Windows.Forms.GroupBox folderDetailsBox;
        private System.Windows.Forms.GroupBox fileDetailsBox;
        private System.Windows.Forms.Button File_syml_loca_button;
        private System.Windows.Forms.Button File_loca_brws_button;
        private System.Windows.Forms.TextBox symlFileFolder_loca_txt_input;
        private System.Windows.Forms.TextBox projFile_loca_txt_input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxStandardFolders;
        private System.Windows.Forms.Button Create_syml_file_button;
    }
}

