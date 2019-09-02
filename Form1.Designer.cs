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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Syml_loca_brws_button = new System.Windows.Forms.Button();
            this.Proj_loca_brws_button = new System.Windows.Forms.Button();
            this.syml_loca_input_txt = new System.Windows.Forms.TextBox();
            this.proj_loca_input_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Create_syml_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Process_log = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Syml_loca_brws_button);
            this.groupBox1.Controls.Add(this.Proj_loca_brws_button);
            this.groupBox1.Controls.Add(this.syml_loca_input_txt);
            this.groupBox1.Controls.Add(this.proj_loca_input_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders Details";
            // 
            // Syml_loca_brws_button
            // 
            this.Syml_loca_brws_button.Location = new System.Drawing.Point(600, 109);
            this.Syml_loca_brws_button.Name = "Syml_loca_brws_button";
            this.Syml_loca_brws_button.Size = new System.Drawing.Size(75, 23);
            this.Syml_loca_brws_button.TabIndex = 5;
            this.Syml_loca_brws_button.Text = "Browse";
            this.Syml_loca_brws_button.UseVisualStyleBackColor = true;
            this.Syml_loca_brws_button.Click += new System.EventHandler(this.Syml_loca_brws_button_Click);
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
            // syml_loca_input_txt
            // 
            this.syml_loca_input_txt.Location = new System.Drawing.Point(20, 109);
            this.syml_loca_input_txt.Name = "syml_loca_input_txt";
            this.syml_loca_input_txt.Size = new System.Drawing.Size(567, 20);
            this.syml_loca_input_txt.TabIndex = 3;
            // 
            // proj_loca_input_txt
            // 
            this.proj_loca_input_txt.Location = new System.Drawing.Point(20, 47);
            this.proj_loca_input_txt.Name = "proj_loca_input_txt";
            this.proj_loca_input_txt.Size = new System.Drawing.Size(567, 20);
            this.proj_loca_input_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Symlink Location:";
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
            // Create_syml_button
            // 
            this.Create_syml_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Create_syml_button.Location = new System.Drawing.Point(18, 305);
            this.Create_syml_button.Name = "Create_syml_button";
            this.Create_syml_button.Size = new System.Drawing.Size(142, 36);
            this.Create_syml_button.TabIndex = 2;
            this.Create_syml_button.Text = "Create";
            this.Create_syml_button.UseVisualStyleBackColor = true;
            this.Create_syml_button.Click += new System.EventHandler(this.Create_syml_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 305);
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
            this.Process_log.Location = new System.Drawing.Point(207, 328);
            this.Process_log.Multiline = true;
            this.Process_log.Name = "Process_log";
            this.Process_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Process_log.Size = new System.Drawing.Size(503, 115);
            this.Process_log.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(108, 480);
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
            this.label6.Location = new System.Drawing.Point(15, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "By: Arthur Zheng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Special thanks to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Process_log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Create_syml_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Unity Symlink Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Syml_loca_brws_button;
        private System.Windows.Forms.Button Proj_loca_brws_button;
        private System.Windows.Forms.TextBox syml_loca_input_txt;
        private System.Windows.Forms.TextBox proj_loca_input_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Create_syml_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Process_log;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

