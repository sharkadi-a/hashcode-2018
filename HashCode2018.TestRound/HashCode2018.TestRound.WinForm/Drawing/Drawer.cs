using System;
using System.Drawing;
using System.Threading;
using HashCode2018.TestRound.NetFrameWork;

namespace HashCode2018.TestRound.WinForm.Drawing
{
	internal class Drawer
	{
		private Graphics _graphics;
		private readonly int _width;
		private readonly int _height;
		private readonly Random _random = new Random();
		private int? _cellSize;
		private Bitmap _buffer;
		private int _scale = 3;

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
			if (_cellSize == null)
			{
				InitView(pizza.Columns, pizza.Rows);
			}
		

			
			//writeMessage($"{cellSize}");
			//writeMessage($"{slice.C0}:{slice.R0} {slice.C1}:{slice.R1}");
			//_random = new Random(slice.C0 + slice.C1 + slice.R0 + slice.R1);
			var color = GetRandomColor();
			//writeMessage($"{color.R} {color.G} {color.B}");
			var Brush = new SolidBrush(color);
			var x0Graph = slice.C0 * _cellSize.Value;
			var y0Graph = slice.R0 * _cellSize.Value;
			var xGraph = (slice.C1+1) * _cellSize.Value;
			var yGraph = (slice.R1+1) * _cellSize.Value;
			//if (x0Graph > _width)
			//{
			//	return;
			//}

			//if (y0Graph > _height)
			//{
			//	return;
			//}
			var bufGraphics = Graphics.FromImage(_buffer);
			bufGraphics.FillRectangle(Brush, x0Graph, y0Graph, xGraph - x0Graph, yGraph - y0Graph);
			_graphics.FillRectangle(Brush, x0Graph, y0Graph, xGraph - x0Graph, yGraph - y0Graph);
			//writeMessage($"{x0Graph}:{y0Graph} {xGraph}:{yGraph}");
			//Thread.Sleep(1000);
		}

		public void Clear(Color color)
		{
			_graphics.Clear(color);
		}
		public void Redraw(Graphics graphics)
		{
			_graphics = graphics;
			_graphics.DrawImage(_buffer,new Point(0,0));
		}
		private void InitView(int viewWidth, int viewHeight)
		{
			if (_width / viewWidth < _height / viewHeight)
			{
				_cellSize = _width / viewWidth;
			}
			else
			{
				_cellSize = _height / viewHeight;
			}
			_cellSize *= _scale;
			if (_cellSize == 0)
				_cellSize = 1;
			_buffer = new Bitmap(_width*_scale,_height*_scale);
		}



		private Color GetRandomColor()
		{
			return Color.FromArgb(_random.Next(25)*10, _random.Next(25) * 10, _random.Next(25) * 10);
		}
	}
}
