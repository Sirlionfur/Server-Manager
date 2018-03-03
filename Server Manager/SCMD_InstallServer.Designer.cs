﻿namespace Server_Manager
{
    partial class SCMD_InstallServer
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
            this.selectedPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.appID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValveList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedPath
            // 
            this.selectedPath.Location = new System.Drawing.Point(12, 38);
            this.selectedPath.Name = "selectedPath";
            this.selectedPath.Size = new System.Drawing.Size(373, 20);
            this.selectedPath.TabIndex = 13;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(50, 9);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 12;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Path:";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(310, 76);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnAddServer.TabIndex = 10;
            this.btnAddServer.Text = "Install";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "AppID:";
            // 
            // appID
            // 
            this.appID.Location = new System.Drawing.Point(12, 76);
            this.appID.Name = "appID";
            this.appID.Size = new System.Drawing.Size(100, 20);
            this.appID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "AppID Lists:";
            // 
            // btnValveList
            // 
            this.btnValveList.Location = new System.Drawing.Point(185, 76);
            this.btnValveList.Name = "btnValveList";
            this.btnValveList.Size = new System.Drawing.Size(75, 23);
            this.btnValveList.TabIndex = 17;
            this.btnValveList.Text = "Valve";
            this.btnValveList.UseVisualStyleBackColor = true;
            this.btnValveList.Click += new System.EventHandler(this.btnValveList_Click);
            // 
            // SCMD_InstallServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 113);
            this.Controls.Add(this.btnValveList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedPath);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddServer);
            this.Name = "SCMD_InstallServer";
            this.Text = "Steam CMD - Install New Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValveList;
    }
}