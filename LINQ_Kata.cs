using System;
using System.Linq;

public class LINQ_Kata {
    public static int Sum(int[] integers) {
        // Sum for Nullable Numeric Types int? sum = numbers.Sum()
        int ret = integers.Sum();
        return ret;
    }

    public static int CountChar(char[] chars, char charToCount) {
        // (from x in items select x).Count();
        var ret = (from x in chars select x).Count();
        return ret;
    }

    public static int[] CalculateSquares(int start, int end) {
        //IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
        var list = Enumerable.Range(start, end);
        var ret = list.Select(i => i * i);
        return ret.ToArray();
    }

    public static int SquareDigits(int n) {
        //???
        string digits = n.ToString();
        string result = "";

        foreach (char character in digits) {
            int number = Convert.ToInt32(character.ToString());
            int square = number * number;
            result += square;
        }
        return int.Parse(result);
    }

    public static string Replace(string s) {
        var chars = s.Select(ReplaceVocals).ToArray();
        string ret = new string(chars);
        return ret;
    }

    private static char ReplaceVocals(char c) {
        // Aqui Edu usa operador ternario
        if ("aeiouAEIOU".Contains(c)) {
            return '!';
        }
        return c;
    }
}