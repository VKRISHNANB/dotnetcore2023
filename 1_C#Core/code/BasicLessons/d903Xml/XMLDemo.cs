using System;
using System.Xml;
using System.IO;
namespace BasicLessons.d93Xml
{
    class XMLDemo
    {
        //XmlWriter
        public static  void CreateXMLfileUsingXmlWriter()
        {
            String fName = "c:\\temp\\";// emp.xml";
            #region A
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            Console.WriteLine("Enter Start Element");
            String startElementName = Console.ReadLine();
            fName += startElementName + ".xml";
            using (XmlWriter writer = XmlWriter.Create(fName, settings))
            {
                writer.WriteStartElement(startElementName);
                Console.WriteLine("Enter Value for ID Element");
                String id = Console.ReadLine();
                writer.WriteElementString("id", id);
                Console.WriteLine("Enter Value for FName Element");
                String fname = Console.ReadLine();
                writer.WriteElementString("FName", fname);
                Console.WriteLine("Enter Value for MName Element");
                String mname = Console.ReadLine();
                writer.WriteElementString("MName", mname);
                Console.WriteLine("Enter Value for lName Element");
                String lname = Console.ReadLine();
                writer.WriteElementString("LName", lname);
                Console.WriteLine("Enter Value for Salary Element");
                String salary = Console.ReadLine();
                writer.WriteElementString("Salary", salary);
                writer.WriteEndElement();
                writer.Flush();
            }
            Console.WriteLine("Completed");
            #endregion
        }
        //XmlDocument
        public static void CreateXMLFileUsingXmlDocument()
        {
            #region B
            XmlDocument xmldoc = new XmlDocument();
            String path = "c:\\temp\\BookCatalog.xml";
            //xmldoc.Load(path); 
            // New XML Element Created
            XmlElement newcatalogentry = xmldoc.CreateElement("Book");
            // New Attribute Created
            XmlAttribute newcatalogattr = xmldoc.CreateAttribute("ID");
            // Value given for the new attribute
            newcatalogattr.Value = "005";
            // Attach the attribute to the XML element
            newcatalogentry.SetAttributeNode(newcatalogattr);
            // First Element - Book - Created
            XmlElement firstelement = xmldoc.CreateElement("Author");
            // Value given for the first element
            firstelement.InnerText = "Peter";
            // Append the newly created element as a child element
            newcatalogentry.AppendChild(firstelement);
            // Second Element - Publisher - Created
            XmlElement secondelement = xmldoc.CreateElement("Publisher");
            // Value given for the second element
            secondelement.InnerText = "Que Publishing";
            // Append the newly created element as a child element
            newcatalogentry.AppendChild(secondelement);
            // New XML element inserted into the document
            xmldoc.AppendChild(newcatalogentry);
            //xmldoc.DocumentElement.InsertAfter(newcatalogentry,xmldoc.DocumentElement.LastChild);

            // An instance of FileStream class created
            // The first parameter is the path to the XML file 
            FileStream fsxml = new FileStream(path, FileMode.CreateNew,FileAccess.Write, FileShare.ReadWrite);
            xmldoc.Save(fsxml);// XML Document Saved
            Console.WriteLine(path + "Created");
            #endregion
        }
        //XmlTextReader
        public static void UsingXmlTextReader()
        {
            String fName = "c:\\temp\\emp.xml";
            Stream stream = null;
            XmlTextReader tr = null;
            try
            {
                stream = File.Open(fName, FileMode.Open);
                tr = new XmlTextReader(stream);
                while (tr.Read())
                {
                    Console.WriteLine(tr.Name + " " + tr.Value);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                tr.Close();
                stream.Close();
            }
        }

        //XMLDocument
        public static void ReadXMLusingXMLDocument()
        {
            String fName = "c:\\temp\\emp.xml";
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(fName);
                Console.WriteLine("DOC HasChildren " + doc.HasChildNodes);
                XmlNode rootelementnode = doc.LastChild;
                Console.WriteLine("Node Name " + rootelementnode.Name);
                Console.WriteLine("RootNode HasChildren " + rootelementnode.HasChildNodes);
                ReadNode(rootelementnode);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private static void ReadNode(XmlNode n)
        {
            if (n.NodeType == XmlNodeType.Text)
                Console.WriteLine("\t"+n.NodeType + " " + n.Value);
            else if (n.NodeType == XmlNodeType.Element)
                Console.WriteLine("\t"+n.NodeType + " " + n.Name);

            if (n.HasChildNodes)
            {
                foreach (XmlNode n1 in n.ChildNodes)
                    ReadNode(n1);
            }
        }

    }
}
