namespace RecursionIleSonsuzDongu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SaatYaz();
		}
		//Konsolu temizle ve saat yazdır.
		 static void SaatYaz()
		{
			Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
			Thread.Sleep(1000);
			SaatYaz();
        }
	}
}