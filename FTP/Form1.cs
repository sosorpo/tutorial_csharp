using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class Form1 : Form
    {
        string _ftpID = "user";
        string _ftpPassword = "1234";
        string _ftpServer = "127.0.0.1";

        string _uploadFilePath = "testimage.png";
        string _downloadFilePath = "testimage_download.png";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            FTPClient ftpClient = new FTPClient(_ftpServer,_ftpID,_ftpPassword);
            ftpClient.UpLoad(_uploadFilePath, _uploadFilePath);
            picUpLoad.Load(string.Format(@"{0}",_uploadFilePath));
            picUpLoad.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            FTPClient ftpClient = new FTPClient(_ftpServer, _ftpID, _ftpPassword);
            ftpClient.DownLoad(_uploadFilePath, _downloadFilePath);
            picDownLoad.Load(string.Format(@"{0}", _uploadFilePath));
            picDownLoad.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
