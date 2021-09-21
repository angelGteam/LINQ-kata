using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_kata
{
	class Program
	{
		static void Main(string[] args)
		{
			var t = new LINQ_KataTest();
			t.FindWord("for");
			t.FindWord("while");
			t.CalculateSquaresTest();
			t.CountOccurencesOfCharacterTest();
			t.SumOfArrayTest();
			t.ReplaceTest();
			t.SquareDigitsTest();

		}
	}

}
