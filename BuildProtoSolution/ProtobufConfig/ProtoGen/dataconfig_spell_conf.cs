//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_spell_conf.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SPELL_CONF")]
  public partial class SPELL_CONF : global::ProtoBuf.IExtensible
  {
    public SPELL_CONF() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _UnlockLevel = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UnlockLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int UnlockLevel
    {
      get { return _UnlockLevel; }
      set { _UnlockLevel = value; }
    }
    private string _DisplayPic = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DisplayPic", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DisplayPic
    {
      get { return _DisplayPic; }
      set { _DisplayPic = value; }
    }
    private int _ComboAbilityId = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ComboAbilityId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int ComboAbilityId
    {
      get { return _ComboAbilityId; }
      set { _ComboAbilityId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SPELL_CONF_ARRAY")]
  public partial class SPELL_CONF_ARRAY : global::ProtoBuf.IExtensible
  {
    public SPELL_CONF_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.SPELL_CONF> _items = new global::System.Collections.Generic.List<dataconfig.SPELL_CONF>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.SPELL_CONF> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}