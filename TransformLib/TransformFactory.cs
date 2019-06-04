using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Xml;


namespace TransformLib
{
    public static class TransformFactory
    {

        /// <summary>
        /// GetParse
        /// according the file type ,create one parse object
        /// </summary>
        /// <returns>ParseFormatBasic</returns>
        public static ParseFormatBasic GetParse(string inputFileType)
        {
            string assemblePath, assembleName;
            
            getAssembleInfo(inputFileType,out assemblePath, out assembleName);

            //if can not find the parse, used the stand parse object
            if (string.IsNullOrEmpty(assemblePath) || string.IsNullOrEmpty(assembleName))
            {
                return new StandParse();
            }

            Assembly assembly = Assembly.LoadFrom(assemblePath);
            Type type = assembly.GetType(assembleName);
            
            ParseFormatBasic pfb = Activator.CreateInstance(type) as ParseFormatBasic;

            return pfb;


        }


        /// <summary>
        /// getAssembleInfo 
        /// according the file type ,get the class name and assemble path from the config
        /// </summary>
        /// <param name="formatName"></param>
        /// <param name="classPath"></param>
        /// <param name="className"></param>

        public static void getAssembleInfo(string formatName,out string  classPath,out string  className)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("transConfig.xml");    // load config xml  
            XmlElement rootElem = doc.DocumentElement;   //get root   
            XmlNodeList nodes = rootElem.GetElementsByTagName("format"); // get parse config node
            foreach (XmlNode node in nodes)
            {
                string strName = ((XmlElement)node).GetAttribute("type");   // 
                if (strName == formatName)
                {
                    classPath= ((XmlElement)node).GetAttribute("ClassPath");
                    className= ((XmlElement)node).GetAttribute("ParseClass");
                    return;
                }
                
            }
            classPath = string.Empty;
            className = string.Empty;
        }

        public static void getFieldProcessInfo(string formatName, string columName, out string destColumName, out int index, out bool isNeedProcess)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("transConfig.xml");    // load config xml  
            XmlElement rootElem = doc.DocumentElement;   //get root   
            XmlNodeList nodes = rootElem.GetElementsByTagName("format"); // get parse config node
            foreach (XmlNode node in nodes)
            {
                string strName = ((XmlElement)node).GetAttribute("type");   // 
                if (strName == formatName)
                {
                    XmlNodeList fields = ((XmlElement)node).GetElementsByTagName("field");
                    foreach (XmlNode fieldNode in fields)
                    {
                        if (((XmlElement)fieldNode).GetAttribute("sourceName") == columName)
                        {
                            destColumName = ((XmlElement)fieldNode).GetAttribute("sourceName");
                            isNeedProcess = Boolean.Parse(((XmlElement)fieldNode).GetAttribute("isNeedProcess"));
                            index = int.Parse(((XmlElement)fieldNode).GetAttribute("index"));
                            return;
                        }
                    }

                 
                }

            }
            destColumName = columName;
            isNeedProcess = false;
            index = 0;

        }


    }
}
