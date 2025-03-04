﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UIFrameWork
{
	public class RegistByPhoneNumberView : AlphaView
	{
		private RegistByPhoneNumberContext _context;
        public Text phoneNumber;
		public override void Init ()
		{
			base.Init ();
		}
		public override void OnEnter(BaseContext context)
		{
			base.OnEnter(context);
			_context = context as RegistByPhoneNumberContext;
		}

		public override void OnExit(BaseContext context)
		{
			base.OnExit(context);
		}

		public override void OnPause(BaseContext context)
		{
			base.OnPause(context);
		}

		public override void OnResume(BaseContext context)
		{
			base.OnResume(context);
		}
		public override void Excute ()
		{
			base.Excute ();
		}
        public void OnClickRegist()
        {
			string num = phoneNumber.text.Replace (" ","");
            if (num.Length != 11)
            {
                ShowNotice("输入格式错误！");
                return;
            }
            if (XMLSaver.saveData.accountList[0].accountId == 0)
                XMLSaver.saveData.accountList.RemoveAt(0);
            AccountSaveData data = XMLSaver.saveData.AddAccountData(0);
            AssetsSaveData assetsData = XMLSaver.saveData.AddAssetsData(0);
            FortuneSaveData fortuneData = XMLSaver.saveData.AddFortuneData(0);
			data.phoneNumber = num;
            data.enname = "i";
            data.realName = "猪脚";
            assetsData.balance = 100000; // todo 金钱
            assetsData.antPay = GameDefine.AntLimit;
			GameManager.Instance.SetUser (0);
			UIManager.Instance.Push(new LoginContext());
        }
        public void OnClickAgreement()
        {
			UIManager.Instance.Push(new RegistAgreementContext());
        }
    }
	public class RegistByPhoneNumberContext : BaseContext
	{
		public RegistByPhoneNumberContext() : base(UIType.RegistByPhoneNumber)
		{
		}
	}
}
