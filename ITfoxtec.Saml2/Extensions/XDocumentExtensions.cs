﻿using System.Xml;
using System.Xml.Linq;

namespace ITfoxtec.Saml2
{
    /// <summary>
    /// Extension methods for XDocument
    /// </summary>
    internal static class XDocumentExtensions
    {
        /// <summary>
        /// Converts an XDocument to an XmlDocument.
        /// </summary>
        internal static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = true;
            using (var reader = xDocument.CreateReader())
            {
                xmlDocument.Load(reader);
            }
            return xmlDocument;
        }

    }
}
