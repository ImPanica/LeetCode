using Algos.Bits.Counting_Bits;
using Algos.Is_Subsequence;
using Algos.Majority_Element;
using Algos.Move_Zeroes;
using Algos.Reverse_Words_in_a_String;

namespace Algos;

class Program
{
    static void Main(string[] args)
    {
        // Ноль в конец https://leetcode.com/problems/move-zeroes/description/
        // [0,1,0,3,12]
        // nums = [0]
        var num = MoveZeros.Move(new int[] { 0,1,0,3,12 });
        num.ToList().ForEach(Console.WriteLine);
        
        Split();
        
        // Наибольше кол-в оповторений https://leetcode.com/problems/majority-element/description/
        // [3,2,3]
        // [2,2,1,1,1,2,2]
        var majorCount = MajorityElement.MajorityToElement(new[] { 2,2,1,1,1,2,2 });
        Console.WriteLine(majorCount);
        
        Split();
        // Поиск вхождения в строке https://leetcode.com/problems/is-subsequence/
        // s = "abc", t = "ahbgdc"
        // s = "axc", t = "ahbgdc"
        var isSubsequence = Subsequence.IsSubsequence("abc", "ahbgdc");
        Console.WriteLine(isSubsequence);
        
        Split();
        // Реверс слов с пробелами https://leetcode.com/problems/reverse-words-in-a-string/
        // "the sky is blue"
        // "  hello world  "
        // "a good   example"
        var reverceWords = ReverseWords.ReverseOptionTwo("a good   example");
        Console.WriteLine(reverceWords);
        
        Split();
        // Получение едениц в битовом представлении числа https://leetcode.com/problems/counting-bits/description/
        // Input: n = 5
        // Output: [0,1,1,2,1,2]
        // Input: n = 2
        // Output: [0,1,1]

        var result = CountingBits.CountBits(7);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($"{result[i]} ");
        }
        
        Split();
        
        Console.ReadKey();
    }

    static void Split()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*********************************");
        Console.ResetColor();
    }
}