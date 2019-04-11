﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NoticePanel : MonoBehaviour {
    public Text text;
    public CanvasGroup group;
    Queue<string> _noticeQueue = new Queue<string>();
	RXIndex rxId = new RXIndex();
	void Awake()
	{
		StartNotice ();
	}
	void StartNotice()
	{
        FrostRX.Instance.StartRX().ExecuteWhen(() => { text.text = _noticeQueue.Dequeue(); group.blocksRaycasts = true; },
            () => { return _noticeQueue.Count != 0; }).
            ExecuteUntil(() => { group.alpha = Mathf.Lerp(group.alpha, 1.2f, 4.0f * Time.deltaTime); }, () => { return group.alpha >= 1.0f; }).
            Wait(1.0f).
            ExecuteUntil(() => { group.alpha = Mathf.Lerp(group.alpha, -0.2f, 4.0f * Time.deltaTime); }, () => { return group.alpha <= 0.0f; }).
            Execute(() => { group.blocksRaycasts = false; }).
            GoToBegin().GetId(rxId);
	}
	public void AddNotice (string notice)
    {
		_noticeQueue.Enqueue(notice);
    }
    public void Close()
    {
        group.alpha = 0.0f;
        group.blocksRaycasts = false;
		FrostRX.Instance.RestartRxById (rxId);
    }

}
