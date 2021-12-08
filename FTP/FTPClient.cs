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
            string uri = string.Format("ftp://{0}/{1}", _serverIP, uploadPath);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.UploadFile;                  //업로드파일
            request.Credentials = new NetworkCredential(_id, _password);

            char[] fileContents;
            using (StreamReader sourceStream = new StreamReader(filePath))
            {
                fileContents = new char[(int)sourceStream.BaseStream.Length];
                sourceStream.Read(fileContents, 0, (int)sourceStream.BaseStream.Length);
            }
            request.ContentLength = fileContents.Length;

            //FTP서버에 파일전송처리
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(Encoding.Default.GetBytes(fileContents), 0, fileContents.Length);
            }
            //FTP전송결과확인
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }

        // 파일다운로드 
        public void DownLoad(string downloadPath, string saveFilePath )
        {
            string uri = string.Format("ftp://{0}/{1}", _serverIP, downloadPath);
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(_id, _password);

            //FTP서버에 파일다운로드요청
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //FTP다운받은 Stream정보 로컬시스템에 파일저장
            using (StreamWriter sw = new StreamWriter(saveFilePath))
            {
                sw.Write(responseStream);
            }
            response.Close();
            Console.WriteLine($"Download Complete, status {response.StatusDescription}");

        }

        // 파일삭제
        public void Delete()
        {
        }
        //디렉토리생성
        public void CreateDirectory(string url, string directoryName)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("user", "1234");

            // Copy the contents of the file to the request stream.
            byte[] fileContents;
            using (StreamReader sourceStream = new StreamReader("testimage.png"))
            {
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }

            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }

    }
}
