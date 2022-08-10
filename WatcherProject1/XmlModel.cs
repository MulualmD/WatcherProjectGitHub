using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatcherProject1
{
    public class XmlModel
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("test-run", Namespace = "", IsNullable = false)]
        public partial class testrun
        {

            private string commandlineField;

            private testrunTestsuite testsuiteField;

            private byte idField;

            private string runstateField;

            private byte testcasecountField;

            private string resultField;

            private string labelField;

            private byte totalField;

            private byte passedField;

            private byte failedField;

            private byte warningsField;

            private byte inconclusiveField;

            private byte skippedField;

            private byte assertsField;

            private string engineversionField;

            private string clrversionField;

            private string starttimeField;

            private string endtimeField;

            private decimal durationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("command-line")]
            public string commandline
            {
                get
                {
                    return this.commandlineField;
                }
                set
                {
                    this.commandlineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuite testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string result
            {
                get
                {
                    return this.resultField;
                }
                set
                {
                    this.resultField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte passed
            {
                get
                {
                    return this.passedField;
                }
                set
                {
                    this.passedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte failed
            {
                get
                {
                    return this.failedField;
                }
                set
                {
                    this.failedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte warnings
            {
                get
                {
                    return this.warningsField;
                }
                set
                {
                    this.warningsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte inconclusive
            {
                get
                {
                    return this.inconclusiveField;
                }
                set
                {
                    this.inconclusiveField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte skipped
            {
                get
                {
                    return this.skippedField;
                }
                set
                {
                    this.skippedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte asserts
            {
                get
                {
                    return this.assertsField;
                }
                set
                {
                    this.assertsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("engine-version")]
            public string engineversion
            {
                get
                {
                    return this.engineversionField;
                }
                set
                {
                    this.engineversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("clr-version")]
            public string clrversion
            {
                get
                {
                    return this.clrversionField;
                }
                set
                {
                    this.clrversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("start-time")]
            public string starttime
            {
                get
                {
                    return this.starttimeField;
                }
                set
                {
                    this.starttimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("end-time")]
            public string endtime
            {
                get
                {
                    return this.endtimeField;
                }
                set
                {
                    this.endtimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal duration
            {
                get
                {
                    return this.durationField;
                }
                set
                {
                    this.durationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuite
        {

            private testrunTestsuiteEnvironment environmentField;

            private testrunTestsuiteSetting[] settingsField;

            private testrunTestsuiteProperty[] propertiesField;

            private testrunTestsuiteFailure failureField;

            private string typeField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string runstateField;

            private byte testcasecountField;

            private string resultField;

            private string labelField;

            private string siteField;

            private System.DateTime starttimeField;

            private System.DateTime endtimeField;

            private decimal durationField;

            private byte totalField;

            private byte passedField;

            private byte failedField;

            private byte warningsField;

            private byte inconclusiveField;

            private byte skippedField;

            private byte assertsField;

            /// <remarks/>
            public testrunTestsuiteEnvironment environment
            {
                get
                {
                    return this.environmentField;
                }
                set
                {
                    this.environmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("setting", IsNullable = false)]
            public testrunTestsuiteSetting[] settings
            {
                get
                {
                    return this.settingsField;
                }
                set
                {
                    this.settingsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
            public testrunTestsuiteProperty[] properties
            {
                get
                {
                    return this.propertiesField;
                }
                set
                {
                    this.propertiesField = value;
                }
            }

            /// <remarks/>
            public testrunTestsuiteFailure failure
            {
                get
                {
                    return this.failureField;
                }
                set
                {
                    this.failureField = value;
                }
            }

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
            public string id
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string result
            {
                get
                {
                    return this.resultField;
                }
                set
                {
                    this.resultField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string label
            {
                get
                {
                    return this.labelField;
                }
                set
                {
                    this.labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string site
            {
                get
                {
                    return this.siteField;
                }
                set
                {
                    this.siteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("start-time")]
            public System.DateTime starttime
            {
                get
                {
                    return this.starttimeField;
                }
                set
                {
                    this.starttimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("end-time")]
            public System.DateTime endtime
            {
                get
                {
                    return this.endtimeField;
                }
                set
                {
                    this.endtimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal duration
            {
                get
                {
                    return this.durationField;
                }
                set
                {
                    this.durationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte passed
            {
                get
                {
                    return this.passedField;
                }
                set
                {
                    this.passedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte failed
            {
                get
                {
                    return this.failedField;
                }
                set
                {
                    this.failedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte warnings
            {
                get
                {
                    return this.warningsField;
                }
                set
                {
                    this.warningsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte inconclusive
            {
                get
                {
                    return this.inconclusiveField;
                }
                set
                {
                    this.inconclusiveField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte skipped
            {
                get
                {
                    return this.skippedField;
                }
                set
                {
                    this.skippedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte asserts
            {
                get
                {
                    return this.assertsField;
                }
                set
                {
                    this.assertsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteEnvironment
        {

            private string frameworkversionField;

            private string clrversionField;

            private string osversionField;

            private string platformField;

            private string cwdField;

            private string machinenameField;

            private string userField;

            private string userdomainField;

            private string cultureField;

            private string uicultureField;

            private string osarchitectureField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("framework-version")]
            public string frameworkversion
            {
                get
                {
                    return this.frameworkversionField;
                }
                set
                {
                    this.frameworkversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("clr-version")]
            public string clrversion
            {
                get
                {
                    return this.clrversionField;
                }
                set
                {
                    this.clrversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("os-version")]
            public string osversion
            {
                get
                {
                    return this.osversionField;
                }
                set
                {
                    this.osversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string platform
            {
                get
                {
                    return this.platformField;
                }
                set
                {
                    this.platformField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string cwd
            {
                get
                {
                    return this.cwdField;
                }
                set
                {
                    this.cwdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("machine-name")]
            public string machinename
            {
                get
                {
                    return this.machinenameField;
                }
                set
                {
                    this.machinenameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string user
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("user-domain")]
            public string userdomain
            {
                get
                {
                    return this.userdomainField;
                }
                set
                {
                    this.userdomainField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string culture
            {
                get
                {
                    return this.cultureField;
                }
                set
                {
                    this.cultureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uiculture
            {
                get
                {
                    return this.uicultureField;
                }
                set
                {
                    this.uicultureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("os-architecture")]
            public string osarchitecture
            {
                get
                {
                    return this.osarchitectureField;
                }
                set
                {
                    this.osarchitectureField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteSetting
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
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
        public partial class testrunTestsuiteProperty
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
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
        public partial class testrunTestsuiteFailure
        {

            private string messageField;

            /// <remarks/>
            public string message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                }
            }
        }

    }
}
