namespace Assignment;

public class VowelFinder
{


    public int CountVowels(string inputStr)
    {
        string vowels = "aeiou";
        int count = 0;

        foreach (char character in inputStr)
        {
            if (vowels.Contains(character))
            {
                count++;
            }
            if (string.IsNullOrEmpty(inputStr))
            {
                return 0;
            }
        }
        return count;
    }
}


// Red to Green
// public static int CountVowels(string inputStr)
//     {
//         throw new NotImplementedException(); 
//     }