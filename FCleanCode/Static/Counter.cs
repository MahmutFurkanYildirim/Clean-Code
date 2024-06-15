namespace FCleanCode.Static
{
	class Counter
	{
		public int InstanceCounter { get; set; }
		public static int StaticCounter { get; private set; }

		public Counter()
		{
			InstanceCounter++;
			StaticCounter++;
		}
	}
}