using System;
using System.Drawing;
using System.Threading;
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
			int cellSize;
			
			if (_width / pizza.Columns < _height / pizza.Rows)
			{
				cellSize = _width / pizza.Columns;
			}
			else
			{
				cellSize = _height / pizza.Rows;
			}

			if (cellSize == 0) 
				cellSize = 1;

			cellSize *= 3;
			//writeMessage($"{cellSize}");
			//writeMessage($"{slice.C0}:{slice.R0} {slice.C1}:{slice.R1}");
			//_random = new Random(slice.C0 + slice.C1 + slice.R0 + slice.R1);
			var color = GetRandomColor();
			//writeMessage($"{color.R} {color.G} {color.B}");
			var Brush = new SolidBrush(color);
			var x0Graph = slice.C0 * cellSize;
			var y0Graph = slice.R0 * cellSize;
			var xGraph = (slice.C1+1) * cellSize;
			var yGraph = (slice.R1+1) * cellSize;
			if (x0Graph > _width)
			{
				return;
			}

			if (y0Graph > _height)
			{
				return;
			}
			_graphics.FillRectangle(Brush, x0Graph, y0Graph, xGraph - x0Graph, yGraph - y0Graph);
			//writeMessage($"{x0Graph}:{y0Graph} {xGraph}:{yGraph}");
			//Thread.Sleep(1000);
		}

		private Color GetRandomColor()
		{
			return Color.FromArgb(_random.Next(25)*10, _random.Next(25) * 10, _random.Next(25) * 10);
		}
	}
}
