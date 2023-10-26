namespace Fritz.Serialization
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class contact
    {
        private byte categoryField;

        private contactPerson personField;

        private contactTelephony telephonyField;

        private contactServices servicesField;

        private object setupField;

        private contactFeatures featuresField;

        private uint mod_timeField;

        private uint uniqueidField;

        /// <remarks/>
        public byte category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public contactPerson person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <remarks/>
        public contactTelephony telephony
        {
            get
            {
                return this.telephonyField;
            }
            set
            {
                this.telephonyField = value;
            }
        }

        /// <remarks/>
        public contactServices services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }

        /// <remarks/>
        public object setup
        {
            get
            {
                return this.setupField;
            }
            set
            {
                this.setupField = value;
            }
        }

        /// <remarks/>
        public contactFeatures features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }

        /// <remarks/>
        public uint mod_time
        {
            get
            {
                return this.mod_timeField;
            }
            set
            {
                this.mod_timeField = value;
            }
        }

        /// <remarks/>
        public uint uniqueid
        {
            get
            {
                return this.uniqueidField;
            }
            set
            {
                this.uniqueidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactPerson
    {

        private string realNameField;

        private string imageURLField;

        /// <remarks/>
        public string realName
        {
            get
            {
                return this.realNameField;
            }
            set
            {
                this.realNameField = value;
            }
        }

        /// <remarks/>
        public string imageURL
        {
            get
            {
                return this.imageURLField;
            }
            set
            {
                this.imageURLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactTelephony
    {

        private contactTelephonyNumber[] numberField;

        private byte nidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("number")]
        public contactTelephonyNumber[] number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nid
        {
            get
            {
                return this.nidField;
            }
            set
            {
                this.nidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactTelephonyNumber
    {

        private string typeField;

        private byte prioField;

        private bool prioFieldSpecified;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte prio
        {
            get
            {
                return this.prioField;
            }
            set
            {
                this.prioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioSpecified
        {
            get
            {
                return this.prioFieldSpecified;
            }
            set
            {
                this.prioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactServices
    {

        private contactServicesEmail emailField;

        private byte nidField;

        /// <remarks/>
        public contactServicesEmail email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nid
        {
            get
            {
                return this.nidField;
            }
            set
            {
                this.nidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactServicesEmail
    {

        private string classifierField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classifier
        {
            get
            {
                return this.classifierField;
            }
            set
            {
                this.classifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactFeatures
    {

        private byte doorphoneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte doorphone
        {
            get
            {
                return this.doorphoneField;
            }
            set
            {
                this.doorphoneField = value;
            }
        }
    }
}
