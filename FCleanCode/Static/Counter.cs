namespace FCleanCode.Static
{
	class Counter
	{
		/* 
		   InstanceCounter, sınıfın her bir örneği (instance) için ayrı ayrı tutulan bir sayaçtır.
		   Her yeni Counter nesnesi oluşturulduğunda, bu sayaç o nesne için artırılır.
		*/
		public int InstanceCounter { get; set; }

		/* 
		   StaticCounter, sınıfın tüm örnekleri tarafından paylaşılan bir sayaçtır.
		   Bu sayaç, tüm Counter nesneleri için ortaktır ve her yeni Counter nesnesi
		   oluşturulduğunda bu sayaç artırılır.
		*/
		public static int StaticCounter { get; private set; }

		public Counter()
		{
			InstanceCounter++;
			StaticCounter++;
		}

	}//end class Counter
}