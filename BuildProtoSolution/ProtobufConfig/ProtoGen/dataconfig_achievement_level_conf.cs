//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_achievement_level_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ACHIEVEMENT_LEVEL_CONF")]
  public partial class ACHIEVEMENT_LEVEL_CONF : global::ProtoBuf.IExtensible
  {
    public ACHIEVEMENT_LEVEL_CONF() {}
    
    private uint _id = (uint)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _AchievementPoint = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AchievementPoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int AchievementPoint
    {
      get { return _AchievementPoint; }
      set { _AchievementPoint = value; }
    }
    private int _TaskId = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TaskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int TaskId
    {
      get { return _TaskId; }
      set { _TaskId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ACHIEVEMENT_LEVEL_CONF_ARRAY")]
  public partial class ACHIEVEMENT_LEVEL_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public ACHIEVEMENT_LEVEL_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.ACHIEVEMENT_LEVEL_CONF> _items = new global::System.Collections.Generic.List<dataconfig.ACHIEVEMENT_LEVEL_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.ACHIEVEMENT_LEVEL_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}