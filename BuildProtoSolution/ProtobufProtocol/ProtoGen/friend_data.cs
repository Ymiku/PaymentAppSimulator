//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: friend_data.proto
// Note: requires additional types generated from: common_data.proto
namespace moba_protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendRoleInfo")]
  public partial class FriendRoleInfo : global::ProtoBuf.IExtensible
  {
    public FriendRoleInfo() {}
    
    private string _openid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"openid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string openid
    {
      get { return _openid?? ""; }
      set { _openid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool openidSpecified
    {
      get { return this._openid != null; }
      set { if (value == (this._openid== null)) this._openid = value ? this.openid : (string)null; }
    }
    private bool ShouldSerializeopenid() { return openidSpecified; }
    private void Resetopenid() { openidSpecified = false; }
    
    private uint? _zoneid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"zoneid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint zoneid
    {
      get { return _zoneid?? default(uint); }
      set { _zoneid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool zoneidSpecified
    {
      get { return this._zoneid != null; }
      set { if (value == (this._zoneid== null)) this._zoneid = value ? this.zoneid : (uint?)null; }
    }
    private bool ShouldSerializezoneid() { return zoneidSpecified; }
    private void Resetzoneid() { zoneidSpecified = false; }
    
    private uint? _uin;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"uin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint uin
    {
      get { return _uin?? default(uint); }
      set { _uin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool uinSpecified
    {
      get { return this._uin != null; }
      set { if (value == (this._uin== null)) this._uin = value ? this.uin : (uint?)null; }
    }
    private bool ShouldSerializeuin() { return uinSpecified; }
    private void Resetuin() { uinSpecified = false; }
    
    private string _name;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name?? ""; }
      set { _name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool nameSpecified
    {
      get { return this._name != null; }
      set { if (value == (this._name== null)) this._name = value ? this.name : (string)null; }
    }
    private bool ShouldSerializename() { return nameSpecified; }
    private void Resetname() { nameSpecified = false; }
    
    private string _logo;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"logo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string logo
    {
      get { return _logo?? ""; }
      set { _logo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool logoSpecified
    {
      get { return this._logo != null; }
      set { if (value == (this._logo== null)) this._logo = value ? this.logo : (string)null; }
    }
    private bool ShouldSerializelogo() { return logoSpecified; }
    private void Resetlogo() { logoSpecified = false; }
    
    private uint? _icon_and_frame;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"icon_and_frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint icon_and_frame
    {
      get { return _icon_and_frame?? default(uint); }
      set { _icon_and_frame = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool icon_and_frameSpecified
    {
      get { return this._icon_and_frame != null; }
      set { if (value == (this._icon_and_frame== null)) this._icon_and_frame = value ? this.icon_and_frame : (uint?)null; }
    }
    private bool ShouldSerializeicon_and_frame() { return icon_and_frameSpecified; }
    private void Reseticon_and_frame() { icon_and_frameSpecified = false; }
    
    private uint? _vip;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint vip
    {
      get { return _vip?? default(uint); }
      set { _vip = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool vipSpecified
    {
      get { return this._vip != null; }
      set { if (value == (this._vip== null)) this._vip = value ? this.vip : (uint?)null; }
    }
    private bool ShouldSerializevip() { return vipSpecified; }
    private void Resetvip() { vipSpecified = false; }
    
    private uint? _level;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level?? default(uint); }
      set { _level = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool levelSpecified
    {
      get { return this._level != null; }
      set { if (value == (this._level== null)) this._level = value ? this.level : (uint?)null; }
    }
    private bool ShouldSerializelevel() { return levelSpecified; }
    private void Resetlevel() { levelSpecified = false; }
    
    private moba_protocol.PlayerState? _player_state;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"player_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public moba_protocol.PlayerState player_state
    {
      get { return _player_state?? moba_protocol.PlayerState.PLAYER_STATE_IDLE; }
      set { _player_state = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool player_stateSpecified
    {
      get { return this._player_state != null; }
      set { if (value == (this._player_state== null)) this._player_state = value ? this.player_state : (moba_protocol.PlayerState?)null; }
    }
    private bool ShouldSerializeplayer_state() { return player_stateSpecified; }
    private void Resetplayer_state() { player_stateSpecified = false; }
    
    private bool? _online;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"online", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool online
    {
      get { return _online?? default(bool); }
      set { _online = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool onlineSpecified
    {
      get { return this._online != null; }
      set { if (value == (this._online== null)) this._online = value ? this.online : (bool?)null; }
    }
    private bool ShouldSerializeonline() { return onlineSpecified; }
    private void Resetonline() { onlineSpecified = false; }
    
    private uint? _gender;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gender
    {
      get { return _gender?? default(uint); }
      set { _gender = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool genderSpecified
    {
      get { return this._gender != null; }
      set { if (value == (this._gender== null)) this._gender = value ? this.gender : (uint?)null; }
    }
    private bool ShouldSerializegender() { return genderSpecified; }
    private void Resetgender() { genderSpecified = false; }
    
    private uint? _last_login_time;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"last_login_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_login_time
    {
      get { return _last_login_time?? default(uint); }
      set { _last_login_time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool last_login_timeSpecified
    {
      get { return this._last_login_time != null; }
      set { if (value == (this._last_login_time== null)) this._last_login_time = value ? this.last_login_time : (uint?)null; }
    }
    private bool ShouldSerializelast_login_time() { return last_login_timeSpecified; }
    private void Resetlast_login_time() { last_login_timeSpecified = false; }
    
    private uint? _last_send_coin_date;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"last_send_coin_date", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_send_coin_date
    {
      get { return _last_send_coin_date?? default(uint); }
      set { _last_send_coin_date = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool last_send_coin_dateSpecified
    {
      get { return this._last_send_coin_date != null; }
      set { if (value == (this._last_send_coin_date== null)) this._last_send_coin_date = value ? this.last_send_coin_date : (uint?)null; }
    }
    private bool ShouldSerializelast_send_coin_date() { return last_send_coin_dateSpecified; }
    private void Resetlast_send_coin_date() { last_send_coin_dateSpecified = false; }
    
    private uint? _last_send_coin_num;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"last_send_coin_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_send_coin_num
    {
      get { return _last_send_coin_num?? default(uint); }
      set { _last_send_coin_num = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool last_send_coin_numSpecified
    {
      get { return this._last_send_coin_num != null; }
      set { if (value == (this._last_send_coin_num== null)) this._last_send_coin_num = value ? this.last_send_coin_num : (uint?)null; }
    }
    private bool ShouldSerializelast_send_coin_num() { return last_send_coin_numSpecified; }
    private void Resetlast_send_coin_num() { last_send_coin_numSpecified = false; }
    
    private ulong? _zone_bus_id;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"zone_bus_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong zone_bus_id
    {
      get { return _zone_bus_id?? default(ulong); }
      set { _zone_bus_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool zone_bus_idSpecified
    {
      get { return this._zone_bus_id != null; }
      set { if (value == (this._zone_bus_id== null)) this._zone_bus_id = value ? this.zone_bus_id : (ulong?)null; }
    }
    private bool ShouldSerializezone_bus_id() { return zone_bus_idSpecified; }
    private void Resetzone_bus_id() { zone_bus_idSpecified = false; }
    
    private uint? _friend_id;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"friend_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint friend_id
    {
      get { return _friend_id?? default(uint); }
      set { _friend_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool friend_idSpecified
    {
      get { return this._friend_id != null; }
      set { if (value == (this._friend_id== null)) this._friend_id = value ? this.friend_id : (uint?)null; }
    }
    private bool ShouldSerializefriend_id() { return friend_idSpecified; }
    private void Resetfriend_id() { friend_idSpecified = false; }
    
    private uint? _scene;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"scene", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint scene
    {
      get { return _scene?? default(uint); }
      set { _scene = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool sceneSpecified
    {
      get { return this._scene != null; }
      set { if (value == (this._scene== null)) this._scene = value ? this.scene : (uint?)null; }
    }
    private bool ShouldSerializescene() { return sceneSpecified; }
    private void Resetscene() { sceneSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendRoleInfoList")]
  public partial class FriendRoleInfoList : global::ProtoBuf.IExtensible
  {
    public FriendRoleInfoList() {}
    
    private string _openid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"openid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string openid
    {
      get { return _openid?? ""; }
      set { _openid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool openidSpecified
    {
      get { return this._openid != null; }
      set { if (value == (this._openid== null)) this._openid = value ? this.openid : (string)null; }
    }
    private bool ShouldSerializeopenid() { return openidSpecified; }
    private void Resetopenid() { openidSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<moba_protocol.FriendRoleInfo> _friend_list = new global::System.Collections.Generic.List<moba_protocol.FriendRoleInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"friend_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<moba_protocol.FriendRoleInfo> friend_list
    {
      get { return _friend_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendRequestInfo")]
  public partial class FriendRequestInfo : global::ProtoBuf.IExtensible
  {
    public FriendRequestInfo() {}
    
    private uint? _uin;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint uin
    {
      get { return _uin?? default(uint); }
      set { _uin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool uinSpecified
    {
      get { return this._uin != null; }
      set { if (value == (this._uin== null)) this._uin = value ? this.uin : (uint?)null; }
    }
    private bool ShouldSerializeuin() { return uinSpecified; }
    private void Resetuin() { uinSpecified = false; }
    
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name?? ""; }
      set { _name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool nameSpecified
    {
      get { return this._name != null; }
      set { if (value == (this._name== null)) this._name = value ? this.name : (string)null; }
    }
    private bool ShouldSerializename() { return nameSpecified; }
    private void Resetname() { nameSpecified = false; }
    
    private string _memo;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"memo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string memo
    {
      get { return _memo?? ""; }
      set { _memo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool memoSpecified
    {
      get { return this._memo != null; }
      set { if (value == (this._memo== null)) this._memo = value ? this.memo : (string)null; }
    }
    private bool ShouldSerializememo() { return memoSpecified; }
    private void Resetmemo() { memoSpecified = false; }
    
    private uint? _timestamp;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timestamp
    {
      get { return _timestamp?? default(uint); }
      set { _timestamp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timestampSpecified
    {
      get { return this._timestamp != null; }
      set { if (value == (this._timestamp== null)) this._timestamp = value ? this.timestamp : (uint?)null; }
    }
    private bool ShouldSerializetimestamp() { return timestampSpecified; }
    private void Resettimestamp() { timestampSpecified = false; }
    
    private uint? _req_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"req_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint req_id
    {
      get { return _req_id?? default(uint); }
      set { _req_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool req_idSpecified
    {
      get { return this._req_id != null; }
      set { if (value == (this._req_id== null)) this._req_id = value ? this.req_id : (uint?)null; }
    }
    private bool ShouldSerializereq_id() { return req_idSpecified; }
    private void Resetreq_id() { req_idSpecified = false; }
    
    private string _logo;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"logo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string logo
    {
      get { return _logo?? ""; }
      set { _logo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool logoSpecified
    {
      get { return this._logo != null; }
      set { if (value == (this._logo== null)) this._logo = value ? this.logo : (string)null; }
    }
    private bool ShouldSerializelogo() { return logoSpecified; }
    private void Resetlogo() { logoSpecified = false; }
    
    private uint? _vip;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"vip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint vip
    {
      get { return _vip?? default(uint); }
      set { _vip = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool vipSpecified
    {
      get { return this._vip != null; }
      set { if (value == (this._vip== null)) this._vip = value ? this.vip : (uint?)null; }
    }
    private bool ShouldSerializevip() { return vipSpecified; }
    private void Resetvip() { vipSpecified = false; }
    
    private uint? _level;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level?? default(uint); }
      set { _level = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool levelSpecified
    {
      get { return this._level != null; }
      set { if (value == (this._level== null)) this._level = value ? this.level : (uint?)null; }
    }
    private bool ShouldSerializelevel() { return levelSpecified; }
    private void Resetlevel() { levelSpecified = false; }
    
    private uint? _gender;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gender
    {
      get { return _gender?? default(uint); }
      set { _gender = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool genderSpecified
    {
      get { return this._gender != null; }
      set { if (value == (this._gender== null)) this._gender = value ? this.gender : (uint?)null; }
    }
    private bool ShouldSerializegender() { return genderSpecified; }
    private void Resetgender() { genderSpecified = false; }
    
    private string _openid;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"openid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string openid
    {
      get { return _openid?? ""; }
      set { _openid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool openidSpecified
    {
      get { return this._openid != null; }
      set { if (value == (this._openid== null)) this._openid = value ? this.openid : (string)null; }
    }
    private bool ShouldSerializeopenid() { return openidSpecified; }
    private void Resetopenid() { openidSpecified = false; }
    
    private uint? _icon_and_frame;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"icon_and_frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint icon_and_frame
    {
      get { return _icon_and_frame?? default(uint); }
      set { _icon_and_frame = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool icon_and_frameSpecified
    {
      get { return this._icon_and_frame != null; }
      set { if (value == (this._icon_and_frame== null)) this._icon_and_frame = value ? this.icon_and_frame : (uint?)null; }
    }
    private bool ShouldSerializeicon_and_frame() { return icon_and_frameSpecified; }
    private void Reseticon_and_frame() { icon_and_frameSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendRequestInfoList")]
  public partial class FriendRequestInfoList : global::ProtoBuf.IExtensible
  {
    public FriendRequestInfoList() {}
    
    private uint? _uin;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint uin
    {
      get { return _uin?? default(uint); }
      set { _uin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool uinSpecified
    {
      get { return this._uin != null; }
      set { if (value == (this._uin== null)) this._uin = value ? this.uin : (uint?)null; }
    }
    private bool ShouldSerializeuin() { return uinSpecified; }
    private void Resetuin() { uinSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<moba_protocol.FriendRequestInfo> _req_list = new global::System.Collections.Generic.List<moba_protocol.FriendRequestInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"req_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<moba_protocol.FriendRequestInfo> req_list
    {
      get { return _req_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}