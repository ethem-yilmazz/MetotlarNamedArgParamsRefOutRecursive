namespace Odev
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Metni Recursive ile tersten yazdırma");
            Console.WriteLine(Tersine("Ankara"));
        }
		//Recursion kullanarak bir stringi tersine çeviren metodu yazınız.
		
		static string Tersine(string metin)
		{
			string result = "";

			if (metin.Length==0)
			{
				return metin;
			}
			char harf = metin[metin.Length - 1];
			result += harf;
			metin = metin.Remove(metin.Length - 1);
			return result + Tersine(metin);
		}

	}
}