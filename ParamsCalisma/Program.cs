namespace ParamsCalisma
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] dizi = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Toplam: "+Toplam(dizi));

			int toplam2=Toplam(3,5,7,10);
            Console.WriteLine("Toplam: "+toplam2);
        }
		//Görev: aldığı tam sayı dizisininin ögelerinin toplamını döndüren metodu yazınız.

		static int Toplam(params int[] dizi )
		{
			int toplam = 0;
			foreach (int oge in dizi)
				toplam += oge;
			return toplam;
		}
	}
}