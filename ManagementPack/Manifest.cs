namespace ManagementPack
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    [XmlRoot("Manifest")]
    [Serializable]
    public class mpManifest
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public mpIdentity Identity;
        public List<mpReference> References;

        [XmlType(TypeName = "Identity")]
        [Serializable]
        public class mpIdentity
        {
            private string _ID;
            private string _Version;

            [XmlElement]
            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            [XmlElement]
            public string Version
            {
                get { return _Version; }
                set { _Version = value; }
            }

            public mpIdentity()
            {

            }

            public mpIdentity(string ID, string Version)
            {
                this._ID = ID;
                this._Version = Version;
            }
        }

        [XmlType(TypeName = "Reference")]
        [Serializable]
        public class mpReference
        {
            private string _Alias;
            private string _PublicKeyToken;
            private string _Version;
            private string _ID;

            [XmlAttribute]
            public string Alias
            {
                get { return _Alias; }
                set { _Alias = value; }
            }

            [XmlElement]
            public string PublicKeyToken
            {
                get { return _PublicKeyToken; }
                set { _PublicKeyToken = value; }
            }

            [XmlElement]
            public string Version
            {
                get { return _Version; }
                set { _Version = value; }
            }

            [XmlElement]
            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            public mpReference()
            {

            }

            public mpReference(string Alias, string PublicKeyToken, string Version, string ID)
            {
                this._Alias = Alias;
                this._PublicKeyToken = PublicKeyToken;
                this._Version = Version;
                this._ID = ID;
            }
        }
        
        public mpManifest()
        {
        }

        public mpManifest(string Name) 
        {
            this._Name = Name;
        }

        public string ToXml()
        {
            XmlSerializer xSerializer = new XmlSerializer(typeof(mpManifest));
            StringWriter sWriter = new StringWriter();
            XmlWriterSettings xWriterSettings = new XmlWriterSettings();
            xWriterSettings.OmitXmlDeclaration = true;
            xWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;
            xWriterSettings.Encoding = System.Text.Encoding.UTF8;
            xWriterSettings.Indent = true;
            XmlWriter xWriter = XmlWriter.Create(sWriter, xWriterSettings);
            XmlSerializerNamespaces xNs = new XmlSerializerNamespaces();
            xNs.Add("", "");
            xSerializer.Serialize(sWriter, this, xNs);
            return sWriter.ToString();
        }

        public mpManifest AddIdentity(mpIdentity Identity)
        {
            if (this.Identity == null)
            {
                this.Identity = Identity;
            }

            return this;
        }

        public mpManifest AddReference(mpReference Reference)
        {
            if (this.References == null)
            {
                this.References = new List<mpReference>();
                this.References.Add(Reference);
            }
            else
            {
                this.References.Add(Reference);
            }

            return this;
        }
    }
}