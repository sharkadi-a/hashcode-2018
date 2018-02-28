namespace HashCode2018.TestRound.NetFrameWork.Patterns
{
	struct Rectangle
	{
		public readonly int Heigth;
		public readonly int Width;
		public readonly CellOffset[] CellsOffsets;
		public Rectangle(int heigth, int width, CellOffset[] cellsOffsets)
		{
			Heigth = heigth;
			Width = width;
			CellsOffsets = cellsOffsets;
		}
	}

	struct CellOffset
	{
		public readonly int x;
		public readonly int y;

		public CellOffset(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
