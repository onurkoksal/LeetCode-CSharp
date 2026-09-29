using System;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int orijinalSayi = x;
        int tersSayi = 0;

        while (x > 0)
        {
            int basamak = x % 10;
            tersSayi = (tersSayi * 10) + basamak;
            x = x / 10;
        }
        return orijinalSayi == tersSayi;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution cozum = new Solution();
        Console.WriteLine(cozum.IsPalindrome(121)); 
        Console.WriteLine(cozum.IsPalindrome(-121)); 
        Console.WriteLine(cozum.IsPalindrome(10));  
    }
}
