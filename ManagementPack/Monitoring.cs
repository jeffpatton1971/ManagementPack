namespace ManagementPack
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    public class mpMonitoring
    {
        public class mpDiagnostic
        {
            private string _ID;
            private string _Comment;
            private bool _Enabled;
            private string _Target;
            private string _Monitor;
            private string _ExecuteOnState;
            private bool _Remotable;
            private int _Timeout;

            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            public string Comment
            {
                get { return _Comment; }
                set { _Comment = value; }
            }

            public bool Enabled
            {
                get { return _Enabled; }
                set { _Enabled = value; }
            }

            public string Target
            {
                get { return _Target; }
                set { _Target = value; }
            }

            public string Monitor
            {
                get { return _Monitor; }
                set { _Monitor = value; }
            }

            public string ExecuteOnState
            {
                get { return _ExecuteOnState; }
                set { _ExecuteOnState = value; }
            }

            public bool Remotable
            {
                get { return _Remotable; }
                set { _Remotable = value; }
            }

            public int Timeout
            {
                get { return _Timeout; }
                set { _Timeout = value; }
            }

            public mpCategory Category;
            public mpConditionDetection ConditionDetection;
            public mpProbeAction ProbeAction;

            public class mpCategory
            {
                private string _Name;

                public string Name
                {
                    get { return _Name; }
                    set { _Name = value; }
                }

                public mpCategory()
                {

                }

                public mpCategory(string Name)
                {
                    List<string> Categories = new List<string>();
                    Categories.Add("PerformanceCollection");
                    Categories.Add("Operations");
                    Categories.Add("EventCollection");
                    Categories.Add("StateCollection");
                    Categories.Add("SoftwareAndUpdates");
                    Categories.Add("Alert");
                    Categories.Add("System");
                    Categories.Add("Custom");
                    Categories.Add("AvailabilityHealth");
                    Categories.Add("PerformanceHealth");
                    Categories.Add("ConfigurationHealth");
                    Categories.Add("SecurityHealth");
                    Categories.Add("Discovery");
                    Categories.Add("Notification");
                    Categories.Add("DSIntegration");
                    Categories.Add("ConnectorFramework");
                    Categories.Add("ExceptionMonitoring");
                    Categories.Add("Maintenance");

                    if (Categories.Contains(Name))
                    {
                        this._Name = Name;
                    }
                }
            }

            public class mpConditionDetection
            {
                private string _ID;
                private string _Comment;
                private string _TypeID;

                public string ID
                {
                    get { return _ID; }
                    set { _ID = value; }
                }

                public string Comment
                {
                    get { return _Comment; }
                    set { _Comment = value; }
                }

                public string TypeID
                {
                    get { return _TypeID; }
                    set { _TypeID = value; }
                }

                public mpConditionDetection()
                {

                }

                public mpConditionDetection(string ID, string TypeID, string Comment)
                {
                    this._ID = ID;
                    this._TypeID = TypeID;
                    this._Comment = Comment;
                }
            }

            public class mpProbeAction
            {
                private string _ID;
                private string _Comment;
                private string _TypeID;

                public string ID
                {
                    get { return _ID; }
                    set { _ID = value; }
                }

                public string Comment
                {
                    get { return _Comment; }
                    set { _Comment = value; }
                }

                public string TypeID
                {
                    get { return _TypeID; }
                    set { _TypeID = value; }
                }

                public mpProbeAction()
                {

                }

                public mpProbeAction(string ID, string TypeID, string Comment)
                {
                    this._ID = ID;
                    this._TypeID = TypeID;
                    this._Comment = Comment;
                }
            }
        }

        public class mpDiscovery
        {

        }

        public class mpAggregateMonitor
        {

        }

        public class mpDependencyMonitor
        {

        }

        public class mpUnitMonitor
        {

        }
    }
}
