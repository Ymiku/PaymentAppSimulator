//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_arena_mode_maptype_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARENA_MODE_MAPTYPE_CONF")]
  public partial class ARENA_MODE_MAPTYPE_CONF : global::ProtoBuf.IExtensible
  {
    public ARENA_MODE_MAPTYPE_CONF() {}
    
    private string _id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARENA_MODE_MAPTYPE_CONF_ARRAY")]
  public partial class ARENA_MODE_MAPTYPE_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public ARENA_MODE_MAPTYPE_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.ARENA_MODE_MAPTYPE_CONF> _items = new global::System.Collections.Generic.List<dataconfig.ARENA_MODE_MAPTYPE_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.ARENA_MODE_MAPTYPE_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}