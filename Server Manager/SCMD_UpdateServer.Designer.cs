﻿namespace Server_Manager
{
    partial class SCMD_UpdateServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.appID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnValveList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppID to Update:";
            // 
            // appID
            // 
            this.appID.Location = new System.Drawing.Point(16, 30);
            this.appID.Name = "appID";
            this.appID.Size = new System.Drawing.Size(100, 20);
            this.appID.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnValveList
            // 
            this.btnValveList.Location = new System.Drawing.Point(233, 27);
            this.btnValveList.Name = "btnValveList";
            this.btnValveList.Size = new System.Drawing.Size(75, 23);
            this.btnValveList.TabIndex = 19;
            this.btnValveList.Text = "Valve";
            this.btnValveList.UseVisualStyleBackColor = true;
            this.btnValveList.Click += new System.EventHandler(this.btnValveList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "AppID Lists:";
            // 
            // SCMD_UpdateServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 64);
            this.Controls.Add(this.btnValveList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.appID);
            this.Controls.Add(this.label1);
            this.Name = "SCMD_UpdateServer";
            this.Text = "SCMD_UpdateServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnValveList;
        private System.Windows.Forms.Label label2;
    }
}