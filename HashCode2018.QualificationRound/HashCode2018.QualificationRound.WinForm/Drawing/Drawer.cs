using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HashCode2018.QualificationRound.WinForm.Drawing
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
			//var pizza = view.Pizza;
			//var slice = view.NewSlice;
			//int cellSize;
			
			//if (_width / pizza.Columns < _height / pizza.Rows)
			//{
			//	cellSize = _width / pizza.Columns;
			//}
			//else
			//{
			//	cellSize = _height / pizza.Rows;
			//}

			//if (cellSize == 0) 
			//	cellSize = 1;

			//cellSize *= 3;
			
			//var color = GetRandomColor();
			//var Brush = new SolidBrush(color);
			//var x0Graph = slice.C0 * cellSize;
			//var y0Graph = slice.R0 * cellSize;
			//var xGraph = (slice.C1+1) * cellSize;
			//var yGraph = (slice.R1+1) * cellSize;
			//if (x0Graph > _width)
			//{
			//	return;
			//}

			//if (y0Graph > _height)
			//{
			//	return;
			//}
			//_graphics.FillRectangle(Brush, x0Graph, y0Graph, xGraph - x0Graph, yGraph - y0Graph);
		}

		private Color GetRandomColor()
		{
			return Color.FromArgb(_random.Next(25)*10, _random.Next(25) * 10, _random.Next(25) * 10);
		}
	}
}
