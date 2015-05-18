namespace ManagementPack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    namespace TypeDefinitions
    {
        public class DataTypes
        {
            public List<dDataType> DataType;

            public class dDataType
            {
                private string _ID;
                private string _Comment;
                private string _Accessibility;
                private string _Base;

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

                public string Accessibility
                {
                    get { return _Accessibility; }
                    set { _Accessibility = value; }
                }

                public string Base
                {
                    get { return _Base; }
                    set { _Base = value; }
                }

                public dAssembly Assembly;
                public dClassID ClassID;
                public dType Type;

                public dDataType(string ID, string Base, string Accessibility)
                {
                    this._ID = ID;
                    this._Base = Base;
                    this._Accessibility = Accessibility;
                }

                public dDataType(string ID, string Base, string Accessibility, string Comment)
                {
                    this._ID = ID;
                    this._Base = Base;
                    this._Accessibility = Accessibility;
                    this._Comment = Comment;
                }

                public dDataType AddAssembly(string Value)
                {
                    this.Assembly = new dAssembly(Value);
                    return this;
                }

                public dDataType AddClassID(string Value)
                {
                    this.ClassID = new dClassID(Value);
                    return this;
                }

                public dDataType AddType(string Value)
                {
                    this.Type = new dType(Value);
                    return this;
                }

                public class Implementation
                {


                }

                public class dAssembly : Implementation
                {
                    private string _Value;

                    public string Value
                    {
                        get { return _Value; }
                        set { _Value = value; }
                    }

                    public dAssembly(string Value)
                    {
                        this._Value = Value;
                    }
                }

                public class dType : Implementation
                {
                    private string _Value;

                    public string Value
                    {
                        get { return _Value; }
                        set { _Value = value; }
                    }

                    public dType(string Value)
                    {
                        this._Value = Value;
                    }
                }

                public class dClassID : Implementation
                {
                    private string _Value;

                    public string Value
                    {
                        get { return _Value; }
                        set { _Value = value; }
                    }

                    public dClassID(string Value)
                    {
                        this._Value = Value;
                    }
                }

            }
        }

        public class EntityTypes
        {
            public List<ClassType> ClassTypes;
            public List<EnumerationValue> EnumerationTypes;
            public List<RelationshipType> RelationshipTypes;
            public List<TypeProjection> TypeProjections;

            public class ClassType
            {
                private string _ID;
                private string _Comment;
                private string _Accessibility;
                private string _Abstract;
                private string _Base;
                private bool _Hosted;
                private bool _Singelton;

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

                public string Accessibility
                {
                    get { return _Accessibility; }
                    set { _Accessibility = value; }
                }

                public string Abstract
                {
                    get { return _Abstract; }
                    set { _Abstract = value; }
                }

                public string Base
                {
                    get { return _Base; }
                    set { _Base = value; }
                }

                public bool Hosted
                {
                    get { return _Hosted; }
                    set { _Hosted = value; }
                }

                public bool Singleton
                {
                    get { return _Singelton; }
                    set { _Singelton = value; }
                }

                public List<cProperty> Property;

                public class cProperty
                {
                    private string _ID;
                    private string _Comment;
                    private string _Type;
                    private bool _Key;
                    private bool _CaseSensitive;
                    private string _Length;
                    private string _MinLength;

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

                    public string Type
                    {
                        get { return _Type; }
                        set { _Type = value; }
                    }

                    public bool Key
                    {
                        get { return _Key; }
                        set { _Key = value; }
                    }

                    public bool CaseSensitive
                    {
                        get { return _CaseSensitive; }
                        set { _CaseSensitive = value; }
                    }

                    public string Length
                    {
                        get { return _Length; }
                        set { _Length = value; }
                    }

                    public string MinLength
                    {
                        get { return _MinLength; }
                        set { _MinLength = value; }
                    }

                    public cProperty(string ID, string Type)
                    {
                        //
                        // Constructor with required's only
                        //
                        this._ID = ID;
                        this._Type = Type;
                    }

                    public cProperty(string ID, string Type, bool Key, bool CaseSensitive)
                    {
                        //
                        // Constructor based off sample online
                        //
                        this._ID = ID;
                        this._Type = Type;
                        this._Key = Key;
                        this._CaseSensitive = CaseSensitive;
                    }

                    public cProperty(string ID, string Type, bool Key, bool CaseSensitive, string Length, string MinLength, string Comment)
                    {
                        this._ID = ID;
                        this._Type = Type;
                        this._Key = Key;
                        this._CaseSensitive = CaseSensitive;
                        this._Length = Length;
                        this._MinLength = MinLength;
                        this._Comment = Comment;
                    }

                }

                public ClassType(string ID, string Accessibility, string Abstract, string Base)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Abstract = Abstract;
                    this._Base = Base;
                }

                public ClassType(string ID, string Accessibility, string Base, bool Hosted, string Abstract, bool Singleton)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Base = Base;
                    this._Hosted = Hosted;
                    this._Abstract = Abstract;
                    this._Singelton = Singleton;
                }

                public ClassType(string ID, string Accessibility, string Base, bool Hosted, string Abstract, bool Singleton, string Comment)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Base = Base;
                    this._Hosted = Hosted;
                    this._Abstract = Abstract;
                    this._Singelton = Singleton;
                    this._Comment = Comment;
                }

                public ClassType(string ID, string Accessibility, string Base, bool Hosted, string Abstract, bool Singleton, string Comment, cProperty Property)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Base = Base;
                    this._Hosted = Hosted;
                    this._Abstract = Abstract;
                    this._Singelton = Singleton;
                    this._Comment = Comment;
                    this.Property = new List<cProperty>();
                    this.Property.Add(Property);
                }
            }

            public EntityTypes AddClassType(string ID, string Accessibility, string Base, bool Hosted, string Abstract, bool Singleton)
            {
                if (this.ClassTypes == null)
                {
                    this.ClassTypes = new List<ClassType>();
                    this.ClassTypes.Add(new EntityTypes.ClassType(ID, Accessibility, Base, Hosted, Abstract, Singleton));
                }
                else
                {
                    this.ClassTypes.Add(new EntityTypes.ClassType(ID, Accessibility, Base, Hosted, Abstract, Singleton));
                }
                return this;
            }

            public EntityTypes AddClassType(string ID, string Accessibility, string Base, bool Hosted, string Abstract, bool Singleton, string Comment, ClassType.cProperty Property)
            {
                if (this.ClassTypes == null)
                {
                    this.ClassTypes = new List<ClassType>();
                    this.ClassTypes.Add(new EntityTypes.ClassType(ID, Accessibility, Base, Hosted, Abstract, Singleton, Comment, Property));
                }
                else
                {
                    this.ClassTypes.Add(new EntityTypes.ClassType(ID, Accessibility, Base, Hosted, Abstract, Singleton, Comment, Property));
                }
                return this;
            }

            public class EnumerationValue
            {
                private string _ID;
                private string _Comment;
                private string _Accessibility;
                private string _Parent;
                private string _Ordinal;

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

                public string Accessibility
                {
                    get { return _Accessibility; }
                    set { _Accessibility = value; }
                }

                public string Parent
                {
                    get { return _Parent; }
                    set { _Parent = value; }
                }

                public string Ordinal
                {
                    get { return _Ordinal; }
                    set { _Ordinal = value; }
                }

                public EnumerationValue(string ID, string Accessibility)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                }

                public EnumerationValue(string ID, string Accessibility, string Parent, string Ordinal, string Comment)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Parent = Parent;
                    this._Ordinal = Ordinal;
                    this._Comment = Comment;
                }

            }

            public class RelationshipType
            {
                private string _ID;
                private string _Accessibility;
                private bool _Abstract;
                private string _Base;
                private string _Source;
                private string _Target;

                public string ID
                {
                    get { return _ID; }
                    set { _ID = value; }
                }

                public string Accessibility
                {
                    get { return _Accessibility; }
                    set { _Accessibility = value; }
                }

                public bool Abstract
                {
                    get { return _Abstract; }
                    set { _Abstract = value; }
                }

                public string Base
                {
                    get { return _Base; }
                    set { _Base = value; }
                }

                public List<rProperty> Property;

                public string Source
                {
                    get { return _Source; }
                    set { _Source = value; }
                }

                public string Target
                {
                    get { return _Target; }
                    set { _Target = value; }
                }

                public class rProperty
                {
                    private string _ID;
                    private string _Comment;
                    private string _Type;
                    private bool _CaseSensitive;
                    private string _Length;

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

                    public string Type
                    {
                        get { return _Type; }
                        set { _Type = value; }
                    }

                    public bool CaseSensitive
                    {
                        get { return _CaseSensitive; }
                        set { _CaseSensitive = value; }
                    }

                    public string Length
                    {
                        get { return _Length; }
                        set { _Length = value; }
                    }

                    public rProperty()
                    {

                    }

                    public rProperty(string ID, string Comment, string Type, bool CaseSensitive, string Length)
                    {
                        this._ID = ID;
                        this._Comment = Comment;
                        this._Type = Type;
                        this._CaseSensitive = CaseSensitive;
                        this._Length = Length;
                    }
                }

                public RelationshipType()
                {

                }

                public RelationshipType(string ID, string Accessibility, bool Abstract, string Base)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Abstract = Abstract;
                    this._Base = Base;
                }

                public RelationshipType(string ID, string Accessibility, bool Abstract, string Base, rProperty Property)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Abstract = Abstract;
                    this._Base = Base;
                    this.Property = new List<rProperty>();
                    this.Property.Add(Property);
                }

                public RelationshipType(string ID, string Accessibility, bool Abstract, string Base, string Source, string Target)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Abstract = Abstract;
                    this._Base = Base;
                    this._Source = Source;
                    this._Target = Target;
                }

                public RelationshipType(string ID, string Accessibility, bool Abstract, string Base, rProperty Property, string Source, string Target)
                {
                    this._ID = ID;
                    this._Accessibility = Accessibility;
                    this._Abstract = Abstract;
                    this._Base = Base;
                    this.Property = new List<rProperty>();
                    this.Property.Add(Property);
                    this._Source = Source;
                    this._Target = Target;
                }
            }

            public EntityTypes AddRelationshipType(string ID, string Accessibility, bool Abstract, string Base)
            {
                if (this.RelationshipTypes == null)
                {
                    this.RelationshipTypes = new List<RelationshipType>();
                    this.RelationshipTypes.Add(new RelationshipType(ID, Accessibility, Abstract, Base));
                }
                else
                {
                    this.RelationshipTypes.Add(new RelationshipType(ID, Accessibility, Abstract, Base));
                }
                return this;
            }

            public EntityTypes AddRelationshipType(string ID, string Accessibility, bool Abstract, string Base, RelationshipType.rProperty Property, string Source, string Target)
            {
                if (this.RelationshipTypes == null)
                {
                    this.RelationshipTypes = new List<RelationshipType>();
                    this.RelationshipTypes.Add(new RelationshipType(ID, Accessibility, Abstract, Base, Property, Source, Target));
                }
                else
                {
                    this.RelationshipTypes.Add(new RelationshipType(ID, Accessibility, Abstract, Base, Property, Source, Target));
                }
                return this;
            }

            public EntityTypes AddRelationshipType(string ID, string Accessibility, bool Abstract, string Base, string Source, string Target)
            {
                if (this.RelationshipTypes == null)
                {
                    this.RelationshipTypes = new List<RelationshipType>();
                    this.RelationshipTypes.Add(new RelationshipType(ID, Accessibility, Abstract, Base, Source, Target));
                }
                else
                {
                    this.RelationshipTypes.Add(new RelationshipType(ID, Accessibility, Abstract, Base, Source, Target));
                }
                return this;
            }
            public class TypeProjection
            {
                public class Component
                {

                }
            }
            
        }
    }
}
