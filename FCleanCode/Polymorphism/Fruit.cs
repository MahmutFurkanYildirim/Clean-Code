namespace FCleanCode.Polymorphism
{
	class Fruit
	{
		public string Type { get; }

		public Fruit(string type)
		{
			Type = type;
		}

		public virtual void FruitColor()
		{
			Console.WriteLine(Type + " color is red");
		}
	}

	class Apple : Fruit
	{
		public Apple() : base("Apple")
		{
		}
	}

	class Lemon : Fruit
	{
        public Lemon() : base("Lemon")
        {            
        }

		public override void FruitColor() 
		{
			Console.WriteLine(Type + " color is yellow");
		}
    }

	class Kiwi : Fruit
	{
        public Kiwi():base("Kiwi")
        {            
        }

		public override void FruitColor()
		{
			Console.WriteLine(Type + " color is brown");
		}
	}
}