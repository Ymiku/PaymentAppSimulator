//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: dataconfig_buff_tag.proto
// Note: requires additional types generated from: ProtoFScalar.proto
// Note: requires additional types generated from: xls_enum.proto
namespace dataconfig
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BUFF_TAG")]
  public partial class BUFF_TAG : global::ProtoBuf.IExtensible
  {
    public BUFF_TAG() {}
    
    private string _tag = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tag
    {
      get { return _tag; }
      set { _tag = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _status = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> status
    {
      get { return _status; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BUFF_TAG_ARRAY")]
  public partial class BUFF_TAG_ARRAY : global::ProtoBuf.IExtensible
  {
    public BUFF_TAG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<dataconfig.BUFF_TAG> _items = new global::System.Collections.Generic.List<dataconfig.BUFF_TAG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dataconfig.BUFF_TAG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}