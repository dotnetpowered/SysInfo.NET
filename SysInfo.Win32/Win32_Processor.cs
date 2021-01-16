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
    // An Early Bound class generated for the WMI class.Win32_Processor
    public class Processor : System.ComponentModel.Component {
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_Processor";
        
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
        public Processor() : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(null)), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public Processor(string keyDeviceID) : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(new System.Management.ManagementPath(Processor.ConstructPath(keyDeviceID)))), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public Processor(System.Management.ManagementScope mgmtScope, string keyDeviceID) : 
                this(((System.Management.ManagementScope)(mgmtScope)), ((System.Management.ManagementPath)(new System.Management.ManagementPath(Processor.ConstructPath(keyDeviceID)))), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public Processor(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(path)), ((System.Management.ObjectGetOptions)(getOptions))) {
        }
        
        public Processor(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) : 
                this(((System.Management.ManagementScope)(mgmtScope)), ((System.Management.ManagementPath)(path)), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public Processor(System.Management.ManagementPath path) : 
                this(((System.Management.ManagementScope)(null)), ((System.Management.ManagementPath)(path)), ((System.Management.ObjectGetOptions)(null))) {
        }
        
        public Processor(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            if ((path != null)) {
                if ((CheckIfProperClass(mgmtScope, path, getOptions) != true)) {
                    throw new System.ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new System.Management.ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        public Processor(System.Management.ManagementObject theObject) {
            if ((CheckIfProperClass(theObject.Scope, theObject.Path, theObject.Options) == true)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        public Processor(System.Management.ManagementBaseObject theObject) {
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
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAddressWidthNull {
            get {
                if ((curObj["AddressWidth"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Processor address width in bits.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 AddressWidth {
            get {
                if ((curObj["AddressWidth"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["AddressWidth"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsArchitectureNull {
            get {
                if ((curObj["Architecture"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Architecture property specifies the processor architecture used by this platf" +
"orm. It returns one of the following \t\tinteger values:\n0 - x86 \n1 - MIPS \n2 - Al" +
"pha \n3 - PowerPC \n6 - ia64 ")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ArchitectureValues Architecture {
            get {
                if ((curObj["Architecture"] == null)) {
                    return ((ArchitectureValues)(System.Convert.ToInt32(0)));
                }
                return ((ArchitectureValues)(Convert.ToInt32(curObj["Architecture"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAvailabilityNull {
            get {
                if ((curObj["Availability"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The availability and status of the device.  For example, the Availability property indicates that the device is running and has full power (value=3), or is in a warning (4), test (5), degraded (10) or power save state (values 13-15 and 17). Regarding the power saving states, these are defined as follows: Value 13 (""Power Save - Unknown"") indicates that the device is known to be in a power save mode, but its exact status in this mode is unknown; 14 (""Power Save - Low Power Mode"") indicates that the device is in a power save state but still functioning, and may exhibit degraded performance; 15 (""Power Save - Standby"") describes that the device is not functioning but could be brought to full power 'quickly'; and value 17 (""Power Save - Warning"") indicates that the device is in a warning state, though also in a power save mode.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public AvailabilityValues Availability {
            get {
                if ((curObj["Availability"] == null)) {
                    return ((AvailabilityValues)(System.Convert.ToInt32(0)));
                }
                return ((AvailabilityValues)(Convert.ToInt32(curObj["Availability"])));
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
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerErrorCodeNull {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the Win32 Configuration Manager error code.  The following values may b" +
"e returned: \n0\tThis device is working properly. \n1\tThis device is not configured" +
" correctly. \n2\tWindows cannot load the driver for this device. \n3\tThe driver for" +
" this device might be corrupted, or your system may be running low on memory or " +
"other resources. \n4\tThis device is not working properly. One of its drivers or y" +
"our registry might be corrupted. \n5\tThe driver for this device needs a resource " +
"that Windows cannot manage. \n6\tThe boot configuration for this device conflicts " +
"with other devices. \n7\tCannot filter. \n8\tThe driver loader for the device is mis" +
"sing. \n9\tThis device is not working properly because the controlling firmware is" +
" reporting the resources for the device incorrectly. \n10\tThis device cannot star" +
"t. \n11\tThis device failed. \n12\tThis device cannot find enough free resources tha" +
"t it can use. \n13\tWindows cannot verify this device\'s resources. \n14\tThis device" +
" cannot work properly until you restart your computer. \n15\tThis device is not wo" +
"rking properly because there is probably a re-enumeration problem. \n16\tWindows c" +
"annot identify all the resources this device uses. \n17\tThis device is asking for" +
" an unknown resource type. \n18\tReinstall the drivers for this device. \n19\tYour r" +
"egistry might be corrupted. \n20\tFailure using the VxD loader. \n21\tSystem failure" +
": Try changing the driver for this device. If that does not work, see your hardw" +
"are documentation. Windows is removing this device. \n22\tThis device is disabled." +
" \n23\tSystem failure: Try changing the driver for this device. If that doesn\'t wo" +
"rk, see your hardware documentation. \n24\tThis device is not present, is not work" +
"ing properly, or does not have all its drivers installed. \n25\tWindows is still s" +
"etting up this device. \n26\tWindows is still setting up this device. \n27\tThis dev" +
"ice does not have valid log configuration. \n28\tThe drivers for this device are n" +
"ot installed. \n29\tThis device is disabled because the firmware of the device did" +
" not give it the required resources. \n30\tThis device is using an Interrupt Reque" +
"st (IRQ) resource that another device is using. \n31\tThis device is not working p" +
"roperly because Windows cannot load the drivers required for this device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ConfigManagerErrorCodeValues ConfigManagerErrorCode {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt64(0)));
                }
                return ((ConfigManagerErrorCodeValues)(Convert.ToInt64(curObj["ConfigManagerErrorCode"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerUserConfigNull {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates whether the device is using a user-defined configuration.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ConfigManagerUserConfig {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ConfigManagerUserConfig"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCpuStatusNull {
            get {
                if ((curObj["CpuStatus"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The CpuStatus property specifies the current status of the processor. Changes in " +
"status arise from processor usage, not the physical condition of the processor.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public CpuStatusValues CpuStatus {
            get {
                if ((curObj["CpuStatus"] == null)) {
                    return ((CpuStatusValues)(System.Convert.ToInt32(0)));
                }
                return ((CpuStatusValues)(Convert.ToInt32(curObj["CpuStatus"])));
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
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentClockSpeedNull {
            get {
                if ((curObj["CurrentClockSpeed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The current speed (in MHz) of this processor.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 CurrentClockSpeed {
            get {
                if ((curObj["CurrentClockSpeed"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["CurrentClockSpeed"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentVoltageNull {
            get {
                if ((curObj["CurrentVoltage"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The CurrentVoltage specifies the voltage of the processor. Bits 0-6 of the field contain the processor's current voltage times 10. This value is only set when SMBIOS designates a voltage value. For specific values, see VoltageCaps.
Example: field value for a processor voltage of 1.8 volts would be 92h = 80h + (1.8 x 10) = 80h + 18 = 80h + 12h.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 CurrentVoltage {
            get {
                if ((curObj["CurrentVoltage"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["CurrentVoltage"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDataWidthNull {
            get {
                if ((curObj["DataWidth"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Processor data width in bits.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 DataWidth {
            get {
                if ((curObj["DataWidth"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["DataWidth"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Description property provides a textual description of the object. ")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DeviceID property contains a string uniquely identifying the processor with o" +
"ther devices on the system.")]
        public string DeviceID {
            get {
                return ((string)(curObj["DeviceID"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsErrorClearedNull {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorCleared is a boolean property indicating that the error reported in LastErro" +
"rCode property is now cleared.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ErrorCleared {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ErrorCleared"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorDescription is a free-form string supplying more information about the error" +
" recorded in LastErrorCode property, and information on any corrective actions t" +
"hat may be taken.")]
        public string ErrorDescription {
            get {
                return ((string)(curObj["ErrorDescription"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsExtClockNull {
            get {
                if ((curObj["ExtClock"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ExtClock property specifies the external clock frequency. If the frequency is" +
" unknown this property is set to null.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 ExtClock {
            get {
                if ((curObj["ExtClock"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["ExtClock"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFamilyNull {
            get {
                if ((curObj["Family"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The processor family type. For example, values include \"Pentium(R) processor with" +
" MMX(TM) technology\" (14) and \"68040\" (96).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public FamilyValues Family {
            get {
                if ((curObj["Family"] == null)) {
                    return ((FamilyValues)(System.Convert.ToInt32(0)));
                }
                return ((FamilyValues)(Convert.ToInt32(curObj["Family"])));
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
        public bool IsL2CacheSizeNull {
            get {
                if ((curObj["L2CacheSize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The L2CacheSize property specifies the size of the processor\'s Level 2 cache. A L" +
"evel 2 cache is an external memory area that has a faster access times than the " +
"main RAM memory.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 L2CacheSize {
            get {
                if ((curObj["L2CacheSize"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["L2CacheSize"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsL2CacheSpeedNull {
            get {
                if ((curObj["L2CacheSpeed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The L2CacheSpeed property specifies the clockspeed of the processor\'s Level 2 cac" +
"he. A Level 2 cache is an external memory area that has a faster access times th" +
"an the main RAM memory.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 L2CacheSpeed {
            get {
                if ((curObj["L2CacheSpeed"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["L2CacheSpeed"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLastErrorCodeNull {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("LastErrorCode captures the last error code reported by the logical device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 LastErrorCode {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["LastErrorCode"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLevelNull {
            get {
                if ((curObj["Level"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Level property further defines the processor type. The value  depends on the " +
"architecture of the processor.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 Level {
            get {
                if ((curObj["Level"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["Level"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLoadPercentageNull {
            get {
                if ((curObj["LoadPercentage"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The LoadPercentage property specifies each processor\'s load capacity averaged ove" +
"r the last second. The term \'processor loading\' refers to the total computing bu" +
"rden each processor carries at one time.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 LoadPercentage {
            get {
                if ((curObj["LoadPercentage"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["LoadPercentage"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Manufacturer property specifies the name of the processor\'s manufacturer.\nExa" +
"mple: GenuineSilicon")]
        public string Manufacturer {
            get {
                return ((string)(curObj["Manufacturer"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxClockSpeedNull {
            get {
                if ((curObj["MaxClockSpeed"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The maximum speed (in MHz) of this processor.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt32 MaxClockSpeed {
            get {
                if ((curObj["MaxClockSpeed"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((System.UInt32)(curObj["MaxClockSpeed"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Name property defines the label by which the object is known. When subclassed" +
", the Name property can be overridden to be a Key property.")]
        public string Name {
            get {
                return ((string)(curObj["Name"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A string describing the processor family type - used when the family property is " +
"set to 1 (\"Other\"). This string should be set to NULL when the family property i" +
"s any value other than 1.")]
        public string OtherFamilyDescription {
            get {
                return ((string)(curObj["OtherFamilyDescription"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the Win32 Plug and Play device ID of the logical device.  Example: *PNP" +
"030b")]
        public string PNPDeviceID {
            get {
                return ((string)(curObj["PNPDeviceID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Indicates the specific power-related capabilities of the logical device. The array values, 0=""Unknown"", 1=""Not Supported"" and 2=""Disabled"" are self-explanatory. The value, 3=""Enabled"" indicates that the power management features are currently enabled but the exact feature set is unknown or the information is unavailable. ""Power Saving Modes Entered Automatically"" (4) describes that a device can change its power state based on usage or other criteria. ""Power State Settable"" (5) indicates that the SetPowerState method is supported. ""Power Cycling Supported"" (6) indicates that the SetPowerState method can be invoked with the PowerState input variable set to 5 (""Power Cycle""). ""Timed Power On Supported"" (7) indicates that the SetPowerState method can be invoked with the PowerState input variable set to 5 (""Power Cycle"") and the Time parameter set to a specific date and time, or interval, for power-on.")]
        public PowerManagementCapabilitiesValues[] PowerManagementCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["PowerManagementCapabilities"]));
                PowerManagementCapabilitiesValues[] enumToRet = new PowerManagementCapabilitiesValues[arrEnumVals.Length];
                Int32 counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((PowerManagementCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPowerManagementSupportedNull {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Boolean indicating that the Device can be power managed - ie, put into a power save state. This boolean does not indicate that power management features are currently enabled, or if enabled, what features are supported. Refer to the PowerManagementCapabilities array for this information. If this boolean is false, the integer value 1, for the string, ""Not Supported"", should be the only entry in the PowerManagementCapabilities array.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PowerManagementSupported {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PowerManagementSupported"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ProcessorId property contains processor-specific information that describes the processor's features. For x86 class CPUs, the field's format depends on the processor's support of the CPUID instruction. If the instruction is supported, the ProcessorId property contains two DWORD-formatted values. The first (offsets 08h-0Bh) is the EAX value returned by a CPUID instruction with input EAX set to 1. The second (offsets 0Ch-0Fh) is the EDX value returned by that instruction. Only the first two bytes of the ProcessorID property are significant (all others are set to 0) and contain (in WORD-format) the contents of the DX register at CPU reset.")]
        public string ProcessorId {
            get {
                return ((string)(curObj["ProcessorId"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsProcessorTypeNull {
            get {
                if ((curObj["ProcessorType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ProcessorType property specifies the processor\'s primary function.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ProcessorTypeValues ProcessorType {
            get {
                if ((curObj["ProcessorType"] == null)) {
                    return ((ProcessorTypeValues)(System.Convert.ToInt32(0)));
                }
                return ((ProcessorTypeValues)(Convert.ToInt32(curObj["ProcessorType"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRevisionNull {
            get {
                if ((curObj["Revision"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Revision property specifies the system\'s architecture-dependent revision leve" +
"l. The meaning of this value depends on the architecture of the processor. It co" +
"ntains the same values as the \"Version\" member, but in a numerical format.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.UInt16 Revision {
            get {
                if ((curObj["Revision"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((System.UInt16)(curObj["Revision"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A free form string describing the role of the processor - for example, \"Central P" +
"rocessor\"\' or \"Math Processor\"")]
        public string Role {
            get {
                return ((string)(curObj["Role"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SocketDesignation property contains the type of chip socket used on the circu" +
"it.\nExample: J202")]
        public string SocketDesignation {
            get {
                return ((string)(curObj["SocketDesignation"]));
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
        public bool IsStatusInfoNull {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("StatusInfo is a string indicating whether the logical device is in an enabled (va" +
"lue = 3), disabled (value = 4) or some other (1) or unknown (2) state. If this p" +
"roperty does not apply to the logical device, the value, 5 (\"Not Applicable\"), s" +
"hould be used.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public StatusInfoValues StatusInfo {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return ((StatusInfoValues)(System.Convert.ToInt32(0)));
                }
                return ((StatusInfoValues)(Convert.ToInt32(curObj["StatusInfo"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Stepping is a free-form string indicating the revision level of the processor wit" +
"hin the processor family.")]
        public string Stepping {
            get {
                return ((string)(curObj["Stepping"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The scoping System\'s CreationClassName.")]
        public string SystemCreationClassName {
            get {
                return ((string)(curObj["SystemCreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The scoping System\'s Name.")]
        public string SystemName {
            get {
                return ((string)(curObj["SystemName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A globally unique identifier for the processor.  This identifier may only be uniq" +
"ue within a processor family.")]
        public string UniqueId {
            get {
                return ((string)(curObj["UniqueId"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsUpgradeMethodNull {
            get {
                if ((curObj["UpgradeMethod"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CPU socket information including data on how this Processor can be upgraded (if u" +
"pgrades are supported). This property is an integer enumeration.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public UpgradeMethodValues UpgradeMethod {
            get {
                if ((curObj["UpgradeMethod"] == null)) {
                    return ((UpgradeMethodValues)(System.Convert.ToInt32(0)));
                }
                return ((UpgradeMethodValues)(Convert.ToInt32(curObj["UpgradeMethod"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Version property specifies an architecture-dependent processor revision numbe" +
"r. Note: This member is not used in Windows 95.\nExample: Model 2, Stepping 12.")]
        public string Version {
            get {
                return ((string)(curObj["Version"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsVoltageCapsNull {
            get {
                if ((curObj["VoltageCaps"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The VoltageCaps property specifies the voltage capabilities of the processor. Bits 0-3 of the field represent specific voltages that the processor socket can accept. All other bits should be set to zero. The socket is configurable if multiple bits are being set. For a range of voltages see CurrentVoltage. If the property is NULL, then the voltage capabilities are unknown.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public VoltageCapsValues VoltageCaps {
            get {
                if ((curObj["VoltageCaps"] == null)) {
                    return ((VoltageCapsValues)(System.Convert.ToInt32(0)));
                }
                return ((VoltageCapsValues)(Convert.ToInt32(curObj["VoltageCaps"])));
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
        
        private bool ShouldSerializeAddressWidth() {
            if ((IsAddressWidthNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeArchitecture() {
            if ((IsArchitectureNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeAvailability() {
            if ((IsAvailabilityNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerErrorCode() {
            if ((IsConfigManagerErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerUserConfig() {
            if ((IsConfigManagerUserConfigNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCpuStatus() {
            if ((IsCpuStatusNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentClockSpeed() {
            if ((IsCurrentClockSpeedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentVoltage() {
            if ((IsCurrentVoltageNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDataWidth() {
            if ((IsDataWidthNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeErrorCleared() {
            if ((IsErrorClearedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeExtClock() {
            if ((IsExtClockNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeFamily() {
            if ((IsFamilyNull == false)) {
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
        
        static string ToDMTFTime(DateTime dateParam) {
            string tempString = dateParam.Year.ToString();
            tempString = (tempString + dateParam.Month.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Day.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Hour.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Minute.ToString().PadLeft(2, '0'));
            tempString = (tempString + dateParam.Second.ToString().PadLeft(2, '0'));
            tempString = (tempString + ".");
            tempString = (tempString + dateParam.Millisecond.ToString().PadLeft(3, '0'));
            tempString = (tempString + "000");
            TimeZoneInfo curZone = TimeZoneInfo.Local;
            TimeSpan tickOffset = curZone.GetUtcOffset(dateParam);
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
        
        private bool ShouldSerializeL2CacheSize() {
            if ((IsL2CacheSizeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeL2CacheSpeed() {
            if ((IsL2CacheSpeedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLastErrorCode() {
            if ((IsLastErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLevel() {
            if ((IsLevelNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLoadPercentage() {
            if ((IsLoadPercentageNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxClockSpeed() {
            if ((IsMaxClockSpeedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePowerManagementSupported() {
            if ((IsPowerManagementSupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeProcessorType() {
            if ((IsProcessorTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeRevision() {
            if ((IsRevisionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeStatusInfo() {
            if ((IsStatusInfoNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeUpgradeMethod() {
            if ((IsUpgradeMethodNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeVoltageCaps() {
            if ((IsVoltageCapsNull == false)) {
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
        
        private static string ConstructPath(string keyDeviceID) {
            string strPath = "ROOT\\CIMV2:Win32_Processor";
            strPath = (strPath 
                        + (".DeviceID=" 
                        + ("\"" 
                        + (keyDeviceID + "\""))));
            return strPath;
        }
        
        // Different flavours of GetInstances() help in enumerating instances of the WMI class.
        public static ProcessorCollection GetInstances() {
            return GetInstances(((System.Management.ManagementScope)(null)), ((System.Management.EnumerationOptions)(null)));
        }
        
        public static ProcessorCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static ProcessorCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static ProcessorCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static ProcessorCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
            if ((mgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = "root\\CIMV2";
            }
            System.Management.ManagementPath pathObj = new System.Management.ManagementPath();
            pathObj.ClassName = "Win32_Processor";
            pathObj.NamespacePath = "root\\CIMV2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new ProcessorCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static ProcessorCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static ProcessorCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static ProcessorCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = "root\\CIMV2";
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_Processor", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new ProcessorCollection(ObjectSearcher.Get());
        }
        
        public System.UInt32 Reset() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Reset", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public System.UInt32 SetPowerState(System.UInt16 PowerState, System.DateTime Time) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetPowerState");
                inParams["PowerState"] = PowerState;
                inParams["Time"] = ToDMTFTime(((System.DateTime)(Time)));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetPowerState", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public enum ArchitectureValues : int {
            
            x86 = 0,
            
            MIPS = 1,
            
            Alpha = 2,
            
            PowerPC = 3,
            
            ia64 = 6,
        }
        
        public enum AvailabilityValues : int {
            
            Other = 1,
            
            Unknown = 2,
            
            Running_Full_Power = 3,
            
            Warning = 4,
            
            In_Test = 5,
            
            Not_Applicable = 6,
            
            Power_Off = 7,
            
            Off_Line = 8,
            
            Off_Duty = 9,
            
            Degraded = 10,
            
            Not_Installed = 11,
            
            Install_Error = 12,
            
            Power_Save_Unknown = 13,
            
            Power_Save_Low_Power_Mode = 14,
            
            Power_Save_Standby = 15,
            
            Power_Cycle = 16,
            
            Power_Save_Warning = 17,
            
            Paused = 18,
            
            Not_Ready = 19,
            
            Not_Configured = 20,
            
            Quiesced = 21,
            
            INVALID_ENUM_VALUE = 0,
        }
        
        public enum ConfigManagerErrorCodeValues : long {
            
            This_device_is_working_properly_ = 0,
            
            This_device_is_not_configured_correctly_ = 1,
            
            Windows_cannot_load_the_driver_for_this_device_ = 2,
            
            The_driver_for_this_device_might_be_corrupted_or_your_system_may_be_running_low_on_memory_or_other_resources_ = 3,
            
            This_device_is_not_working_properly_One_of_its_drivers_or_your_registry_might_be_corrupted_ = 4,
            
            The_driver_for_this_device_needs_a_resource_that_Windows_cannot_manage_ = 5,
            
            The_boot_configuration_for_this_device_conflicts_with_other_devices_ = 6,
            
            Cannot_filter_ = 7,
            
            The_driver_loader_for_the_device_is_missing_ = 8,
            
            This_device_is_not_working_properly_because_the_controlling_firmware_is_reporting_the_resources_for_the_device_incorrectly_ = 9,
            
            This_device_cannot_start_ = 10,
            
            This_device_failed_ = 11,
            
            This_device_cannot_find_enough_free_resources_that_it_can_use_ = 12,
            
            Windows_cannot_verify_this_device_s_resources_ = 13,
            
            This_device_cannot_work_properly_until_you_restart_your_computer_ = 14,
            
            This_device_is_not_working_properly_because_there_is_probably_a_re_enumeration_problem_ = 15,
            
            Windows_cannot_identify_all_the_resources_this_device_uses_ = 16,
            
            This_device_is_asking_for_an_unknown_resource_type_ = 17,
            
            Reinstall_the_drivers_for_this_device_ = 18,
            
            Failure_using_the_VxD_loader_ = 19,
            
            Your_registry_might_be_corrupted_ = 20,
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_does_not_work_see_your_hardware_documentation_Windows_is_removing_this_device_ = 21,
            
            This_device_is_disabled_ = 22,
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_doesn_t_work_see_your_hardware_documentation_ = 23,
            
            This_device_is_not_present_is_not_working_properly_or_does_not_have_all_its_drivers_installed_ = 24,
            
            Windows_is_still_setting_up_this_device_ = 25,
            
            Windows_is_still_setting_up_this_device_0 = 26,
            
            This_device_does_not_have_valid_log_configuration_ = 27,
            
            The_drivers_for_this_device_are_not_installed_ = 28,
            
            This_device_is_disabled_because_the_firmware_of_the_device_did_not_give_it_the_required_resources_ = 29,
            
            This_device_is_using_an_Interrupt_Request_IRQ_resource_that_another_device_is_using_ = 30,
            
            This_device_is_not_working_properly_because_Windows_cannot_load_the_drivers_required_for_this_device_ = 31,
        }
        
        public enum CpuStatusValues : int {
            
            Unknown,
            
            CPU_Enabled,
            
            CPU_Disabled_by_User_via_BIOS_Setup,
            
            CPU_Disabled_By_BIOS_POST_Error_,
            
            CPU_is_Idle,
            
            Reserved,
            
            Reserved0,
            
            Other,
        }
        
        public enum FamilyValues : int {
            
            Other = 1,
            
            Unknown = 2,
            
            Val_8086 = 3,
            
            Val_80286 = 4,
            
            Val_80386 = 5,
            
            Val_80486 = 6,
            
            Val_8087 = 7,
            
            Val_80287 = 8,
            
            Val_80387 = 9,
            
            Val_80487 = 10,
            
            Pentium_Family = 11,
            
            Pentium_Pro = 12,
            
            Pentium_II = 13,
            
            Pentium_MMX = 14,
            
            Celeron = 15,
            
            Pentium_II_Xeon = 16,
            
            Pentium_III = 17,
            
            M1_Family = 18,
            
            M2_Family = 19,
            
            K5_Family = 25,
            
            K6_Family = 26,
            
            K6_2 = 27,
            
            K6_III = 28,
            
            Athlon = 29,
            
            Power_PC_Family = 32,
            
            Power_PC_601 = 33,
            
            Power_PC_603 = 34,
            
            Power_PC_603_ = 35,
            
            Power_PC_604 = 36,
            
            Alpha_Family = 48,
            
            MIPS_Family = 64,
            
            SPARC_Family = 80,
            
            Val_68040 = 96,
            
            Val_68xxx_Family = 97,
            
            Val_68000 = 98,
            
            Val_68010 = 99,
            
            Val_68020 = 100,
            
            Val_68030 = 101,
            
            Hobbit_Family = 112,
            
            Weitek = 128,
            
            PA_RISC_Family = 144,
            
            V30_Family = 160,
            
            Pentium_III_Xeon = 176,
            
            AS400_Family = 180,
            
            IBM390_Family = 200,
            
            i860 = 250,
            
            i960 = 251,
            
            SH_3 = 260,
            
            SH_4 = 261,
            
            ARM = 280,
            
            StrongARM = 281,
            
            Val_6x86 = 300,
            
            MediaGX = 301,
            
            MII = 302,
            
            WinChip = 320,
            
            INVALID_ENUM_VALUE = 0,
        }
        
        public enum PowerManagementCapabilitiesValues : int {
            
            Unknown,
            
            Not_Supported,
            
            Disabled,
            
            Enabled,
            
            Power_Saving_Modes_Entered_Automatically,
            
            Power_State_Settable,
            
            Power_Cycling_Supported,
            
            Timed_Power_On_Supported,
        }
        
        public enum ProcessorTypeValues : int {
            
            Other = 1,
            
            Unknown = 2,
            
            Central_Processor = 3,
            
            Math_Processor = 4,
            
            DSP_Processor = 5,
            
            Video_Processor = 6,
            
            INVALID_ENUM_VALUE = 0,
        }
        
        public enum StatusInfoValues : int {
            
            Other = 1,
            
            Unknown = 2,
            
            Enabled = 3,
            
            Disabled = 4,
            
            Not_Applicable = 5,
            
            INVALID_ENUM_VALUE = 0,
        }
        
        public enum UpgradeMethodValues : int {
            
            Other = 1,
            
            Unknown = 2,
            
            Daughter_Board = 3,
            
            ZIF_Socket = 4,
            
            Replacement_Piggy_Back = 5,
            
            None = 6,
            
            LIF_Socket = 7,
            
            Slot_1 = 8,
            
            Slot_2 = 9,
            
            Val_370_Pin_Socket = 10,
            
            Slot_A = 11,
            
            Slot_M = 12,
            
            INVALID_ENUM_VALUE = 0,
        }
        
        public enum VoltageCapsValues : int {
            
            Val_5 = 1,
            
            Val_3_3 = 2,
            
            Val_2_9 = 4,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class ProcessorCollection : object, ICollection {
            
            private ManagementObjectCollection ObjectCollection;
            
            public ProcessorCollection(ManagementObjectCollection objCollection) {
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
                    array.SetValue(new Processor(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return new ProcessorEnumerator(ObjectCollection.GetEnumerator());
            }
            
            public class ProcessorEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator ObjectEnumerator;
                
                public ProcessorEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    ObjectEnumerator = objEnum;
                }
                
                public object Current {
                    get {
                        return new Processor(((System.Management.ManagementObject)(ObjectEnumerator.Current)));
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
