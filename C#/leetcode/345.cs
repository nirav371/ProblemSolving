using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;

//namespace leetcode
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            //List<int> list = new List<int> { 1, 2, 3 };
//            //List<int> list = [1, 2, 3, 4];
//            //foreach (var item in list)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            var res = Program.ReverseVowels("IceCreAm");
//            Console.WriteLine(res);
//        }
//        public static string ReverseVowels(string s)
//        {
//            string vowels = "aeiouAEIOU";
//            char[] charArray = s.ToCharArray();
//            int left = 0;
//            int right = s.Length - 1;
//            while (left < right)
//            {
//                while (left < right && !vowels.Contains(charArray[left]))
//                {
//                    left++;
//                }
//                while (left < right && !vowels.Contains(charArray[right]))
//                {
//                    right--;
//                }
//                if (left < right)
//                {
//                    char temp = charArray[left];
//                    charArray[left] = charArray[right];
//                    charArray[right] = temp;
//                    left++;
//                    right--;
//                }
//            }
//            return new String(charArray);
//        }
//    }
//}

namespace leetcode
{
    internal class _345
    {
        public string ReverseVowels(string s)
        {
            string vowels = "aeiouAEIOU";
            StringBuilder sb = new StringBuilder(s);
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (left < right && !vowels.Contains(sb[left]))
                {
                    left++;
                }
                while (left < right && !vowels.Contains(sb[right]))
                {
                    right--;
                }
                if (left < right)
                {
                    char temp = sb[left];
                    sb[left] = sb[right];
                    sb[right] = temp;
                    left++;
                    right--;
                }
            }
            return sb.ToString();
        }
    }
}

