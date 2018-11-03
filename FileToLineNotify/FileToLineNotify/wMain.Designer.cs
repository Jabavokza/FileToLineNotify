namespace FileToLineNotify
{
    partial class wMain
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
            this.ocmSend = new System.Windows.Forms.Button();
            this.ocmOpenFile = new System.Windows.Forms.Button();
            this.otbPartFile = new System.Windows.Forms.TextBox();
            this.oOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.otbResult = new System.Windows.Forms.TextBox();
            this.otbMsgRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ocmSend
            // 
            this.ocmSend.Location = new System.Drawing.Point(25, 85);
            this.ocmSend.Name = "ocmSend";
            this.ocmSend.Size = new System.Drawing.Size(75, 28);
            this.ocmSend.TabIndex = 0;
            this.ocmSend.Text = "Send";
            this.ocmSend.UseVisualStyleBackColor = true;
            this.ocmSend.Click += new System.EventHandler(this.ocmSend_Click);
            // 
            // ocmOpenFile
            // 
            this.ocmOpenFile.Location = new System.Drawing.Point(266, 52);
            this.ocmOpenFile.Name = "ocmOpenFile";
            this.ocmOpenFile.Size = new System.Drawing.Size(75, 23);
            this.ocmOpenFile.TabIndex = 1;
            this.ocmOpenFile.Text = "OpenFile";
            this.ocmOpenFile.UseVisualStyleBackColor = true;
            this.ocmOpenFile.Click += new System.EventHandler(this.ocmOpenFile_Click);
            // 
            // otbPartFile
            // 
            this.otbPartFile.Location = new System.Drawing.Point(26, 52);
            this.otbPartFile.Name = "otbPartFile";
            this.otbPartFile.Size = new System.Drawing.Size(234, 20);
            this.otbPartFile.TabIndex = 2;
            // 
            // otbResult
            // 
            this.otbResult.Location = new System.Drawing.Point(26, 125);
            this.otbResult.Multiline = true;
            this.otbResult.Name = "otbResult";
            this.otbResult.Size = new System.Drawing.Size(234, 52);
            this.otbResult.TabIndex = 3;
            // 
            // otbMsgRes
            // 
            this.otbMsgRes.Location = new System.Drawing.Point(278, 125);
            this.otbMsgRes.Multiline = true;
            this.otbMsgRes.Name = "otbMsgRes";
            this.otbMsgRes.Size = new System.Drawing.Size(99, 52);
            this.otbMsgRes.TabIndex = 4;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 189);
            this.Controls.Add(this.otbMsgRes);
            this.Controls.Add(this.otbResult);
            this.Controls.Add(this.otbPartFile);
            this.Controls.Add(this.ocmOpenFile);
            this.Controls.Add(this.ocmSend);
            this.Name = "wMain";
            this.Load += new System.EventHandler(this.wMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ocmSend;
        private System.Windows.Forms.Button ocmOpenFile;
        private System.Windows.Forms.TextBox otbPartFile;
        private System.Windows.Forms.OpenFileDialog oOpenFileDialog;
        private System.Windows.Forms.TextBox otbResult;
        private System.Windows.Forms.TextBox otbMsgRes;
    }
}

