namespace SonluRecursion
{
	internal class Program
	{
		static void Main(string[] args)
		{
            #region Recursion kullanmadan geri sayım
            //recursion kullanmadan geri sayım
            //int x = 10;
            //while (x >= 0)
            //{
            //	Console.Clear();
            //	Console.WriteLine(x--);
            //	Thread.Sleep(1000);
            //}
            //Console.WriteLine("Have a good Daaay!!"); 
            #endregion
            //GeriSayim(10);
            //Console.WriteLine("Bye bye!!");
            Console.WriteLine("Sayı giriniz");
			int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{sayi}!={Faktoriyel(sayi)}");


        }
		static void GeriSayim(int sayi) 
		{
			Console.Clear();
			Console.WriteLine(sayi);
			Thread.Sleep(1000);
			if (sayi == 0)
				return ;
			GeriSayim(--sayi);
		}
		static int Faktoriyel(int sayi)
		{
			if(sayi<2)
				return 1;
			return sayi * Faktoriyel(sayi - 1);
		}
	}
}