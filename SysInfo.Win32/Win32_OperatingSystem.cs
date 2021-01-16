namespace SysInfo.Win32.ROOT.CIMV2 {
    using System;
    using System.ComponentModel;
    using System.Management;
    using System.Collections;
    using System.Globalization;
    using System.ComponentModel.Design.Serialization;
    using System.Reflection;
    
    
    // Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions uses Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that a empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    // Functions Is<PropertyName>Null() are functions . These functions are to be used to check if a property is NULL.
    // Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used in VS designere in property browser to set a property to NULL.
    // 	Every property added to the class for WMI property has attributes set to define its behaviour in Visual Studio designer and as well as to define a TypeConverter to be used.
    // DateTime Conversions are added for the class to convert DMTF date to System.DateTime and Vise-versa. Conversion from DMTF to System.DateTime conversion ignores the microseconds as System.DateTime doesn't have the microseconds part in it.
    // An Early Bound class generated for the WMI class.Win32_OperatingSystem
    public class OperatingSystem : System.ComponentModel.Component {
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_OperatingSystem";
        
        // Property pointing to a embeded object to get System properties of the WMI object.
        private ManagementSystemProperties PrivateSystemProperties;
        
        // Underlying LateBound WMI object.
        private System.Management.ManagementObject PrivateLateBoundObject;
        
        // Member variable to store the autocommit behaviour for the class.
        private bool AutoCommitProp = true;
        
        // Private variable to hold the embedded property representing the instance.
        private System.Management.ManagementBaseObject embeddedObj;
        
        // The current WMI object used
        private System.Management.ManagementBaseObject curObj;
        
        // Flag to indicate if t	he instance is a embedded object.
        private bool isEmbedded = false;
        
        // Below are different flavours of constructors to initialize the instance with a WMI object.
        public OperatingSystem() : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(null)), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public OperatingSystem(string keyName) : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(new System.Management.ManagementPath(OperatingSystem.ConstructPath(keyName)))), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public OperatingSystem(System.Management.ManagementScope mgmtScope, string keyName) : 
                this(((System.Management.ManagementScope)(mgmtScope)), ((System.Management.ManagementPath)(new System.Management.ManagementPath(OperatingSystem.ConstructPath(keyName)))), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public OperatingSystem(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(path)), ((System.Management.ObjectGetOptions)(getOptions))) {
        }
        
        public OperatingSystem(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) : 
                this(((System.Management.ManagementScope)(mgmtScope)), ((System.Management.ManagementPath)(path)), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public OperatingSystem(System.Management.ManagementPath path) : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(path)), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public OperatingSystem(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            if ((path != null)) {
                if ((CheckIfProperClass(mgmtScope, path, getOptions) != true)) {
                    throw new System.ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new System.Management.ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        public OperatingSystem(System.Management.ManagementObject theObject) {
            if ((CheckIfProperClass(theObject.Scope, theObject.Path, theObject.Options) == true)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        public OperatingSystem(System.Management.ManagementBaseObject theObject) {
            if ((CheckIfProperClass(theObject) == true)) {
                embeddedObj = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(theObject);
                curObj = embeddedObj;
                isEmbedded = true;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        // Property returns the namespace of the WMI class.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OriginatingNamespace {
            get {
                return "ROOT\\CIMV2";
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManagementClassName {
            get {
                string strRet = CreatedClassName;
                if ((curObj != null)) {
                    if ((curObj.ClassPath != null)) {
                        strRet = ((string)(curObj["__CLASS"]));
                        if (((strRet == null) 
                                    || (strRet == System.String.Empty))) {
                            strRet = CreatedClassName;
                        }
                    }
                }
                return strRet;
            }
        }
        
        // Property pointing to a embeded object to get System properties of the WMI object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementSystemProperties SystemProperties {
            get {
                return PrivateSystemProperties;
            }
        }
        
        // Property returning the underlying LateBound object.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementBaseObject LateBoundObject {
            get {
                return curObj;
            }
        }
        
        // ManagementScope of the object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementScope Scope {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Scope;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    PrivateLateBoundObject.Scope = value;
                }
            }
        }
        
        // Property to show the autocommit behaviour for the WMI object. If this is true then WMI object is saved to WMI then for change in every property (ie. Put is called after modification of a property).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoCommit {
            get {
                return AutoCommitProp;
            }
            set {
                AutoCommitProp = value;
            }
        }
        
        // The ManagementPath of the underlying WMI object.
        [Browsable(true)]
        public System.Management.ManagementPath Path {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Path;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    if ((CheckIfProperClass(null, value, null) != true)) {
                        throw new System.ArgumentException("Class name does not match.");
                    }
                    PrivateLateBoundObject.Path = value;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The BootDevice property indicates the name of the disk drive from which the Win32" +
" operating system boots. \nExample: \\\\Device\\Harddisk0.")]
        public string BootDevice {
            get {
                return ((string)(curObj["BootDevice"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The BuildNumber property indicates the build number of the operating system.  It " +
"can be used for more precise versioning information than product release version" +
" numbers\nExample: 1381")]
        public string BuildNumber {
            get {
                return ((string)(curObj["BuildNumber"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The BuildType property indicates the type of build used for the operating system." +
" Examples are retail build and checked build.")]
        public string BuildType {
            get {
                return ((string)(curObj["BuildType"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Caption property is a short textual description (one-line string) of the obje" +
"ct.")]
        public string Caption {
            get {
                return ((string)(curObj["Caption"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The CodeSet property indicates the code page value used by the operating system. A code page contains a character table used by the operating system to translate strings for different languages. The American National Standards Institute (ANSI) lists values that represent defined code pages. If the operating system does not use an ANSI code page, this member will be set to 0. The CodeSet string can use up to six characters to define the code page value.
Example: 1255.")]
        public string CodeSet {
            get {
                return ((string)(curObj["CodeSet"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The CountryCode property indicates the code for the country/regionused by the operating system. Values are based on international phone dialing prefixes (also referred to as IBM country/region codes). The CountryCode string can use up to six characters to define the country/region code value.
Example: 1 for the United States)")]
        public string CountryCode {
            get {
                return ((string)(curObj["CountryCode"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CreationClassName indicates the name of the class or the subclass used in the cre" +
"ation of an instance. When used with the other key properties of this class, thi" +
"s property allows all instances of this class and its subclasses to be uniquely " +
"identified.")]
        public string CreationClassName {
            get {
                return ((string)(curObj["CreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CSCreationClassName contains the scoping computer system\'s creation class name.")]
        public string CSCreationClassName {
            get {
                return ((string)(curObj["CSCreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The CSDVersion property contains a null-terminated string, that indicates the latest Service Pack installed on the computer system. If no Service Pack is installed, the string is NULL. For computer systems running Windows 95, this property contains a null-terminated string that provides arbitrary additional information about the operating system.
Example: Service Pack 3.")]
        public string CSDVersion {
            get {
                return ((string)(curObj["CSDVersion"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CSName contains the scoping computer system\'s name.")]
        public string CSName {
            get {
                return ((string)(curObj["CSName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentTimeZoneNull {
            get {
                if ((curObj["CurrentTimeZone"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CurrentTimeZone indicates the number of minutes the operating system is offset fr" +
"om Greenwich Mean Time. Either the number is positive, negative or zero.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public short CurrentTimeZone {
            get {
                if ((curObj["CurrentTimeZone"] == null)) {
                    return System.Convert.ToInt16(0);
                }
                return ((short)(curObj["CurrentTimeZone"]));
            }
            set {
                curObj["CurrentTimeZone"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDebugNull {
            get {
                if ((curObj["Debug"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Debug property indicates whether the operating system is a checked (debug) build. Checked builds provide error checking, argument verification, and system debugging code. Additional code in a checked binary generates a kernel debugger error message and breaks into the debugger. This helps  immediately determine the cause and location of the error. Performance suffers in the checked build due to the additional code that is executed.
Values: TRUE or FALSE, A value of TRUE indicates the debugging version of User.exe is installed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Debug {
            get {
                if ((curObj["Debug"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Debug"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Description property provides a description of the Windows operating system. " +
"Some user interfaces (those that allow editing of this description) limit its le" +
"ngth to 48 characters.")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
            set {
                curObj["Description"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDistributedNull {
            get {
                if ((curObj["Distributed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Boolean indicating whether the operating system is distributed across several com" +
"puter system nodes. If so, these nodes should be grouped as a cluster.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Distributed {
            get {
                if ((curObj["Distributed"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Distributed"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsEncryptionLevelNull {
            get {
                if ((curObj["EncryptionLevel"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The EncryptionLevel property specifies if the encryption level for secure transac" +
"tions is 40-bit, 128-bit, or n-bit encryption.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public EncryptionLevelValues EncryptionLevel {
            get {
                if ((curObj["EncryptionLevel"] == null)) {
                    return ((EncryptionLevelValues)(System.Convert.ToInt32(0)));
                }
                return ((EncryptionLevelValues)(Convert.ToInt32(curObj["EncryptionLevel"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsForegroundApplicationBoostNull {
            get {
                if ((curObj["ForegroundApplicationBoost"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ForegroundApplicationBoost property indicates the increase in priority given to the foreground application. On computer systems running Windows NT 4.0 and Windows 2000, application boost is implemented by giving an application more execution time slices (quantum lengths). A ForegroundApplicationBoost value of 0 indicates the system boosts the quantum length by 6; if 1, then 12; and if 2 then 18. On Windows NT 3.51 and earlier, application boost is implemented by increasing the scheduling priority. For these systems, the scheduling priority is increased by the value of this property. The default value is 2.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ForegroundApplicationBoostValues ForegroundApplicationBoost {
            get {
                if ((curObj["ForegroundApplicationBoost"] == null)) {
                    return ((ForegroundApplicationBoostValues)(System.Convert.ToInt32(0)));
                }
                return ((ForegroundApplicationBoostValues)(Convert.ToInt32(curObj["ForegroundApplicationBoost"])));
            }
            set {
                curObj["ForegroundApplicationBoost"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFreePhysicalMemoryNull {
            get {
                if ((curObj["FreePhysicalMemory"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of kilobytes of physical memory currently unused and available")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 FreePhysicalMemory {
            get {
                if ((curObj["FreePhysicalMemory"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["FreePhysicalMemory"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFreeSpaceInPagingFilesNull {
            get {
                if ((curObj["FreeSpaceInPagingFiles"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The total number of KBytes that can be mapped into the OperatingSystem\'s paging f" +
"iles without causing any other pages to be swapped out. 0 indicates that there a" +
"re no paging files.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 FreeSpaceInPagingFiles {
            get {
                if ((curObj["FreeSpaceInPagingFiles"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["FreeSpaceInPagingFiles"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFreeVirtualMemoryNull {
            get {
                if ((curObj["FreeVirtualMemory"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of kilobytes of virtual memory currently unused and available. For example" +
", this may be calculated by adding the amount of free RAM to the amount of free " +
"paging space (i.e., adding the properties, FreePhysicalMemory and FreeSpaceInPag" +
"ingFiles).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 FreeVirtualMemory {
            get {
                if ((curObj["FreeVirtualMemory"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["FreeVirtualMemory"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInstallDateNull {
            get {
                if ((curObj["InstallDate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InstallDate property is datetime value indicating when the object was install" +
"ed. A lack of a value does not indicate that the object is not installed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime InstallDate {
            get {
                if ((curObj["InstallDate"] != null)) {
                    return ToDateTime(((string)(curObj["InstallDate"])));
                }
                else {
                    return ToDateTime(null);
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLargeSystemCacheNull {
            get {
                if ((curObj["LargeSystemCache"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The LargeSystemCache property indicates whether to optimize memory for applicatio" +
"ns (value=0) or for system performance (value=1).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public LargeSystemCacheValues LargeSystemCache {
            get {
                if ((curObj["LargeSystemCache"] == null)) {
                    return ((LargeSystemCacheValues)(System.Convert.ToInt64(0)));
                }
                return ((LargeSystemCacheValues)(Convert.ToInt64(curObj["LargeSystemCache"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLastBootUpTimeNull {
            get {
                if ((curObj["LastBootUpTime"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Time when the operating system was last booted")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime LastBootUpTime {
            get {
                if ((curObj["LastBootUpTime"] != null)) {
                    return ToDateTime(((string)(curObj["LastBootUpTime"])));
                }
                else {
                    return ToDateTime(null);
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLocalDateTimeNull {
            get {
                if ((curObj["LocalDateTime"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Operating system\'s notion of the local date and time of day.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime LocalDateTime {
            get {
                if ((curObj["LocalDateTime"] != null)) {
                    return ToDateTime(((string)(curObj["LocalDateTime"])));
                }
                else {
                    return ToDateTime(null);
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Locale property indicates the language identifier used by the operating system. A language identifier is a standard international numeric abbreviation for a country or region. Each language has a unique language identifier (LANGID), a 16-bit value that consists of a primary language identifier and a secondary language identifier.")]
        public string Locale {
            get {
                return ((string)(curObj["Locale"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Manufacturer property indicates the name of the operating system manufacturer" +
".  For Win32 systems this value will be Microsoft Corporation.")]
        public string Manufacturer {
            get {
                return ((string)(curObj["Manufacturer"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxNumberOfProcessesNull {
            get {
                if ((curObj["MaxNumberOfProcesses"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Maximum number of process contexts the operating system can support. If there is no fixed maximum, the value should be 0. On systems that have a fixed maximum, this object can help diagnose failures that occur when the maximum is reached. If unknown, enter -1.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 MaxNumberOfProcesses {
            get {
                if ((curObj["MaxNumberOfProcesses"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["MaxNumberOfProcesses"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxProcessMemorySizeNull {
            get {
                if ((curObj["MaxProcessMemorySize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Maximum number of kilobytes of memory that can be allocated to a process. For operating systems with no virtual memory, this value is typically equal to the total amount of physical memory minus memory used by the BIOS and OS. For some operating systems, this value may be infinity - in which case, 0 should be entered. In other cases, this value could be a constant - for example, 2G or 4G.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 MaxProcessMemorySize {
            get {
                if ((curObj["MaxProcessMemorySize"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["MaxProcessMemorySize"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The inherited Name property serves as key of an operating system instance within " +
"a computer system.")]
        public string Name {
            get {
                return ((string)(curObj["Name"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumberOfLicensedUsersNull {
            get {
                if ((curObj["NumberOfLicensedUsers"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of user licenses for the operating system. If unlimited, enter 0. If unkno" +
"wn, enter -1.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 NumberOfLicensedUsers {
            get {
                if ((curObj["NumberOfLicensedUsers"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["NumberOfLicensedUsers"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumberOfProcessesNull {
            get {
                if ((curObj["NumberOfProcesses"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of process contexts currently loaded or running on the operating system.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 NumberOfProcesses {
            get {
                if ((curObj["NumberOfProcesses"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["NumberOfProcesses"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumberOfUsersNull {
            get {
                if ((curObj["NumberOfUsers"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of user sessions for which the operating system is currently storing state" +
" information")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 NumberOfUsers {
            get {
                if ((curObj["NumberOfUsers"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["NumberOfUsers"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Organization property indicates the registered user\'s (of the operating syste" +
"m) company name.\nExample: Microsoft Corporation.")]
        public string Organization {
            get {
                return ((string)(curObj["Organization"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsOSLanguageNull {
            get {
                if ((curObj["OSLanguage"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The OSLanguage property indicates which language version of the operating system " +
"is installed.\nExample: 0x0807 (German, Switzerland)")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 OSLanguage {
            get {
                if ((curObj["OSLanguage"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["OSLanguage"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsOSProductSuiteNull {
            get {
                if ((curObj["OSProductSuite"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The OSProductSuite property identifies installed and licensed system product addi" +
"tions to the operating system.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public OSProductSuiteValues OSProductSuite {
            get {
                if ((curObj["OSProductSuite"] == null)) {
                    return ((OSProductSuiteValues)(System.Convert.ToInt32(0)));
                }
                return ((OSProductSuiteValues)(Convert.ToInt32(curObj["OSProductSuite"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsOSTypeNull {
            get {
                if ((curObj["OSType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A integer indicating the type of operating system.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public OSTypeValues OSType {
            get {
                if ((curObj["OSType"] == null)) {
                    return ((OSTypeValues)(System.Convert.ToInt32(0)));
                }
                return ((OSTypeValues)(Convert.ToInt32(curObj["OSType"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"A string describing the manufacturer and operating system type - used when the operating system property, OSType, is set to 1 (""Other""). The format of the string inserted in OtherTypeDescription should be similar in format to the Values strings defined for OSType.  OtherTypeDescription should be set to NULL when OSType is any value other than 1.")]
        public string OtherTypeDescription {
            get {
                return ((string)(curObj["OtherTypeDescription"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The PlusProductID property contains the product identification number for the Win" +
"dows Plus! operating system enhancement software (if installed).")]
        public string PlusProductID {
            get {
                return ((string)(curObj["PlusProductID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The PlusVersionNumber property contains the version number of the Windows Plus! o" +
"perating system enhancement software (if installed).")]
        public string PlusVersionNumber {
            get {
                return ((string)(curObj["PlusVersionNumber"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPrimaryNull {
            get {
                if ((curObj["Primary"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Primary property determines whether this is the primary operating system.\nVal" +
"ues: TRUE or FALSE. A value of TRUE indicates this is the primary operating syst" +
"em.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Primary {
            get {
                if ((curObj["Primary"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Primary"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsProductTypeNull {
            get {
                if ((curObj["ProductType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ProductType property indicates additional information about the system. This " +
"member can be one of the following values: \n1 - Work Station \n2 - Domain Control" +
"ler \n3 - Server")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ProductTypeValues ProductType {
            get {
                if ((curObj["ProductType"] == null)) {
                    return ((ProductTypeValues)(System.Convert.ToInt64(0)));
                }
                return ((ProductTypeValues)(Convert.ToInt64(curObj["ProductType"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsQuantumLengthNull {
            get {
                if ((curObj["QuantumLength"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The QuantumLength property defines the number of clock ticks per quantum. A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to other applications. When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities. The actual length of a thread's quantum varies across different Windows platforms. For Windows NT/Windows 2000 only.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public QuantumLengthValues QuantumLength {
            get {
                if ((curObj["QuantumLength"] == null)) {
                    return ((QuantumLengthValues)(System.Convert.ToInt32(0)));
                }
                return ((QuantumLengthValues)(Convert.ToInt32(curObj["QuantumLength"])));
            }
            set {
                curObj["QuantumLength"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsQuantumTypeNull {
            get {
                if ((curObj["QuantumType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The QuantumType property specifies either fixed or variable length quantums. Windows NT 4.0 Workstation/Windows 2000 defaults to variable length quantums where the foreground application has a longer quantum than the background applications. Windows NT Server defaults to fixed-length quantums. A quantum is a unit of execution time that the scheduler is allowed to give to an application before switching to another application. When a thread runs one quantum, the kernel preempts it and moves it to the end of a queue for applications with equal priorities. The actual length of a thread's quantum varies across different Windows platforms. For Windows NT/Windows 2000 only.
The property can take the following values: 
0 = Unkown - Quantum Type not known.
1 = Fixed - Quantum length is fixed.
2 = Variable - Quantum length is variable.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public QuantumTypeValues QuantumType {
            get {
                if ((curObj["QuantumType"] == null)) {
                    return ((QuantumTypeValues)(System.Convert.ToInt32(0)));
                }
                return ((QuantumTypeValues)(Convert.ToInt32(curObj["QuantumType"])));
            }
            set {
                curObj["QuantumType"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The RegisteredUser property indicates the name of the registered user of the oper" +
"ating system.\nExample: Jane Doe")]
        public string RegisteredUser {
            get {
                return ((string)(curObj["RegisteredUser"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SerialNumber property indicates the operating system product serial identific" +
"ation number.\nExample:10497-OEM-0031416-71674.")]
        public string SerialNumber {
            get {
                return ((string)(curObj["SerialNumber"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsServicePackMajorVersionNull {
            get {
                if ((curObj["ServicePackMajorVersion"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ServicePackMajorVersion property indicates the major version number of the service pack installed on the computer system. If no service pack has been installed, the value is zero. ServicePackMajorVersion is valid for computers running Windows 2000 and later (NULL otherwise).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 ServicePackMajorVersion {
            get {
                if ((curObj["ServicePackMajorVersion"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["ServicePackMajorVersion"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsServicePackMinorVersionNull {
            get {
                if ((curObj["ServicePackMinorVersion"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ServicePackMinorVersion property indicates the minor version number of the service pack installed on the computer system. If no service pack has been installed, the value is zero. ServicePackMinorVersion is valid for computers running Windows 2000 and later (NULL otherwise).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 ServicePackMinorVersion {
            get {
                if ((curObj["ServicePackMinorVersion"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["ServicePackMinorVersion"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSizeStoredInPagingFilesNull {
            get {
                if ((curObj["SizeStoredInPagingFiles"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The total number of kilobytes that can be stored in the operating system\'s paging" +
" files. Note that this number does not represent the actual physical size of the" +
" paging file on disk.  0 indicates that there are no paging files.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 SizeStoredInPagingFiles {
            get {
                if ((curObj["SizeStoredInPagingFiles"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["SizeStoredInPagingFiles"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Status property is a string indicating the current status of the object. Various operational and non-operational statuses can be defined. Operational statuses are ""OK"", ""Degraded"" and ""Pred Fail"". ""Pred Fail"" indicates that an element may be functioning properly but predicting a failure in the near future. An example is a SMART-enabled hard drive. Non-operational statuses can also be specified. These are ""Error"", ""Starting"", ""Stopping"" and ""Service"". The latter, ""Service"", could apply during mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is on-line, yet the managed element is neither ""OK"" nor in one of the other states.")]
        public string Status {
            get {
                return ((string)(curObj["Status"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSuiteMaskNull {
            get {
                if ((curObj["SuiteMask"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The SuiteMask property indicates a set of bit flags that identify the product suites available on the system. This member can be a combination of the following values: 
0 - Small Business 
1 - Enterprise 
2 - Backoffice 
3 - Communications 
4 - Terminal 
5 - Smallbusiness Restricted 
6 - Embedded NT 
7 - Data Center 
8 - Singe User 
9 - Personal 
10 - Blade 
30 - NT Work Station 
31 - NT Server")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public SuiteMaskValues SuiteMask {
            get {
                if ((curObj["SuiteMask"] == null)) {
                    return ((SuiteMaskValues)(System.Convert.ToInt32(0)));
                }
                return ((SuiteMaskValues)(Convert.ToInt32(curObj["SuiteMask"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SystemDevice property indicates the physical disk partition the operating sys" +
"tem is installed on.")]
        public string SystemDevice {
            get {
                return ((string)(curObj["SystemDevice"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SystemDirectory property indicates the system directory of the operating syst" +
"em.\nExample: C:\\WINDOWS\\SYSTEM32")]
        public string SystemDirectory {
            get {
                return ((string)(curObj["SystemDirectory"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SystemDrive property contains the letter of the disk drive that the operating" +
" system resides on.\nExample: C:")]
        public string SystemDrive {
            get {
                return ((string)(curObj["SystemDrive"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTotalSwapSpaceSizeNull {
            get {
                if ((curObj["TotalSwapSpaceSize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Total swap space in kilobytes. This value may be NULL (unspecified) if swap space is not distinguished from page files.  However, some operating systems distinguish these concepts.  For example, in UNIX, whole processes can be 'swapped out' when the free page list falls and remains below a specified amount.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 TotalSwapSpaceSize {
            get {
                if ((curObj["TotalSwapSpaceSize"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["TotalSwapSpaceSize"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTotalVirtualMemorySizeNull {
            get {
                if ((curObj["TotalVirtualMemorySize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of kilobytes of virtual memory. For example, this may be calculated by add" +
"ing the amount of total RAM to the amount of paging space (i.e., adding the amou" +
"nt of memory in/aggregated by the computer system to the property, SizeStoredInP" +
"agingFiles.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 TotalVirtualMemorySize {
            get {
                if ((curObj["TotalVirtualMemorySize"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["TotalVirtualMemorySize"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTotalVisibleMemorySizeNull {
            get {
                if ((curObj["TotalVisibleMemorySize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The total amount of physical memory (in Kbytes) available to the OperatingSystem." +
" This value does not necessarily indicate the true amount of physical memory, bu" +
"t what is reported to the OperatingSystem as available to it.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt64 TotalVisibleMemorySize {
            get {
                if ((curObj["TotalVisibleMemorySize"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((System.UInt64)(curObj["TotalVisibleMemorySize"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Version property indicates the version number of the operating system.\nExampl" +
"e: 4.0")]
        public string Version {
            get {
                return ((string)(curObj["Version"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The WindowsDirectory property indicates the Windows directory of the operating sy" +
"stem.\nExample: C:\\WINDOWS")]
        public string WindowsDirectory {
            get {
                return ((string)(curObj["WindowsDirectory"]));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions OptionsParam) {
            if (((path != null) 
                        && (System.String.Compare(path.ClassName, ManagementClassName, true) == 0))) {
                return true;
            }
            else {
                return CheckIfProperClass(new System.Management.ManagementObject(mgmtScope, path, OptionsParam));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementBaseObject theObj) {
            if (((theObj != null) 
                        && (System.String.Compare(((string)(theObj["__CLASS"])), ManagementClassName, true) == 0))) {
                return true;
            }
            else {
                System.Array parentClasses = ((System.Array)(theObj["__DERIVATION"]));
                if ((parentClasses != null)) {
                    Int32 count = 0;
                    for (count = 0; (count < parentClasses.Length); count = (count + 1)) {
                        if ((System.String.Compare(((string)(parentClasses.GetValue(count))), ManagementClassName, true) == 0)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentTimeZone() {
            if ((IsCurrentTimeZoneNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetCurrentTimeZone() {
            curObj["CurrentTimeZone"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDebug() {
            if ((IsDebugNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetDescription() {
            curObj["Description"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDistributed() {
            if ((IsDistributedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeEncryptionLevel() {
            if ((IsEncryptionLevelNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeForegroundApplicationBoost() {
            if ((IsForegroundApplicationBoostNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetForegroundApplicationBoost() {
            curObj["ForegroundApplicationBoost"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeFreePhysicalMemory() {
            if ((IsFreePhysicalMemoryNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeFreeSpaceInPagingFiles() {
            if ((IsFreeSpaceInPagingFilesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeFreeVirtualMemory() {
            if ((IsFreeVirtualMemoryNull == false)) {
                return true;
            }
            return false;
        }
        
        static System.DateTime ToDateTime(string dmtfDate) {
            int year = System.DateTime.Now.Year;
            int month = 1;
            int day = 1;
            int hour = 0;
            int minute = 0;
            int second = 0;
            int millisec = 0;
            string dmtf = dmtfDate;
            string tempString = System.String.Empty;
            if (((System.String.Empty == dmtf) 
                        || (dmtf == null))) {
                return System.DateTime.MinValue;
            }
            if ((dmtf.Length != 25)) {
                return System.DateTime.MinValue;
            }
            tempString = dmtf.Substring(0, 4);
            if (("****" != tempString)) {
                year = System.Int32.Parse(tempString);
            }
            tempString = dmtf.Substring(4, 2);
            if (("**" != tempString)) {
                month = System.Int32.Parse(tempString);
            }
            tempString = dmtf.Substring(6, 2);
            if (("**" != tempString)) {
                day = System.Int32.Parse(tempString);
            }
            tempString = dmtf.Substring(8, 2);
            if (("**" != tempString)) {
                hour = System.Int32.Parse(tempString);
            }
            tempString = dmtf.Substring(10, 2);
            if (("**" != tempString)) {
                minute = System.Int32.Parse(tempString);
            }
            tempString = dmtf.Substring(12, 2);
            if (("**" != tempString)) {
                second = System.Int32.Parse(tempString);
            }
            tempString = dmtf.Substring(15, 3);
            if (("***" != tempString)) {
                millisec = System.Int32.Parse(tempString);
            }
            System.DateTime dateRet = new System.DateTime(year, month, day, hour, minute, second, millisec);
            return dateRet;
        }
        
        static string ToDMTFTime(System.DateTime dateParam) {
            string tempString = dateParam.Year.ToString();
            tempString = (tempString + dateParam.Month.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Day.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Hour.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Minute.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Second.ToString().PadLeft(2, '0'));
            tempString = (tempString + ".");
            tempString = (tempString + dateParam.Millisecond.ToString().PadLeft(3, '0'));
            tempString = (tempString + "000");
            System.TimeZone curZone = System.TimeZone.CurrentTimeZone;
            System.TimeSpan tickOffset = curZone.GetUtcOffset(dateParam);
            if ((tickOffset.Ticks >= 0)) {
                tempString = (tempString + "+");
                tempString = (tempString + ((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)).ToString());
            }
            else {
                tempString = (tempString + "-");
                tempString = (tempString + ((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)).ToString().Substring(1, 3));
            }
            return tempString;
        }
        
        private bool ShouldSerializeInstallDate() {
            if ((IsInstallDateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLargeSystemCache() {
            if ((IsLargeSystemCacheNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLastBootUpTime() {
            if ((IsLastBootUpTimeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLocalDateTime() {
            if ((IsLocalDateTimeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxNumberOfProcesses() {
            if ((IsMaxNumberOfProcessesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxProcessMemorySize() {
            if ((IsMaxProcessMemorySizeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNumberOfLicensedUsers() {
            if ((IsNumberOfLicensedUsersNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNumberOfProcesses() {
            if ((IsNumberOfProcessesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNumberOfUsers() {
            if ((IsNumberOfUsersNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeOSLanguage() {
            if ((IsOSLanguageNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeOSProductSuite() {
            if ((IsOSProductSuiteNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeOSType() {
            if ((IsOSTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePrimary() {
            if ((IsPrimaryNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeProductType() {
            if ((IsProductTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeQuantumLength() {
            if ((IsQuantumLengthNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetQuantumLength() {
            curObj["QuantumLength"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeQuantumType() {
            if ((IsQuantumTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetQuantumType() {
            curObj["QuantumType"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeServicePackMajorVersion() {
            if ((IsServicePackMajorVersionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeServicePackMinorVersion() {
            if ((IsServicePackMinorVersionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeSizeStoredInPagingFiles() {
            if ((IsSizeStoredInPagingFilesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeSuiteMask() {
            if ((IsSuiteMaskNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTotalSwapSpaceSize() {
            if ((IsTotalSwapSpaceSizeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTotalVirtualMemorySize() {
            if ((IsTotalVirtualMemorySizeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTotalVisibleMemorySize() {
            if ((IsTotalVisibleMemorySizeNull == false)) {
                return true;
            }
            return false;
        }
        
        [Browsable(true)]
        public void CommitObject() {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private static string ConstructPath(string keyName) {
            string strPath = "ROOT\\CIMV2:Win32_OperatingSystem";
            strPath = (strPath 
                        + (".Name=" 
                        + ("\"" 
                        + (keyName + "\""))));
            return strPath;
        }
        
        // Different flavours of GetInstances() help in enumerating instances of the WMI class.
        public static OperatingSystemCollection GetInstances() {
            return GetInstances(((System.Management.ManagementScope)(null)), ((System.Management.EnumerationOptions)(null)));
        }
        
        public static OperatingSystemCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static OperatingSystemCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static OperatingSystemCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static OperatingSystemCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
            if ((mgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = "root\\CIMV2";
            }
            System.Management.ManagementPath pathObj = new System.Management.ManagementPath();
            pathObj.ClassName = "Win32_OperatingSystem";
            pathObj.NamespacePath = "root\\CIMV2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new OperatingSystemCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static OperatingSystemCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static OperatingSystemCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static OperatingSystemCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = "root\\CIMV2";
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_OperatingSystem", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new OperatingSystemCollection(ObjectSearcher.Get());
        }
        
        public System.UInt32 Reboot() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                bool EnablePrivileges = PrivateLateBoundObject.Scope.Options.EnablePrivileges;
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = true;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Reboot", inParams, null);
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = EnablePrivileges;
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public System.UInt32 SetDateTime(System.DateTime LocalDateTime) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                bool EnablePrivileges = PrivateLateBoundObject.Scope.Options.EnablePrivileges;
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = true;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetDateTime");
                inParams["LocalDateTime"] = ToDMTFTime(((System.DateTime)(LocalDateTime)));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetDateTime", inParams, null);
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = EnablePrivileges;
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public System.UInt32 Shutdown() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                bool EnablePrivileges = PrivateLateBoundObject.Scope.Options.EnablePrivileges;
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = true;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Shutdown", inParams, null);
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = EnablePrivileges;
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public System.UInt32 Win32Shutdown(int Flags, int Reserved) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                bool EnablePrivileges = PrivateLateBoundObject.Scope.Options.EnablePrivileges;
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = true;
                inParams = PrivateLateBoundObject.GetMethodParameters("Win32Shutdown");
                inParams["Flags"] = Flags;
                inParams["Reserved"] = Reserved;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Win32Shutdown", inParams, null);
                PrivateLateBoundObject.Scope.Options.EnablePrivileges = EnablePrivileges;
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public enum EncryptionLevelValues : int {
            
            Val_40_bit,
            
            Val_128_bit,
            
            n_bit,
        }
        
        public enum ForegroundApplicationBoostValues : int {
            
            None,
            
            Minimum,
            
            Maximum,
        }
        
        public enum LargeSystemCacheValues : long {
            
            Optimize_for_Applications = 0,
            
            Optimize_for_System_Performance = 1,
        }
        
        public enum OSProductSuiteValues : int {
            
            Small_Business = 1,
            
            Enterprise = 2,
            
            BackOffice = 4,
            
            Communication_Server = 8,
            
            Terminal_Server = 16,
            
            Small_Business_Restricted_ = 32,
            
            Embedded_NT = 64,
            
            Data_Center = 128,
        }
        
        public enum OSTypeValues : int {
            
            Unknown,
            
            Other,
            
            MACOS,
            
            ATTUNIX,
            
            DGUX,
            
            DECNT,
            
            Digital_Unix,
            
            OpenVMS,
            
            HPUX,
            
            AIX,
            
            MVS,
            
            OS400,
            
            OS_2,
            
            JavaVM,
            
            MSDOS,
            
            WIN3x,
            
            WIN95,
            
            WIN98,
            
            WINNT,
            
            WINCE,
            
            NCR3000,
            
            NetWare,
            
            OSF,
            
            DC_OS,
            
            Reliant_UNIX,
            
            SCO_UnixWare,
            
            SCO_OpenServer,
            
            Sequent,
            
            IRIX,
            
            Solaris,
            
            SunOS,
            
            U6000,
            
            ASERIES,
            
            TandemNSK,
            
            TandemNT,
            
            BS2000,
            
            LINUX,
            
            Lynx,
            
            XENIX,
            
            VM_ESA,
            
            Interactive_UNIX,
            
            BSDUNIX,
            
            FreeBSD,
            
            NetBSD,
            
            GNU_Hurd,
            
            OS9,
            
            MACH_Kernel,
            
            Inferno,
            
            QNX,
            
            EPOC,
            
            IxWorks,
            
            VxWorks,
            
            MiNT,
            
            BeOS,
            
            HP_MPE,
            
            NextStep,
            
            PalmPilot,
            
            Rhapsody,
            
            Windows_2000,
            
            Dedicated,
            
            OS_390,
            
            VSE,
            
            TPF,
        }
        
        public enum ProductTypeValues : long {
            
            Work_Station = 1,
            
            Domain_Controller = 2,
            
            Server = 3,
            
            INVALID_ENUM_VALUE = 0,
        }
        
        public enum QuantumLengthValues : int {
            
            Unknown,
            
            One_tick,
            
            Two_ticks,
        }
        
        public enum QuantumTypeValues : int {
            
            Unknown,
            
            Fixed,
            
            Variable,
        }
        
        public enum SuiteMaskValues : int {
            
            Small_Business = 1,
            
            Enterprise = 2,
            
            Backoffice = 4,
            
            Communications = 8,
            
            Terminal = 16,
            
            Smallbusiness_Restricted = 32,
            
            Embedded_NT = 64,
            
            Data_Center = 128,
            
            Singe_User = 256,
            
            Personal = 512,
            
            Blade = 1024,
            
            NT_Work_Station = 2048,
            
            NT_Server = 4096,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class OperatingSystemCollection : object, ICollection {
            
            private ManagementObjectCollection ObjectCollection;
            
            public OperatingSystemCollection(ManagementObjectCollection objCollection) {
                ObjectCollection = objCollection;
            }
            
            public int Count {
                get {
                    return ObjectCollection.Count;
                }
            }
            
            public bool IsSynchronized {
                get {
                    return ObjectCollection.IsSynchronized;
                }
            }
            
            public object SyncRoot {
                get {
                    return this;
                }
            }
            
            public void CopyTo(System.Array array, int index) {
                ObjectCollection.CopyTo(array, index);
                int nCtr;
                for (nCtr = 0; (nCtr < array.Length); nCtr = (nCtr + 1)) {
                    array.SetValue(new OperatingSystem(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return new OperatingSystemEnumerator(ObjectCollection.GetEnumerator());
            }
            
            public class OperatingSystemEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator ObjectEnumerator;
                
                public OperatingSystemEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    ObjectEnumerator = objEnum;
                }
                
                public object Current {
                    get {
                        return new OperatingSystem(((System.Management.ManagementObject)(ObjectEnumerator.Current)));
                    }
                }
                
                public bool MoveNext() {
                    return ObjectEnumerator.MoveNext();
                }
                
                public void Reset() {
                    ObjectEnumerator.Reset();
                }
            }
        }
        
        // TypeConverter to handle null values for ValueType properties
        public class WMIValueTypeConverter : TypeConverter {
            
            private TypeConverter baseConverter;
            
            public WMIValueTypeConverter(System.Type baseType) {
                baseConverter = TypeDescriptor.GetConverter(baseType);
            }
            
            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type srcType) {
                return baseConverter.CanConvertFrom(context, srcType);
            }
            
            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) {
                return baseConverter.CanConvertTo(context, destinationType);
            }
            
            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
                return baseConverter.ConvertFrom(context, culture, value);
            }
            
            public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary dictionary) {
                return baseConverter.CreateInstance(context, dictionary);
            }
            
            public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetCreateInstanceSupported(context);
            }
            
            public override PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributeVar) {
                return baseConverter.GetProperties(context, value, attributeVar);
            }
            
            public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetPropertiesSupported(context);
            }
            
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValues(context);
            }
            
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesExclusive(context);
            }
            
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesSupported(context);
            }
            
            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) {
                if ((context != null)) {
                    if ((context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false)) {
                        return "";
                    }
                }
                return baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }
        
        // Embedded class to represent WMI system Properties.
        [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public class ManagementSystemProperties {
            
            private System.Management.ManagementBaseObject PrivateLateBoundObject;
            
            public ManagementSystemProperties(System.Management.ManagementBaseObject ManagedObject) {
                PrivateLateBoundObject = ManagedObject;
            }
            
            [Browsable(true)]
            public int GENUS {
                get {
                    return ((int)(PrivateLateBoundObject["__GENUS"]));
                }
            }
            
            [Browsable(true)]
            public string CLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__CLASS"]));
                }
            }
            
            [Browsable(true)]
            public string SUPERCLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__SUPERCLASS"]));
                }
            }
            
            [Browsable(true)]
            public string DYNASTY {
                get {
                    return ((string)(PrivateLateBoundObject["__DYNASTY"]));
                }
            }
            
            [Browsable(true)]
            public string RELPATH {
                get {
                    return ((string)(PrivateLateBoundObject["__RELPATH"]));
                }
            }
            
            [Browsable(true)]
            public int PROPERTY_COUNT {
                get {
                    return ((int)(PrivateLateBoundObject["__PROPERTY_COUNT"]));
                }
            }
            
            [Browsable(true)]
            public string[] DERIVATION {
                get {
                    return ((string[])(PrivateLateBoundObject["__DERIVATION"]));
                }
            }
            
            [Browsable(true)]
            public string SERVER {
                get {
                    return ((string)(PrivateLateBoundObject["__SERVER"]));
                }
            }
            
            [Browsable(true)]
            public string NAMESPACE {
                get {
                    return ((string)(PrivateLateBoundObject["__NAMESPACE"]));
                }
            }
            
            [Browsable(true)]
            public string PATH {
                get {
                    return ((string)(PrivateLateBoundObject["__PATH"]));
                }
            }
        }
    }
}
