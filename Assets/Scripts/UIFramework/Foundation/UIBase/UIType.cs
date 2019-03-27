using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace UIFrameWork
{
	public class UIType {

        public string Path { get; private set; }

        public string Name { get; private set; }

        public UIType(string path)
        {
            Path = path;
            Name = path.Substring(path.LastIndexOf('/') + 1);
        }

        public override string ToString()
        {
            return string.Format("path : {0} name : {1}", Path, Name);
        }
	
		//public static readonly UIType LogIn = new UIType("View/LogInView");
		public static readonly UIType Home = new UIType("View/HomeView");
		public static readonly UIType Fortune = new UIType("View/FortuneView");
		public static readonly UIType Koubei = new UIType("View/KoubeiView");
		public static readonly UIType Friends = new UIType("View/FriendsView");
		public static readonly UIType Me = new UIType("View/MeView");
		public static readonly UIType Chat = new UIType("View/ChatView");
		public static readonly UIType Quit = new UIType("View/QuitView");
		public static readonly UIType Scan = new UIType("View/ScanView");
		public static readonly UIType Pay = new UIType("View/PayView");
		public static readonly UIType Collect = new UIType("View/CollectView");
		public static readonly UIType Pocket = new UIType("View/PocketView");
		public static readonly UIType Transfer = new UIType("View/TransferView");
		public static readonly UIType PhoneTopup = new UIType("View/PhoneTopupView");
		public static readonly UIType MyPackages = new UIType("View/MyPackagesView");
		public static readonly UIType Carhailing = new UIType("View/CarhailingView");
		public static readonly UIType Settings = new UIType("View/SettingsView");
		public static readonly UIType Membership = new UIType("View/MembershipView");
		public static readonly UIType Transactions = new UIType("View/TransactionsView");
		public static readonly UIType Balance = new UIType("View/BalanceView");
		public static readonly UIType TotalAssets = new UIType("View/TotalAssetsView");
		public static readonly UIType TransDetails = new UIType("View/TransDetailsView"); //转账明细界面
		public static readonly UIType YuEBao = new UIType("View/YuEBaoView"); //余额宝界面
		public static readonly UIType AntCredit = new UIType("View/AntCreditView"); //花呗界面
		public static readonly UIType ZhimaCredit = new UIType("View/ZhimaCreditView"); //芝麻信用界面
		public static readonly UIType MyBank = new UIType("View/MyBankView"); //我的银行卡界面
		public static readonly UIType BankServices = new UIType("View/BankServicesView"); //银行卡服务界面
		public static readonly UIType Search = new UIType("View/SearchView"); //搜索栏
		public static readonly UIType FixedTerm = new UIType("View/FixedTermView"); //定期界面
		public static readonly UIType FixedTermHave = new UIType("View/FixedTermHaveView"); //定期持有界面
		public static readonly UIType Login = new UIType("View/LoginView"); //点击头像登录
		public static readonly UIType RegistByPhoneNumber = new UIType("View/RegistByPhoneNumberView"); //注册
		public static readonly UIType LoginByPhoneNumber = new UIType("View/LoginByPhoneNumberView"); //用手机号登录
		public static readonly UIType AddBankCard = new UIType("View/AddBankCardView"); //添加银行卡界面
		public static readonly UIType AddBankCardInfo = new UIType("View/AddBankCardInfoView"); //添加银行卡第二步界面
		public static readonly UIType RegistAgreement = new UIType("View/RegistAgreementView"); //注册协议
    }
}
