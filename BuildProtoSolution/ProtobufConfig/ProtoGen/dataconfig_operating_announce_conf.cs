//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_operating_announce_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OPERATING_ANNOUNCE_CONF")]
  public partial class OPERATING_ANNOUNCE_CONF : global::ProtoBuf.IExtensible
  {
    public OPERATING_ANNOUNCE_CONF() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _AnnounceTapName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AnnounceTapName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string AnnounceTapName
    {
      get { return _AnnounceTapName; }
      set { _AnnounceTapName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OPERATING_ANNOUNCE_CONF_ARRAY")]
  public partial class OPERATING_ANNOUNCE_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public OPERATING_ANNOUNCE_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.OPERATING_ANNOUNCE_CONF> _items = new global::System.Collections.Generic.List<dataconfig.OPERATING_ANNOUNCE_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.OPERATING_ANNOUNCE_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}