using UnityEngine;
using System.Collections;
namespace UIFrameWork
{
	public class KoubeiView : EnabledView
	{
		private KoubeiContext _context;

		public override void Init ()
		{
			base.Init ();
            RegistCommonView(UIType.CommonHomeBar);
        }
		public override void OnEnter(BaseContext context)
		{
			base.OnEnter(context);
			_context = context as KoubeiContext;
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
        public void OnClickHome()
        {
            UIManager.Instance.StartAndResetUILine(UIManager.UILine.Main);
            UIManager.Instance.Push(new HomeContext());
        }
        public void OnClickFortune()
        {
            UIManager.Instance.StartAndResetUILine(UIManager.UILine.Main);
            UIManager.Instance.Push(new FortuneContext());
        }
        public void OnClickKoubei()
        {
            UIManager.Instance.StartAndResetUILine(UIManager.UILine.Main);
            UIManager.Instance.Push(new KoubeiContext());
        }
        public void OnClickFriends()
        {
            UIManager.Instance.StartAndResetUILine(UIManager.UILine.Main);
            UIManager.Instance.Push(new FriendsContext());
        }
        public void OnClickMe()
        {
            UIManager.Instance.StartAndResetUILine(UIManager.UILine.Main);
            UIManager.Instance.Push(new MeContext());
        }
    }
	public class KoubeiContext : BaseContext
	{
		public KoubeiContext() : base(UIType.Koubei)
		{
		}
	}
}
