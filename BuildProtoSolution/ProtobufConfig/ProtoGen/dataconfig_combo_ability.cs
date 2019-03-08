//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_combo_ability.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COMBO_ABILITY")]
  public partial class COMBO_ABILITY : global::ProtoBuf.IExtensible
  {
    public COMBO_ABILITY() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
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
    private int _slot_key = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"slot_key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int slot_key
    {
      get { return _slot_key; }
      set { _slot_key = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _position = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> position
    {
      get { return _position; }
    }
  
    private string _slotLabel = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"slotLabel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string slotLabel
    {
      get { return _slotLabel; }
      set { _slotLabel = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _ability_tags = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"ability_tags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> ability_tags
    {
      get { return _ability_tags; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _icon_res = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(7, Name=@"icon_res", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> icon_res
    {
      get { return _icon_res; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _atomic_ability = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"atomic_ability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> atomic_ability
    {
      get { return _atomic_ability; }
    }
  
    private int _max_level = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"max_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int max_level
    {
      get { return _max_level; }
      set { _max_level = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _unlock_levels = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(10, Name=@"unlock_levels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> unlock_levels
    {
      get { return _unlock_levels; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _unlock_exp = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(11, Name=@"unlock_exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> unlock_exp
    {
      get { return _unlock_exp; }
    }
  
    private int _auto_replace_multi_ability = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"auto_replace_multi_ability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int auto_replace_multi_ability
    {
      get { return _auto_replace_multi_ability; }
      set { _auto_replace_multi_ability = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COMBO_ABILITY_ARRAY")]
  public partial class COMBO_ABILITY_ARRAY : global::ProtoBuf.IExtensible
  {
    public COMBO_ABILITY_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.COMBO_ABILITY> _items = new global::System.Collections.Generic.List<dataconfig.COMBO_ABILITY>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.COMBO_ABILITY> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}