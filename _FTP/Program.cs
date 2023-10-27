


using System.Net.NetworkInformation;
using System.Net;


class Program
{

    static void Main()
    {
        string path = Path.Combine(@"C:\Users\caya\Desktop", "files.rc");

        // 确保路径以分隔符结尾
        FtpUpload(path);
    }



    static void FtpUpload(string path)
    {
        //string ipAddress = "10.32.25.19";
        string ipAddress = "10.32.25.95";
        var ping = new Ping();
        var res = ping.Send(ipAddress, 500);
        if (res.Status != IPStatus.Success)
        {
            Console.WriteLine("Ping不通");
            return;
        }
        string filename = Path.GetFileName(path);
        //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ipAddress + "/13.FTP/caya/temp/new/" + filename);
        //request.Credentials = new NetworkCredential("syntronic_NJ", "123456");
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ipAddress + "/test/" + filename);
        request.Credentials = new NetworkCredential("test", "123456");
        request.Method = WebRequestMethods.Ftp.UploadFile;

        using (Stream fileStream = File.OpenRead(path))
        using (Stream ftpStream = request.GetRequestStream())
        {
            fileStream.CopyTo(ftpStream);
        }
        Console.WriteLine("成功");
    }
}