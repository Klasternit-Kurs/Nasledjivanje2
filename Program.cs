using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje2
{
	class Program
	{
		static void Main(string[] args)
		{
			Proba p = new Proba(8);
			Console.WriteLine("------------------------");
			Nesto n = new Nesto("asd", 7);
			Console.ReadKey();
			
		}
	}

	class Proba
	{
		public int Broj;
		public Proba(int b)
		{
			Broj = b;
			Console.WriteLine("Za probu");
		}
	}

	class Nesto : Proba
	{
		public string Test;
		public Nesto(string t, int zaProbu) : base(zaProbu)
		{
			Test = t;
			Console.WriteLine("Za Nesto");
		}
	}
}
