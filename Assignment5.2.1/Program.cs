namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " fly me to the moon ";
            int wordCount = 0;
            string word = string.Empty;
            for (int i = s.Length - 2; i >= 0; i--)//this is mius 2 in case the last character is a space
            {
                if (s[i] == ' ')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == ' ') break;
                        word += s[j];
                        wordCount++;
                    }
                    break;
                }               
            }
            Console.WriteLine($"The last word is: \"{word}\" with a length {wordCount}");
        }
    }
}
