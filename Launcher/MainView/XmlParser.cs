using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;
using System.Xml;
//*
namespace Launcher.MainView
{
    class XmlParser
    {
        static WebClient _wc = new WebClient();
        static XDocument doc = new XDocument();
        public static bool isFileExist(string pathFile)
        {
            string path = System.IO.Path.GetFullPath("./");
            bool isPathExist = System.IO.File.Exists(path + pathFile);
            return isPathExist;
        }
        public static void LoadXML()
        {
            try
            {
            //   string path = System.IO.Path.GetFullPath("./");
            //   string xml = _wc.DownloadString(NetworkThing.Info.getXmlFileFromUrl());
            //   if (isFileExist("version.xml") == true)
            //   {
            //       File.Delete(path + "version.xml");
            //   }
            //   File.Create(path + "version.xml").Close();
            //   File.WriteAllText(path + "version.xml", xml);
            //   doc = XDocument.Load("version.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static string getLauncherVersion()
        {
            var version = doc.Root.Element("WoALauncher").Value;
            return version;
        }






        // Added portion to read xml

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Location of the file");

            // get the location we want to get the sitemaps from 
            string dirLoc = Console.ReadLine();

            // get all the sitemaps 
            string[] sitemaps = Directory.GetFiles(dirLoc);
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"G:\OneDrive\UE4\builds\Build Notes.xml", true);

            // loop through each file 
            foreach (string sitemap in sitemaps)
            {
                try
                {
                    // new xdoc instance 
                    XmlDocument xDoc = new XmlDocument();

                    //load up the xml from the location 
                    xDoc.Load(sitemap);

                    // cycle through each child noed 
                    foreach (XmlNode node in xDoc.DocumentElement.ChildNodes)
                    {
                        // first node is the url ... have to go to nexted loc node 
                        foreach (XmlNode locNode in node)
                        {
                            // thereare a couple child nodes here so only take data from node named loc 
                            if (locNode.Name == "loc")
                            {
                                // get the content of the loc node 
                                string loc = locNode.InnerText;

                                // write it to the console so you can see its working 
                                Console.WriteLine(loc + Environment.NewLine);

                                string valueString = "XML Loaded";
                                Console.WriteLine(valueString);

                                // write it to the file 
                                sw.Write(loc + Environment.NewLine);
                            }
                        }
                    }
                }
                catch { }
            }
            Console.WriteLine("All Done :-)");
            Console.ReadLine();
        }

        static void readSitemap()
        {
        }









    }
}
