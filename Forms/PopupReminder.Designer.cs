namespace Messenger
{
    partial class PopupReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupReminder));
            this.pbPopReminder = new System.Windows.Forms.PictureBox();
            this.tlpShowReminder = new System.Windows.Forms.TableLayoutPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbRemDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPopReminder)).BeginInit();
            this.tlpShowReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPopReminder
            // 
            this.pbPopReminder.BackColor = System.Drawing.Color.White;
            this.pbPopReminder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPopReminder.BackgroundImage")));
            this.pbPopReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPopReminder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbPopReminder.Location = new System.Drawing.Point(220, 0);
            this.pbPopReminder.Name = "pbPopReminder";
            this.pbPopReminder.Size = new System.Drawing.Size(74, 105);
            this.pbPopReminder.TabIndex = 1;
            this.pbPopReminder.TabStop = false;
            // 
            // tlpShowReminder
            // 
            this.tlpShowReminder.AutoSize = true;
            this.tlpShowReminder.BackColor = System.Drawing.Color.White;
            this.tlpShowReminder.ColumnCount = 1;
            this.tlpShowReminder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowReminder.Controls.Add(this.lbName, 0, 0);
            this.tlpShowReminder.Controls.Add(this.lbTitle, 0, 3);
            this.tlpShowReminder.Controls.Add(this.lbCreateDate, 0, 1);
            this.tlpShowReminder.Controls.Add(this.lbRemDate, 0, 2);
            this.tlpShowReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShowReminder.Location = new System.Drawing.Point(0, 0);
            this.tlpShowReminder.Name = "tlpShowReminder";
            this.tlpShowReminder.RowCount = 4;
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowReminder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowReminder.Size = new System.Drawing.Size(220, 105);
            this.tlpShowReminder.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(81, 1);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 23);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "label1";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(89, 65);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(42, 16);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "label3";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbCreateDate.Location = new System.Drawing.Point(89, 27);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(42, 16);
            this.lbCreateDate.TabIndex = 5;
            this.lbCreateDate.Text = "label1";
            // 
            // lbRemDate
            // 
            this.lbRemDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRemDate.AutoSize = true;
            this.lbRemDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemDate.ForeColor = System.Drawing.Color.Black;
            this.lbRemDate.Location = new System.Drawing.Point(89, 47);
            this.lbRemDate.Name = "lbRemDate";
            this.lbRemDate.Size = new System.Drawing.Size(42, 16);
            this.lbRemDate.TabIndex = 0;
            this.lbRemDate.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(273, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PopupReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(294, 105);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tlpShowReminder);
            this.Controls.Add(this.pbPopReminder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupReminder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PopupReminder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PopupReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPopReminder)).EndInit();
            this.tlpShowReminder.ResumeLayout(false);
            this.tlpShowReminder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPopReminder;
        private System.Windows.Forms.TableLayoutPanel tlpShowReminder;
        private System.Windows.Forms.Label lbRemDate;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.PictureBox btnClose;
    }
}