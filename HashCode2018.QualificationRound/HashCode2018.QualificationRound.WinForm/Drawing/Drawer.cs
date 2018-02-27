using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HashCode2018.QualificationRound.WinForm.Drawing
{
	class Drawer
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
