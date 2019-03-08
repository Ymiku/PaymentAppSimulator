//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_user_guide_trigger_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"USER_GUIDE_TRIGGER_CONF")]
  public partial class USER_GUIDE_TRIGGER_CONF : global::ProtoBuf.IExtensible
  {
    public USER_GUIDE_TRIGGER_CONF() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private dataconfig.UserGuideTriggerType _type = dataconfig.UserGuideTriggerType.NONE;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(dataconfig.UserGuideTriggerType.NONE)]
    public dataconfig.UserGuideTriggerType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _step = (uint)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"step", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint step
    {
      get { return _step; }
      set { _step = value; }
    }
    private string _arenaType = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"arenaType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string arenaType
    {
      get { return _arenaType; }
      set { _arenaType = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _subType = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(5, Name=@"subType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> subType
    {
      get { return _subType; }
    }
  
    private dataconfig.ProtoFScalar _paramValue = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"paramValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar paramValue
    {
      get { return _paramValue; }
      set { _paramValue = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _killNum = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"killNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> killNum
    {
      get { return _killNum; }
    }
  
    private readonly global::System.Collections.Generic.List<dataconfig.ProtoFScalar> _pos = new global::System.Collections.Generic.List<dataconfig.ProtoFScalar>();
    [global::ProtoBuf.ProtoMember(8, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.ProtoFScalar> pos
    {
      get { return _pos; }
    }
  
    private dataconfig.ProtoFScalar _distance = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"distance", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar distance
    {
      get { return _distance; }
      set { _distance = value; }
    }
    private bool _closeAutoBuy = (bool)false;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"closeAutoBuy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool closeAutoBuy
    {
      get { return _closeAutoBuy; }
      set { _closeAutoBuy = value; }
    }
    private uint _repeatNum = (uint)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"repeatNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint repeatNum
    {
      get { return _repeatNum; }
      set { _repeatNum = value; }
    }
    private bool _finishByKill = (bool)false;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"finishByKill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool finishByKill
    {
      get { return _finishByKill; }
      set { _finishByKill = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"USER_GUIDE_TRIGGER_CONF_ARRAY")]
  public partial class USER_GUIDE_TRIGGER_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public USER_GUIDE_TRIGGER_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.USER_GUIDE_TRIGGER_CONF> _items = new global::System.Collections.Generic.List<dataconfig.USER_GUIDE_TRIGGER_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.USER_GUIDE_TRIGGER_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}