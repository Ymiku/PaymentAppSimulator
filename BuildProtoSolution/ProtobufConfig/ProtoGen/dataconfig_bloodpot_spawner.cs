//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_bloodpot_spawner.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BLOODPOT_SPAWNER")]
  public partial class BLOODPOT_SPAWNER : global::ProtoBuf.IExtensible
  {
    public BLOODPOT_SPAWNER() {}
    
    private uint _id = (uint)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _autoSpawn = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"autoSpawn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int autoSpawn
    {
      get { return _autoSpawn; }
      set { _autoSpawn = value; }
    }
    private dataconfig.ProtoFScalar _spawnTime = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"spawnTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar spawnTime
    {
      get { return _spawnTime; }
      set { _spawnTime = value; }
    }
    private dataconfig.ProtoFScalar _refreshTime = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"refreshTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dataconfig.ProtoFScalar refreshTime
    {
      get { return _refreshTime; }
      set { _refreshTime = value; }
    }
    private uint _buffID = (uint)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"buffID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)0)]
    public uint buffID
    {
      get { return _buffID; }
      set { _buffID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BLOODPOT_SPAWNER_ARRAY")]
  public partial class BLOODPOT_SPAWNER_ARRAY : global::ProtoBuf.IExtensible
  {
    public BLOODPOT_SPAWNER_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.BLOODPOT_SPAWNER> _items = new global::System.Collections.Generic.List<dataconfig.BLOODPOT_SPAWNER>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.BLOODPOT_SPAWNER> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}