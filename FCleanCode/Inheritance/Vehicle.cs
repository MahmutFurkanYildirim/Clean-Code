namespace FCleanCode.Inheritance
{
	// Vehicle sınıfı, Car ve Plane sınıfları tarafından miras alınacak temel sınıftır (base class).
	class Vehicle
	{
		public int Prize { get; set; }
		public double LoadCapacity { get; set; }
		public float MaxSpeed { get; set; }
		public string? Brand { get; set; }

	}//end class Vehicle

	/* 
	  Car sınıfı, Vehicle sınıfından miras alır. Bu, Car sınıfının Vehicle sınıfındaki tüm
	  özelliklere ve davranışlara (methods) sahip olduğu anlamına gelir.
	*/
	class Car : Vehicle { }//end class Car

	/* 
	  Plane sınıfı da Vehicle sınıfından miras alır. Bu, Plane sınıfının Vehicle sınıfındaki
	  tüm özelliklere ve davranışlara (methods) sahip olduğu anlamına gelir.
	*/
	class Plane : Vehicle { }//end class Plane
}