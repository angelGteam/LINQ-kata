using NUnit.Framework;
using System.IO;
// Si no añado algo no puedo hacer pull request
[TestFixture]
public class LINQ_KataTest
{
	[Test]
	public void SumOfArrayTest()
	{
		Assert.AreEqual(6, LINQ_Kata.Sum(new[] { 2, 3, 1 }));
	}

	[Test]
	public void CountOccurencesOfCharacterTest()
	{
		Assert.AreEqual(2, LINQ_Kata.CountChar(new[] { 'A', 'B', 'C', 'A' }, 'A'));
	}

	[Test]
	public void CalculateSquaresTest()
	{
		Assert.AreEqual(new[] { 1, 4, 9, 16, 25, 36 }, LINQ_Kata.CalculateSquares(1, 6));
	}
	[Test]
	public void ReplaceTest()
	{
		Assert.AreEqual("H!!", LINQ_Kata.Replace("Hi!"));
		Assert.AreEqual("!H!! H!!", LINQ_Kata.Replace("!Hi! Hi!"));
		Assert.AreEqual("!!!!!", LINQ_Kata.Replace("aeiou"));
		Assert.AreEqual("!BCD!", LINQ_Kata.Replace("ABCDE"));
	}	
	[Test]
	public void SquareDigitsTest()
	{
		Assert.AreEqual(811181, LINQ_Kata.SquareDigits(9119));
		Assert.AreEqual(0, LINQ_Kata.SquareDigits(0));
	}

	[TestCase("for")]
	[TestCase("while")]
	public void FindWord(string input)
	{
		//the path of the file
		FileStream inFile = new FileStream(@"..\..\LINQ_Kata.cs", FileMode.Open, FileAccess.Read);
		StreamReader reader = new StreamReader(inFile);
		string record;
		try
		{
			//the program reads the record and displays it on the screen
			record = reader.ReadLine();
			while (record != null)
			{
				if (record.Contains(input))
				{
					Assert.Fail(input + " found");
				}
				record = reader.ReadLine();
			}
			Assert.Pass("");
		}
		finally
		{
			//after the record is done being read, the progam closes
			reader.Close();
			inFile.Close();
		}
	}
}