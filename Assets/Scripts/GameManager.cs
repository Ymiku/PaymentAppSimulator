﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : UnitySingleton<GameManager>
{
    long _timeStamp;
    float _localTime;
	public int curUserId;
	public string curEnName;
    public long time
    {
        get { return _timeStamp + (long)_localTime; }
    }
    public int localTime
    {
        get { return (int)_localTime; }
    }
    public AccountSaveData accountData;
    public override void Awake()
    {
        base.Awake();
        OnEnterGame();
    }
	public void SetUser(int userId)
	{
		curUserId = userId;
		curEnName = XMLSaver.saveData.GetAccountData (userId).enname;
		XMLSaver.saveData.lastUser = userId;
        accountData = XMLSaver.saveData.GetAccountData(userId);
        if (!XMLSaver.saveData.canLoginUserIds.Contains (userId))
			XMLSaver.saveData.canLoginUserIds.Add (userId);
        ChatManager.Instance.OnExit();
        ChatManager.Instance.OnEnter(XMLSaver.saveData.GetAccountData(userId).enname);
        AssetsManager.Instance.Set(userId);
	}
    void OnEnterGame()
    {
        //load
        XMLSaver.Load();
        StaticDataLoader.Load();
        _timeStamp = GetTimeStamp();
        _localTime = 0.0f;
    }
	void OnDestroy()
	{
		OnExitGame ();
	}
    void OnExitGame()
    {
        XMLSaver.Save();
    }
    void Update()
    {
        _localTime += Time.deltaTime;
        StoryManager.Instance.Execute();
        ChatManager.Instance.OnExcute();
        FrostRX.Instance.Execute();
    }
    public static long GetTimeStamp()
    {
        TimeSpan ts = DateTime.UtcNow - new DateTime(2018, 1, 1, 0, 0, 0, 0);
        return Convert.ToInt64(ts.TotalSeconds);
    }
	public void ClearData()
	{
		XMLSaver.saveData = new SaveData ();
	}
}
