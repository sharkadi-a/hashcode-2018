namespace HashCode2018.TestRound.NetFrameWork
{
	public class View
	{
		public View(Pizza pizza, bool[][] cuttedOutPicies, Slice newSlice)
		{
			Pizza = pizza;
			CuttedOutPicies = cuttedOutPicies;
			NewSlice = newSlice;
		}

		public Pizza Pizza { get; }
		public bool[][] CuttedOutPicies { get; }
		public Slice NewSlice { get; }
	}
}
