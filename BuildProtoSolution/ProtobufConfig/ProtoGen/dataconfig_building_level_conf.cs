//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_building_level_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BUILDING_LEVEL_CONF")]
  public partial class BUILDING_LEVEL_CONF : global::ProtoBuf.IExtensible
  {
    public BUILDING_LEVEL_CONF() {}
    
    private uint _id = (uint)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private dataconfig.ProtoFScalar _level_up_interval = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level_up_interval", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar level_up_interval
    {
      get { return _level_up_interval; }
      set { _level_up_interval = value; }
    }
    private dataconfig.ProtoFScalar _level_up_beginTime = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level_up_beginTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar level_up_beginTime
    {
      get { return _level_up_beginTime; }
      set { _level_up_beginTime = value; }
    }
    private dataconfig.ProtoFScalar _level_up_endTime = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"level_up_endTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar level_up_endTime
    {
      get { return _level_up_endTime; }
      set { _level_up_endTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BUILDING_LEVEL_CONF_ARRAY")]
  public partial class BUILDING_LEVEL_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public BUILDING_LEVEL_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.BUILDING_LEVEL_CONF> _items = new global::System.Collections.Generic.List<dataconfig.BUILDING_LEVEL_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.BUILDING_LEVEL_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}