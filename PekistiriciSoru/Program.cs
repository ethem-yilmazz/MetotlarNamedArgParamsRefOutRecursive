namespace PekistiriciSoru
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//26 eylül 2000 tarihini c# üstünde tanımlamak istiyoruz
			//1. önce normal bir şekilde yıl ay gün belirterek tanımlamak istiyoruz.
			//2. şimdi de argüman olarak önce günu yani 26,sonra ayı 9, sonra yılı 2000 olarak girmek istiyoruz.
			DateTime dt = new DateTime(2000, 09, 06);
			DateTime dt2 = new DateTime(day: 26, month: 9, year: 2000);
		}

	}
}