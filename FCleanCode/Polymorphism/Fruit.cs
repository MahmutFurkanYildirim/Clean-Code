namespace FCleanCode.Polymorphism
{
	// Temel sınıf Fruit, tüm meyve türlerinin ortak özelliklerini ve davranışlarını tanımlar.
	class Fruit
	{
		public string Type { get; }

		// Constructor, meyve türünü belirlemek için kullanılır.
		public Fruit(string type)
		{
			Type = type;
		}

		/* 
		   FruitColor yöntemi, meyvenin rengini yazdırır.
		   'virtual' anahtar kelimesi, bu yöntemin türetilmiş sınıflarda geçersiz kılınabileceğini belirtir.
		*/
		public virtual void FruitColor()
		{
			Console.WriteLine(Type + " color is red");
		}
	}//end class Fruit

	// Apple sınıfı, Fruit sınıfının FruitColor yöntemini değiştirmez, bu nedenle temel sınıfın davranışını kullanır.
	class Apple : Fruit
	{
		// Apple sınıfının constructor'ı, temel sınıfın constructor'ına "Apple" türünü ileterek çağırır.
		public Apple() : base("Apple")
		{
		}
	}//end class Apple


	// Lemon sınıfı, Fruit sınıfından miras alır ve FruitColor yöntemini geçersiz kılar (override).
	class Lemon : Fruit
	{
		// Lemon sınıfının constructor'ı, temel sınıfın constructor'ına "Lemon" türünü ileterek çağırır.
		public Lemon() : base("Lemon")
        {            
        }

		// FruitColor yöntemi, Lemon sınıfı için özel olarak yeniden tanımlanır ve sarı renk belirtilir.
		public override void FruitColor() 
		{
			Console.WriteLine(Type + " color is yellow");
		}
    }//end class Lemon
	

	class Kiwi : Fruit
	{
        public Kiwi():base("Kiwi")
        {            
        }

		public override void FruitColor()
		{
			Console.WriteLine(Type + " color is brown");
		}
	}//end class Kiwi
}