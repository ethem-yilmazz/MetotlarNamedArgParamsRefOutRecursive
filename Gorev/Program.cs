namespace Gorev
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			string s1 = Birlestir("-",new string[] { "ali", "can", "cem" });
			string s2 = Birlestir("-", "eda", "ece", "ela");
			Console.Write(s1);
            Console.WriteLine();
            Console.WriteLine(s2);
		}
		//Öyle bir metod tanımlayın ki iki şekilde kullanabileyim.

		static string Birlestir(string s,params string[] args)
		{
			return string.Join(s, args);
		}
	}
}