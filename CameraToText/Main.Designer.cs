
namespace CameraToText
{
    partial class Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCam = new System.Windows.Forms.Button();
            this.rtbOcrResult = new System.Windows.Forms.RichTextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureCrop = new System.Windows.Forms.PictureBox();
            this.pictureCam = new System.Windows.Forms.PictureBox();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCam)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(902, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(39, 17);
            this.statusBar.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.MenuItemStop,
            this.MenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItemStop
            // 
            this.MenuItemStop.Name = "MenuItemStop";
            this.MenuItemStop.Size = new System.Drawing.Size(180, 22);
            this.MenuItemStop.Text = "Stop";
            this.MenuItemStop.Click += new System.EventHandler(this.MenuItemStop_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // comPortDevices
            // 
            this.comPortDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comPortDevices.FormattingEnabled = true;
            this.comPortDevices.Location = new System.Drawing.Point(769, 27);
            this.comPortDevices.Name = "comPortDevices";
            this.comPortDevices.Size = new System.Drawing.Size(121, 21);
            this.comPortDevices.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port :";
            // 
            // btnOpenCam
            // 
            this.btnOpenCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCam.Location = new System.Drawing.Point(769, 54);
            this.btnOpenCam.Name = "btnOpenCam";
            this.btnOpenCam.Size = new System.Drawing.Size(121, 23);
            this.btnOpenCam.TabIndex = 4;
            this.btnOpenCam.Text = "Open camera";
            this.btnOpenCam.UseVisualStyleBackColor = true;
            this.btnOpenCam.Click += new System.EventHandler(this.btnOpenCam_Click);
            // 
            // rtbOcrResult
            // 
            this.rtbOcrResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOcrResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOcrResult.Location = new System.Drawing.Point(522, 123);
            this.rtbOcrResult.Name = "rtbOcrResult";
            this.rtbOcrResult.Size = new System.Drawing.Size(368, 270);
            this.rtbOcrResult.TabIndex = 6;
            this.rtbOcrResult.Text = "";
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(769, 83);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(121, 23);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 71);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert to Text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCrop
            // 
            this.pictureCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureCrop.Location = new System.Drawing.Point(522, 399);
            this.pictureCrop.Name = "pictureCrop";
            this.pictureCrop.Size = new System.Drawing.Size(368, 92);
            this.pictureCrop.TabIndex = 7;
            this.pictureCrop.TabStop = false;
            // 
            // pictureCam
            // 
            this.pictureCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureCam.Location = new System.Drawing.Point(22, 31);
            this.pictureCam.Name = "pictureCam";
            this.pictureCam.Size = new System.Drawing.Size(494, 478);
            this.pictureCam.TabIndex = 5;
            this.pictureCam.TabStop = false;
            this.pictureCam.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureCam_Paint);
            this.pictureCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureCam_MouseDown);
            this.pictureCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureCam_MouseMove);
            this.pictureCam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureCam_MouseUp);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 541);
            this.Controls.Add(this.pictureCrop);
            this.Controls.Add(this.rtbOcrResult);
            this.Controls.Add(this.pictureCam);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnOpenCam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comPortDevices);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ComboBox comPortDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenCam;
        private System.Windows.Forms.PictureBox pictureCam;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.RichTextBox rtbOcrResult;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStop;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.PictureBox pictureCrop;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    }
}

