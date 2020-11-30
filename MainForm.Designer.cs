
namespace Youtube_DL_GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // youtubedlBtn
            // 
            this.youtubedlBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.youtubedlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtubedlBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.youtubedlBtn.Location = new System.Drawing.Point(10, 181);
            this.youtubedlBtn.Name = "youtubedlBtn";
            this.youtubedlBtn.Size = new System.Drawing.Size(139, 23);
            this.youtubedlBtn.TabIndex = 0;
            this.youtubedlBtn.Text = "Download Youtube-dl";
            this.toolTip1.SetToolTip(this.youtubedlBtn, "Download the youtube-dl form official website!\r\nIf you can\'t click on the GET but" +
        "ton, is disable beacause the youtube-dl.exe is missing!");
            this.youtubedlBtn.UseVisualStyleBackColor = false;
            this.youtubedlBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderselBtn
            // 
            this.folderselBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.folderselBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderselBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderselBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.folderselBtn.Location = new System.Drawing.Point(395, 149);
            this.folderselBtn.Name = "folderselBtn";
            this.folderselBtn.Size = new System.Drawing.Size(75, 21);
            this.folderselBtn.TabIndex = 1;
            this.folderselBtn.Text = "Select";
            this.folderselBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.folderselBtn, "Option to select where to save your files!");
            this.folderselBtn.UseVisualStyleBackColor = false;
            this.folderselBtn.Click += new System.EventHandler(this.folderselBtn_Click);
            // 
            // txturlBox
            // 
            this.txturlBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txturlBox.ForeColor = System.Drawing.Color.Gray;
            this.txturlBox.Location = new System.Drawing.Point(10, 29);
            this.txturlBox.Name = "txturlBox";
            this.txturlBox.Size = new System.Drawing.Size(379, 20);
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
            this.getlinkBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.getlinkBtn.FlatAppearance.BorderSize = 0;
            this.getlinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getlinkBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.getlinkBtn.Location = new System.Drawing.Point(395, 29);
            this.getlinkBtn.Name = "getlinkBtn";
            this.getlinkBtn.Size = new System.Drawing.Size(75, 20);
            this.getlinkBtn.TabIndex = 4;
            this.getlinkBtn.Text = "GET";
            this.toolTip1.SetToolTip(this.getlinkBtn, "If you can\'t click on the button is disable beacause the youtube-dl.exe is missin" +
        "g!");
            this.getlinkBtn.UseVisualStyleBackColor = false;
            this.getlinkBtn.Click += new System.EventHandler(this.getlinkBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.ForeColor = System.Drawing.Color.LightCoral;
            this.progressBar.Location = new System.Drawing.Point(10, 55);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(379, 23);
            this.progressBar.TabIndex = 5;
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLbl.Location = new System.Drawing.Point(395, 63);
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
            this.txtfolderBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfolderBox.ForeColor = System.Drawing.Color.Gray;
            this.txtfolderBox.Location = new System.Drawing.Point(10, 150);
            this.txtfolderBox.Name = "txtfolderBox";
            this.txtfolderBox.ReadOnly = true;
            this.txtfolderBox.Size = new System.Drawing.Size(379, 20);
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
            this.githublinkLbl.Location = new System.Drawing.Point(339, 191);
            this.githublinkLbl.Name = "githublinkLbl";
            this.githublinkLbl.Size = new System.Drawing.Size(131, 13);
            this.githublinkLbl.TabIndex = 9;
            this.githublinkLbl.TabStop = true;
            this.githublinkLbl.Text = "Click here to get to github ";
            this.githublinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublinkLbl_LinkClicked);
            // 
            // txtfilenameBox
            // 
            this.txtfilenameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfilenameBox.Location = new System.Drawing.Point(10, 103);
            this.txtfilenameBox.Name = "txtfilenameBox";
            this.txtfilenameBox.Size = new System.Drawing.Size(379, 20);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(398, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Guid-Naming";
            this.toolTip1.SetToolTip(this.checkBox1, "If this is checked will generated an guid number for every file\r\nSomething like t" +
        "his : f5e97257-a569-441c-b869-193e4be2eb06");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(482, 211);
            this.Controls.Add(this.checkBox1);
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
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Youtube-DL GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

