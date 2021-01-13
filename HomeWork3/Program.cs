using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace File
{
    class Program
    { 
        static void Main(string[] args)
        {
            string pathDirectory = @"D:\Program Files";
            string pathDesktop = @"C:\Users\dimka\OneDrive\Desktop\Ruban.txt";
            string pathCompressed = @"C:\Users\dimka\OneDrive\Desktop\Ruban.gz";
          
            List<string> list = new List<string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(pathDirectory);
            FileInfo fileInfo = new FileInfo(pathDesktop);
            if (directoryInfo.Exists)
            {
                foreach (var dir in directoryInfo.GetDirectories("*.*", SearchOption.AllDirectories))
                {
                }
                foreach (var file in directoryInfo.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    if (DateTime.Now.Subtract(file.CreationTime).TotalDays <= 14)
                    {
                        list.Add(file.FullName);
                    }

                }
            }
            using (fileInfo.Create()) { }

            using (StreamWriter streamWriter = new StreamWriter(pathDesktop, true, Encoding.Default))
            {
                list.ForEach(streamWriter.WriteLine);
            }

            Compress(pathDesktop, pathCompressed);

            fileInfo.Delete();
        }

        static void Compress(string source, string compressed)
        {
            FileInfo fileInfo = new FileInfo(compressed);
            using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream dfs = fileInfo.Create())
                {
                    using (GZipStream gzs = new GZipStream(dfs, CompressionMode.Compress))
                    {
                        fs.CopyTo(gzs);
                    }
                }
            }
        }

        static void Decompress(string compressed, string destination)
        {
            FileInfo fileInfo = new FileInfo(destination);
            using (FileStream fs = new FileStream(compressed, FileMode.Open))
            {
                using (FileStream dfs = fileInfo.Create())
                {
                    using (GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress))
                    {
                        gzs.CopyTo(dfs);
                    }
                }
            }
        }
    }
}