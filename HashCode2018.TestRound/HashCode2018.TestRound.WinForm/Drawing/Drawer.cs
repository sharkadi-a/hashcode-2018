using System.Drawing;
using HashCode2018.TestRound.NetFrameWork;

namespace HashCode2018.TestRound.WinForm.Drawing
{
	internal class Drawer
	{
		private readonly Graphics _graphics;
		private readonly int _width;
		private readonly int _height;

		public Drawer(Graphics graphics, int width, int height)
		{
			_graphics = graphics;
			_width = width;
			_height = height;
		}

		public void Start(View view)
		{
			var pizza = view.Pizza;
			var slice = view.NewSlice;
			var cellSize = _width / pizza.Columns;
			var Brush = new SolidBrush(Color.Blue);
			_graphics.FillRectangle(Brush, slice.C0*cellSize, slice.R0*cellSize, slice.C1 * cellSize, slice.R1 * cellSize);
		}
	}
}
