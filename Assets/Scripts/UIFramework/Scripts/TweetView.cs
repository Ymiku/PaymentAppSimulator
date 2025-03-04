using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
namespace UIFrameWork
{
	public class TweetView : AlphaView
	{
		public ProceduralImage head;
        public PoolableScrollViewInconsist scroll;
		public CanvasGroup backCanvas;
		public RectTransform content;
		private TweetContext _context;

		public override void Init ()
		{
			base.Init ();
		}
		public override void OnEnter(BaseContext context)
		{
			base.OnEnter(context);
			_context = context as TweetContext;
			Refresh ();
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
			Refresh ();
		}
		public override void Excute ()
		{
			base.Excute ();
			backCanvas.alpha = (content.anchoredPosition.y - 720.0f) / 120.0f;
			backCanvas.blocksRaycasts = (backCanvas.alpha >= 0.0f);
		}
        BinaryList<TweetData> tweets = new BinaryList<TweetData>();
        void Refresh()
        {
			AccountSaveData data = XMLSaver.saveData.GetAccountData (_context.userId);
			HeadSpriteUtils.Instance.SetHead (head,_context.userId);
			List<int> friends = XMLSaver.saveData.GetFriendsLst (_context.userId);
            tweets.Clear();
            for (int i = 0; i < friends.Count; i++)
            {
                List<TweetData> ftweets = null;
                ZoneManager.Instance.id2Tweet.TryGetValue(i,out ftweets);
                if (ftweets == null)
                    continue;
                for (int m = 0; m < ftweets.Count; m++)
                {
                    AddTweet(ftweets[m]);
                }
            }
            scroll.SetDatas<TweetData>(tweets.orderedList);
            tweets.Clear();
        }
        void AddTweet(TweetData data)
        {
            tweets.Add(data);
        }
    }
    
	public class TweetContext : BaseContext
	{
        public int userId;
		public TweetContext() : base(UIType.Tweet)
		{

		}
	}
}
