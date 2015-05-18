namespace ManagementPack
{
    using System;
    using System.Management.Automation;
    
    namespace Cmdlets
    {
        [Cmdlet(VerbsCommon.New, "Manifest")]
        public class NewManifest : PSCmdlet
        {
            private string _Name;
            private mpManifest.mpIdentity _Identity;
            private mpManifest.mpReference _References;

            [Parameter(
                Mandatory = true,
                ValueFromPipeline = true,
                ValueFromPipelineByPropertyName = true,
                Position = 0)]
            
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            [Parameter(
                Mandatory = false,
                ValueFromPipeline = true,
                ValueFromPipelineByPropertyName = true,
                Position = 1)]

            public mpManifest.mpIdentity Identity
            {
                get { return _Identity; }
                set { _Identity = value; }
            }

            [Parameter(
                Mandatory = false,
                ValueFromPipeline = true,
                ValueFromPipelineByPropertyName = true,
                Position = 2)]
            
            public mpManifest.mpReference References
            {
                get { return _References; }
                set { _References = value; }
            }

            protected override void ProcessRecord()
            {
                mpManifest Manifest = new mpManifest(this._Name);
                if (this._Identity != null)
                {
                    Manifest.Identity = this._Identity;
                }
                if (this.References != null)
                {
                    Manifest.References.Add(this._References);
                }
                WriteObject(Manifest);
            }
        }

        [Cmdlet(VerbsCommon.New, "Identity")]
        public class NewIdentity : PSCmdlet
        {
            private string _ID;
            private string _Version;

            [Parameter(
                Mandatory = true,
                ValueFromPipeline = true,
                ValueFromPipelineByPropertyName = true,
                Position = 0)]

            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            [Parameter(
                Mandatory = true,
                ValueFromPipeline = true,
                ValueFromPipelineByPropertyName = true,
                Position = 1)]

            public string Version
            {
                get { return _Version; }
                set { _Version = value; }
            }

            protected override void BeginProcessing()
            {
                mpManifest.mpIdentity Identity = new mpManifest.mpIdentity(this._ID, this._Version);
                WriteObject(Identity);
            }
        }

        [Cmdlet(VerbsCommon.Add, "Reference")]
        public class AddReference : PSCmdlet
        {
            private mpManifest _Manifest;
            private string _Alias;
            private string _PublicKeyToken;
            private string _Version;
            private string _ID;

            [Parameter(
                Mandatory = true,
                Position = 0)]

            public mpManifest Manifest
            {
                get { return _Manifest; }
                set { _Manifest = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 1)]

            public string Alias
            {
                get { return _Alias; }
                set { _Alias = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 2)]

            public string PublicKeyToken
            {
                get { return _PublicKeyToken; }
                set { _PublicKeyToken = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 3)]

            public string Version
            {
                get { return _Version; }
                set { _Version = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 4)]

            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            protected override void BeginProcessing()
            {
                WriteVerbose(this._Manifest.Name);
                mpManifest.mpReference Reference = new mpManifest.mpReference(this._Alias, this._PublicKeyToken, this._Version, this._ID);
                if (this._Manifest.References == null)
                {
                    this._Manifest.References = new System.Collections.Generic.List<mpManifest.mpReference>();
                    this._Manifest.References.Add(Reference);
                }
                else
                {
                    this._Manifest.References.Add(Reference);
                }
                WriteObject(this._Manifest);
            }
        }

        [Cmdlet(VerbsCommon.New, "Reference")]
        public class NewReference : PSCmdlet
        {
            private string _Alias;
            private string _PublicKeyToken;
            private string _Version;
            private string _ID;

            [Parameter(
                Mandatory = true,
                Position = 1)]

            public string Alias
            {
                get { return _Alias; }
                set { _Alias = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 2)]

            public string PublicKeyToken
            {
                get { return _PublicKeyToken; }
                set { _PublicKeyToken = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 3)]

            public string Version
            {
                get { return _Version; }
                set { _Version = value; }
            }

            [Parameter(
                Mandatory = true,
                Position = 4)]

            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            protected override void BeginProcessing()
            {
                mpManifest.mpReference Reference = new mpManifest.mpReference(this._Alias, this._PublicKeyToken, this._Version, this._ID);
                WriteObject(Reference);
            }
        }
    }
}
