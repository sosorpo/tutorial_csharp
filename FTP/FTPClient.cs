using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;       //FtpWebRequest
using System.IO;

// ref :  https://docs.microsoft.com/ko-kr/dotnet/framework/network-programming/how-to-upload-files-with-ftp

namespace FTP
{
    class FTPClient
    {
        private string _serverIP;
        private string _id;
        private string _password;

        public FTPClient(string serverIP, string id, string password)
        {
            _serverIP = serverIP;
            _id = id;
            _password = password;
        }

        // 파일업로드 
        public void UpLoad(string filePath, string uploadPath)
        {
            //FTP다운로드관련 URL, Method설정(UploadFile)
            string uri = string.Format("ftp://{0}/{1}", _serverIP, uploadPath);
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.UploadFile;                      
            request.Credentials = new NetworkCredential(_id, _password);

            //파일정보를 Byte로열기
            byte[] fileContents = null;
            using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                long dataLength = br.BaseStream.Length;
                fileContents = new byte[br.BaseStream.Length];
                fileContents = br.ReadBytes((int) br.BaseStream.Length);
            }

            //FTP서버에 파일전송처리
            request.ContentLength = fileContents.LongLength;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            //FTP전송결과확인
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }

        // 파일다운로드 
        public void DownLoad(string downloadPath, string saveFilePath)
        {
            //FTP다운로드관련 URL, Method설정(DownloadFile)
            string uri = string.Format("ftp://{0}/{1}", _serverIP, downloadPath);
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(_id, _password);

            //FTP서버에 파일다운로드요청
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            ////FTP다운받은 Stream정보 로컬시스템에 파일저장
            //byte[] fileContents = new byte[responseStream.Length];
            //int fileContentsLength = responseStream.Read(fileContents,0,(int)responseStream.Length);

            //Stream stream = new FileStream(saveFilePath, FileMode.OpenOrCreate);
            //using (BinaryWriter bw = new BinaryWriter(responseStream))
            //{
            //    bw.Write(fileContents);
            //}
            Console.WriteLine($"Download Complete, status {response.StatusDescription}");

        }

        private void SaveFileBinaryData(byte[] buffer, string saveFilePath)
        {
        }


        public void DownLoadAsync()
        {
        }

        // 파일삭제
        public void Delete()
        {
        }


    }
}
