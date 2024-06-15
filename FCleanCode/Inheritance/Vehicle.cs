namespace FCleanCode.Inheritance
{
	class Vehicle
	{
		public int Prize { get; set; }
		public double LoadCapacity { get; set; }
		public float MaxSpeed { get; set; }
		public string? Brand { get; set; }

	}

	class Car: Vehicle { }

	class Plane: Vehicle { }
}