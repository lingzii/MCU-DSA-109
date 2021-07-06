using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Homework_2
{
	public class cNode
	{
		public char Data { get; set; }
		public cNode Left { get; set; }
		public cNode Right { get; set; }
		public cNode(char v) { Data = v; }

		Image _lastImage;
		private int _lastImageLocationOfStarterNode;
		private static Bitmap _nodeBg = new Bitmap(30, 25);
		private static Size _freeSpace = new Size(_nodeBg.Width / 8, (int)(_nodeBg.Height * 1.3f));
		private static readonly float Coef = _nodeBg.Width / 40f;
		private static Font font = new Font("Consolas", 14f * Coef);

		public Image Draw(out int center)
		{
			center = _lastImageLocationOfStarterNode;
			var lCenter = 0;
			var rCenter = 0;
			Image lNodeImg = null, rNodeImg = null;
			if (Left != null) lNodeImg = Left.Draw(out lCenter);
			if (Right != null) rNodeImg = Right.Draw(out rCenter);
			var lSize = new Size();
			var rSize = new Size();
			var under = (lNodeImg != null) || (rNodeImg != null);
			if (lNodeImg != null) lSize = lNodeImg.Size;
			if (rNodeImg != null) rSize = rNodeImg.Size;
			var maxHeight = lSize.Height;
			if (maxHeight < rSize.Height) maxHeight = rSize.Height;
			if (lSize.Width <= 0)
				lSize.Width = (_nodeBg.Width - _freeSpace.Width) / 2;
			if (rSize.Width <= 0)
				rSize.Width = (_nodeBg.Width - _freeSpace.Width) / 2;
			var resSize = new Size
			{
				Width = lSize.Width + rSize.Width + _freeSpace.Width,
				Height = _nodeBg.Size.Height + (under ? maxHeight + _freeSpace.Height : 0)
			};

			var result = new Bitmap(resSize.Width, resSize.Height);
			var g = Graphics.FromImage(result);
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.FillRectangle(Brushes.White, new Rectangle(new Point(0, 0), resSize));
			g.DrawImage(_nodeBg, lSize.Width - _nodeBg.Width / 2 + _freeSpace.Width / 2, 0);
			var str = Data.ToString();
			g.DrawString(str, font, Brushes.Black, lSize.Width - _nodeBg.Width / 2 + _freeSpace.Width / 2 + (2 + (str.Length == 1 ? 10 : str.Length == 2 ? 5 : 0)) * Coef, _nodeBg.Height / 2f - 12 * Coef);

			center = lSize.Width + _freeSpace.Width / 2;
			var pen = new Pen(Brushes.Black, 1.2f * Coef)
			{
				EndCap = LineCap.ArrowAnchor,
				StartCap = LineCap.Round
			};

			float x1 = center;
			float y1 = _nodeBg.Height;
			float y2 = _nodeBg.Height + _freeSpace.Height;
			float x2 = lCenter;
			var h = Math.Abs(y2 - y1);
			var w = Math.Abs(x2 - x1);
			if (lNodeImg != null)
			{
				g.DrawImage(lNodeImg, 0, _nodeBg.Size.Height + _freeSpace.Height);
				var points1 = new List<PointF>
								  {
									  new PointF(x1, y1),
									  new PointF(x1 - w/6, y1 + h/3.5f),
									  new PointF(x2 + w/6, y2 - h/3.5f),
									  new PointF(x2, y2),
								  };
				g.DrawCurve(pen, points1.ToArray(), 0.5f);
			}
			if (rNodeImg != null)
			{
				g.DrawImage(rNodeImg, lSize.Width + _freeSpace.Width, _nodeBg.Size.Height + _freeSpace.Height);
				x2 = rCenter + lSize.Width + _freeSpace.Width;
				w = Math.Abs(x2 - x1);
				var points = new List<PointF>
								 {
									 new PointF(x1, y1),
									 new PointF(x1 + w/6, y1 + h/3.5f),
									 new PointF(x2 - w/6, y2 - h/3.5f),
									 new PointF(x2, y2)
								 };
				g.DrawCurve(pen, points.ToArray(), 0.5f);
			}
			_lastImage = result;
			_lastImageLocationOfStarterNode = center;
			return result;
		}
	}
}


