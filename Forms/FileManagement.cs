using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Messenger
{
    public partial class FileManagement : Form
    {
        private long TotalSize;

        public FileManagement()
        {
            InitializeComponent();
        }

        private void FileManagment_Load(object sender, EventArgs e)
        {
            load_Files();
        }

        private void load_Files()
        {
            dgvFiles.Rows.Clear();
            DataBase.searchMsgMyFile(Main.idUser);
            DataTable table = DataBase.dataTable;
            foreach (DataRow drow in table.Rows)
            {
                dgvFiles.Rows.Add(drow["IdFile"].ToString(), drow["IdMessage"].ToString(), drow["refUser"].ToString(), imlEmpty.Images[0], imlEmpty.Images[0], AesCryp.decode(drow["TextMessage"].ToString()), fileSize((byte[])drow["FileSource"]), Time.convertMiladiToShamsiOnlyDate(Convert.ToDateTime(drow["CreateDate"].ToString())), drow["Receiver"].ToString());
                effectMessages(dgvFiles.Rows.Count - 1);
            }
            lbTotalSize.Text = convertSize(TotalSize);
        }

        public void effectMessages(int rowNo)
        {
            try
            {
                DataGridViewRow grow = dgvFiles.Rows[rowNo];

                if (DataBase.findMsgDownloadedFile(grow.Cells["refUser"].Value.ToString(), grow.Cells["IdMes"].Value.ToString()))
                {
                    grow.Cells["DownloadMes"].Value = imlFiles.Images[1];
                }

                if (DataBase.findMsgReadMessage(grow.Cells["refUser"].Value.ToString(), grow.Cells["IdMes"].Value.ToString()))
                {
                    grow.Cells["SeenMessage"].Value = imlFiles.Images[0];
                }
            }
            catch { }
        }

        private string fileSize(byte[] file)
        {
            TotalSize += file.Length;
            return convertSize(file.Length);
        }

        private string convertSize(long size)
        {
            if (size < 1024)
            {
                return size.ToString() + "B";
            }
            else if (size < 1024 * 1024)
            {
                return (size / 1024).ToString() + "KB";
            }
            else if (size < 1024 * 1024 * 1024)
            {
                return (size / (1024 * 1024)).ToString() + "MB";
            }
            return (size / (1024 * 1024 * 1024)).ToString() + "GB";
        }

        private void openFile()
        {
            try
            {
                string fileName = dgvFiles.SelectedRows[0].Cells["FileName"].Value.ToString();
                if (Message.downloadFile(Path.GetTempPath() + @"\" + fileName, dgvFiles.SelectedRows[0].Cells["IdMes"].Value.ToString(), "2"))
                {
                    Process.Start(Path.GetTempPath() + @"\" + fileName);
                }
            }
            catch (Exception me)
            {
                //MessageBox.Show(me.Message);
            }
        }

        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openFile();
        }

        private void cbtnDeleteFile_Click(object sender, EventArgs e)
        {
            string id = "";
            DialogResult result = MessageBox.Show("آیا مایل به حذف این فایل هستید؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow grow in dgvFiles.SelectedRows)
                {
                    id = grow.Cells["IdMes"].Value.ToString();
                    DataBase.searchMsgFileWithoutFile("refMessage", id);
                    DataTable table = DataBase.dataTable;
                    if (table.Rows.Count == 1)
                    {
                        DataBase.DeleteFromMsgFile(table.Rows[0]["IdFile"].ToString(), id);
                        dgvFiles.Rows.Remove(grow);
                        lbTotalSize.Text = convertSize(Message.sizeAllFiles(Main.idUser));
                    }
                }
            }
        }

        private void cbtnDownloadFile_Click(object sender, EventArgs e)
        {
            sfdSaveFile.FileName = dgvFiles.SelectedRows[0].Cells["FileName"].Value.ToString();
            sfdSaveFile.ShowDialog();
            Message.downloadFile(sfdSaveFile.FileName, dgvFiles.SelectedRows[0].Cells["IdMes"].Value.ToString(), "2");
        }

        private void cbtnOpenFile_Click(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
