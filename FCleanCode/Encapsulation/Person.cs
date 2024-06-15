namespace FCleanCode.Encapsulation
{
	class Person
	{
		// Alan private yapılarak dışarıya kapatılır.
		private string Tc;

		// getter: Değeri dışarıya verir.
		public string GetTc()
		{
			return Tc;
		}

		// setter: Dıştan aldığı değeri alana aktarır
		public void SetTc(string value)
		{
			if(value.Any(item => !char.IsNumber(item)))
			{
				throw new ArgumentException("Tc must consist of numbers!");
			}

			if(value.Length != 11)
			{
				throw new ArgumentException("Tc must be 11 digits!");
			}

			Tc = value;
		}
	}
}
