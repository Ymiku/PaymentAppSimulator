using UnityEngine;
using System.Collections;
namespace UIFrameWork
{
	public class RecoverPasswordView : AlphaView
	{
		private RecoverPasswordContext _context;

		public override void Init ()
		{
			base.Init ();
		}
		public override void OnEnter(BaseContext context)
		{
			base.OnEnter(context);
			_context = context as RecoverPasswordContext;
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
        public void OnClickEmailVerification()
        {
            UIManager.Instance.Push(new EmailVerificationContext());
        }

    }
	public class RecoverPasswordContext : BaseContext
	{
		public RecoverPasswordContext() : base(UIType.RecoverPassword)
		{
		}
	}
}
