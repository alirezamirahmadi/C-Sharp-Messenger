namespace Messenger
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.tsReminder = new System.Windows.Forms.ToolStrip();
            this.btnShowAllReminder = new System.Windows.Forms.ToolStripButton();
            this.btnShowReminder = new System.Windows.Forms.ToolStripButton();
            this.tlpShowReminder = new System.Windows.Forms.TableLayoutPanel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.lbHourInterval = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.IdRemMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plReminder = new System.Windows.Forms.Panel();
            this.tlpRem = new System.Windows.Forms.TableLayoutPanel();
            this.tsReminder.SuspendLayout();
            this.tlpShowReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            this.plReminder.SuspendLayout();
            this.tlpRem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsReminder
            // 
            this.tsReminder.BackColor = System.Drawing.Color.White;
            this.tsReminder.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsReminder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowAllReminder,
            this.btnShowReminder});
            this.tsReminder.Location = new System.Drawing.Point(0, 0);
            this.tsReminder.Name = "tsReminder";
            this.tsReminder.Size = new System.Drawing.Size(530, 25);
            this.tsReminder.TabIndex = 0;
            this.tsReminder.Text = "toolStrip1";
            // 
            // btnShowAllReminder
            // 
            this.btnShowAllReminder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowAllReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllReminder.Image")));
            this.btnShowAllReminder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAllReminder.Name = "btnShowAllReminder";
            this.btnShowAllReminder.Size = new System.Drawing.Size(23, 22);
            this.btnShowAllReminder.Text = "toolStripButton1";
            this.btnShowAllReminder.Click += new System.EventHandler(this.btnShowAllReminder_Click);
            // 
            // btnShowReminder
            // 
            this.btnShowReminder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnShowReminder.Image")));
            this.btnShowReminder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowReminder.Name = "btnShowReminder";
            this.btnShowReminder.Size = new System.Drawing.Size(23, 22);
            this.btnShowReminder.Text = "toolStripButton2";
            this.btnShowReminder.Click += new System.EventHandler(this.btnShowReminder_Click);
            // 
            // tlpShowReminder
            // 
            this.tlpShowReminder.AutoSize = true;
            this.tlpShowReminder.BackColor = System.Drawing.Color.White;
            this.tlpShowReminder.ColumnCount = 1;
            this.tlpShowReminder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 451F));
            this.tlpShowReminder.Controls.Add(this.lbDate, 0, 0);
            this.tlpShowReminder.Controls.Add(this.lbTitle, 0, 1);
            this.tlpShowReminder.Controls.Add(this.lbText, 0, 2);
            this.tlpShowReminder.Controls.Add(this.lbHourInterval, 0, 3);
            this.tlpShowReminder.Location = new System.Drawing.Point(13, 3);
            this.tlpShowReminder.Name = "tlpShowReminder";
            this.tlpShowReminder.RowCount = 4;
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowReminder.Size = new System.Drawing.Size(434, 96);
            this.tlpShowReminder.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbDate.Location = new System.Drawing.Point(171, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(75, 29);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "label1";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTitle.Location = new System.Drawing.Point(171, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(75, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "label3";
            // 
            // lbText
            // 
            this.lbText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbText.Location = new System.Drawing.Point(188, 60);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(42, 16);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "label1";
            // 
            // lbHourInterval
            // 
            this.lbHourInterval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHourInterval.AutoSize = true;
            this.lbHourInterval.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbHourInterval.Location = new System.Drawing.Point(190, 76);
            this.lbHourInterval.Name = "lbHourInterval";
            this.lbHourInterval.Size = new System.Drawing.Size(38, 14);
            this.lbHourInterval.TabIndex = 4;
            this.lbHourInterval.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(453, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 96);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvReminder
            // 
            this.dgvReminder.AllowDrop = true;
            this.dgvReminder.AllowUserToAddRows = false;
            this.dgvReminder.AllowUserToDeleteRows = false;
            this.dgvReminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReminder.BackgroundColor = System.Drawing.Color.White;
            this.dgvReminder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRemMes,
            this.IdMes,
            this.Sender,
            this.CreateDate,
            this.RemText,
            this.RemDate,
            this.Receiver,
            this.TextMessage,
            this.HourInterval});
            this.dgvReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReminder.GridColor = System.Drawing.Color.White;
            this.dgvReminder.Location = new System.Drawing.Point(0, 102);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.ReadOnly = true;
            this.dgvReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReminder.RowHeadersVisible = false;
            this.dgvReminder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReminder.Size = new System.Drawing.Size(530, 270);
            this.dgvReminder.TabIndex = 1;
            this.dgvReminder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminder_CellClick);
            // 
            // IdRemMes
            // 
            this.IdRemMes.HeaderText = "IdRemMes";
            this.IdRemMes.Name = "IdRemMes";
            this.IdRemMes.ReadOnly = true;
            this.IdRemMes.Visible = false;
            // 
            // IdMes
            // 
            this.IdMes.HeaderText = "IdMes";
            this.IdMes.Name = "IdMes";
            this.IdMes.ReadOnly = true;
            this.IdMes.Visible = false;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "ارسال کننده";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "تاریخ ارسال";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // RemText
            // 
            this.RemText.HeaderText = "عنوان";
            this.RemText.Name = "RemText";
            this.RemText.ReadOnly = true;
            // 
            // RemDate
            // 
            this.RemDate.HeaderText = "تاریخ یادآوری";
            this.RemDate.Name = "RemDate";
            this.RemDate.ReadOnly = true;
            // 
            // Receiver
            // 
            this.Receiver.HeaderText = "گیرنده";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            // 
            // TextMessage
            // 
            this.TextMessage.HeaderText = "TextMessage";
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.ReadOnly = true;
            this.TextMessage.Visible = false;
            // 
            // HourInterval
            // 
            this.HourInterval.HeaderText = "HourInterval";
            this.HourInterval.Name = "HourInterval";
            this.HourInterval.ReadOnly = true;
            this.HourInterval.Visible = false;
            // 
            // plReminder
            // 
            this.plReminder.BackColor = System.Drawing.Color.White;
            this.plReminder.Controls.Add(this.dgvReminder);
            this.plReminder.Controls.Add(this.tlpRem);
            this.plReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plReminder.Font = new System.Drawing.Font("Tahoma", 9F);
            this.plReminder.Location = new System.Drawing.Point(0, 25);
            this.plReminder.Name = "plReminder";
            this.plReminder.Size = new System.Drawing.Size(530, 372);
            this.plReminder.TabIndex = 2;
            // 
            // tlpRem
            // 
            this.tlpRem.AutoSize = true;
            this.tlpRem.ColumnCount = 3;
            this.tlpRem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpRem.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpRem.Controls.Add(this.tlpShowReminder, 1, 0);
            this.tlpRem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpRem.Location = new System.Drawing.Point(0, 0);
            this.tlpRem.Name = "tlpRem";
            this.tlpRem.RowCount = 1;
            this.tlpRem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRem.Size = new System.Drawing.Size(530, 102);
            this.tlpRem.TabIndex = 2;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 397);
            this.Controls.Add(this.plReminder);
            this.Controls.Add(this.tsReminder);
            this.Name = "Reminder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "یادآوری";
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.tsReminder.ResumeLayout(false);
            this.tsReminder.PerformLayout();
            this.tlpShowReminder.ResumeLayout(false);
            this.tlpShowReminder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            this.plReminder.ResumeLayout(false);
            this.plReminder.PerformLayout();
            this.tlpRem.ResumeLayout(false);
            this.tlpRem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsReminder;
        public System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.TableLayoutPanel tlpShowReminder;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnShowAllReminder;
        private System.Windows.Forms.ToolStripButton btnShowReminder;
        private System.Windows.Forms.Panel plReminder;
        private System.Windows.Forms.TableLayoutPanel tlpRem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRemMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourInterval;
        private System.Windows.Forms.Label lbHourInterval;
    }
}