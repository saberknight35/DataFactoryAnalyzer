namespace DataFactoryAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbFolderPath = new TextBox();
            lsbJsonFileList = new ListBox();
            btnBrowseFolder = new Button();
            pnlProcess = new Panel();
            pnlSummary = new Panel();
            btnShowSummary = new Button();
            txbPipelineSummary = new TextBox();
            txbDatasetSummary = new TextBox();
            txbLinkedServiceSummary = new TextBox();
            pnlProcess.SuspendLayout();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // 
            // txbFolderPath
            // 
            txbFolderPath.Location = new Point(24, 24);
            txbFolderPath.Name = "txbFolderPath";
            txbFolderPath.Size = new Size(439, 27);
            txbFolderPath.TabIndex = 0;
            // 
            // lsbJsonFileList
            // 
            lsbJsonFileList.FormattingEnabled = true;
            lsbJsonFileList.Location = new Point(24, 66);
            lsbJsonFileList.Name = "lsbJsonFileList";
            lsbJsonFileList.Size = new Size(539, 344);
            lsbJsonFileList.TabIndex = 1;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Location = new Point(457, 11);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(94, 29);
            btnBrowseFolder.TabIndex = 2;
            btnBrowseFolder.Text = "Browse";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // pnlProcess
            // 
            pnlProcess.Controls.Add(btnBrowseFolder);
            pnlProcess.Location = new Point(12, 12);
            pnlProcess.Name = "pnlProcess";
            pnlProcess.Size = new Size(566, 414);
            pnlProcess.TabIndex = 3;
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(btnShowSummary);
            pnlSummary.Controls.Add(txbPipelineSummary);
            pnlSummary.Controls.Add(txbDatasetSummary);
            pnlSummary.Controls.Add(txbLinkedServiceSummary);
            pnlSummary.Location = new Point(584, 12);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(496, 416);
            pnlSummary.TabIndex = 4;
            // 
            // btnShowSummary
            // 
            btnShowSummary.Location = new Point(13, 12);
            btnShowSummary.Name = "btnShowSummary";
            btnShowSummary.Size = new Size(94, 29);
            btnShowSummary.TabIndex = 3;
            btnShowSummary.Text = "Summarize";
            btnShowSummary.UseVisualStyleBackColor = true;
            btnShowSummary.Click += btnShowSummary_Click;
            // 
            // txbPipelineSummary
            // 
            txbPipelineSummary.Location = new Point(13, 293);
            txbPipelineSummary.Multiline = true;
            txbPipelineSummary.Name = "txbPipelineSummary";
            txbPipelineSummary.Size = new Size(465, 105);
            txbPipelineSummary.TabIndex = 2;
            // 
            // txbDatasetSummary
            // 
            txbDatasetSummary.Location = new Point(13, 182);
            txbDatasetSummary.Multiline = true;
            txbDatasetSummary.Name = "txbDatasetSummary";
            txbDatasetSummary.ScrollBars = ScrollBars.Both;
            txbDatasetSummary.Size = new Size(465, 105);
            txbDatasetSummary.TabIndex = 1;
            // 
            // txbLinkedServiceSummary
            // 
            txbLinkedServiceSummary.Location = new Point(13, 71);
            txbLinkedServiceSummary.Multiline = true;
            txbLinkedServiceSummary.Name = "txbLinkedServiceSummary";
            txbLinkedServiceSummary.ScrollBars = ScrollBars.Both;
            txbLinkedServiceSummary.Size = new Size(465, 105);
            txbLinkedServiceSummary.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 442);
            Controls.Add(pnlSummary);
            Controls.Add(lsbJsonFileList);
            Controls.Add(txbFolderPath);
            Controls.Add(pnlProcess);
            Name = "MainForm";
            Text = "Data Factory Analyzer";
            pnlProcess.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbFolderPath;
        private ListBox lsbJsonFileList;
        private Button btnBrowseFolder;
        private Panel pnlProcess;
        private Panel pnlSummary;
        private Button btnShowSummary;
        private TextBox txbPipelineSummary;
        private TextBox txbDatasetSummary;
        private TextBox txbLinkedServiceSummary;
    }
}
