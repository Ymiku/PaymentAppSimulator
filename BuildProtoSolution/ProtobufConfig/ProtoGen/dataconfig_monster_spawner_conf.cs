//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_monster_spawner_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MONSTER_SPAWNER_CONF")]
  public partial class MONSTER_SPAWNER_CONF : global::ProtoBuf.IExtensible
  {
    public MONSTER_SPAWNER_CONF() {}
    
    private uint _id = (uint)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _monsters = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"monsters", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> monsters
    {
      get { return _monsters; }
    }
  
    private dataconfig.ProtoFScalar _spawn_time = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"spawn_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar spawn_time
    {
      get { return _spawn_time; }
      set { _spawn_time = value; }
    }
    private dataconfig.ProtoFScalar _refresh_interval = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"refresh_interval", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar refresh_interval
    {
      get { return _refresh_interval; }
      set { _refresh_interval = value; }
    }
    private dataconfig.ProtoFScalar _level_up_interval = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"level_up_interval", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar level_up_interval
    {
      get { return _level_up_interval; }
      set { _level_up_interval = value; }
    }
    private dataconfig.ProtoFScalar _level_up_beginTime = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"level_up_beginTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar level_up_beginTime
    {
      get { return _level_up_beginTime; }
      set { _level_up_beginTime = value; }
    }
    private dataconfig.ProtoFScalar _level_up_endTime = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"level_up_endTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar level_up_endTime
    {
      get { return _level_up_endTime; }
      set { _level_up_endTime = value; }
    }
    private dataconfig.ProtoFScalar _activity_range = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"activity_range", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar activity_range
    {
      get { return _activity_range; }
      set { _activity_range = value; }
    }
    private uint _ward_id = (uint)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ward_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint ward_id
    {
      get { return _ward_id; }
      set { _ward_id = value; }
    }
    private dataconfig.ProtoFScalar _ward_life = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ward_life", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar ward_life
    {
      get { return _ward_life; }
      set { _ward_life = value; }
    }
    private dataconfig.ProtoFScalar _ward_view_range = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ward_view_range", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar ward_view_range
    {
      get { return _ward_view_range; }
      set { _ward_view_range = value; }
    }
    private uint _born_effect_id = (uint)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"born_effect_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint born_effect_id
    {
      get { return _born_effect_id; }
      set { _born_effect_id = value; }
    }
    private uint _skin_effect_id = (uint)0;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"skin_effect_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint skin_effect_id
    {
      get { return _skin_effect_id; }
      set { _skin_effect_id = value; }
    }
    private int _kite_time = (int)0;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"kite_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int kite_time
    {
      get { return _kite_time; }
      set { _kite_time = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _immunity_state = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(15, Name=@"immunity_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> immunity_state
    {
      get { return _immunity_state; }
    }
  
    private uint _force_back_buff = (uint)0;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"force_back_buff", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint force_back_buff
    {
      get { return _force_back_buff; }
      set { _force_back_buff = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _drop_buff_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(17, Name=@"drop_buff_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> drop_buff_id
    {
      get { return _drop_buff_id; }
    }
  
    private uint _drop_buff_field = (uint)0;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"drop_buff_field", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint drop_buff_field
    {
      get { return _drop_buff_field; }
      set { _drop_buff_field = value; }
    }
    private dataconfig.ProtoFScalar _spawn_delay = null;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"spawn_delay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar spawn_delay
    {
      get { return _spawn_delay; }
      set { _spawn_delay = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MONSTER_SPAWNER_CONF_ARRAY")]
  public partial class MONSTER_SPAWNER_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public MONSTER_SPAWNER_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.MONSTER_SPAWNER_CONF> _items = new global::System.Collections.Generic.List<dataconfig.MONSTER_SPAWNER_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.MONSTER_SPAWNER_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}