using System.Drawing;

namespace HashCode2018.TestRound.WinForm.Drawing
{
	internal class Drawer
	{
		private readonly Graphics _graphics;

		public Drawer(Graphics graphics)
		{
			_graphics = graphics;
		}

		public void Start(View view)
		{
			_graphics.DrawLine(new Pen(Color.Red), 0, 0, 100, 100);
		}
	}
}
