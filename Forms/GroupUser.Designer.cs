namespace Messenger
{
    partial class GroupUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupUser));
            this.sp1 = new System.Windows.Forms.SplitContainer();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.sp2 = new System.Windows.Forms.SplitContainer();
            this.lvGroup = new System.Windows.Forms.ListView();
            this.lbGroups = new System.Windows.Forms.Label();
            this.lvUserGroup = new System.Windows.Forms.ListView();
            this.lbUserGroup = new System.Windows.Forms.Label();
            this.tsGroupUser = new System.Windows.Forms.ToolStrip();
            this.btnNewGroup = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddToGroup = new System.Windows.Forms.ToolStripButton();
            this.btnDelFromGroup = new System.Windows.Forms.ToolStripButton();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).BeginInit();
            this.sp1.Panel1.SuspendLayout();
            this.sp1.Panel2.SuspendLayout();
            this.sp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
            this.sp2.Panel1.SuspendLayout();
            this.sp2.Panel2.SuspendLayout();
            this.sp2.SuspendLayout();
            this.tsGroupUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp1
            // 
            this.sp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp1.Location = new System.Drawing.Point(0, 45);
            this.sp1.Name = "sp1";
            // 
            // sp1.Panel1
            // 
            this.sp1.Panel1.Controls.Add(this.lvUsers);
            this.sp1.Panel1.Controls.Add(this.txtSearchUser);
            this.sp1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // sp1.Panel2
            // 
            this.sp1.Panel2.Controls.Add(this.sp2);
            this.sp1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sp1.Size = new System.Drawing.Size(572, 354);
            this.sp1.SplitterDistance = 144;
            this.sp1.TabIndex = 0;
            // 
            // lvUsers
            // 
            this.lvUsers.CheckBoxes = true;
            this.lvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lvUsers.Location = new System.Drawing.Point(0, 20);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.RightToLeftLayout = true;
            this.lvUsers.Size = new System.Drawing.Size(144, 334);
            this.lvUsers.TabIndex = 3;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.List;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BackColor = System.Drawing.Color.LightYellow;
            this.txtSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchUser.Location = new System.Drawing.Point(0, 0);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(144, 20);
            this.txtSearchUser.TabIndex = 4;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // sp2
            // 
            this.sp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp2.Location = new System.Drawing.Point(0, 0);
            this.sp2.Name = "sp2";
            this.sp2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp2.Panel1
            // 
            this.sp2.Panel1.Controls.Add(this.lvGroup);
            this.sp2.Panel1.Controls.Add(this.lbGroups);
            this.sp2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // sp2.Panel2
            // 
            this.sp2.Panel2.Controls.Add(this.lvUserGroup);
            this.sp2.Panel2.Controls.Add(this.lbUserGroup);
            this.sp2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sp2.Size = new System.Drawing.Size(424, 354);
            this.sp2.SplitterDistance = 207;
            this.sp2.TabIndex = 0;
            // 
            // lvGroup
            // 
            this.lvGroup.CheckBoxes = true;
            this.lvGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lvGroup.LabelEdit = true;
            this.lvGroup.Location = new System.Drawing.Point(0, 13);
            this.lvGroup.MultiSelect = false;
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.RightToLeftLayout = true;
            this.lvGroup.Size = new System.Drawing.Size(424, 194);
            this.lvGroup.TabIndex = 2;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            this.lvGroup.View = System.Windows.Forms.View.List;
            this.lvGroup.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvGroup_AfterLabelEdit);
            this.lvGroup.SelectedIndexChanged += new System.EventHandler(this.lvGroup_SelectedIndexChanged);
            // 
            // lbGroups
            // 
            this.lbGroups.BackColor = System.Drawing.Color.White;
            this.lbGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbGroups.Location = new System.Drawing.Point(0, 0);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(424, 13);
            this.lbGroups.TabIndex = 3;
            this.lbGroups.Text = "لیست گروه ها";
            // 
            // lvUserGroup
            // 
            this.lvUserGroup.CheckBoxes = true;
            this.lvUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUserGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lvUserGroup.Location = new System.Drawing.Point(0, 13);
            this.lvUserGroup.Name = "lvUserGroup";
            this.lvUserGroup.RightToLeftLayout = true;
            this.lvUserGroup.Size = new System.Drawing.Size(424, 130);
            this.lvUserGroup.TabIndex = 2;
            this.lvUserGroup.UseCompatibleStateImageBehavior = false;
            this.lvUserGroup.View = System.Windows.Forms.View.List;
            // 
            // lbUserGroup
            // 
            this.lbUserGroup.BackColor = System.Drawing.Color.White;
            this.lbUserGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUserGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserGroup.Location = new System.Drawing.Point(0, 0);
            this.lbUserGroup.Name = "lbUserGroup";
            this.lbUserGroup.Size = new System.Drawing.Size(424, 13);
            this.lbUserGroup.TabIndex = 4;
            this.lbUserGroup.Text = "کاربران گروه";
            // 
            // tsGroupUser
            // 
            this.tsGroupUser.BackColor = System.Drawing.Color.White;
            this.tsGroupUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsGroupUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGroupUser.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsGroupUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewGroup,
            this.btnDeleteGroup,
            this.toolStripSeparator1,
            this.btnAddToGroup,
            this.btnDelFromGroup});
            this.tsGroupUser.Location = new System.Drawing.Point(0, 0);
            this.tsGroupUser.Name = "tsGroupUser";
            this.tsGroupUser.Size = new System.Drawing.Size(572, 45);
            this.tsGroupUser.TabIndex = 1;
            this.tsGroupUser.Text = "toolStrip1";
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGroup.Image")));
            this.btnNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(56, 42);
            this.btnNewGroup.Text = "گروه جدید";
            this.btnNewGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteGroup.Image")));
            this.btnDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(57, 42);
            this.btnDeleteGroup.Text = "حذف گروه";
            this.btnDeleteGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToGroup.Image")));
            this.btnAddToGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(72, 42);
            this.btnAddToGroup.Text = "اضافه به گروه";
            this.btnAddToGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // btnDelFromGroup
            // 
            this.btnDelFromGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFromGroup.Image")));
            this.btnDelFromGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelFromGroup.Name = "btnDelFromGroup";
            this.btnDelFromGroup.Size = new System.Drawing.Size(67, 42);
            this.btnDelFromGroup.Text = "حذف از گروه";
            this.btnDelFromGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelFromGroup.Click += new System.EventHandler(this.btnDelFromGroup_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.Multiselect = true;
            // 
            // GroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 399);
            this.Controls.Add(this.sp1);
            this.Controls.Add(this.tsGroupUser);
            this.Name = "GroupUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گروه کاربران";
            this.Load += new System.EventHandler(this.GroupUser_Load);
            this.sp1.Panel1.ResumeLayout(false);
            this.sp1.Panel1.PerformLayout();
            this.sp1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).EndInit();
            this.sp1.ResumeLayout(false);
            this.sp2.Panel1.ResumeLayout(false);
            this.sp2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
            this.sp2.ResumeLayout(false);
            this.tsGroupUser.ResumeLayout(false);
            this.tsGroupUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer sp1;
        private System.Windows.Forms.SplitContainer sp2;
        private System.Windows.Forms.ToolStrip tsGroupUser;
        private System.Windows.Forms.ListView lvGroup;
        private System.Windows.Forms.ListView lvUserGroup;
        private System.Windows.Forms.ToolStripButton btnNewGroup;
        private System.Windows.Forms.ToolStripButton btnDeleteGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddToGroup;
        private System.Windows.Forms.ToolStripButton btnDelFromGroup;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lbGroups;
        private System.Windows.Forms.Label lbUserGroup;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
    }
}