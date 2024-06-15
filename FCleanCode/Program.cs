using FCleanCode.Encapsulation;
using FCleanCode.Inheritance;
using FCleanCode.Polymorphism;
using FCleanCode.Static;

namespace FCleanCode
{
	public class Program
	{
		private static void Main(string[] args)
		{
			//-------------------------------------STATIC--------------------------------------------------------//
			Console.WriteLine("------------------------STATIC------------------------------");
			Counter counter = null;

			for (int i = 0; i < 10; i++)
			{
				counter = new Counter();
			}

			/*
				InstanceCounter: Bu, son oluşturulan Counter nesnesinin InstanceCounter değerini gösterir.
				Ancak, InstanceCounter değeri yapıcı metod içinde her seferinde 1 artırıldığından,
				her yeni nesne oluşturulduğunda bu özellik sıfırdan başlayarak 1'e artar.
				Sonuç olarak, InstanceCounter 1 olacaktır çünkü her yeni Counter nesnesi,
				InstanceCounter'ı 1'e artırır ve her nesne için sıfırdan başlar.
			*/
			Console.WriteLine("Instance Counter: " + counter.InstanceCounter);

			/*
				StaticCounter: Bu, toplamda kaç Counter nesnesi oluşturulduğunu gösterir.
				10 kez new Counter() çağrıldığı için, StaticCounter 10 olacaktır.
			*/
			Console.WriteLine("Static Counter: " + Counter.StaticCounter);

			//------------------------------------INHERITANCE---------------------------------------------------------//
			Console.WriteLine("------------------------INHERITANCE------------------------------");
			Car car = new Car();
			car.Brand = "Mercedes";
			car.Prize = 25000;
			car.LoadCapacity = 100;
			car.MaxSpeed = 290;
			Console.WriteLine("Write what you wanna see information about car!");

			Plane plane = new Plane();
			plane.Brand = "Boeing";
			plane.Prize = 1000000;
			plane.LoadCapacity = 5000;
			plane.MaxSpeed = 400;
			Console.WriteLine("Write what you wanna see information about plane!");

			//------------------------------------POLYMORPHISM---------------------------------------------------------//
			Console.WriteLine("------------------------POLYMORPHISM------------------------------");
			FruitColor(new Apple());
			FruitColor(new Lemon());
			FruitColor(new Kiwi());

			//------------------------------------ENCAPSULATION---------------------------------------------------------//
			Console.WriteLine("------------------------ENCAPSULATION------------------------------");
			Person person = new Person();
			person.SetTc("11111111111");
			Console.WriteLine("Valid TR ID number has been set: " + person.GetTc());


		}

		//POLYMORPHISM
		static void FruitColor(Fruit fruit)
		{
			fruit.FruitColor();
		}
	}
}