//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: static_data_blog.proto
namespace static_data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BLOG")]
  public partial class BLOG : global::ProtoBuf.IExtensible
  {
    public BLOG() {}
    
    private int _blog_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blog_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blog_id
    {
      get { return _blog_id; }
      set { _blog_id = value; }
    }
    private int _user_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _blog_title;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"blog_title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string blog_title
    {
      get { return _blog_title; }
      set { _blog_title = value; }
    }
    private string _blog_summary;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"blog_summary", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string blog_summary
    {
      get { return _blog_summary; }
      set { _blog_summary = value; }
    }
    private string _blog_path;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"blog_path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string blog_path
    {
      get { return _blog_path; }
      set { _blog_path = value; }
    }
    private int _is_secret;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"is_secret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int is_secret
    {
      get { return _is_secret; }
      set { _is_secret = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BLOG_ARRAY")]
  public partial class BLOG_ARRAY : global::ProtoBuf.IExtensible
  {
    public BLOG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<static_data.BLOG> _items = new global::System.Collections.Generic.List<static_data.BLOG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<static_data.BLOG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}