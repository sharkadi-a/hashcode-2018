using System;
using System.Drawing;
using HashCode2018.TestRound.NetFrameWork;

namespace HashCode2018.TestRound.WinForm.Drawing
{
	internal class Drawer
	{
		private readonly Graphics _graphics;
		private readonly int _width;
		private readonly int _height;
		private static Random _random = new Random();
		public Drawer(Graphics graphics, int width, int height)
		{
			_graphics = graphics;
			_width = width;
			_height = height;
		}

		public void Start(View view, Action<string> writeMessage)
		{
			var pizza = view.Pizza;
			var slice = view.NewSlice;
			var cellSize = _width / pizza.Columns;
			writeMessage($"{slice.C0}:{slice.R0} {slice.C1}:{slice.R1}");
			//_random = new Random(slice.C0 + slice.C1 + slice.R0 + slice.R1);
			var color = GetRandomColor();
			//writeMessage($"{color.R} {color.G} {color.B}");
			var Brush = new SolidBrush(color);
		
			_graphics.FillRectangle(Brush, slice.C0*cellSize, slice.R0*cellSize, slice.C1 * cellSize, slice.R1 * cellSize);
		}

		private Color GetRandomColor()
		{
			return Color.FromArgb(_random.Next(25)*10, _random.Next(25) * 10, _random.Next(25) * 10);
		}
	}
}
