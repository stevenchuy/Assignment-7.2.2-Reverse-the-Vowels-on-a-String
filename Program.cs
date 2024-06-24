

namespace Assignment_7._2._2_Reverse_the_Vowels_on_a_String
{

    /// <summary>
    /// 
    /* Given a string s, reverse only all the vowels in the string and return it.

        The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

        Example 1:

        Input: s = "hello"

        Output: "holle"

        Example 2:

        Input: s = "avacado"

        Output: "ovacada"

        Example 3: “intelligent”- i , e, i, e

        Output: entillegint */

    /// </summary>
    internal class Program
    {

        // Driver Code
        static void Main(string[] args)
        {
            string word = "intelligent";

            ReverseTheVowels implement = new ReverseTheVowels();

            Console.WriteLine(implement.Reversanator(word));
        }
    }

    public class ReverseTheVowels
    {
        // utility function to check for vowel
        public bool isVowel(char c)
        {
            return (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U');
        }

        // fuction to reverse order of vowels
        public string Reversanator(string word)
        {
            int i = 0;
            int j = word.Length - 1;
            char[] wordChar = word.ToCharArray();

            while (i < j)
            {
                if (!isVowel(wordChar[i]))
                {
                    i++;
                    continue;
                }

                if (!isVowel(wordChar[j]))
                {
                    j--;
                    continue;
                }

                // swapping
                char temp = wordChar[i];
                wordChar[i] = wordChar[j];
                wordChar[j] = temp;
                i++;
                j--;
               
            }
            string wordFinal = String.Join("", wordChar);
            return wordFinal;

        }

    }
}
