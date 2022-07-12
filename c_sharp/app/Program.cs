using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		/*
			if() --> eger kosul saglanirsa calisir / saglanmazsa calismaz.
												1 /	0
		*/
		public static void Main(string[] args)
		{
			Console.WriteLine("sayi gir");
			int toplam = 0;
			int degerint = 1;

			while(degerint != 0)
			{
				int sayi = Convert.ToInt32(Console.ReadLine());
				if (sayi == '*')
				{
					Console.WriteLine("Toplanilan Deger: {0}", Convert.ToString(toplam));
					break;
				}
				else
					toplam = toplam + sayi;
		}
	}
}
