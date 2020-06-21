using System;
using System.Configuration;
using System.IO;
using log4net;
using log4net.Config;

namespace EncodeFile
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            log.Info("Info message");

            string filename;

            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter valid path.");
                filename = ConfigurationManager.AppSettings["filePath"];
                //return;
            }
            else {
                filename = args[0];
            }
            
                       
            Byte[] bytes = File.ReadAllBytes(filename);
            String outputFile = Convert.ToBase64String(bytes);

            System.Console.WriteLine(outputFile);


        }
    }
}
