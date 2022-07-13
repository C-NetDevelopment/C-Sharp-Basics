using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question2Event
{
    delegate void DownloadCompeteHandler(int perc);
    class FileDownloader
    {
        protected string resourceUrl;
        protected string resourceSavePath;
        
        public FileDownloader(string url, string savepath)
        {
            this.resourceUrl = url;
            this.resourceSavePath = savepath;
        }

        public event DownloadCompeteHandler DownLoadComplete;
        public void DownLoadResource()
        {
            for (int i = 1; i <= 4; i++)
            {
                //Dummy loop to add a delay
                for (int j = 1; i <= 10000; i++) ;
                DownLoadComplete(i * 25);
            }

        }
        public  void OnDownLoadComplete()
        {
            if (DownLoadComplete == null)
            {
                Console.WriteLine("Not downloaded");
            }
            else
            {
                Console.WriteLine("downloaded");
            }
            Console.ReadLine();  
        }

    }
}
