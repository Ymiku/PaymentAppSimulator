//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_creep_spawn_rule_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CREEP_SPAWN_RULE_CONF")]
  public partial class CREEP_SPAWN_RULE_CONF : global::ProtoBuf.IExtensible
  {
    public CREEP_SPAWN_RULE_CONF() {}
    
    private uint _id = (uint)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _creep_id = (uint)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"creep_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint creep_id
    {
      get { return _creep_id; }
      set { _creep_id = value; }
    }
    private string _type = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _creep_num_zero = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"creep_num_zero", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> creep_num_zero
    {
      get { return _creep_num_zero; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _creep_num_one = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"creep_num_one", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> creep_num_one
    {
      get { return _creep_num_one; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _creep_num_three = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"creep_num_three", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> creep_num_three
    {
      get { return _creep_num_three; }
    }
  
    private dataconfig.ProtoFScalar _begin_Time = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"begin_Time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar begin_Time
    {
      get { return _begin_Time; }
      set { _begin_Time = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _wave_gap = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(8, Name=@"wave_gap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> wave_gap
    {
      get { return _wave_gap; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CREEP_SPAWN_RULE_CONF_ARRAY")]
  public partial class CREEP_SPAWN_RULE_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public CREEP_SPAWN_RULE_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.CREEP_SPAWN_RULE_CONF> _items = new global::System.Collections.Generic.List<dataconfig.CREEP_SPAWN_RULE_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.CREEP_SPAWN_RULE_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}