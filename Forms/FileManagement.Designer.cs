namespace Messenger
{
    partial class FileManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagement));
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.cmsFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.plReminder = new System.Windows.Forms.Panel();
            this.tlpRem = new System.Windows.Forms.TableLayoutPanel();
            this.ssFileManagement = new System.Windows.Forms.StatusStrip();
            this.lbLabelTotalSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTotalSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.imlFiles = new System.Windows.Forms.ImageList(this.components);
            this.IdFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadMes = new System.Windows.Forms.DataGridViewImageColumn();
            this.SeenMessage = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imlEmpty = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.cmsFiles.SuspendLayout();
            this.plReminder.SuspendLayout();
            this.ssFileManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowDrop = true;
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFile,
            this.IdMes,
            this.refUser,
            this.DownloadMes,
            this.SeenMessage,
            this.FileName,
            this.Size,
            this.CreateDate,
            this.Receiver});
            this.dgvFiles.ContextMenuStrip = this.cmsFiles;
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.GridColor = System.Drawing.Color.White;
            this.dgvFiles.Location = new System.Drawing.Point(0, 0);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(530, 375);
            this.dgvFiles.TabIndex = 1;
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            // 
            // cmsFiles
            // 
            this.cmsFiles.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmsFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnDeleteFile,
            this.cbtnDownloadFile,
            this.cbtnOpenFile});
            this.cmsFiles.Name = "cmsConversationText";
            this.cmsFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsFiles.Size = new System.Drawing.Size(132, 70);
            // 
            // cbtnDeleteFile
            // 
            this.cbtnDeleteFile.Name = "cbtnDeleteFile";
            this.cbtnDeleteFile.Size = new System.Drawing.Size(131, 22);
            this.cbtnDeleteFile.Text = "حذف";
            this.cbtnDeleteFile.Click += new System.EventHandler(this.cbtnDeleteFile_Click);
            // 
            // cbtnDownloadFile
            // 
            this.cbtnDownloadFile.Name = "cbtnDownloadFile";
            this.cbtnDownloadFile.Size = new System.Drawing.Size(131, 22);
            this.cbtnDownloadFile.Text = "دانلود فایل";
            this.cbtnDownloadFile.Click += new System.EventHandler(this.cbtnDownloadFile_Click);
            // 
            // cbtnOpenFile
            // 
            this.cbtnOpenFile.Name = "cbtnOpenFile";
            this.cbtnOpenFile.Size = new System.Drawing.Size(131, 22);
            this.cbtnOpenFile.Text = "باز کردن فایل";
            this.cbtnOpenFile.Click += new System.EventHandler(this.cbtnOpenFile_Click);
            // 
            // plReminder
            // 
            this.plReminder.BackColor = System.Drawing.Color.White;
            this.plReminder.Controls.Add(this.dgvFiles);
            this.plReminder.Controls.Add(this.tlpRem);
            this.plReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plReminder.Font = new System.Drawing.Font("Tahoma", 9F);
            this.plReminder.Location = new System.Drawing.Point(0, 0);
            this.plReminder.Name = "plReminder";
            this.plReminder.Size = new System.Drawing.Size(530, 375);
            this.plReminder.TabIndex = 2;
            // 
            // tlpRem
            // 
            this.tlpRem.AutoSize = true;
            this.tlpRem.ColumnCount = 3;
            this.tlpRem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpRem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpRem.Location = new System.Drawing.Point(0, 0);
            this.tlpRem.Name = "tlpRem";
            this.tlpRem.RowCount = 1;
            this.tlpRem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRem.Size = new System.Drawing.Size(530, 0);
            this.tlpRem.TabIndex = 2;
            // 
            // ssFileManagement
            // 
            this.ssFileManagement.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ssFileManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbLabelTotalSize,
            this.lbTotalSize});
            this.ssFileManagement.Location = new System.Drawing.Point(0, 375);
            this.ssFileManagement.Name = "ssFileManagement";
            this.ssFileManagement.Size = new System.Drawing.Size(530, 22);
            this.ssFileManagement.TabIndex = 3;
            this.ssFileManagement.Text = "statusStrip1";
            // 
            // lbLabelTotalSize
            // 
            this.lbLabelTotalSize.Name = "lbLabelTotalSize";
            this.lbLabelTotalSize.Size = new System.Drawing.Size(95, 17);
            this.lbLabelTotalSize.Text = "حجم کل فایل ها:";
            // 
            // lbTotalSize
            // 
            this.lbTotalSize.Name = "lbTotalSize";
            this.lbTotalSize.Size = new System.Drawing.Size(14, 17);
            this.lbTotalSize.Text = "0";
            // 
            // imlFiles
            // 
            this.imlFiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFiles.ImageStream")));
            this.imlFiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFiles.Images.SetKeyName(0, "Tick_32.png");
            this.imlFiles.Images.SetKeyName(1, "AttachmentD2-32.png");
            // 
            // IdFile
            // 
            this.IdFile.HeaderText = "IdFile";
            this.IdFile.Name = "IdFile";
            this.IdFile.ReadOnly = true;
            this.IdFile.Visible = false;
            // 
            // IdMes
            // 
            this.IdMes.HeaderText = "IdMes";
            this.IdMes.Name = "IdMes";
            this.IdMes.ReadOnly = true;
            this.IdMes.Visible = false;
            // 
            // refUser
            // 
            this.refUser.HeaderText = "refUser";
            this.refUser.Name = "refUser";
            this.refUser.ReadOnly = true;
            this.refUser.Visible = false;
            // 
            // DownloadMes
            // 
            this.DownloadMes.HeaderText = "";
            this.DownloadMes.Name = "DownloadMes";
            this.DownloadMes.ReadOnly = true;
            this.DownloadMes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DownloadMes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DownloadMes.Width = 19;
            // 
            // SeenMessage
            // 
            this.SeenMessage.HeaderText = "";
            this.SeenMessage.Name = "SeenMessage";
            this.SeenMessage.ReadOnly = true;
            this.SeenMessage.Width = 5;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "نام فایل";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 71;
            // 
            // Size
            // 
            this.Size.HeaderText = "حجم فایل";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 81;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "تاریخ ارسال";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 89;
            // 
            // Receiver
            // 
            this.Receiver.HeaderText = "گیرنده";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            this.Receiver.Width = 63;
            // 
            // imlEmpty
            // 
            this.imlEmpty.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlEmpty.ImageStream")));
            this.imlEmpty.TransparentColor = System.Drawing.Color.Transparent;
            this.imlEmpty.Images.SetKeyName(0, "white2.jpg");
            // 
            // FileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 397);
            this.Controls.Add(this.plReminder);
            this.Controls.Add(this.ssFileManagement);
            this.Name = "FileManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فایل";
            this.Load += new System.EventHandler(this.FileManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.cmsFiles.ResumeLayout(false);
            this.plReminder.ResumeLayout(false);
            this.plReminder.PerformLayout();
            this.ssFileManagement.ResumeLayout(false);
            this.ssFileManagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel plReminder;
        private System.Windows.Forms.TableLayoutPanel tlpRem;
        private System.Windows.Forms.StatusStrip ssFileManagement;
        private System.Windows.Forms.ToolStripStatusLabel lbLabelTotalSize;
        private System.Windows.Forms.ToolStripStatusLabel lbTotalSize;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.ContextMenuStrip cmsFiles;
        private System.Windows.Forms.ToolStripMenuItem cbtnDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem cbtnDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem cbtnOpenFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        public System.Windows.Forms.ImageList imlFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn refUser;
        private System.Windows.Forms.DataGridViewImageColumn DownloadMes;
        private System.Windows.Forms.DataGridViewImageColumn SeenMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        public System.Windows.Forms.ImageList imlEmpty;
    }
}