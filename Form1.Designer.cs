
namespace Youtube_DL_GUI
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
            this.youtubedlBtn = new System.Windows.Forms.Button();
            this.folderselBtn = new System.Windows.Forms.Button();
            this.txturlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getlinkBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLbl = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtfolderBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.githublinkLbl = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtfilenameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // youtubedlBtn
            // 
            this.youtubedlBtn.ForeColor = System.Drawing.Color.White;
            this.youtubedlBtn.Location = new System.Drawing.Point(10, 176);
            this.youtubedlBtn.Name = "youtubedlBtn";
            this.youtubedlBtn.Size = new System.Drawing.Size(139, 23);
            this.youtubedlBtn.TabIndex = 0;
            this.youtubedlBtn.Text = "Download Youtube-dl";
            this.toolTip1.SetToolTip(this.youtubedlBtn, "Download the youtube-dl form official website!\r\nIf you can\'t click on the GET but" +
        "ton, is disable beacause the youtube-dl.exe is missing!");
            this.youtubedlBtn.UseVisualStyleBackColor = true;
            this.youtubedlBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderselBtn
            // 
            this.folderselBtn.ForeColor = System.Drawing.Color.White;
            this.folderselBtn.Location = new System.Drawing.Point(429, 149);
            this.folderselBtn.Name = "folderselBtn";
            this.folderselBtn.Size = new System.Drawing.Size(36, 20);
            this.folderselBtn.TabIndex = 1;
            this.folderselBtn.Text = "...";
            this.toolTip1.SetToolTip(this.folderselBtn, "Option to select where to save your files!");
            this.folderselBtn.UseVisualStyleBackColor = true;
            this.folderselBtn.Click += new System.EventHandler(this.folderselBtn_Click);
            // 
            // txturlBox
            // 
            this.txturlBox.ForeColor = System.Drawing.Color.White;
            this.txturlBox.Location = new System.Drawing.Point(12, 29);
            this.txturlBox.Name = "txturlBox";
            this.txturlBox.Size = new System.Drawing.Size(377, 20);
            this.txturlBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please put here an youtube link with id containing:";
            // 
            // getlinkBtn
            // 
            this.getlinkBtn.ForeColor = System.Drawing.Color.White;
            this.getlinkBtn.Location = new System.Drawing.Point(395, 29);
            this.getlinkBtn.Name = "getlinkBtn";
            this.getlinkBtn.Size = new System.Drawing.Size(75, 20);
            this.getlinkBtn.TabIndex = 4;
            this.getlinkBtn.Text = "GET";
            this.toolTip1.SetToolTip(this.getlinkBtn, "If you can\'t click on the button is disable beacause the youtube-dl.exe is missin" +
        "g!");
            this.getlinkBtn.UseVisualStyleBackColor = true;
            this.getlinkBtn.Click += new System.EventHandler(this.getlinkBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 61);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(410, 23);
            this.progressBar.TabIndex = 5;
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLbl.Location = new System.Drawing.Point(426, 64);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(31, 15);
            this.progressLbl.TabIndex = 6;
            this.progressLbl.Text = "0 %";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // txtfolderBox
            // 
            this.txtfolderBox.Location = new System.Drawing.Point(10, 150);
            this.txtfolderBox.Name = "txtfolderBox";
            this.txtfolderBox.ReadOnly = true;
            this.txtfolderBox.Size = new System.Drawing.Size(410, 20);
            this.txtfolderBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please select where do you want to save the file:";
            // 
            // githublinkLbl
            // 
            this.githublinkLbl.AutoSize = true;
            this.githublinkLbl.Location = new System.Drawing.Point(339, 181);
            this.githublinkLbl.Name = "githublinkLbl";
            this.githublinkLbl.Size = new System.Drawing.Size(131, 13);
            this.githublinkLbl.TabIndex = 9;
            this.githublinkLbl.TabStop = true;
            this.githublinkLbl.Text = "Click here to get to github ";
            this.githublinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublinkLbl_LinkClicked);
            // 
            // txtfilenameBox
            // 
            this.txtfilenameBox.Location = new System.Drawing.Point(10, 103);
            this.txtfilenameBox.Name = "txtfilenameBox";
            this.txtfilenameBox.Size = new System.Drawing.Size(410, 20);
            this.txtfilenameBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name of your song ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(482, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfilenameBox);
            this.Controls.Add(this.githublinkLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfolderBox);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.getlinkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txturlBox);
            this.Controls.Add(this.folderselBtn);
            this.Controls.Add(this.youtubedlBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button youtubedlBtn;
        private System.Windows.Forms.Button folderselBtn;
        private System.Windows.Forms.TextBox txturlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getlinkBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox txtfolderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel githublinkLbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtfilenameBox;
        private System.Windows.Forms.Label label3;
    }
}

