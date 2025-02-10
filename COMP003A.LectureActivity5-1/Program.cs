namespace COMP003A.LectureActivity5_1
{
	internal class Car
	{
		// Fields
		public string Make;
		public string Model;
		public int Year;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="make"></param>
		/// <param name="model"></param>
		/// <param name="year"></param>
		public Car(string make, string model, int year)
		{
			Make = make;
			Model = model;
			Year = year;
		}

		/// <summary>
		/// Display the car information
		/// </summary>
		public void DisplayInfo()
		{
			Console.WriteLine($"Car: {Year} {Make} {Model}");
		}
		internal class Program
		{
			static void Main(string[] args)
			{
				Car myCar = new Car("Honda", "Civic", 2021); // Create a new Car object using the constructor
				myCar.DisplayInfo(); // Display the car information
			}
		}
	}
}