namespace Presentation
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.lblFormatSupported = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 105);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(126, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "please select the folder, where you want to \r\norganize music. But First make a ba" +
    "ckup!";
            // 
            // lblInformation
            // 
            this.lblInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 251);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(70, 18);
            this.lblInformation.TabIndex = 2;
            this.lblInformation.Text = "Waiting...";
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 18;
            this.lbFiles.Location = new System.Drawing.Point(172, 79);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(290, 148);
            this.lbFiles.TabIndex = 3;
            // 
            // btnOrganize
            // 
            this.btnOrganize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrganize.Enabled = false;
            this.btnOrganize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrganize.Location = new System.Drawing.Point(202, 282);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(75, 29);
            this.btnOrganize.TabIndex = 4;
            this.btnOrganize.Text = "Organize";
            this.btnOrganize.UseVisualStyleBackColor = true;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // lblFormatSupported
            // 
            this.lblFormatSupported.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormatSupported.AutoSize = true;
            this.lblFormatSupported.Location = new System.Drawing.Point(12, 131);
            this.lblFormatSupported.Name = "lblFormatSupported";
            this.lblFormatSupported.Size = new System.Drawing.Size(100, 90);
            this.lblFormatSupported.TabIndex = 5;
            this.lblFormatSupported.Text = "Only support: \r\n- mp3\r\n- flac \r\n- wav\r\n- wma";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 321);
            this.Controls.Add(this.lblFormatSupported);
            this.Controls.Add(this.btnOrganize);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFolder);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 580);
            this.MinimumSize = new System.Drawing.Size(490, 360);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Label lblFormatSupported;
    }
}