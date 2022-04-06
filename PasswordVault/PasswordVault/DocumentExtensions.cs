using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace PasswordVault
{
    // Using var blocks will call dispose on exit making cleanup easier
    public static class DocumentExtensions
    {
        public static XmlDocument ToXmlDocument(XDocument xDoc)
        {
            XmlDocument xmlDoc = new XmlDocument();
            using (var xmlReader = xDoc.CreateReader())
            {
                xmlDoc.Load(xmlReader);
            }
            return xmlDoc;
        }

        public static XDocument ToXDocument(XmlDocument xmlDoc)
        {
            using (var nodeReader = new XmlNodeReader(xmlDoc))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }
    }
}
