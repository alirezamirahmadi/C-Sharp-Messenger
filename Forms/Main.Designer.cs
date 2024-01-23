namespace Messenger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnConversation = new System.Windows.Forms.ToolStripButton();
            this.btnUsers = new System.Windows.Forms.ToolStripButton();
            this.btnGroupUser = new System.Windows.Forms.ToolStripButton();
            this.btnShowReminder = new System.Windows.Forms.ToolStripButton();
            this.btnFileManagement = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.cmsListConversation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnDelConversation = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnClearHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lbUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbsp1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbName = new System.Windows.Forms.ToolStripStatusLabel();
            this.spc1 = new System.Windows.Forms.SplitContainer();
            this.dgvListConversation = new System.Windows.Forms.DataGridView();
            this.TypeCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolTipCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListUser = new System.Windows.Forms.DataGridView();
            this.IdUr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusUr = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameUr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.lbTypeList = new System.Windows.Forms.Label();
            this.lbSplit = new System.Windows.Forms.Label();
            this.spc2 = new System.Windows.Forms.SplitContainer();
            this.dgvConversation = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUserMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMessage = new System.Windows.Forms.DataGridViewImageColumn();
            this.SeenMessage = new System.Windows.Forms.DataGridViewImageColumn();
            this.TextDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextDatePar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsConversation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnCopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnForwardMes = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnDeleteText = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnCompleteDeleteText = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpUserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbNameParticipant = new System.Windows.Forms.Label();
            this.lbLastSeenParticipant = new System.Windows.Forms.Label();
            this.rtxtNewMessage = new System.Windows.Forms.RichTextBox();
            this.tlpReminderMessage = new System.Windows.Forms.TableLayoutPanel();
            this.dtpReminder = new BehComponents.DateTimePickerX();
            this.txtReminderText = new System.Windows.Forms.TextBox();
            this.lbInterval = new System.Windows.Forms.Label();
            this.cbUserInterval = new System.Windows.Forms.ComboBox();
            this.lbReminderText = new System.Windows.Forms.Label();
            this.dtpReminderFrom = new BehComponents.DateTimePickerX();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.lbToDate = new System.Windows.Forms.Label();
            this.nudHourInterval = new System.Windows.Forms.NumericUpDown();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.tsSendMessage = new System.Windows.Forms.ToolStrip();
            this.btnSendMessage = new System.Windows.Forms.ToolStripButton();
            this.btnBrowseFile = new System.Windows.Forms.ToolStripButton();
            this.btnReminder = new System.Windows.Forms.ToolStripButton();
            this.tiNewMessage = new System.Windows.Forms.Timer(this.components);
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.nfiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnOpenWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnCloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.imlReadMessage = new System.Windows.Forms.ImageList(this.components);
            this.tiReminder = new System.Windows.Forms.Timer(this.components);
            this.imlTypeMessage = new System.Windows.Forms.ImageList(this.components);
            this.imlUnReadMessage = new System.Windows.Forms.ImageList(this.components);
            this.imlStatus = new System.Windows.Forms.ImageList(this.components);
            this.tsMain.SuspendLayout();
            this.cmsListConversation.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc1)).BeginInit();
            this.spc1.Panel1.SuspendLayout();
            this.spc1.Panel2.SuspendLayout();
            this.spc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListConversation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc2)).BeginInit();
            this.spc2.Panel1.SuspendLayout();
            this.spc2.Panel2.SuspendLayout();
            this.spc2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversation)).BeginInit();
            this.cmsConversation.SuspendLayout();
            this.tlpUserInfo.SuspendLayout();
            this.tlpReminderMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourInterval)).BeginInit();
            this.tsSendMessage.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConversation,
            this.btnUsers,
            this.btnGroupUser,
            this.btnShowReminder,
            this.btnFileManagement,
            this.btnHelp,
            this.btnExit});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(840, 55);
            this.tsMain.TabIndex = 0;
            // 
            // btnConversation
            // 
            this.btnConversation.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnConversation.Image = ((System.Drawing.Image)(resources.GetObject("btnConversation.Image")));
            this.btnConversation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConversation.Name = "btnConversation";
            this.btnConversation.Size = new System.Drawing.Size(44, 52);
            this.btnConversation.Text = "مکالمه";
            this.btnConversation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConversation.Click += new System.EventHandler(this.btnConversation_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(44, 52);
            this.btnUsers.Text = "کاربران";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnGroupUser
            // 
            this.btnGroupUser.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnGroupUser.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupUser.Image")));
            this.btnGroupUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGroupUser.Name = "btnGroupUser";
            this.btnGroupUser.Size = new System.Drawing.Size(70, 52);
            this.btnGroupUser.Text = "گروه کاربران";
            this.btnGroupUser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnGroupUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGroupUser.Click += new System.EventHandler(this.btnGroupUser_Click);
            // 
            // btnShowReminder
            // 
            this.btnShowReminder.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnShowReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnShowReminder.Image")));
            this.btnShowReminder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowReminder.Name = "btnShowReminder";
            this.btnShowReminder.Size = new System.Drawing.Size(46, 52);
            this.btnShowReminder.Text = "یادآوری";
            this.btnShowReminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowReminder.Click += new System.EventHandler(this.btnShowReminder_Click);
            // 
            // btnFileManagement
            // 
            this.btnFileManagement.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFileManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnFileManagement.Image")));
            this.btnFileManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileManagement.Name = "btnFileManagement";
            this.btnFileManagement.Size = new System.Drawing.Size(48, 52);
            this.btnFileManagement.Text = "فایل ها";
            this.btnFileManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFileManagement.Click += new System.EventHandler(this.btnFileManagement_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(41, 52);
            this.btnHelp.Text = "راهنما";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 52);
            this.btnExit.Text = "خروج";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmsListConversation
            // 
            this.cmsListConversation.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmsListConversation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnDelConversation,
            this.cbtnClearHistory});
            this.cmsListConversation.Name = "cmsConversation";
            this.cmsListConversation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsListConversation.Size = new System.Drawing.Size(152, 48);
            this.cmsListConversation.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListConversation_Opening);
            // 
            // cbtnDelConversation
            // 
            this.cbtnDelConversation.Name = "cbtnDelConversation";
            this.cbtnDelConversation.Size = new System.Drawing.Size(151, 22);
            this.cbtnDelConversation.Text = "حذف";
            this.cbtnDelConversation.Click += new System.EventHandler(this.cbtnDelConversation_Click);
            // 
            // cbtnClearHistory
            // 
            this.cbtnClearHistory.Name = "cbtnClearHistory";
            this.cbtnClearHistory.Size = new System.Drawing.Size(151, 22);
            this.cbtnClearHistory.Text = "پاک کردن تاریخچه";
            this.cbtnClearHistory.Click += new System.EventHandler(this.cbtnClearHistory_Click);
            // 
            // ssMain
            // 
            this.ssMain.BackColor = System.Drawing.Color.White;
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbUserName,
            this.lbsp1,
            this.lbName});
            this.ssMain.Location = new System.Drawing.Point(0, 479);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(840, 22);
            this.ssMain.TabIndex = 2;
            // 
            // lbUserName
            // 
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(60, 17);
            this.lbUserName.Text = "Username";
            // 
            // lbsp1
            // 
            this.lbsp1.Name = "lbsp1";
            this.lbsp1.Size = new System.Drawing.Size(10, 17);
            this.lbsp1.Text = "|";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 17);
            this.lbName.Text = "Name";
            // 
            // spc1
            // 
            this.spc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc1.Location = new System.Drawing.Point(0, 55);
            this.spc1.Name = "spc1";
            // 
            // spc1.Panel1
            // 
            this.spc1.Panel1.Controls.Add(this.dgvListConversation);
            this.spc1.Panel1.Controls.Add(this.dgvListUser);
            this.spc1.Panel1.Controls.Add(this.txtSearchItem);
            this.spc1.Panel1.Controls.Add(this.lbTypeList);
            this.spc1.Panel1.Controls.Add(this.lbSplit);
            this.spc1.Panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.spc1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spc1.Panel2
            // 
            this.spc1.Panel2.Controls.Add(this.spc2);
            this.spc1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spc1.Size = new System.Drawing.Size(840, 424);
            this.spc1.SplitterDistance = 148;
            this.spc1.TabIndex = 4;
            // 
            // dgvListConversation
            // 
            this.dgvListConversation.AllowUserToAddRows = false;
            this.dgvListConversation.AllowUserToDeleteRows = false;
            this.dgvListConversation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListConversation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListConversation.BackgroundColor = System.Drawing.Color.White;
            this.dgvListConversation.ColumnHeadersVisible = false;
            this.dgvListConversation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCon,
            this.IdCon,
            this.refUser,
            this.StatusUser,
            this.NameCon,
            this.ToolTipCon});
            this.dgvListConversation.ContextMenuStrip = this.cmsListConversation;
            this.dgvListConversation.GridColor = System.Drawing.Color.White;
            this.dgvListConversation.Location = new System.Drawing.Point(29, 144);
            this.dgvListConversation.MultiSelect = false;
            this.dgvListConversation.Name = "dgvListConversation";
            this.dgvListConversation.ReadOnly = true;
            this.dgvListConversation.RowHeadersVisible = false;
            this.dgvListConversation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListConversation.Size = new System.Drawing.Size(79, 70);
            this.dgvListConversation.TabIndex = 7;
            this.dgvListConversation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListConversation_CellClick);
            this.dgvListConversation.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListConversation_CellMouseEnter);
            // 
            // TypeCon
            // 
            this.TypeCon.HeaderText = "TypeCon";
            this.TypeCon.Name = "TypeCon";
            this.TypeCon.ReadOnly = true;
            this.TypeCon.Visible = false;
            this.TypeCon.Width = 5;
            // 
            // IdCon
            // 
            this.IdCon.HeaderText = "IdCon";
            this.IdCon.Name = "IdCon";
            this.IdCon.ReadOnly = true;
            this.IdCon.Visible = false;
            this.IdCon.Width = 5;
            // 
            // refUser
            // 
            this.refUser.HeaderText = "refUser";
            this.refUser.Name = "refUser";
            this.refUser.ReadOnly = true;
            this.refUser.Visible = false;
            this.refUser.Width = 5;
            // 
            // StatusUser
            // 
            this.StatusUser.HeaderText = "StatusUser";
            this.StatusUser.Name = "StatusUser";
            this.StatusUser.ReadOnly = true;
            this.StatusUser.Width = 5;
            // 
            // NameCon
            // 
            this.NameCon.HeaderText = "NameCon";
            this.NameCon.Name = "NameCon";
            this.NameCon.ReadOnly = true;
            this.NameCon.Width = 5;
            // 
            // ToolTipCon
            // 
            this.ToolTipCon.HeaderText = "ToolTipCon";
            this.ToolTipCon.Name = "ToolTipCon";
            this.ToolTipCon.ReadOnly = true;
            this.ToolTipCon.Visible = false;
            this.ToolTipCon.Width = 5;
            // 
            // dgvListUser
            // 
            this.dgvListUser.AllowUserToAddRows = false;
            this.dgvListUser.AllowUserToDeleteRows = false;
            this.dgvListUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvListUser.ColumnHeadersVisible = false;
            this.dgvListUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUr,
            this.StatusUr,
            this.NameUr});
            this.dgvListUser.GridColor = System.Drawing.Color.White;
            this.dgvListUser.Location = new System.Drawing.Point(16, 269);
            this.dgvListUser.MultiSelect = false;
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.ReadOnly = true;
            this.dgvListUser.RowHeadersVisible = false;
            this.dgvListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUser.Size = new System.Drawing.Size(77, 78);
            this.dgvListUser.TabIndex = 5;
            this.dgvListUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUser_CellDoubleClick);
            this.dgvListUser.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUser_CellMouseEnter);
            // 
            // IdUr
            // 
            this.IdUr.HeaderText = "IdUr";
            this.IdUr.Name = "IdUr";
            this.IdUr.ReadOnly = true;
            this.IdUr.Visible = false;
            this.IdUr.Width = 5;
            // 
            // StatusUr
            // 
            this.StatusUr.HeaderText = "StatusUr";
            this.StatusUr.Name = "StatusUr";
            this.StatusUr.ReadOnly = true;
            this.StatusUr.Width = 5;
            // 
            // NameUr
            // 
            this.NameUr.HeaderText = "NameUr";
            this.NameUr.Name = "NameUr";
            this.NameUr.ReadOnly = true;
            this.NameUr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameUr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameUr.Width = 5;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.BackColor = System.Drawing.Color.LightYellow;
            this.txtSearchItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchItem.Location = new System.Drawing.Point(0, 23);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(148, 22);
            this.txtSearchItem.TabIndex = 6;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // lbTypeList
            // 
            this.lbTypeList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTypeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTypeList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeList.Location = new System.Drawing.Point(0, 10);
            this.lbTypeList.Name = "lbTypeList";
            this.lbTypeList.Size = new System.Drawing.Size(148, 13);
            this.lbTypeList.TabIndex = 2;
            this.lbTypeList.Text = "لیست مکالمات";
            this.lbTypeList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSplit
            // 
            this.lbSplit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSplit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSplit.Location = new System.Drawing.Point(0, 0);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(148, 10);
            this.lbSplit.TabIndex = 4;
            // 
            // spc2
            // 
            this.spc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc2.Location = new System.Drawing.Point(0, 0);
            this.spc2.Name = "spc2";
            this.spc2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc2.Panel1
            // 
            this.spc2.Panel1.BackColor = System.Drawing.Color.White;
            this.spc2.Panel1.Controls.Add(this.dgvConversation);
            this.spc2.Panel1.Controls.Add(this.tlpUserInfo);
            this.spc2.Panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.spc2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spc2.Panel2
            // 
            this.spc2.Panel2.Controls.Add(this.rtxtNewMessage);
            this.spc2.Panel2.Controls.Add(this.tlpReminderMessage);
            this.spc2.Panel2.Controls.Add(this.tsSendMessage);
            this.spc2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spc2.Size = new System.Drawing.Size(688, 424);
            this.spc2.SplitterDistance = 323;
            this.spc2.TabIndex = 4;
            // 
            // dgvConversation
            // 
            this.dgvConversation.AllowDrop = true;
            this.dgvConversation.AllowUserToAddRows = false;
            this.dgvConversation.AllowUserToDeleteRows = false;
            this.dgvConversation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConversation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConversation.BackgroundColor = System.Drawing.Color.White;
            this.dgvConversation.ColumnHeadersVisible = false;
            this.dgvConversation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Seen,
            this.IdUserMes,
            this.Id,
            this.TypeMessage,
            this.SeenMessage,
            this.TextDate,
            this.TextMessage,
            this.TextDatePar});
            this.dgvConversation.ContextMenuStrip = this.cmsConversation;
            this.dgvConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConversation.GridColor = System.Drawing.Color.White;
            this.dgvConversation.Location = new System.Drawing.Point(0, 45);
            this.dgvConversation.Name = "dgvConversation";
            this.dgvConversation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvConversation.RowHeadersVisible = false;
            this.dgvConversation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConversation.Size = new System.Drawing.Size(688, 278);
            this.dgvConversation.TabIndex = 0;
            this.dgvConversation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConversation_CellDoubleClick);
            this.dgvConversation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvConversation_Scroll);
            this.dgvConversation.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvConversation_DragDrop);
            this.dgvConversation.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvConversation_DragEnter);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            this.Type.Width = 5;
            // 
            // Seen
            // 
            this.Seen.HeaderText = "Seen";
            this.Seen.Name = "Seen";
            this.Seen.Visible = false;
            this.Seen.Width = 5;
            // 
            // IdUserMes
            // 
            this.IdUserMes.HeaderText = "IdUserMes";
            this.IdUserMes.Name = "IdUserMes";
            this.IdUserMes.ReadOnly = true;
            this.IdUserMes.Visible = false;
            this.IdUserMes.Width = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // TypeMessage
            // 
            this.TypeMessage.HeaderText = "TypeMessage";
            this.TypeMessage.Name = "TypeMessage";
            this.TypeMessage.Width = 5;
            // 
            // SeenMessage
            // 
            this.SeenMessage.HeaderText = "SeenMessage";
            this.SeenMessage.Name = "SeenMessage";
            this.SeenMessage.ReadOnly = true;
            this.SeenMessage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeenMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SeenMessage.Width = 5;
            // 
            // TextDate
            // 
            this.TextDate.HeaderText = "TextDate";
            this.TextDate.Name = "TextDate";
            this.TextDate.ReadOnly = true;
            this.TextDate.Width = 5;
            // 
            // TextMessage
            // 
            this.TextMessage.HeaderText = "TextMessage";
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.ReadOnly = true;
            this.TextMessage.Width = 5;
            // 
            // TextDatePar
            // 
            this.TextDatePar.HeaderText = "TextDatePar";
            this.TextDatePar.Name = "TextDatePar";
            this.TextDatePar.ReadOnly = true;
            this.TextDatePar.Width = 5;
            // 
            // cmsConversation
            // 
            this.cmsConversation.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmsConversation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnCopyText,
            this.cbtnForwardMes,
            this.cbtnDeleteText,
            this.cbtnCompleteDeleteText,
            this.cbtnDownloadFile,
            this.cbtnOpenFile});
            this.cmsConversation.Name = "cmsConversationText";
            this.cmsConversation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsConversation.Size = new System.Drawing.Size(132, 136);
            this.cmsConversation.Opening += new System.ComponentModel.CancelEventHandler(this.cmsConversationText_Opening);
            // 
            // cbtnCopyText
            // 
            this.cbtnCopyText.Name = "cbtnCopyText";
            this.cbtnCopyText.Size = new System.Drawing.Size(131, 22);
            this.cbtnCopyText.Text = "کپی";
            this.cbtnCopyText.Click += new System.EventHandler(this.cbtnCopyText_Click);
            // 
            // cbtnForwardMes
            // 
            this.cbtnForwardMes.Name = "cbtnForwardMes";
            this.cbtnForwardMes.Size = new System.Drawing.Size(131, 22);
            this.cbtnForwardMes.Text = "ارسال به";
            this.cbtnForwardMes.Click += new System.EventHandler(this.cbtnForwardMes_Click);
            // 
            // cbtnDeleteText
            // 
            this.cbtnDeleteText.Name = "cbtnDeleteText";
            this.cbtnDeleteText.Size = new System.Drawing.Size(131, 22);
            this.cbtnDeleteText.Text = "حذف";
            this.cbtnDeleteText.Click += new System.EventHandler(this.cbtnDeleteText_Click);
            // 
            // cbtnCompleteDeleteText
            // 
            this.cbtnCompleteDeleteText.Name = "cbtnCompleteDeleteText";
            this.cbtnCompleteDeleteText.Size = new System.Drawing.Size(131, 22);
            this.cbtnCompleteDeleteText.Text = "حذف کامل";
            this.cbtnCompleteDeleteText.Click += new System.EventHandler(this.cbtnCompleteDeleteText_Click);
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
            // tlpUserInfo
            // 
            this.tlpUserInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpUserInfo.ColumnCount = 1;
            this.tlpUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserInfo.Controls.Add(this.lbNameParticipant, 0, 0);
            this.tlpUserInfo.Controls.Add(this.lbLastSeenParticipant, 0, 1);
            this.tlpUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tlpUserInfo.Name = "tlpUserInfo";
            this.tlpUserInfo.RowCount = 2;
            this.tlpUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpUserInfo.Size = new System.Drawing.Size(688, 45);
            this.tlpUserInfo.TabIndex = 1;
            // 
            // lbNameParticipant
            // 
            this.lbNameParticipant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNameParticipant.AutoSize = true;
            this.lbNameParticipant.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameParticipant.ForeColor = System.Drawing.Color.Black;
            this.lbNameParticipant.Location = new System.Drawing.Point(637, 5);
            this.lbNameParticipant.Name = "lbNameParticipant";
            this.lbNameParticipant.Size = new System.Drawing.Size(48, 18);
            this.lbNameParticipant.TabIndex = 0;
            this.lbNameParticipant.Text = "        ";
            // 
            // lbLastSeenParticipant
            // 
            this.lbLastSeenParticipant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLastSeenParticipant.AutoSize = true;
            this.lbLastSeenParticipant.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastSeenParticipant.ForeColor = System.Drawing.Color.DimGray;
            this.lbLastSeenParticipant.Location = new System.Drawing.Point(654, 30);
            this.lbLastSeenParticipant.Name = "lbLastSeenParticipant";
            this.lbLastSeenParticipant.Size = new System.Drawing.Size(31, 13);
            this.lbLastSeenParticipant.TabIndex = 1;
            this.lbLastSeenParticipant.Text = "        ";
            // 
            // rtxtNewMessage
            // 
            this.rtxtNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtNewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtNewMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtxtNewMessage.Location = new System.Drawing.Point(0, 54);
            this.rtxtNewMessage.Name = "rtxtNewMessage";
            this.rtxtNewMessage.Size = new System.Drawing.Size(688, 43);
            this.rtxtNewMessage.TabIndex = 1;
            this.rtxtNewMessage.Text = "";
            this.rtxtNewMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtNewMessage_KeyDown);
            // 
            // tlpReminderMessage
            // 
            this.tlpReminderMessage.BackColor = System.Drawing.Color.White;
            this.tlpReminderMessage.ColumnCount = 10;
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpReminderMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tlpReminderMessage.Controls.Add(this.dtpReminder, 5, 0);
            this.tlpReminderMessage.Controls.Add(this.txtReminderText, 1, 0);
            this.tlpReminderMessage.Controls.Add(this.lbInterval, 6, 0);
            this.tlpReminderMessage.Controls.Add(this.cbUserInterval, 9, 0);
            this.tlpReminderMessage.Controls.Add(this.lbReminderText, 0, 0);
            this.tlpReminderMessage.Controls.Add(this.dtpReminderFrom, 3, 0);
            this.tlpReminderMessage.Controls.Add(this.lbFromDate, 2, 0);
            this.tlpReminderMessage.Controls.Add(this.lbToDate, 4, 0);
            this.tlpReminderMessage.Controls.Add(this.nudHourInterval, 7, 0);
            this.tlpReminderMessage.Controls.Add(this.cbInterval, 8, 0);
            this.tlpReminderMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpReminderMessage.Location = new System.Drawing.Point(0, 27);
            this.tlpReminderMessage.Name = "tlpReminderMessage";
            this.tlpReminderMessage.RowCount = 1;
            this.tlpReminderMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReminderMessage.Size = new System.Drawing.Size(688, 27);
            this.tlpReminderMessage.TabIndex = 2;
            // 
            // dtpReminder
            // 
            this.dtpReminder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpReminder.AnchorSize = new System.Drawing.Size(84, 20);
            this.dtpReminder.BackColor = System.Drawing.Color.White;
            this.dtpReminder.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpReminder.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpReminder.CalendarDayRectTickness = 2F;
            this.dtpReminder.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpReminder.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpReminder.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpReminder.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpReminder.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpReminder.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpReminder.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpReminder.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpReminder.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpReminder.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarSelectedDate = new System.DateTime(2018, 3, 12, 0, 0, 0, 0);
            this.dtpReminder.CalendarShowToday = true;
            this.dtpReminder.CalendarShowTodayRect = true;
            this.dtpReminder.CalendarShowToolTips = false;
            this.dtpReminder.CalendarShowTrailing = true;
            this.dtpReminder.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpReminder.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminder.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpReminder.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminder.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminder.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpReminder.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpReminder.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpReminder.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpReminder.CalendarTodayDate = new System.DateTime(2018, 3, 12, 0, 0, 0, 0);
            this.dtpReminder.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpReminder.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpReminder.CalendarTodayRectTickness = 2F;
            this.dtpReminder.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpReminder.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpReminder.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpReminder.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpReminder.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpReminder.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpReminder.CustomFormat = "";
            this.dtpReminder.DockSide = BehComponents.DropDownEmpty.eDockSide.Left;
            this.dtpReminder.DropDownClosedWhenClickOnDays = false;
            this.dtpReminder.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpReminder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpReminder.Format = BehComponents.DateTimePickerX.FormatDate.Short;
            this.dtpReminder.Location = new System.Drawing.Point(281, 3);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.RightToLeftLayout = true;
            this.dtpReminder.SelectedDate = "1396/12/21";
            this.dtpReminder.Size = new System.Drawing.Size(84, 20);
            this.dtpReminder.TabIndex = 4;
            this.dtpReminder.TodayDate = "1396/12/21";
            // 
            // txtReminderText
            // 
            this.txtReminderText.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtReminderText.Location = new System.Drawing.Point(501, 3);
            this.txtReminderText.MaxLength = 40;
            this.txtReminderText.Name = "txtReminderText";
            this.txtReminderText.Size = new System.Drawing.Size(114, 21);
            this.txtReminderText.TabIndex = 2;
            // 
            // lbInterval
            // 
            this.lbInterval.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbInterval.AutoSize = true;
            this.lbInterval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterval.Location = new System.Drawing.Point(211, 7);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(60, 13);
            this.lbInterval.TabIndex = 52;
            this.lbInterval.Text = "یادآوری هر:";
            // 
            // cbUserInterval
            // 
            this.cbUserInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cbUserInterval.FormattingEnabled = true;
            this.cbUserInterval.Items.AddRange(new object[] {
            "دریافت کننده",
            "ارسال کننده",
            "هر دو"});
            this.cbUserInterval.Location = new System.Drawing.Point(15, 3);
            this.cbUserInterval.Name = "cbUserInterval";
            this.cbUserInterval.Size = new System.Drawing.Size(90, 21);
            this.cbUserInterval.TabIndex = 7;
            // 
            // lbReminderText
            // 
            this.lbReminderText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbReminderText.AutoSize = true;
            this.lbReminderText.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbReminderText.Location = new System.Drawing.Point(621, 7);
            this.lbReminderText.Name = "lbReminderText";
            this.lbReminderText.Size = new System.Drawing.Size(60, 13);
            this.lbReminderText.TabIndex = 57;
            this.lbReminderText.Text = "پیام یادآوری";
            // 
            // dtpReminderFrom
            // 
            this.dtpReminderFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpReminderFrom.AnchorSize = new System.Drawing.Size(84, 20);
            this.dtpReminderFrom.BackColor = System.Drawing.Color.White;
            this.dtpReminderFrom.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpReminderFrom.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpReminderFrom.CalendarDayRectTickness = 2F;
            this.dtpReminderFrom.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpReminderFrom.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpReminderFrom.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpReminderFrom.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpReminderFrom.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpReminderFrom.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpReminderFrom.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpReminderFrom.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpReminderFrom.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpReminderFrom.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpReminderFrom.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminderFrom.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminderFrom.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpReminderFrom.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminderFrom.CalendarSelectedDate = new System.DateTime(2018, 3, 12, 0, 0, 0, 0);
            this.dtpReminderFrom.CalendarShowToday = true;
            this.dtpReminderFrom.CalendarShowTodayRect = true;
            this.dtpReminderFrom.CalendarShowToolTips = false;
            this.dtpReminderFrom.CalendarShowTrailing = true;
            this.dtpReminderFrom.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpReminderFrom.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminderFrom.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpReminderFrom.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminderFrom.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminderFrom.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpReminderFrom.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpReminderFrom.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpReminderFrom.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpReminderFrom.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpReminderFrom.CalendarTodayDate = new System.DateTime(2018, 3, 12, 0, 0, 0, 0);
            this.dtpReminderFrom.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpReminderFrom.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpReminderFrom.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpReminderFrom.CalendarTodayRectTickness = 2F;
            this.dtpReminderFrom.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpReminderFrom.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpReminderFrom.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpReminderFrom.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpReminderFrom.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpReminderFrom.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpReminderFrom.CustomFormat = "";
            this.dtpReminderFrom.DockSide = BehComponents.DropDownEmpty.eDockSide.Left;
            this.dtpReminderFrom.DropDownClosedWhenClickOnDays = false;
            this.dtpReminderFrom.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpReminderFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpReminderFrom.Format = BehComponents.DateTimePickerX.FormatDate.Short;
            this.dtpReminderFrom.Location = new System.Drawing.Point(391, 3);
            this.dtpReminderFrom.Name = "dtpReminderFrom";
            this.dtpReminderFrom.RightToLeftLayout = true;
            this.dtpReminderFrom.SelectedDate = "1396/12/21";
            this.dtpReminderFrom.Size = new System.Drawing.Size(84, 20);
            this.dtpReminderFrom.TabIndex = 3;
            this.dtpReminderFrom.TodayDate = "1396/12/21";
            // 
            // lbFromDate
            // 
            this.lbFromDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbFromDate.Location = new System.Drawing.Point(481, 7);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(14, 13);
            this.lbFromDate.TabIndex = 59;
            this.lbFromDate.Text = "از";
            // 
            // lbToDate
            // 
            this.lbToDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbToDate.AutoSize = true;
            this.lbToDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbToDate.Location = new System.Drawing.Point(372, 7);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(13, 13);
            this.lbToDate.TabIndex = 60;
            this.lbToDate.Text = "تا";
            // 
            // nudHourInterval
            // 
            this.nudHourInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.nudHourInterval.Location = new System.Drawing.Point(171, 3);
            this.nudHourInterval.Name = "nudHourInterval";
            this.nudHourInterval.Size = new System.Drawing.Size(34, 21);
            this.nudHourInterval.TabIndex = 5;
            // 
            // cbInterval
            // 
            this.cbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "ساعت",
            "روز"});
            this.cbInterval.Location = new System.Drawing.Point(111, 3);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(54, 21);
            this.cbInterval.TabIndex = 6;
            // 
            // tsSendMessage
            // 
            this.tsSendMessage.BackColor = System.Drawing.Color.White;
            this.tsSendMessage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSendMessage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsSendMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSendMessage,
            this.btnBrowseFile,
            this.btnReminder});
            this.tsSendMessage.Location = new System.Drawing.Point(0, 0);
            this.tsSendMessage.Name = "tsSendMessage";
            this.tsSendMessage.Size = new System.Drawing.Size(688, 27);
            this.tsSendMessage.TabIndex = 9;
            this.tsSendMessage.Text = "toolStrip1";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.Image")));
            this.btnSendMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(24, 24);
            this.btnSendMessage.Text = "ارسال متن";
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowseFile.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBrowseFile.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseFile.Image")));
            this.btnBrowseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(24, 24);
            this.btnBrowseFile.Text = "ارسال فایل";
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.CheckOnClick = true;
            this.btnReminder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnReminder.Image")));
            this.btnReminder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(24, 24);
            this.btnReminder.Text = "پیام یادآوری";
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // tiNewMessage
            // 
            this.tiNewMessage.Interval = 5000;
            this.tiNewMessage.Tick += new System.EventHandler(this.tiNewMessage_Tick);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.Multiselect = true;
            // 
            // nfiMain
            // 
            this.nfiMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nfiMain.ContextMenuStrip = this.cmsNotify;
            this.nfiMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiMain.Icon")));
            this.nfiMain.Text = "پیام رسان گروه صنایع سیمان کرمان";
            this.nfiMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfiMain_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnOpenWindow,
            this.cbtnCloseWindow});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsNotify.Size = new System.Drawing.Size(153, 70);
            // 
            // cbtnOpenWindow
            // 
            this.cbtnOpenWindow.Name = "cbtnOpenWindow";
            this.cbtnOpenWindow.Size = new System.Drawing.Size(152, 22);
            this.cbtnOpenWindow.Text = "باز کردن پنجره";
            this.cbtnOpenWindow.Click += new System.EventHandler(this.cbtnOpenWindow_Click);
            // 
            // cbtnCloseWindow
            // 
            this.cbtnCloseWindow.Name = "cbtnCloseWindow";
            this.cbtnCloseWindow.Size = new System.Drawing.Size(152, 22);
            this.cbtnCloseWindow.Text = "خروج";
            this.cbtnCloseWindow.Click += new System.EventHandler(this.cbtnCloseWindow_Click);
            // 
            // imlReadMessage
            // 
            this.imlReadMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlReadMessage.ImageStream")));
            this.imlReadMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.imlReadMessage.Images.SetKeyName(0, "Tick_32.png");
            // 
            // tiReminder
            // 
            this.tiReminder.Interval = 3600000;
            this.tiReminder.Tick += new System.EventHandler(this.tiReminder_Tick);
            // 
            // imlTypeMessage
            // 
            this.imlTypeMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTypeMessage.ImageStream")));
            this.imlTypeMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTypeMessage.Images.SetKeyName(0, "AttachmentD2-32.png");
            this.imlTypeMessage.Images.SetKeyName(1, "Balloon-yellow-32.png");
            this.imlTypeMessage.Images.SetKeyName(2, "File.png");
            this.imlTypeMessage.Images.SetKeyName(3, "Alarm-32 (2).png");
            // 
            // imlUnReadMessage
            // 
            this.imlUnReadMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlUnReadMessage.ImageStream")));
            this.imlUnReadMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.imlUnReadMessage.Images.SetKeyName(0, "white2.jpg");
            // 
            // imlStatus
            // 
            this.imlStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlStatus.ImageStream")));
            this.imlStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imlStatus.Images.SetKeyName(0, "offline_user_32.png");
            this.imlStatus.Images.SetKeyName(1, "user_32.png");
            this.imlStatus.Images.SetKeyName(2, "user_group_32.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 501);
            this.Controls.Add(this.spc1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.ssMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیام رسان گروه صنایع سیمان کرمان";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.cmsListConversation.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.spc1.Panel1.ResumeLayout(false);
            this.spc1.Panel1.PerformLayout();
            this.spc1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc1)).EndInit();
            this.spc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListConversation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.spc2.Panel1.ResumeLayout(false);
            this.spc2.Panel2.ResumeLayout(false);
            this.spc2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc2)).EndInit();
            this.spc2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversation)).EndInit();
            this.cmsConversation.ResumeLayout(false);
            this.tlpUserInfo.ResumeLayout(false);
            this.tlpUserInfo.PerformLayout();
            this.tlpReminderMessage.ResumeLayout(false);
            this.tlpReminderMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourInterval)).EndInit();
            this.tsSendMessage.ResumeLayout(false);
            this.tsSendMessage.PerformLayout();
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.SplitContainer spc1;
        private System.Windows.Forms.ToolStripStatusLabel lbUserName;
        private System.Windows.Forms.ToolStripStatusLabel lbsp1;
        private System.Windows.Forms.ToolStripStatusLabel lbName;
        private System.Windows.Forms.SplitContainer spc2;
        private System.Windows.Forms.RichTextBox rtxtNewMessage;
        private System.Windows.Forms.ToolStripButton btnUsers;
        private System.Windows.Forms.ToolStripButton btnConversation;
        private System.Windows.Forms.Label lbTypeList;
        private System.Windows.Forms.ContextMenuStrip cmsListConversation;
        private System.Windows.Forms.ToolStripMenuItem cbtnDelConversation;
        private System.Windows.Forms.ToolStripMenuItem cbtnClearHistory;
        private System.Windows.Forms.ToolStripButton btnGroupUser;
        private System.Windows.Forms.Timer tiNewMessage;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.NotifyIcon nfiMain;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem cbtnOpenWindow;
        private System.Windows.Forms.ToolStripMenuItem cbtnCloseWindow;
        private System.Windows.Forms.ToolStrip tsSendMessage;
        private System.Windows.Forms.ToolStripButton btnSendMessage;
        private System.Windows.Forms.ToolStripButton btnBrowseFile;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.DataGridView dgvListUser;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.ContextMenuStrip cmsConversation;
        private System.Windows.Forms.ToolStripMenuItem cbtnDeleteText;
        private System.Windows.Forms.ToolStripMenuItem cbtnCompleteDeleteText;
        private System.Windows.Forms.ToolStripMenuItem cbtnDownloadFile;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem cbtnOpenFile;
        private System.Windows.Forms.TableLayoutPanel tlpReminderMessage;
        private System.Windows.Forms.TextBox txtReminderText;
        private System.Windows.Forms.ToolStripButton btnReminder;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.ComboBox cbUserInterval;
        private System.Windows.Forms.NumericUpDown nudHourInterval;
        public System.Windows.Forms.ImageList imlReadMessage;
        public System.Windows.Forms.DataGridView dgvConversation;
        private System.Windows.Forms.ToolStripButton btnShowReminder;
        private System.Windows.Forms.Timer tiReminder;
        private System.Windows.Forms.Label lbReminderText;
        private BehComponents.DateTimePickerX dtpReminder;
        private System.Windows.Forms.ToolStripMenuItem cbtnForwardMes;
        private System.Windows.Forms.ToolStripMenuItem cbtnCopyText;
        private System.Windows.Forms.ImageList imlTypeMessage;
        public System.Windows.Forms.ImageList imlUnReadMessage;
        private System.Windows.Forms.DataGridView dgvListConversation;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUr;
        private System.Windows.Forms.DataGridViewImageColumn StatusUr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUr;
        public System.Windows.Forms.ImageList imlStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUserMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn TypeMessage;
        private System.Windows.Forms.DataGridViewImageColumn SeenMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextDatePar;
        private System.Windows.Forms.ToolStripButton btnFileManagement;
        private BehComponents.DateTimePickerX dtpReminderFrom;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn refUser;
        private System.Windows.Forms.DataGridViewImageColumn StatusUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolTipCon;
        private System.Windows.Forms.TableLayoutPanel tlpUserInfo;
        private System.Windows.Forms.Label lbNameParticipant;
        private System.Windows.Forms.Label lbLastSeenParticipant;
    }
}