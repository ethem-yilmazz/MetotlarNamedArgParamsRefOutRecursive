namespace IsimliArgumanlar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Yaz("Oley!", true, true, 3);
			Yaz("Hayatı Seviyorum", true, true);
			Yaz("C# Öğreniyorum!", true);
			Yaz("Merhaba");
			Yaz("İmdat", false, false, 4);
			Yaz(metin: "İmdat", tekrar: 5);
			Yaz(metin: "Ethem", buyukMu: true);
			Yaz("Yaşasın!", tekrar: 3);
			//Math.Pow metodunun argümanlarını istediğimiz sırada girebilir miyiz? 2^5
			Console.WriteLine("2^5= " + Math.Pow(y: 5, x: 2));
		}
		//Opsiyonel parametre: İster gir ister girme girmezsen tanımladığım değerde veririm.
		static void Yaz(string metin = "", bool ortaliMi = false, bool buyukMu = false, int tekrar = 1)
		{
			string sonuc = "";
			for (int i = 0; i < tekrar; i++)
			{
				sonuc += metin + " ";
			}
			if (buyukMu)
			{
				sonuc = sonuc.ToUpper();
			}
			if (ortaliMi)
			{
				int boslukAdet = (Console.BufferWidth - sonuc.Length) / 2;
				sonuc = new string(' ', boslukAdet) + sonuc;
			}
			Console.WriteLine(sonuc);
		}

	}
}